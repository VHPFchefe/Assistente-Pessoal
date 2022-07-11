using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using AssistentePessoal.Entities;
using AssistentePessoal.Extras;

namespace AssistentePessoal
{
    public partial class FormRegistros : Form
    {
        public DataGridViewCellStyle default_back_color = new DataGridViewCellStyle();
        

        private int[] transacoes = { };
   
        public FormRegistros()
        {
            InitializeComponent();
            this.grid.ClearSelection();
        }

        private void AtualizaGrafico()
        {
            ((FormSystem)this.Owner).AtualizarGrafico();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            FormRegistroEntrada form = new FormRegistroEntrada();
            form.Owner = this;
            form.Show();
        }

        private void EditarRegistro()
        {
            FormRegistroEntrada form = new FormRegistroEntrada(transacoes[0]);
            form.Owner = this;
            form.Show();
        }

        private void Search()
        {
            string parameterSQL = tx_pesquisa.Text;
            int identSearch = cb_filtro.SelectedIndex;
            int movimentation_type = cb_movimentation.SelectedIndex;
            LoadGrid(parameterSQL, identSearch, movimentation_type, cb_date.Text);
        }

        private void LoadCb_filtros()
        {
            cb_filtro.Items.Clear();
            cb_filtro.Items.Add("[Todos]"); //0 
            cb_filtro.Items.Add("Número da Transação"); //1
            cb_filtro.Items.Add("Remetente"); //2 
            cb_filtro.Items.Add("Portifólio"); //3
            cb_filtro.SelectedIndex = 0;
            cb_movimentation.Items.Clear();
            cb_movimentation.Items.Add("[Todos]");
            cb_movimentation.Items.Add("Entrada");
            cb_movimentation.Items.Add("Saída");
            cb_movimentation.SelectedIndex = 0;
            LoadDataComboBox();
        }

        private void LoadDataComboBox()
        {
            cb_date.Items.Clear();
            cb_date.Items.Add("[Todos]");

            Db_connection db = new Db_connection();
            try
            {
                string sql =
                        " select Datepart(YEAR,date_transact) from transact " +
                        " group by Datepart(YEAR, date_transact) order by  Datepart(YEAR, date_transact)  desc";

                SqlCommand command = new SqlCommand(sql, db.con);
                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    cb_date.Items.Add(teste[0]);
                    //MessageBox.Show(String.Format("{0}, {1}", teste[0], teste[1]));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o Formulário.\n" + ex.ToString());
            }
            finally
            {
                db.con.Close();
            }
            cb_date.SelectedIndex = 0;
        }

        public void LoadGrid()
        {
            Db_connection db = new Db_connection();
            try
            {
                string sql = "select t.transact_number as 'Número da Transação', t.transact_value as 'Valor da Transação', it.name_transact_type as 'Movimentação', s.sender_name as 'Remetente',	p.name_portfolio as 'Portifólio', 	t.transact_comment as 'Comentário',	format(t.date_transact, 'dd/MM/yyyy') as 'Data de Transação'from transact t inner join transact_type it on (it.id_transact_type = t.id_transact_type) inner join sender s on (s.id_sender = t.id_sender) inner join portfolio p on (p.id_portfolio = t.id_portfolio) where t.removed = 0 order by date_transact desc";
                db.con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, db.con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        this.grid.DataSource = dt;
                        this.grid.ReadOnly = true;
                    }
                    AtualizaGrafico(); ;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { db.con.Close(); }
        }

        private void LoadGrid(string sqlSearch, int identSearch, int movimentation_type, string date)
        {
            Db_connection db = new Db_connection();
            try
            {
                string[] search = { "0", "0", "0"}; ////r1
                string[] ident = { "0", "0", "0"};  //p1

                if (identSearch == 1) //("Número da Transação"); 
                {
                    search[0] = sqlSearch;
                    ident[0] = "t.transact_number";
                }
                if (identSearch == 2) //("Remetente");
                {
                    search[1] = sqlSearch;
                    ident[1] = "s.sender_name";
                }
                if (identSearch == 3) //("Portifólio");
                {
                    search[2] = sqlSearch;
                    ident[2] = "p.name_portfolio";
                }


                string data = (string.IsNullOrEmpty(date.ToString()) ? DateTime.Now.ToString("yyyy") : date.ToString());
                data = (data == "[Todos]" ?  "0" : data); // o 0 cancela o filtro na consulta


                string[] p1 = { "@p1", "@p2", "@p3", "@r1", "@r2", "@r3", "@v1", "@p0", "@d1"};
                string[] p2 = { ident[0], ident[1], ident[2], search[0], search[1], search[2], movimentation_type.ToString(), identSearch.ToString(), data };
                string sql = new Consultas().sqlGrid;
                for (int i = 0; i < p1.Length; i++)
                {
                    sql = sql.Replace(p1[i], p2[i]);
                }
                SqlCommand cmd = new SqlCommand(sql, db.con);

                db.con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, db.con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        this.grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { db.con.Close(); }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip.Cursor = System.Windows.Forms.Cursors.Hand;

            if (grid.SelectedRows.Count > 1)
            {
                editar_menu_item.Visible = false;
            }
            else
            {
                editar_menu_item.Visible = true;
                int index = PointCellIndex();
                this.grid.ClearSelection();
                this.grid.Rows[index].Selected = true;
            }
        }

        public int PointCellIndex()
        {
            Point pointRight = this.grid.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hitTest = this.grid.HitTest(pointRight.X, pointRight.Y);
            if (hitTest.RowIndex >= 0)
            {
                return hitTest.RowIndex;
            }
            return 0;
        }

        private void editar_menu_item_Click(object sender, EventArgs e)
        {
            EditarRegistro();
        }

        private void remover_menu_item_Click(object sender, EventArgs e)
        {
            try
            {
                string aviso = "";

                if (grid.SelectedRows.Count == 1)
                {
                    aviso += "Você realmente deseja remover o item: \n";
                }
                else
                {
                    aviso += "Antenção! \nVocê realmente deseja remover os " + grid.SelectedRows.Count + " items?\n";
                }
                foreach (int item in GetIdInRows())
                {
                    aviso += "Transação N°: " + item + "\n";
                }

                if (MessageBox.Show(aviso, "Remover Registros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string p1, p2, p3;
                    if (grid.SelectedRows.Count == 1)
                    {
                        p1 = "Foi";
                        p2 = "removido";
                        p3 = "item";
                    }
                    else
                    {
                        p1 = "Foram";
                        p2 = "removidos";
                        p3 = "itens";
                    }
                    RemoverRegistros();
                    MessageBox.Show($"{p1} {p2} {grid.SelectedRows.Count} {p3}.");
                    Search();
                    AtualizaGrafico();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void RemoverRegistros()
        {
            Transact transact = new Transact();
            foreach (int item in GetIdInRows())
            {
                transact.RegisterRemoved(item);
            }
        }

        private int[] GetIdInRows()
        {
            int i = 0;
            int[] id = new int[grid.SelectedRows.Count];
            foreach(DataGridViewRow item in grid.SelectedRows)
            {
                id[i] = int.Parse(item.Cells["Número da Transação"].Value.ToString());
                i++;
            }
            return id;
        }

        private void grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja editar ?", "Editar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EditarRegistro();
            }
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            LoadCb_filtros();
            LoadGrid();
        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void tx_pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }


    }
}

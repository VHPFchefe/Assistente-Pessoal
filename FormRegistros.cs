using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistentePessoal
{
    public partial class FormRegistros : Form
    {
        public FormRegistros()
        {
            InitializeComponent();
        }

        private void Search()
        {
            string parameterSQL = tx_pesquisa.Text;
            int identSearch = cb_filtro.SelectedIndex;
            int movimentation_type = cb_movimentation.SelectedIndex;
            LoadGrid(parameterSQL, identSearch, movimentation_type);
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
                    ((FormSystem)this.Owner).AtualizarGrafico();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { db.con.Close(); }
        }

        private void LoadGrid(string sqlSearch, int identSearch, int movimentation_type)
        {
            Db_connection db = new Db_connection();
            try
            {
                string[] search = { "0", "0", "0" }; ////r1
                string[] ident = { "0", "0", "0" };  //p1

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

                string[] p1 = { "@p1", "@p2", "@p3", "@r1", "@r2", "@r3", "@v1", "@p0" };
                string[] p2 = { ident[0], ident[1], ident[2], search[0], search[1], search[2], movimentation_type.ToString(), identSearch.ToString() };
                string sql =
                    " select t.transact_number as 'Número da Transação', " +
                    " t.transact_value as 'Valor da Transação', " +
                    " it.name_transact_type as 'Movimentação', " +
                    " s.sender_name as 'Remetente',	" +
                    " p.name_portfolio as 'Portifólio', 	" +
                    " t.transact_comment as 'Comentário',	" +
                    " format(t.date_transact, 'dd/MM/yyyy') as 'Data de Transação'" +
                    " from transact t inner join transact_type it on (it.id_transact_type = t.id_transact_type) " +
                    " inner join sender s on (s.id_sender = t.id_sender) " +
                    " inner join portfolio p on (p.id_portfolio = t.id_portfolio) " +
                    " where t.removed = 0 " +
                    " and (@p0 = 0 or (@p1 like '%@r1%' " +
                    " and @p2 like '%@r2%' " +
                    " and @p3 like '%@r3%')) " +
                    " and (@v1 = 0 or it.id_transact_type like '%@v1%')" +
                    " order by t.date_transact desc";

                for (int i = 0; i < p1.Length; i++)
                {
                    sql = sql.Replace(p1[i], p2[i]);
                }

                //MessageBox.Show(sql);

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

        private void Iniciar_Click(object sender, EventArgs e)
        {
            FormRegistroEntrada form = new FormRegistroEntrada();
            form.Owner = this;
            form.Show();
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadCb_filtros();
        }


        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (MessageBox.Show("Você realmente deseja editar ?", "Editar registro", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Form teste = new Form();
                teste.Show();
            }*/
        }

        private void tx_pesquisaEvent(object sender, KeyPressEventArgs e)
        {
            Search();
        }

        private void tx_pesquisaEvent(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void cb_movimentation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            Point point = this.grid.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hitTest = this.grid.HitTest(point.X, point.Y);
            if (hitTest.RowIndex >= 0)
            {
                index = hitTest.RowIndex;
                MessageBox.Show(hitTest.RowIndex.ToString());
            }
        }

        private void grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //this.grid.Rows.SharedRow(this.grid.Rows.);
        }
    }
}

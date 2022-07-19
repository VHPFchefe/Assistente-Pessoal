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
using AssistentePessoal.Entities;
using AssistentePessoal.Extras;

namespace AssistentePessoal
{
    public partial class FormRegistrosCarteira : Form
    {
        public FormRegistrosCarteira()
        {
            InitializeComponent();
            this.grid.ClearSelection();
            LoadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarRegistro(true);
        }

        private void CriarRegistro(bool isNew)
        {
            if (GetIdInRows().Length <= 1)
            {
                FormCadastroCarteira f = (FormCadastroCarteira)Application.OpenForms["FormCadastroCarteira"];
                if (f != null) { 
                    f.BringToFront();
                }
                else
                {
                    if (isNew)
                    {
                        f = new FormCadastroCarteira();
                    }
                    else
                    {
                        int id = GetIdInRows().ElementAt(0);
                        f = new FormCadastroCarteira(id);
                    }
                    f.Owner = this;
                    f.Show();
                }
                LoadGrid();
            }
        }


        public void LoadGrid()
        {
            Db_connection db = new Db_connection();
            try
            {
                string parameterSQL = tx_pesquisa.Text;
                string sql = "select id_portfolio as 'Id', name_portfolio as 'Nome', patrimony as 'Patrimônio/Saldo'  from portfolio where removed = 0 " +
                    " and ( " +
                    " name_portfolio like '%@p1%'" +
                    " ) ";

                sql = sql.Replace("@p1", parameterSQL);

                db.con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, db.con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        this.grid.DataSource = dt;
                        this.grid.ReadOnly = true;
                    }
                }
                this.grid.Columns[0].Visible = false;
                this.grid.Columns[1].Width = 300;
                this.grid.Columns[2].Width = 160;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { db.con.Close(); }
        }

        private void tx_pesquisa_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            this.contextMenuStrip1.Cursor = System.Windows.Forms.Cursors.Hand;

            if (this.grid.SelectedRows.Count > 1)
            {
                this.tool_editar.Visible = false;
            }
            else
            {
                this.tool_editar.Visible = true;
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

        private void toolEditar_Click(object sender, EventArgs e)
        {
            CriarRegistro(false);
        }

        private void toolRemover_Click(object sender, EventArgs e)
        {
            try
            {
                string aviso = "";

                if (this.grid.SelectedRows.Count == 1)
                {
                    aviso += "Você realmente deseja remover o remetente: \n";
                }
                else
                {
                    aviso += "Antenção! \nVocê realmente deseja remover os " + grid.SelectedRows.Count.ToString() + " remetentes?\n";
                }

                foreach (string item in GetNameInRows())
                {
                    aviso += " - " + item.ToString() + "\n";
                }


                if (MessageBox.Show(aviso, "Remover Remetentes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string p1, p2, p3;
                    if (grid.SelectedRows.Count == 1)
                    {
                        p1 = "Foi";
                        p2 = "removido";
                        p3 = "carteira";
                    }
                    else
                    {
                        p1 = "Foram";
                        p2 = "removidas";
                        p3 = "carteiras";
                    }
                    RemoverRegistros();
                    MessageBox.Show($"{p1} {p2} {grid.SelectedRows.Count} {p3}.");
                    LoadGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao remover carteira!\n" + ex.ToString()); }
        }

        private void RemoverRegistros()
        {
            Portfolio portfolio= new Portfolio();
            foreach (int item in GetIdInRows())
            {
                portfolio.RegisterRemoved(item);
            }
        }

        private string[] GetNameInRows()
        {
            int i = 0;
            string[] id = new string[grid.SelectedRows.Count];
            foreach (DataGridViewRow item in grid.SelectedRows)
            {
                id[i] = item.Cells["Nome"].Value.ToString();
                i++;
            }
            return id;
        }

        private int[] GetIdInRows()
        {
            int i = 0;
            int[] id = new int[grid.SelectedRows.Count];
            foreach (DataGridViewRow item in grid.SelectedRows)
            {
                id[i] = int.Parse(item.Cells["Id"].Value.ToString());
                i++;
            }
            return id;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja editar ?", "Editar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CriarRegistro(false);
            }
        }
    }
}

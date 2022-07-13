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

namespace AssistentePessoal
{
    public partial class FormRegistrosSender : Form
    {
        public FormRegistrosSender()
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
            if (GetIdInRows().Length == 1)
            {
                int id = GetIdInRows().ElementAt(0);
                FormCadastroSender f = (FormCadastroSender)Application.OpenForms["FormCadastroSender"];
                if (f != null)
                    f.BringToFront();
                else
                {
                    if (isNew)
                    {
                        f = new FormCadastroSender();
                    }
                    else
                    {
                        f = new FormCadastroSender(id);
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
                string sql = "select id_sender as 'Id' ,sender_name as 'Nome', sender_phone as 'Celular', sender_email as 'E-mail', sender_cep as 'CEP' from sender where removed = 0 "+
                    " and ( " +
                    " sender_name like '%@p1%' or" +
                    " sender_phone like '%@p1%' or" +
                    " sender_email like '%@p1%' or" +
                    " sender_cep like '%@p1%'" +
                    " ) order by sender_name asc";

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
                this.grid.Columns[1].Width = 250;
                this.grid.Columns[2].Width = 130;
                this.grid.Columns[3].Width = 230;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { db.con.Close(); }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            this.contextMenuStrip1.Cursor = System.Windows.Forms.Cursors.Hand;

            if (this.grid.SelectedRows.Count > 1)
            {
                this.toolEditar.Visible = false;
            }
            else
            {
                this.toolEditar.Visible = true;
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


        private void tx_pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            LoadGrid();
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
                        p3 = "remetente";
                    }
                    else
                    {
                        p1 = "Foram";
                        p2 = "removidos";
                        p3 = "remetentes";
                    }
                    RemoverRegistros();
                    MessageBox.Show($"{p1} {p2} {grid.SelectedRows.Count} {p3}.");
                    LoadGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao remover remetente!\n" + ex.ToString()); }
        }

        private void RemoverRegistros()
        {
            Senders senders = new Senders();
            foreach (int item in GetIdInRows())
            {
                senders.RegisterRemoved(item);
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

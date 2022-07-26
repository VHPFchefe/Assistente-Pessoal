using AssistentePessoal.Extras;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using AssistentePessoal.Entities.Account;
using System.IO;
using System.Configuration;

namespace AssistentePessoal
{
    public partial class FormCadastroPagamento : Form
    {
        Payments payment;
        private bool is_edit = false;
        string progress = "Progresso: 7/10";
        DataGridViewRow last_row;

        public FormCadastroPagamento(int edit_transact)
        {
            this.BringToFront();
            InitializeComponent();
            is_edit = true;
            LoadFormRegister();
        }

        public FormCadastroPagamento()
        {
            InitializeComponent();
            is_edit = false;
            payment = new Payments();
            this.grid.Rows.Add(1);
            LoadFormRegister();
        }

        #region Eventos
            private void btn_add_Click(object sender, EventArgs e)
            {
                AddRow();
            }

            private void btn_remove_Click(object sender, EventArgs e)
            {
                RemoveRow();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Você realmente deseja cancelar ?", "Cancelar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }


            private void button3_Click(object sender, EventArgs e)
            {
                Anexar();
            }
        #endregion

        #region Metodos

        private void LoadFormRegister()
        {
            LoadRows();
            LoadBeneficiario();
        }

        private void getLastRow()
        {
            this.last_row = this.grid.Rows[this.grid.Rows.Count - 1];
            this.last_row.ReadOnly = true;
            this.last_row.DefaultCellStyle.BackColor = Color.DarkSlateGray;
        }

        private void getValue_label() { }

        private void LoadRows()
        {
            getLastRow();
            getValue_label();
            foreach (DataGridViewRow dr in this.grid.Rows)
            {
                if (dr.Cells["number"].RowIndex != this.last_row.Index)
                    dr.Cells["number"].Value = ((int)dr.Cells["number"].RowIndex + 1).ToString();
            }
        }

        private void AddRow()
        {
            this.grid.Rows.Add(1);
            LoadRows();
        }

        private void RemoveRow()
        {
            if (this.grid.CurrentRow == null) return;
            int index_a = -1;
            foreach (DataGridViewCell item in this.grid.SelectedCells)
            {
                if (item.RowIndex != index_a)
                {
                    if (item.RowIndex != this.last_row.Index)
                    {
                        this.grid.Rows.RemoveAt(item.RowIndex);
                        index_a = item.RowIndex;
                    }
                }
            }
            LoadRows();
        }

        private void LoadBeneficiario()
        {
            Db_connection db = new Db_connection();
            try
            {
                c_beneficiado.Items.Clear();
                c_beneficiado.Text = "Selecione uma opção";
                string sql =
                        " Select " +
                        " id_sender as id, " +
                        " sender_name as name " +
                        " from sender  where removed = 0";

                SqlCommand command = new SqlCommand(sql, db.con);
                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    c_beneficiado.Items.Add(teste[1]);
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
        }

        private void Anexar()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string localPath = ConfigurationManager.AppSettings["localPath"] + @"\Arquivos\"+ openFileDialog1.SafeFileName;
                File.Copy(fileName, localPath);
                MessageBox.Show("Registrar no banco !!!\n\n"+fileName+"\npara =>\n"+ localPath);
            }
        }
        #endregion


    }
}

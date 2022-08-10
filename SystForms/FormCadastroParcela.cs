using AssistentePessoal.Entities.Account;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AssistentePessoal.Extras;
using System.Data.SqlClient;
using System.Data;

namespace AssistentePessoal
{
    public partial class FormCadastroParcela : Form
    {
        private int id;
        private bool is_edit = false;
        public Parcel parcel { get; private set; }
        public bool close = false;

        public FormCadastroParcela(int id, Parcel parcel)
        {
            this.BringToFront();
            InitializeComponent();
            loadPortfolio();
            this.TexBoxValues.Text = parcel.value.ToString("F2");
            this.Data_vencimento.Value = parcel.vencimento;
            this.is_edit = true;
            this.id = id;
            this.cb_carteira.Text = parcel.portfolio.name;
        }

        public FormCadastroParcela(int id)
        {
            InitializeComponent();
            loadPortfolio();
            TexBoxValues.Text = string.Format("{0:#,##0.00}", 0d);
            is_edit = false;
            data_pagamento.Enabled = false;
            cb_carteira.Enabled = false;
            c_comment.Enabled = false;
        }


        void loadPortfolio()
        {
            Db_connection db = new Db_connection();
            try
            {
                cb_carteira.Items.Clear();
                string sql =
                        " Select " +
                        " id_portfolio as id, " +
                        " name_portfolio as name " +
                        " from portfolio  where removed = 0";

                SqlCommand command = new SqlCommand(sql, db.con);
                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    cb_carteira.Items.Add(teste[1]);
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
        }


        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja cancelar a parcela  ?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja salvar a parcela ?", "Salvar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                double value = double.Parse(TexBoxValues.Text);
                DateTime vencimento = Data_vencimento.Value;
                DateTime pagamento = data_pagamento.Value;
                parcel = new Parcel(this.id, value, vencimento, c_comment.Text ?? "");
                if (is_pago.Checked)
                {
                    parcel.PagarParcela(pagamento);
                    parcel.portfolio = new Entities.Portfolio(cb_carteira.Text);
                }
                close = true;
                this.Close();
            }
        }

        private void value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                if (w == string.Empty)
                {
                    w = "00";
                }

                if (e.KeyChar.Equals((char)Keys.Back))
                {
                    w = w.Substring(0, w.Length - 1);
                }
                else
                {
                    w += e.KeyChar;
                }


                t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }

        private void value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                TextBox t = (TextBox)sender;
                t.Text = string.Format("{0:#,##0.00}", 0d);
                t.Select(t.Text.Length, 0);
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (is_pago.Checked)
            {
                data_pagamento.Enabled = true;
                cb_carteira.Enabled = true;
                c_comment.Enabled = true;
            }
        }
    }
}

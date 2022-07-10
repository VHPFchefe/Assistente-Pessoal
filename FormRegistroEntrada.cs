﻿using System;
using System.Data;
using System.Windows.Forms;
using AssistentePessoal.Entities;
using AssistentePessoal.Entities.Enum;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace AssistentePessoal
{
    public partial class FormRegistroEntrada : Form
    {

        public FormRegistroEntrada(int edit_transact)
        {
            InitializeComponent();

            Transact transact = new Transact(edit_transact);
            this.cb_movimentacao.Text = transact.movimentation.ToString();
            this.TexBoxValues.Text = transact.value.ToString("F2");
            this.cb_carteira.SelectedItem = transact.portfolio.name;
            this.textBox1.Text = transact.comment;
            this.cb_remetente.SelectedItem = transact.sender.name;
            this.register_date.Value = transact.date;
            this.titulo.Text = titulo.Text +"  -  N° "+ transact.TransactNumber.ToString();
        }

        public FormRegistroEntrada()
        {
            InitializeComponent();
            TexBoxValues.Text = string.Format("{0:#,##0.00}", 0d);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadTipoEntrada();
            loadPortfolio();
            loadRemetente();
        }

        private void AtualizaFormPai()
        {
            ((FormRegistros)this.Owner).LoadGrid();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja cancelar o registro ?", "Registro de Movimentação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AtualizaFormPai();
                this.Close();
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            try
            {
                ; if (cb_carteira.Text == "Selecione uma carteira" || cb_remetente.Text == "Selecione um remetente" || double.Parse(TexBoxValues.Text) == 0)
                {
                    MessageBox.Show("Verifique os campos e preencha novamente");
                }
                else if (register_date.Value > DateTime.Now)
                {
                    MessageBox.Show("A data de movimentação não pode ser maior que hoje!");
                }
                else
                {
                    Transact transact = new Transact(register_date.Value, (Movimentation)Enum.Parse(typeof(Movimentation), cb_movimentacao.Text), Double.Parse(TexBoxValues.Text), cb_carteira.Text, textBox1.Text, cb_remetente.Text);
                    transact.RegisterTransactAdd();
                    AtualizaFormPai();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
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

        void loadTipoEntrada()
        {
            Db_connection db = new Db_connection();

            try
            {
                cb_movimentacao.Items.Clear();
                string sql =
                        " Select " +
                        " id_transact_type as id, " +
                        " name_transact_type as name " +
                        " from transact_type  where removed = 0";
                SqlCommand command = new SqlCommand(sql, db.con);
                db.con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var teste = (IDataRecord)reader;
                    cb_movimentacao.Items.Add(teste[1]);
                }
                reader.Close();
                cb_movimentacao.SelectedIndex = 0;
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


        void loadRemetente()
        {
            Db_connection db = new Db_connection();
            try
            {
                cb_remetente.Items.Clear();
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
                    cb_remetente.Items.Add(teste[1]);
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
    }
}
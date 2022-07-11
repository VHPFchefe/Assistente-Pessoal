using AssistentePessoal.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistentePessoal
{
    public partial class FormSenderCadastro : Form
    {
        Senders remetente;

        public FormSenderCadastro()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateSender())
                {
                    string cep = decode(maskedTextBox1.Text) == 0 ? "" : maskedTextBox1.Text;
                    string celular = decode(msk_celular.Text) == 0 ? "" : msk_celular.Text;
                    string email = tx_email.Text.Length == 0 ? "" : tx_email.Text;
                    remetente = new Senders(tb_nome.Text, celular , email, cep);
                    remetente.CadastroCliente();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja cancelar o registro ?", "Registro de Movimentação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void msk_celular_MouseClick(object sender, MouseEventArgs e)
        {
            MaskedTextBox t = (MaskedTextBox)sender;
            t.Select(0, t.TextLength);
        }

        int decode(string text)
        {
            string text_validantion = "";
            foreach (char c in text)
            {
                if (int.TryParse(c.ToString(), out int result))
                    text_validantion += c.ToString();
            }
            return text_validantion.Length;
        }

        private bool ValidateSender()
        {
            string exc = "Verifique o formulário e tente novamente!\n";
            bool ex = false;

            if (tb_nome.Text.Length == 0)
            {
                ex = true;
                exc += "O nome não pode ficar em branco.\n";
            }

            if (decode(msk_celular.Text) == 0 ? false : decode(msk_celular.Text) < 11) 
            {
                ex = true;
                exc += "Preencha corretamente o campos Celular.\n";
            }

            if (decode(maskedTextBox1.Text) == 0 ? false : decode(maskedTextBox1.Text) < 8)
            {
                ex = true;
                exc += "Preencha corretamente o campo CEP.\n";
            }

            if (ex)
            {
                MessageBox.Show(exc);
            }

            return ex;
        }
    }
}


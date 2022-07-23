using AssistentePessoal.Entities;
using System;
using System.Windows.Forms;

namespace AssistentePessoal
{
    public partial class FormCadastroSender : Form
    {
        Senders remetente;
        public bool is_new;

        public FormCadastroSender()
        {
            InitializeComponent();
            is_new = true;
        }

        public FormCadastroSender(int id)
        {
            InitializeComponent();
            remetente= new Senders(id);
            mask_cep.Text = remetente.cep;
            msk_celular.Text = remetente.phone;
            tx_email.Text = remetente.email;
            tb_nome.Text = remetente.name;
            is_new = false;
        }

        private void AtualizaFormPai()
        {
            ((FormRegistrosSender)this.Owner).LoadGrid();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateSender())
                {
                    string cep = decode(mask_cep.Text) == 0 ? "" : mask_cep.Text;
                    string celular = decode(msk_celular.Text) == 0 ? "" : msk_celular.Text;
                    string email = tx_email.Text.Length == 0 ? "" : tx_email.Text;

                    if (!is_new)
                    {
                        remetente = new Senders(remetente.id,tb_nome.Text, celular, email, cep);
                        remetente.RegisterEdit();
                    }
                    else
                    {
                        remetente = new Senders(tb_nome.Text, celular, email, cep);
                        remetente.RegisterAdd();
                    }

                    AtualizaFormPai();
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

            if (decode(mask_cep.Text) == 0 ? false : decode(mask_cep.Text) < 8)
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


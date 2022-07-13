using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssistentePessoal.Entities;
namespace AssistentePessoal
{
    public partial class FormCadastroCarteira : Form
    {
        Portfolio portfolio;
        public bool is_new;

        public FormCadastroCarteira()
        {
            InitializeComponent();
            is_new = true;
        }

        public FormCadastroCarteira(int id)
        {
            InitializeComponent();
            is_new = false;
            portfolio = new Portfolio(id);
            tb_nome.Text = portfolio.name;
        }

        private void AtualizaFormPai()
        {
            ((FormRegistrosCarteira)this.Owner).LoadGrid();
        }


        private void ok_Click(object sender, EventArgs e)
        {
            try
            {

                if (!is_new)
                {
                    portfolio = new Portfolio(portfolio.id, tb_nome.Text);
                    portfolio.RegisterEdit();
                }
                else
                {
                    portfolio = new Portfolio(tb_nome.Text);
                    portfolio.RegisterAdd();
                }
                AtualizaFormPai();
                this.Close();
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
    }
}


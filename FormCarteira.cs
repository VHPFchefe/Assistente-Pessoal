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
    public partial class FormCarteira : Form
    {
        Portfolio portfolio;
        public FormCarteira()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                portfolio = new Portfolio(tb_nome.Text);
                portfolio.Insert();
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

        private void FormCarteira_Load(object sender, EventArgs e)
        {

        }
    }
}


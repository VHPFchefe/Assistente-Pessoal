using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistentePessoal
{
    public partial class FormDialogDuplicar : Form
    {
        public FormDialogDuplicar()
        {
            InitializeComponent();
        }

        public string DMY;
        public int num_reincidencia;
        public int num_duplicatas;
        public bool close = false;

        private void ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja Salvar?", "Salvar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DMY = cb_DMY.SelectedText.ToString();
                num_reincidencia = Convert.ToInt32(numeric_reincidencia.Value);
                num_duplicatas = Convert.ToInt32(numeric_duplicatas.Value);
                close = true;
                this.Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja cancelar ?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}


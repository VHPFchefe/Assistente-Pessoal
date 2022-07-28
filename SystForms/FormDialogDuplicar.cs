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

        public string dmy;
        public int num_reincidencia;
        public int num_duplicatas;
        public bool close = false;

        private void ok_Click(object sender, EventArgs e)
        {
            num_reincidencia = Convert.ToInt32(numeric_reincidencia.Value);
            num_duplicatas = Convert.ToInt32(numeric_duplicatas.Value);
            if (num_duplicatas == 0 || num_reincidencia == 0 || cb_DMY.Text.Length < 1) throw new Exception("Nenhum campo pode ficar em branco ou ser igual a zero!");
            dmy = cb_DMY.SelectedItem.ToString();
            if (MessageBox.Show("Você deseja Salvar?", "Salvar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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


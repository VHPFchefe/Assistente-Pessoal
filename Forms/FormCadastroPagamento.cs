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
    public partial class FormCadastroPagamento : Form
    {

        private bool is_edit = false;


        public FormCadastroPagamento(int edit_transact)
        {
            this.BringToFront();
            InitializeComponent();/*
            loadTipoEntrada();
            loadPortfolio();
            loadRemetente();
            this.transact_edit = new Transact(edit_transact);
            this.titulo.Text = titulo.Text + "  -  N° " + transact_edit.TransactNumber.ToString();
            this.cb_movimentacao.Text = transact_edit.movimentation.ToString();
            this.TexBoxValues.Text = transact_edit.value.ToString("F2");
            this.cb_carteira.Text = transact_edit.portfolio.name;
            this.textBox1.Text = transact_edit.comment;
            this.cb_remetente.Text = transact_edit.sender.name;
            this.register_date.Value = transact_edit.date;*/
            is_edit = true;
        }

        public FormCadastroPagamento()
        {
            InitializeComponent();/*
            loadTipoEntrada();
            loadPortfolio();
            loadRemetente();
            TexBoxValues.Text = string.Format("{0:#,##0.00}", 0d);*/
            is_edit = false;
        }
    }
}

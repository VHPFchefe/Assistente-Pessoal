﻿using AssistentePessoal.Entities.Account;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AssistentePessoal
{
    public partial class FormCadastroParcela : Form
    {
        private int id;
        private bool is_edit = false;
        public Parcel parcel { get; private set; }
        public bool close = false;

        public FormCadastroParcela(int id, int edit_transact)
        {
            this.BringToFront();
            InitializeComponent();
            /*
            this.transact_edit = new Transact(edit_transact);
            this.titulo.Text = titulo.Text +"  -  N° "+ transact_edit.TransactNumber.ToString();
            this.cb_movimentacao.Text = transact_edit.movimentation.ToString();
            this.TexBoxValues.Text = transact_edit.value.ToString("F2");
            this.cb_carteira.Text = transact_edit.portfolio.name;
            this.textBox1.Text = transact_edit.comment;
            this.cb_remetente.Text = transact_edit.sender.name;
            this.register_date.Value = transact_edit.date;*/
            is_edit = true;
            this.id = id;
        }

        public FormCadastroParcela(int id)
        {
            InitializeComponent();
            TexBoxValues.Text = string.Format("{0:#,##0.00}", 0d);
            is_edit = false;
            data_pagamento.Enabled = false;
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
                parcel = new Parcel(this.id, value, pagamento, vencimento);
                if (is_pago.Checked)
                {
                    parcel.PagarParcela();
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
            data_pagamento.Enabled = is_pago.Checked;
        }
    }
}
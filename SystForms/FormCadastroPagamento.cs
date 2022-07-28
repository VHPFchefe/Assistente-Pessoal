using AssistentePessoal.Entities.Account;
using AssistentePessoal.Extras;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections.Generic;

namespace AssistentePessoal
{
    public partial class FormCadastroPagamento : Form
    {
        Payments payment;
        private bool is_edit = false;
        DataGridViewRow last_row;

        public FormCadastroPagamento(int edit_transact)
        {
            this.BringToFront();
            InitializeComponent();
            is_edit = true;
            LoadFormRegister();
        }

        public FormCadastroPagamento()
        {
            InitializeComponent();
            is_edit = false;
            payment = new Payments();
            LoadFormRegister();
        }

        #region Metodos

        private void LoadFormRegister()
        {
            LoadProgress();
            LoadRows();
            LoadBeneficiario();
            btn_editar.Enabled = false;
            btn_pagar.Enabled = false;
            btn_duplicar_selecionado.Enabled = false;
        }

        #region Geral

        private void LoadBeneficiario()
        {
            Db_connection db = new Db_connection();
            try
            {
                c_beneficiado.Items.Clear();
                c_beneficiado.Text = "Selecione uma opção";
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
                    c_beneficiado.Items.Add(teste[1]);
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

        private void Anexar()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string localPath = ConfigurationManager.AppSettings["localPath"] + @"\Arquivos\" + openFileDialog1.SafeFileName;
                File.Copy(fileName, localPath);
                MessageBox.Show("Registrar no banco !!!\n\n" + fileName + "\npara =>\n" + localPath);
            }
        }
        #endregion

        #region Parcelas
        private void RefreshForm()
        {
            LoadProgress();
            getValue_label();
            this.grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void getLastRow()
        {
            this.last_row = this.grid.Rows[this.grid.Rows.Count - 1];
            this.last_row.ReadOnly = true;
            this.last_row.DefaultCellStyle.BackColor = Color.DarkSlateGray;
        }

        private void getValue_label()
        {
            value_label.Text = "R$ " + this.payment.value.ToString();
        }

        private void LoadProgress()
        {
            double qtd = payment.parcelas.Count;
            double progres = payment.ParcelasPagas();
            double value = progres / qtd * 100;
            this.lab_progress.Text = $"Progresso: {progres}/{qtd}";
            this.c_progresso.Value = (int)value < 0 ? 0 : (int)value;
        }

        private void LoadRows()
        {
            getLastRow();
            foreach (DataGridViewRow dr in this.grid.Rows)
            {
                if (dr.Cells["number"].RowIndex != this.last_row.Index)
                {
                    dr.Cells["number"].Value = ((int)dr.Cells["number"].RowIndex + 1).ToString();
                    dr.Cells["value"].Style.Format = "F2";
                    dr.Cells["vencimento"].Style.Format = "dd/MM/yyyy";
                    dr.Cells["pagamento"].Style.Format = "dd/MM/yyyy";
                    this.payment.parcelas[dr.Index].id = Convert.ToInt32(dr.Cells["number"].Value);
                }
                bool pago = dr.Cells["pago"].Value is null == false;
                if (pago)
                {
                    dr.DefaultCellStyle.ForeColor = Color.Gray;
                    dr.DefaultCellStyle.SelectionForeColor = Color.Gray;
                }
            }
            RefreshForm();
            StatusEditar();
        }

        private void AddRow()
        {
            int id = last_row.Index;
            FormCadastroParcela form = new FormCadastroParcela(id);
            form.ShowDialog();
            if (form.close)
            {
                this.grid.Rows.Add(1);
                this.grid.Rows[id].Cells["value"].Value = form.parcel.value;
                this.grid.Rows[id].Cells["vencimento"].Value = form.parcel.vencimento;
                if (form.parcel.status == Entities.Enum.PaymentStatus.Pago)
                {
                    this.grid.Rows[id].Cells["pagamento"].Value = form.parcel.date_pagamento;
                    this.grid.Rows[id].Cells["pago"].Value = true;
                }
                this.payment.AddParcel(form.parcel);
                LoadRows();
                StatusEditar();
            }
        }

        private void EditarParcela(int index)
        {
            FormCadastroParcela form = new FormCadastroParcela(index, this.payment.parcelas[index]);
            form.ShowDialog();
            if (form.close)
            {
                this.grid.Rows[index].Cells["value"].Value = form.parcel.value;
                this.grid.Rows[index].Cells["vencimento"].Value = form.parcel.vencimento;
                if (form.parcel.status == Entities.Enum.PaymentStatus.Pago)
                {
                    this.grid.Rows[index].Cells["pagamento"].Value = form.parcel.date_pagamento;
                    this.grid.Rows[index].Cells["pago"].Value = true;
                }
                this.payment.parcelas[index] = form.parcel;
                LoadRows();
                StatusEditar();
            }
        }

        private void RemoveRow()
        {
            if (this.grid.CurrentRow == null) return;
            foreach (DataGridViewRow item in this.grid.SelectedRows)
            {
                if (item.Index != this.last_row.Index)
                {
                    this.payment.RemoveParcel(item.Index);
                    this.grid.Rows.RemoveAt(item.Index);
                }
            }
            LoadRows();
        }

        private void PagarPacerlas()
        {
            try
            {
                List<Parcel> parcelasPagas = new List<Parcel>();
                string showParcel = "As parcelas:";
                foreach (DataGridViewRow dr in this.grid.SelectedRows)
                {
                    if (dr.Index != this.last_row.Index && dr.Cells["pago"].Value is null)
                    {
                        int id = Convert.ToInt32(dr.Cells["number"].Value.ToString());
                        foreach (Parcel item in this.payment.parcelas)
                        {
                            if (id == item.id)
                            {
                                item.PagarParcela();
                                parcelasPagas.Add(item);
                                showParcel += "\nN° " + item.id + ".";
                                dr.Cells["pago"].Value = true;
                                dr.Cells["pagamento"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                            }
                        }
                    }
                }
                if (parcelasPagas.Count == 0) throw new Exception("Nenhuma parcela pôde ser paga!");
                MessageBox.Show(showParcel + "\nForam pagas com sucesso!");
                LoadRows();
            }
            catch (Exception ex) { MessageBox.Show("Erro ao pagar as parcelas: " + ex.Message); }
        }

        private void DuplicarPacerlas(DataGridViewRow duplicada)
        {
            try
            {
                FormDialogDuplicar form = new FormDialogDuplicar();
                form.ShowDialog();
                if (form.close)
                {
                    int indexROW = last_row.Index;
                    string dmy = form.dmy;
                    int num_dupl = Convert.ToInt32(form.num_duplicatas);
                    int num_rein = Convert.ToInt32(form.num_reincidencia);
                    DateTime data_anterior = DateTime.Parse(duplicada.Cells["vencimento"].Value.ToString());
                    for (int i = 1 + indexROW; i <= num_dupl + indexROW; i++)
                    {
                        this.grid.Rows.Add(1);
                        DataGridViewRow row = this.grid.Rows[last_row.Index - 1];

                        double value = double.Parse(duplicada.Cells["value"].Value.ToString());
                        DateTime dataVencimento = IncrementarData(data_anterior, dmy, num_rein);
                        data_anterior = dataVencimento;

                        row.Cells["number"].Value = i;
                        row.Cells["value"].Value = value;
                        row.Cells["vencimento"].Value = dataVencimento;

                        // Optado por não duplicar as parcelas como pagas, o user deve pagar individualmente ou em massa após a duplicação
                        this.payment.AddParcel(new Parcel(i, value, dataVencimento));
                    }
                    LoadRows();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void GravarConta()
        {

        }

        private void StatusEditar()
        {
            if (this.grid.SelectedRows.Count == 1)
            {
                if (this.grid.SelectedRows[0].Cells["pago"].Value is null && this.grid.SelectedRows[0].Index != last_row.Index)
                {
                    btn_editar.Enabled = true;
                    btn_pagar.Enabled = true;
                }
                else
                {
                    btn_editar.Enabled = false;
                    btn_pagar.Enabled = false;
                }
                btn_duplicar_selecionado.Enabled = true; // mesmo estando paga a parcela ela pode ser duplicada, porém as duplicatas não terão status de pagas.
            }
            else
            {
                bool isT = false;
                foreach (DataGridViewRow dr in this.grid.SelectedRows)
                {
                    if (dr.Cells["pago"].Value is null)
                    {
                        isT = true;
                        break;
                    }
                }
                btn_pagar.Enabled = isT;
                btn_editar.Enabled = false;
                btn_duplicar_selecionado.Enabled = false;
            }
        }

        private DateTime IncrementarData(DateTime date, String dmy, int reincidencia)
        {
            DateTime newDate = date;

            switch (dmy)
            {
                case "Dia":
                    newDate = newDate.AddDays(reincidencia);
                    break;
                case "Mês":
                    newDate = newDate.AddMonths(1);
                    break;
                case "Ano":
                    newDate = newDate.AddYears(reincidencia);
                    break;
            }

            return newDate;
        }

        #endregion

        #endregion

        #region Eventos
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            RemoveRow();
        }

        private void btn_cancelar_conta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja cancelar ?", "Cancelar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anexar();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            PagarPacerlas();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            this.grid.Rows[last_row.Index].Selected = false;
            StatusEditar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            EditarParcela(this.grid.SelectedRows[0].Index);
        }

        private void btn_gravar_conta_Click(object sender, EventArgs e)
        {
            GravarConta();
        }

        private void btn_duplicar_selecionado_Click(object sender, EventArgs e)
        {
            DuplicarPacerlas(this.grid.SelectedRows[0]);
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(1);
        }
        #endregion
    }
}

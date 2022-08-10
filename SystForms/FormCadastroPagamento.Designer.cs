
namespace AssistentePessoal
{
    partial class FormCadastroPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPagamento));
            this.tabParcelas = new System.Windows.Forms.TabPage();
            this.btn_cancelar_conta = new System.Windows.Forms.Button();
            this.btn_gravar_conta = new System.Windows.Forms.Button();
            this.btn_duplicar_selecionado = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.c_beneficiado = new System.Windows.Forms.ComboBox();
            this.value_label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.c_data_emissao = new System.Windows.Forms.DateTimePicker();
            this.c_nome = new System.Windows.Forms.TextBox();
            this.lab_progress = new System.Windows.Forms.Label();
            this.c_description = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c_progresso = new System.Windows.Forms.ProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tabGeral.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabParcelas
            // 
            this.tabParcelas.BackColor = System.Drawing.SystemColors.Control;
            this.tabParcelas.Controls.Add(this.btn_cancelar_conta);
            this.tabParcelas.Controls.Add(this.btn_gravar_conta);
            this.tabParcelas.Controls.Add(this.btn_duplicar_selecionado);
            this.tabParcelas.Controls.Add(this.btn_editar);
            this.tabParcelas.Controls.Add(this.btn_pagar);
            this.tabParcelas.Controls.Add(this.grid);
            this.tabParcelas.Controls.Add(this.btn_remove);
            this.tabParcelas.Controls.Add(this.btn_add);
            this.tabParcelas.Location = new System.Drawing.Point(4, 22);
            this.tabParcelas.Name = "tabParcelas";
            this.tabParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tabParcelas.Size = new System.Drawing.Size(633, 373);
            this.tabParcelas.TabIndex = 2;
            this.tabParcelas.Text = "Parcelas";
            // 
            // btn_cancelar_conta
            // 
            this.btn_cancelar_conta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancelar_conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar_conta.Location = new System.Drawing.Point(468, 342);
            this.btn_cancelar_conta.Name = "btn_cancelar_conta";
            this.btn_cancelar_conta.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_conta.TabIndex = 18;
            this.btn_cancelar_conta.Text = "Cancelar";
            this.btn_cancelar_conta.UseVisualStyleBackColor = false;
            this.btn_cancelar_conta.Click += new System.EventHandler(this.btn_cancelar_conta_Click);
            // 
            // btn_gravar_conta
            // 
            this.btn_gravar_conta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_gravar_conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gravar_conta.Location = new System.Drawing.Point(549, 342);
            this.btn_gravar_conta.Name = "btn_gravar_conta";
            this.btn_gravar_conta.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar_conta.TabIndex = 17;
            this.btn_gravar_conta.Text = "Ok";
            this.btn_gravar_conta.UseVisualStyleBackColor = false;
            this.btn_gravar_conta.Click += new System.EventHandler(this.btn_gravar_conta_Click);
            // 
            // btn_duplicar_selecionado
            // 
            this.btn_duplicar_selecionado.Image = global::AssistentePessoal.Properties.Resources.campos_adicionais16x16;
            this.btn_duplicar_selecionado.Location = new System.Drawing.Point(126, 26);
            this.btn_duplicar_selecionado.Name = "btn_duplicar_selecionado";
            this.btn_duplicar_selecionado.Size = new System.Drawing.Size(24, 23);
            this.btn_duplicar_selecionado.TabIndex = 9;
            this.btn_duplicar_selecionado.UseVisualStyleBackColor = true;
            this.btn_duplicar_selecionado.Click += new System.EventHandler(this.btn_duplicar_selecionado_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Image = global::AssistentePessoal.Properties.Resources.editar16x16;
            this.btn_editar.Location = new System.Drawing.Point(96, 26);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(24, 23);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.Image = global::AssistentePessoal.Properties.Resources.apply;
            this.btn_pagar.Location = new System.Drawing.Point(66, 26);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(24, 23);
            this.btn_pagar.TabIndex = 7;
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.value,
            this.vencimento,
            this.pagamento,
            this.pago});
            this.grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grid.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.grid.Location = new System.Drawing.Point(7, 55);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(246)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(617, 281);
            this.grid.TabIndex = 6;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // number
            // 
            this.number.HeaderText = "N°";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number.Width = 90;
            // 
            // value
            // 
            this.value.HeaderText = "$";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "Data de Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.ReadOnly = true;
            this.vencimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vencimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vencimento.Width = 160;
            // 
            // pagamento
            // 
            this.pagamento.HeaderText = "Data de Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pagamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pagamento.Width = 160;
            // 
            // pago
            // 
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pago.Width = 67;
            // 
            // btn_remove
            // 
            this.btn_remove.Image = global::AssistentePessoal.Properties.Resources.cancelar_NFe16x16;
            this.btn_remove.Location = new System.Drawing.Point(36, 26);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(24, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::AssistentePessoal.Properties.Resources.duplicar;
            this.btn_add.Location = new System.Drawing.Point(6, 26);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(24, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tabGeral
            // 
            this.tabGeral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeral.Controls.Add(this.btn_continuar);
            this.tabGeral.Controls.Add(this.c_beneficiado);
            this.tabGeral.Controls.Add(this.value_label);
            this.tabGeral.Controls.Add(this.button3);
            this.tabGeral.Controls.Add(this.c_data_emissao);
            this.tabGeral.Controls.Add(this.c_nome);
            this.tabGeral.Controls.Add(this.lab_progress);
            this.tabGeral.Controls.Add(this.c_description);
            this.tabGeral.Controls.Add(this.label7);
            this.tabGeral.Controls.Add(this.label6);
            this.tabGeral.Controls.Add(this.label5);
            this.tabGeral.Controls.Add(this.label3);
            this.tabGeral.Controls.Add(this.label2);
            this.tabGeral.Controls.Add(this.label1);
            this.tabGeral.Controls.Add(this.c_progresso);
            this.tabGeral.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(633, 373);
            this.tabGeral.TabIndex = 0;
            this.tabGeral.Text = "Geral";
            // 
            // btn_continuar
            // 
            this.btn_continuar.Location = new System.Drawing.Point(549, 341);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(75, 23);
            this.btn_continuar.TabIndex = 19;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // c_beneficiado
            // 
            this.c_beneficiado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_beneficiado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_beneficiado.FormattingEnabled = true;
            this.c_beneficiado.Location = new System.Drawing.Point(136, 90);
            this.c_beneficiado.Name = "c_beneficiado";
            this.c_beneficiado.Size = new System.Drawing.Size(185, 21);
            this.c_beneficiado.TabIndex = 18;
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.BackColor = System.Drawing.Color.Gainsboro;
            this.value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_label.Location = new System.Drawing.Point(443, 66);
            this.value_label.MinimumSize = new System.Drawing.Size(165, 0);
            this.value_label.Name = "value_label";
            this.value_label.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.value_label.Size = new System.Drawing.Size(165, 19);
            this.value_label.TabIndex = 17;
            this.value_label.Text = "R$ 0,00";
            this.value_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(134, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 22);
            this.button3.TabIndex = 16;
            this.button3.Text = "Anexar\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // c_data_emissao
            // 
            this.c_data_emissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_data_emissao.Location = new System.Drawing.Point(443, 40);
            this.c_data_emissao.Name = "c_data_emissao";
            this.c_data_emissao.Size = new System.Drawing.Size(167, 20);
            this.c_data_emissao.TabIndex = 14;
            // 
            // c_nome
            // 
            this.c_nome.Location = new System.Drawing.Point(136, 40);
            this.c_nome.Name = "c_nome";
            this.c_nome.Size = new System.Drawing.Size(185, 20);
            this.c_nome.TabIndex = 12;
            // 
            // lab_progress
            // 
            this.lab_progress.AutoSize = true;
            this.lab_progress.BackColor = System.Drawing.Color.LightGray;
            this.lab_progress.Location = new System.Drawing.Point(327, 91);
            this.lab_progress.Margin = new System.Windows.Forms.Padding(3);
            this.lab_progress.MaximumSize = new System.Drawing.Size(110, 20);
            this.lab_progress.MinimumSize = new System.Drawing.Size(110, 20);
            this.lab_progress.Name = "lab_progress";
            this.lab_progress.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.lab_progress.Size = new System.Drawing.Size(110, 20);
            this.lab_progress.TabIndex = 9;
            this.lab_progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // c_description
            // 
            this.c_description.Location = new System.Drawing.Point(22, 159);
            this.c_description.Multiline = true;
            this.c_description.Name = "c_description";
            this.c_description.Size = new System.Drawing.Size(588, 176);
            this.c_description.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(52, 4, 0, 3);
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descrição:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4, 4, 0, 3);
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Documento / Anexo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(327, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 4, 0, 3);
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Emissão:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(327, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(76, 4, 0, 3);
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(44, 4, 0, 3);
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beneficiado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(72, 4, 0, 3);
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // c_progresso
            // 
            this.c_progresso.Location = new System.Drawing.Point(443, 92);
            this.c_progresso.Name = "c_progresso";
            this.c_progresso.Size = new System.Drawing.Size(167, 19);
            this.c_progresso.TabIndex = 8;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeral);
            this.tabControl.Controls.Add(this.tabParcelas);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(641, 399);
            this.tabControl.TabIndex = 0;
            // 
            // FormCadastroPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 401);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas";
            this.tabParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabParcelas;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.TextBox c_description;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DateTimePicker c_data_emissao;
        private System.Windows.Forms.TextBox c_nome;
        private System.Windows.Forms.Label lab_progress;
        private System.Windows.Forms.ProgressBar c_progresso;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label value_label;
        private System.Windows.Forms.ComboBox c_beneficiado;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.Button btn_duplicar_selecionado;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_cancelar_conta;
        private System.Windows.Forms.Button btn_gravar_conta;
    }
}
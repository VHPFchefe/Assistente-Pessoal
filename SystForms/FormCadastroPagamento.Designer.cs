
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.c_valor = new System.Windows.Forms.TextBox();
            this.c_data_emissao = new System.Windows.Forms.DateTimePicker();
            this.c_beneficiado = new System.Windows.Forms.ComboBox();
            this.c_nome = new System.Windows.Forms.TextBox();
            this.c_documento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c_progresso = new System.Windows.Forms.ProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.grid = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabParcelas.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabParcelas
            // 
            this.tabParcelas.BackColor = System.Drawing.SystemColors.Control;
            this.tabParcelas.Controls.Add(this.grid);
            this.tabParcelas.Controls.Add(this.button2);
            this.tabParcelas.Controls.Add(this.btn_remove);
            this.tabParcelas.Controls.Add(this.btn_add);
            this.tabParcelas.Controls.Add(this.button1);
            this.tabParcelas.Location = new System.Drawing.Point(4, 22);
            this.tabParcelas.Name = "tabParcelas";
            this.tabParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tabParcelas.Size = new System.Drawing.Size(633, 373);
            this.tabParcelas.TabIndex = 2;
            this.tabParcelas.Text = "Parcelas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabGeral
            // 
            this.tabGeral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeral.Controls.Add(this.c_valor);
            this.tabGeral.Controls.Add(this.c_data_emissao);
            this.tabGeral.Controls.Add(this.c_beneficiado);
            this.tabGeral.Controls.Add(this.c_nome);
            this.tabGeral.Controls.Add(this.c_documento);
            this.tabGeral.Controls.Add(this.label4);
            this.tabGeral.Controls.Add(this.textBox1);
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
            // c_valor
            // 
            this.c_valor.Location = new System.Drawing.Point(442, 66);
            this.c_valor.Name = "c_valor";
            this.c_valor.ReadOnly = true;
            this.c_valor.Size = new System.Drawing.Size(168, 20);
            this.c_valor.TabIndex = 15;
            // 
            // c_data_emissao
            // 
            this.c_data_emissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_data_emissao.Location = new System.Drawing.Point(443, 39);
            this.c_data_emissao.Name = "c_data_emissao";
            this.c_data_emissao.Size = new System.Drawing.Size(167, 20);
            this.c_data_emissao.TabIndex = 14;
            // 
            // c_beneficiado
            // 
            this.c_beneficiado.FormattingEnabled = true;
            this.c_beneficiado.Location = new System.Drawing.Point(136, 89);
            this.c_beneficiado.Name = "c_beneficiado";
            this.c_beneficiado.Size = new System.Drawing.Size(185, 21);
            this.c_beneficiado.TabIndex = 13;
            // 
            // c_nome
            // 
            this.c_nome.Location = new System.Drawing.Point(136, 39);
            this.c_nome.Name = "c_nome";
            this.c_nome.Size = new System.Drawing.Size(185, 20);
            this.c_nome.TabIndex = 12;
            // 
            // c_documento
            // 
            this.c_documento.Location = new System.Drawing.Point(136, 65);
            this.c_documento.Name = "c_documento";
            this.c_documento.Size = new System.Drawing.Size(185, 20);
            this.c_documento.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(327, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.MaximumSize = new System.Drawing.Size(110, 20);
            this.label4.MinimumSize = new System.Drawing.Size(110, 20);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Progresso: XXX";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 176);
            this.textBox1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
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
            this.c_progresso.Value = 70;
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
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(246)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(617, 281);
            this.grid.TabIndex = 6;
            this.grid.VirtualMode = true;
            // 
            // number
            // 
            this.number.HeaderText = "N°";
            this.number.Name = "number";
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 90;
            // 
            // value
            // 
            this.value.HeaderText = "Valor";
            this.value.Name = "value";
            this.value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "Data de Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vencimento.Width = 160;
            // 
            // pagamento
            // 
            this.pagamento.HeaderText = "Data de Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pagamento.Width = 160;
            // 
            // pago
            // 
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pago.Width = 67;
            // 
            // FormCadastroPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 401);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroPagamento";
            this.Text = "Contas";
            this.tabParcelas.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabParcelas;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox c_valor;
        private System.Windows.Forms.DateTimePicker c_data_emissao;
        private System.Windows.Forms.ComboBox c_beneficiado;
        private System.Windows.Forms.TextBox c_nome;
        private System.Windows.Forms.TextBox c_documento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar c_progresso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
    }
}
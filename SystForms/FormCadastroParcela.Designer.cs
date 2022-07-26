
namespace AssistentePessoal
{
    partial class FormCadastroParcela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroParcela));
            this.label1 = new System.Windows.Forms.Label();
            this.Data_vencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TexBoxValues = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_pagamento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.is_pago = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cancelar = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Data_vencimento
            // 
            this.Data_vencimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Data_vencimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Data_vencimento.CustomFormat = "";
            this.Data_vencimento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data_vencimento.Location = new System.Drawing.Point(184, 104);
            this.Data_vencimento.Name = "Data_vencimento";
            this.Data_vencimento.Size = new System.Drawing.Size(235, 21);
            this.Data_vencimento.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 100);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "Data de Vencimento:";
            // 
            // TexBoxValues
            // 
            this.TexBoxValues.Location = new System.Drawing.Point(184, 69);
            this.TexBoxValues.Name = "TexBoxValues";
            this.TexBoxValues.Size = new System.Drawing.Size(234, 20);
            this.TexBoxValues.TabIndex = 32;
            this.TexBoxValues.KeyDown += new System.Windows.Forms.KeyEventHandler(this.value_KeyDown);
            this.TexBoxValues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.value_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 63);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(95, 6, 0, 6);
            this.label4.Size = new System.Drawing.Size(138, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "Valor:";
            // 
            // data_pagamento
            // 
            this.data_pagamento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.data_pagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_pagamento.CustomFormat = "";
            this.data_pagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_pagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_pagamento.Location = new System.Drawing.Point(185, 184);
            this.data_pagamento.Name = "data_pagamento";
            this.data_pagamento.Size = new System.Drawing.Size(235, 21);
            this.data_pagamento.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 180);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Data de Pagamento:";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.LightGray;
            this.titulo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(40, 37);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(50, 15);
            this.titulo.TabIndex = 28;
            this.titulo.Text = "Parcela";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(39, 37);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(110, 3, 110, 0);
            this.label6.Size = new System.Drawing.Size(379, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Registro de Movimentação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 139);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(100, 6, 0, 6);
            this.label5.Size = new System.Drawing.Size(138, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pago:";
            // 
            // is_pago
            // 
            this.is_pago.AutoSize = true;
            this.is_pago.Location = new System.Drawing.Point(198, 145);
            this.is_pago.Name = "is_pago";
            this.is_pago.Size = new System.Drawing.Size(42, 17);
            this.is_pago.TabIndex = 35;
            this.is_pago.Text = "Sim";
            this.is_pago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.is_pago.UseVisualStyleBackColor = true;
            this.is_pago.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(246, 145);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Location = new System.Drawing.Point(262, 228);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 38;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.Location = new System.Drawing.Point(343, 228);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 37;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.salvar_Click);
            // 
            // FormCadastroParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 263);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.is_pago);
            this.Controls.Add(this.Data_vencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TexBoxValues);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_pagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCadastroParcela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistente Pessoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Data_vencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TexBoxValues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker data_pagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton is_pago;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button ok;
    }
}


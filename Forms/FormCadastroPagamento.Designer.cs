
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPagamento));
            this.tabParcelas = new System.Windows.Forms.TabPage();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.c_progresso = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.c_documento = new System.Windows.Forms.TextBox();
            this.c_nome = new System.Windows.Forms.TextBox();
            this.c_beneficiado = new System.Windows.Forms.ComboBox();
            this.c_data_emissao = new System.Windows.Forms.DateTimePicker();
            this.c_valor = new System.Windows.Forms.TextBox();
            this.tabGeral.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabParcelas
            // 
            this.tabParcelas.BackColor = System.Drawing.SystemColors.Control;
            this.tabParcelas.Location = new System.Drawing.Point(4, 22);
            this.tabParcelas.Name = "tabParcelas";
            this.tabParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tabParcelas.Size = new System.Drawing.Size(633, 373);
            this.tabParcelas.TabIndex = 2;
            this.tabParcelas.Text = "Parcelas";
            // 
            // tabGeral
            // 
            this.tabGeral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeral.Controls.Add(this.c_valor);
            this.tabGeral.Controls.Add(this.c_data_emissao);
            this.tabGeral.Controls.Add(this.c_beneficiado);
            this.tabGeral.Controls.Add(this.c_nome);
            this.tabGeral.Controls.Add(this.c_documento);
            this.tabGeral.Controls.Add(this.label8);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(72, 4, 0, 3);
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(19, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4, 4, 0, 3);
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Documento / Anexo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 176);
            this.textBox1.TabIndex = 7;
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
            // c_progresso
            // 
            this.c_progresso.Location = new System.Drawing.Point(443, 92);
            this.c_progresso.Name = "c_progresso";
            this.c_progresso.Size = new System.Drawing.Size(167, 19);
            this.c_progresso.TabIndex = 8;
            this.c_progresso.Value = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(327, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(53, 4, 0, 3);
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Progresso:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(440, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "7 / 10";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c_documento
            // 
            this.c_documento.Location = new System.Drawing.Point(136, 40);
            this.c_documento.Name = "c_documento";
            this.c_documento.Size = new System.Drawing.Size(185, 20);
            this.c_documento.TabIndex = 11;
            // 
            // c_nome
            // 
            this.c_nome.Location = new System.Drawing.Point(136, 66);
            this.c_nome.Name = "c_nome";
            this.c_nome.Size = new System.Drawing.Size(185, 20);
            this.c_nome.TabIndex = 12;
            // 
            // c_beneficiado
            // 
            this.c_beneficiado.FormattingEnabled = true;
            this.c_beneficiado.Location = new System.Drawing.Point(136, 89);
            this.c_beneficiado.Name = "c_beneficiado";
            this.c_beneficiado.Size = new System.Drawing.Size(185, 21);
            this.c_beneficiado.TabIndex = 13;
            // 
            // c_data_emissao
            // 
            this.c_data_emissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.c_data_emissao.Location = new System.Drawing.Point(443, 39);
            this.c_data_emissao.Name = "c_data_emissao";
            this.c_data_emissao.Size = new System.Drawing.Size(167, 20);
            this.c_data_emissao.TabIndex = 14;
            // 
            // c_valor
            // 
            this.c_valor.Location = new System.Drawing.Point(442, 66);
            this.c_valor.Name = "c_valor";
            this.c_valor.Size = new System.Drawing.Size(168, 20);
            this.c_valor.TabIndex = 15;
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
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            this.tabControl.ResumeLayout(false);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar c_progresso;
    }
}
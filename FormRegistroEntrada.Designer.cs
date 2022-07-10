
namespace AssistentePessoal
{
    partial class FormRegistroEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroEntrada));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register_date = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.titulo = new System.Windows.Forms.Label();
            this.cb_movimentacao = new System.Windows.Forms.ComboBox();
            this.cb_carteira = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.TexBoxValues = new System.Windows.Forms.TextBox();
            this.cb_remetente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 53);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(100, 6, 0, 6);
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 89);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(42, 6, 0, 6);
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movimentação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 126);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(95, 6, 0, 6);
            this.label4.Size = new System.Drawing.Size(138, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 163);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(79, 6, 0, 6);
            this.label5.Size = new System.Drawing.Size(139, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Carteira:";
            // 
            // register_date
            // 
            this.register_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.register_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_date.CustomFormat = "";
            this.register_date.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.register_date.Location = new System.Drawing.Point(206, 57);
            this.register_date.Name = "register_date";
            this.register_date.Size = new System.Drawing.Size(235, 21);
            this.register_date.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listView1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 377);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(65, 27);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(159, 15);
            this.titulo.TabIndex = 7;
            this.titulo.Text = "Registro de Movimentação";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_movimentacao
            // 
            this.cb_movimentacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_movimentacao.FormattingEnabled = true;
            this.cb_movimentacao.Location = new System.Drawing.Point(206, 93);
            this.cb_movimentacao.Name = "cb_movimentacao";
            this.cb_movimentacao.Size = new System.Drawing.Size(235, 21);
            this.cb_movimentacao.TabIndex = 8;
            // 
            // cb_carteira
            // 
            this.cb_carteira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_carteira.FormattingEnabled = true;
            this.cb_carteira.Location = new System.Drawing.Point(206, 167);
            this.cb_carteira.Name = "cb_carteira";
            this.cb_carteira.Size = new System.Drawing.Size(235, 21);
            this.cb_carteira.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 84);
            this.textBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 244);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(150, 0, 150, 0);
            this.label7.Size = new System.Drawing.Size(375, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comentário";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ok.Location = new System.Drawing.Point(365, 352);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 15;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.salvar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelar.Location = new System.Drawing.Point(284, 352);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 16;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // TexBoxValues
            // 
            this.TexBoxValues.Location = new System.Drawing.Point(206, 132);
            this.TexBoxValues.Name = "TexBoxValues";
            this.TexBoxValues.Size = new System.Drawing.Size(234, 20);
            this.TexBoxValues.TabIndex = 17;
            this.TexBoxValues.KeyDown += new System.Windows.Forms.KeyEventHandler(this.value_KeyDown);
            this.TexBoxValues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.value_KeyPress);
            // 
            // cb_remetente
            // 
            this.cb_remetente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_remetente.FormattingEnabled = true;
            this.cb_remetente.Location = new System.Drawing.Point(206, 205);
            this.cb_remetente.Name = "cb_remetente";
            this.cb_remetente.Size = new System.Drawing.Size(235, 21);
            this.cb_remetente.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 201);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(66, 6, 0, 6);
            this.label8.Size = new System.Drawing.Size(139, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "Remetente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(61, 27);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(110, 0, 110, 0);
            this.label6.Size = new System.Drawing.Size(379, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Registro de Movimentação";
            // 
            // FormRegistroEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 401);
            this.Controls.Add(this.cb_remetente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TexBoxValues);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_carteira);
            this.Controls.Add(this.cb_movimentacao);
            this.Controls.Add(this.register_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistroEntrada";
            this.Text = "Assistente Pessoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Label label5;
        private global::System.Windows.Forms.DateTimePicker register_date;
        private global::System.Windows.Forms.ListView listView1;
        private global::System.Windows.Forms.Label titulo;
        private global::System.Windows.Forms.ComboBox cb_movimentacao;
        private global::System.Windows.Forms.ComboBox cb_carteira;
        private global::System.Windows.Forms.TextBox textBox1;
        private global::System.Windows.Forms.Label label7;
        private global::System.Windows.Forms.Button ok;
        private global::System.Windows.Forms.Button cancelar;
        private global::System.Windows.Forms.TextBox TexBoxValues;
        private System.Windows.Forms.ComboBox cb_remetente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}


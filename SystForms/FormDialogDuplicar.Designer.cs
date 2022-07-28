
namespace AssistentePessoal
{
    partial class FormDialogDuplicar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogDuplicar));
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_duplicatas = new System.Windows.Forms.NumericUpDown();
            this.numeric_reincidencia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_DMY = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_duplicatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_reincidencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(46, 2, 0, 3);
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quantidade:";
            // 
            // numeric_duplicatas
            // 
            this.numeric_duplicatas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numeric_duplicatas.Location = new System.Drawing.Point(143, 40);
            this.numeric_duplicatas.Name = "numeric_duplicatas";
            this.numeric_duplicatas.Size = new System.Drawing.Size(39, 20);
            this.numeric_duplicatas.TabIndex = 36;
            // 
            // numeric_reincidencia
            // 
            this.numeric_reincidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numeric_reincidencia.Location = new System.Drawing.Point(143, 9);
            this.numeric_reincidencia.Name = "numeric_reincidencia";
            this.numeric_reincidencia.Size = new System.Drawing.Size(39, 20);
            this.numeric_reincidencia.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Reincidência: a cada";
            // 
            // cb_DMY
            // 
            this.cb_DMY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_DMY.FormattingEnabled = true;
            this.cb_DMY.Items.AddRange(new object[] {
            "Dia",
            "Mês",
            "Ano"});
            this.cb_DMY.Location = new System.Drawing.Point(188, 9);
            this.cb_DMY.Name = "cb_DMY";
            this.cb_DMY.Size = new System.Drawing.Size(70, 21);
            this.cb_DMY.TabIndex = 37;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Location = new System.Drawing.Point(102, 74);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 40;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.Location = new System.Drawing.Point(183, 74);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 39;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // FormDialogDuplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 112);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cb_DMY);
            this.Controls.Add(this.numeric_reincidencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_duplicatas);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogDuplicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Duplicar Parcelas";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_duplicatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_reincidencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric_duplicatas;
        private System.Windows.Forms.NumericUpDown numeric_reincidencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_DMY;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button ok;
    }
}
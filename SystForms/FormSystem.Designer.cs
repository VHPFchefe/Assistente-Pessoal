
namespace AssistentePessoal
{
    partial class FormSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSystem));
            this.grafico_entrada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.entrada_saida = new System.Windows.Forms.TabPage();
            this.lucro_tendencia = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grafico_lucro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tollStripADM = new System.Windows.Forms.ToolStripButton();
            this.tollStripPORT = new System.Windows.Forms.ToolStripButton();
            this.tollStripMOV = new System.Windows.Forms.ToolStripButton();
            this.toolStripPagamentos = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_entrada)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.entrada_saida.SuspendLayout();
            this.lucro_tendencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_lucro)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafico_entrada
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico_entrada.ChartAreas.Add(chartArea1);
            this.grafico_entrada.Cursor = System.Windows.Forms.Cursors.No;
            this.grafico_entrada.Location = new System.Drawing.Point(-1, 0);
            this.grafico_entrada.Name = "grafico_entrada";
            this.grafico_entrada.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.grafico_entrada.Size = new System.Drawing.Size(845, 431);
            this.grafico_entrada.TabIndex = 5;
            this.grafico_entrada.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.entrada_saida);
            this.tabControl1.Controls.Add(this.lucro_tendencia);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 443);
            this.tabControl1.TabIndex = 6;
            // 
            // entrada_saida
            // 
            this.entrada_saida.BackColor = System.Drawing.Color.Transparent;
            this.entrada_saida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.entrada_saida.Controls.Add(this.grafico_entrada);
            this.entrada_saida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.entrada_saida.Location = new System.Drawing.Point(4, 22);
            this.entrada_saida.Name = "entrada_saida";
            this.entrada_saida.Padding = new System.Windows.Forms.Padding(3);
            this.entrada_saida.Size = new System.Drawing.Size(840, 417);
            this.entrada_saida.TabIndex = 0;
            this.entrada_saida.Text = "Entradas x Saídas";
            // 
            // lucro_tendencia
            // 
            this.lucro_tendencia.Controls.Add(this.richTextBox1);
            this.lucro_tendencia.Controls.Add(this.grafico_lucro);
            this.lucro_tendencia.Location = new System.Drawing.Point(4, 22);
            this.lucro_tendencia.Name = "lucro_tendencia";
            this.lucro_tendencia.Padding = new System.Windows.Forms.Padding(3);
            this.lucro_tendencia.Size = new System.Drawing.Size(840, 417);
            this.lucro_tendencia.TabIndex = 1;
            this.lucro_tendencia.Text = "Lucro x Tendência";
            this.lucro_tendencia.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox1.Location = new System.Drawing.Point(97, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(640, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Coming soon:\n----------------------------------------------\n1 - Nova funcionalida" +
    "de - Contas a Pagar;\n2 - Implementar gráfico de lucro x tendencia;\n3 - Webview";
            // 
            // grafico_lucro
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico_lucro.ChartAreas.Add(chartArea2);
            this.grafico_lucro.Cursor = System.Windows.Forms.Cursors.No;
            this.grafico_lucro.Location = new System.Drawing.Point(-1, -1);
            this.grafico_lucro.Name = "grafico_lucro";
            this.grafico_lucro.Size = new System.Drawing.Size(848, 431);
            this.grafico_lucro.TabIndex = 6;
            this.grafico_lucro.Text = "chart1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tollStripADM,
            this.tollStripPORT,
            this.tollStripMOV,
            this.toolStripPagamentos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 38);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tollStripADM
            // 
            this.tollStripADM.BackColor = System.Drawing.Color.Transparent;
            this.tollStripADM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tollStripADM.Image = global::AssistentePessoal.Properties.Resources.conta_32px;
            this.tollStripADM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tollStripADM.Margin = new System.Windows.Forms.Padding(1);
            this.tollStripADM.Name = "tollStripADM";
            this.tollStripADM.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tollStripADM.Size = new System.Drawing.Size(56, 36);
            this.tollStripADM.Text = "Remetente/Beneficiário";
            this.tollStripADM.Click += new System.EventHandler(this.tollStripADM_Click);
            this.tollStripADM.MouseEnter += new System.EventHandler(this.tollStripADM_MouseEnter);
            this.tollStripADM.MouseLeave += new System.EventHandler(this.tollStripADM_MouseLeave);
            // 
            // tollStripPORT
            // 
            this.tollStripPORT.BackColor = System.Drawing.Color.Transparent;
            this.tollStripPORT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tollStripPORT.Image = global::AssistentePessoal.Properties.Resources.carteira_32px;
            this.tollStripPORT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tollStripPORT.Margin = new System.Windows.Forms.Padding(1);
            this.tollStripPORT.Name = "tollStripPORT";
            this.tollStripPORT.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tollStripPORT.Size = new System.Drawing.Size(56, 36);
            this.tollStripPORT.Text = "Portifólio/Carteira";
            this.tollStripPORT.Click += new System.EventHandler(this.tollStripPORT_Click);
            this.tollStripPORT.MouseEnter += new System.EventHandler(this.tollStripADM_MouseEnter);
            this.tollStripPORT.MouseLeave += new System.EventHandler(this.tollStripADM_MouseLeave);
            // 
            // tollStripMOV
            // 
            this.tollStripMOV.BackColor = System.Drawing.Color.Transparent;
            this.tollStripMOV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tollStripMOV.Image = global::AssistentePessoal.Properties.Resources.intercambio_32px;
            this.tollStripMOV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tollStripMOV.Margin = new System.Windows.Forms.Padding(1);
            this.tollStripMOV.Name = "tollStripMOV";
            this.tollStripMOV.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tollStripMOV.Size = new System.Drawing.Size(56, 36);
            this.tollStripMOV.Text = "Movimentações";
            this.tollStripMOV.Click += new System.EventHandler(this.tollStripMOV_Click);
            this.tollStripMOV.MouseEnter += new System.EventHandler(this.tollStripADM_MouseEnter);
            this.tollStripMOV.MouseLeave += new System.EventHandler(this.tollStripADM_MouseLeave);
            // 
            // toolStripPagamentos
            // 
            this.toolStripPagamentos.BackColor = System.Drawing.Color.Transparent;
            this.toolStripPagamentos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPagamentos.Image = global::AssistentePessoal.Properties.Resources.seta_para_baixo_32px;
            this.toolStripPagamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPagamentos.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripPagamentos.Name = "toolStripPagamentos";
            this.toolStripPagamentos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripPagamentos.Size = new System.Drawing.Size(56, 36);
            this.toolStripPagamentos.Text = "Contas a Pagar";
            this.toolStripPagamentos.Click += new System.EventHandler(this.toolStripPagamentos_Click);
            this.toolStripPagamentos.MouseEnter += new System.EventHandler(this.tollStripADM_MouseEnter);
            this.toolStripPagamentos.MouseLeave += new System.EventHandler(this.tollStripADM_MouseLeave);
            // 
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(882, 506);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistente Pessoal";
            this.Load += new System.EventHandler(this.FormSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico_entrada)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.entrada_saida.ResumeLayout(false);
            this.lucro_tendencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafico_lucro)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_entrada;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage entrada_saida;
        private System.Windows.Forms.TabPage lucro_tendencia;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_lucro;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tollStripADM;
        private System.Windows.Forms.ToolStripButton tollStripPORT;
        private System.Windows.Forms.ToolStripButton tollStripMOV;
        private System.Windows.Forms.ToolStripButton toolStripPagamentos;
    }
}
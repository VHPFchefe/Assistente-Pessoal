
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
            this.registros = new System.Windows.Forms.Button();
            this.remetentes = new System.Windows.Forms.Button();
            this.carteira = new System.Windows.Forms.Button();
            this.grafico_entrada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.entrada_saida = new System.Windows.Forms.TabPage();
            this.lucro_tendencia = new System.Windows.Forms.TabPage();
            this.grafico_lucro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_entrada)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.entrada_saida.SuspendLayout();
            this.lucro_tendencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_lucro)).BeginInit();
            this.SuspendLayout();
            // 
            // registros
            // 
            this.registros.BackColor = System.Drawing.Color.LightGreen;
            this.registros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registros.Location = new System.Drawing.Point(608, 11);
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(118, 34);
            this.registros.TabIndex = 1;
            this.registros.Text = "Visualizar Registros";
            this.registros.UseVisualStyleBackColor = false;
            this.registros.Click += new System.EventHandler(this.button1_Click);
            // 
            // remetentes
            // 
            this.remetentes.BackColor = System.Drawing.Color.LightGreen;
            this.remetentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remetentes.Location = new System.Drawing.Point(732, 11);
            this.remetentes.Name = "remetentes";
            this.remetentes.Size = new System.Drawing.Size(121, 34);
            this.remetentes.TabIndex = 2;
            this.remetentes.Text = "Cadastrar Remetentes";
            this.remetentes.UseVisualStyleBackColor = false;
            this.remetentes.Click += new System.EventHandler(this.button2_Click);
            // 
            // carteira
            // 
            this.carteira.BackColor = System.Drawing.Color.LightGreen;
            this.carteira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carteira.Location = new System.Drawing.Point(483, 11);
            this.carteira.Name = "carteira";
            this.carteira.Size = new System.Drawing.Size(119, 34);
            this.carteira.TabIndex = 3;
            this.carteira.Text = "Cadastrar Carteira";
            this.carteira.UseVisualStyleBackColor = false;
            this.carteira.Click += new System.EventHandler(this.button3_Click);
            // 
            // grafico_entrada
            // 
            this.grafico_entrada.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.grafico_entrada.ChartAreas.Add(chartArea1);
            this.grafico_entrada.Cursor = System.Windows.Forms.Cursors.No;
            this.grafico_entrada.Location = new System.Drawing.Point(-1, -1);
            this.grafico_entrada.Name = "grafico_entrada";
            this.grafico_entrada.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.grafico_entrada.Size = new System.Drawing.Size(848, 432);
            this.grafico_entrada.TabIndex = 5;
            this.grafico_entrada.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.entrada_saida);
            this.tabControl1.Controls.Add(this.lucro_tendencia);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 454);
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
            this.entrada_saida.Size = new System.Drawing.Size(840, 428);
            this.entrada_saida.TabIndex = 0;
            this.entrada_saida.Text = "Entradas x Saídas";
            // 
            // lucro_tendencia
            // 
            this.lucro_tendencia.Controls.Add(this.grafico_lucro);
            this.lucro_tendencia.Location = new System.Drawing.Point(4, 22);
            this.lucro_tendencia.Name = "lucro_tendencia";
            this.lucro_tendencia.Padding = new System.Windows.Forms.Padding(3);
            this.lucro_tendencia.Size = new System.Drawing.Size(840, 428);
            this.lucro_tendencia.TabIndex = 1;
            this.lucro_tendencia.Text = "Lucro x Tendência";
            this.lucro_tendencia.UseVisualStyleBackColor = true;
            // 
            // grafico_lucro
            // 
            this.grafico_lucro.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.grafico_lucro.ChartAreas.Add(chartArea2);
            this.grafico_lucro.Cursor = System.Windows.Forms.Cursors.No;
            this.grafico_lucro.Location = new System.Drawing.Point(-1, -1);
            this.grafico_lucro.Name = "grafico_lucro";
            this.grafico_lucro.Size = new System.Drawing.Size(848, 431);
            this.grafico_lucro.TabIndex = 6;
            this.grafico_lucro.Text = "chart1";
            // 
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(882, 506);
            this.Controls.Add(this.carteira);
            this.Controls.Add(this.remetentes);
            this.Controls.Add(this.registros);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSystem";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico_entrada)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.entrada_saida.ResumeLayout(false);
            this.lucro_tendencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafico_lucro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registros;
        private System.Windows.Forms.Button remetentes;
        private System.Windows.Forms.Button carteira;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_entrada;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage entrada_saida;
        private System.Windows.Forms.TabPage lucro_tendencia;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_lucro;
    }
}
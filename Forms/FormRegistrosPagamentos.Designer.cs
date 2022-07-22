
namespace AssistentePessoal
{
    partial class FormRegistrosPagamentos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrosPagamentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.label_selecionado = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_movimentation = new System.Windows.Forms.ComboBox();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.tx_pesquisa = new System.Windows.Forms.TextBox();
            this.Iniciar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editar_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.remover_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exportar
            // 
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportar.Image")));
            this.btn_exportar.Location = new System.Drawing.Point(729, 7);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(58, 28);
            this.btn_exportar.TabIndex = 24;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            this.btn_exportar.MouseHover += new System.EventHandler(this.btn_exportar_MouseHover);
            // 
            // label_selecionado
            // 
            this.label_selecionado.AutoSize = true;
            this.label_selecionado.Location = new System.Drawing.Point(33, 473);
            this.label_selecionado.Name = "label_selecionado";
            this.label_selecionado.Size = new System.Drawing.Size(123, 13);
            this.label_selecionado.TabIndex = 23;
            this.label_selecionado.Text = "Saldo Selecionado: XXX";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(33, 450);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(88, 13);
            this.label_total.TabIndex = 22;
            this.label_total.Text = "Saldo Total: XXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Período:";
            // 
            // cb_date
            // 
            this.cb_date.AutoCompleteCustomSource.AddRange(new string[] {
            "2025",
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cb_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Location = new System.Drawing.Point(158, 14);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(138, 21);
            this.cb_date.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisa:";
            // 
            // cb_movimentation
            // 
            this.cb_movimentation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_movimentation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_movimentation.FormattingEnabled = true;
            this.cb_movimentation.Location = new System.Drawing.Point(158, 41);
            this.cb_movimentation.Name = "cb_movimentation";
            this.cb_movimentation.Size = new System.Drawing.Size(138, 21);
            this.cb_movimentation.TabIndex = 17;
            // 
            // cb_filtro
            // 
            this.cb_filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Location = new System.Drawing.Point(430, 41);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(138, 21);
            this.cb_filtro.TabIndex = 16;
            // 
            // tx_pesquisa
            // 
            this.tx_pesquisa.Location = new System.Drawing.Point(574, 42);
            this.tx_pesquisa.Name = "tx_pesquisa";
            this.tx_pesquisa.Size = new System.Drawing.Size(213, 20);
            this.tx_pesquisa.TabIndex = 15;
            // 
            // Iniciar
            // 
            this.Iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Iniciar.Location = new System.Drawing.Point(645, 444);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(142, 42);
            this.Iniciar.TabIndex = 14;
            this.Iniciar.Text = "Registrar Movimentação";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click_1);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ContextMenuStrip = this.contextMenuStrip;
            this.grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grid.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.grid.Location = new System.Drawing.Point(36, 69);
            this.grid.Name = "grid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(751, 369);
            this.grid.TabIndex = 13;
            this.grid.VirtualMode = true;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            this.grid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.Azure;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editar_menu_item,
            this.remover_menu_item});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(97, 48);
            // 
            // editar_menu_item
            // 
            this.editar_menu_item.Name = "editar_menu_item";
            this.editar_menu_item.Size = new System.Drawing.Size(96, 22);
            this.editar_menu_item.Text = "Editar";
            this.editar_menu_item.Click += new System.EventHandler(this.editar_menu_item_Click);
            // 
            // remover_menu_item
            // 
            this.remover_menu_item.Name = "remover_menu_item";
            this.remover_menu_item.Size = new System.Drawing.Size(96, 22);
            this.remover_menu_item.Text = "Remover";
            this.remover_menu_item.Click += new System.EventHandler(this.remover_menu_item_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormRegistrosPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 498);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.label_selecionado);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_movimentation);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.tx_pesquisa);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistrosPagamentos";
            this.Text = "Contas à Pagar";
            this.Load += new System.EventHandler(this.FormRegistrosPagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Label label_selecionado;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_movimentation;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.TextBox tx_pesquisa;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editar_menu_item;
        private System.Windows.Forms.ToolStripMenuItem remover_menu_item;
    }
}
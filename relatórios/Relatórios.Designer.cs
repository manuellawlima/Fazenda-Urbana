namespace FazendaUrbana
{
    partial class Relatórios
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
            dtpDataInicio = new DateTimePicker();
            dtpDataFim = new DateTimePicker();
            btnGerarRelatorio = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDataFim = new Label();
            lblDataInicio = new Label();
            lblMediaVendas = new Label();
            lblTotalVendas = new Label();
            label1 = new Label();
            panelPrincipal = new Panel();
            btnVoltar = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDataInicio.CalendarForeColor = Color.Green;
            dtpDataInicio.CalendarMonthBackground = Color.Green;
            dtpDataInicio.CalendarTitleBackColor = Color.White;
            dtpDataInicio.CalendarTitleForeColor = Color.AntiqueWhite;
            dtpDataInicio.CalendarTrailingForeColor = Color.White;
            dtpDataInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDataInicio.Location = new Point(3, 159);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(484, 30);
            dtpDataInicio.TabIndex = 0;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDataFim.CalendarForeColor = Color.Green;
            dtpDataFim.CalendarMonthBackground = Color.Green;
            dtpDataFim.CalendarTitleBackColor = Color.White;
            dtpDataFim.CalendarTitleForeColor = Color.AntiqueWhite;
            dtpDataFim.CalendarTrailingForeColor = Color.White;
            dtpDataFim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDataFim.Location = new Point(493, 159);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(484, 30);
            dtpDataFim.TabIndex = 1;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.BackColor = Color.Green;
            btnGerarRelatorio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarRelatorio.ForeColor = Color.White;
            btnGerarRelatorio.Location = new Point(582, 527);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(206, 56);
            btnGerarRelatorio.TabIndex = 2;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = false;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblDataFim, 1, 0);
            tableLayoutPanel1.Controls.Add(dtpDataFim, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDataInicio, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpDataInicio, 0, 1);
            tableLayoutPanel1.Location = new Point(198, 198);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(980, 312);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // lblDataFim
            // 
            lblDataFim.Anchor = AnchorStyles.None;
            lblDataFim.AutoSize = true;
            lblDataFim.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFim.ForeColor = Color.GreenYellow;
            lblDataFim.Location = new Point(638, 51);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(193, 54);
            lblDataFim.TabIndex = 7;
            lblDataFim.Text = "Data Fim";
            // 
            // lblDataInicio
            // 
            lblDataInicio.Anchor = AnchorStyles.None;
            lblDataInicio.AutoSize = true;
            lblDataInicio.BackColor = Color.Green;
            lblDataInicio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataInicio.ForeColor = Color.GreenYellow;
            lblDataInicio.Location = new Point(103, 51);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(284, 54);
            lblDataInicio.TabIndex = 6;
            lblDataInicio.Text = "Data de Início";
            // 
            // lblMediaVendas
            // 
            lblMediaVendas.AutoSize = true;
            lblMediaVendas.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMediaVendas.ForeColor = Color.White;
            lblMediaVendas.Location = new Point(691, 133);
            lblMediaVendas.Name = "lblMediaVendas";
            lblMediaVendas.Size = new Size(400, 62);
            lblMediaVendas.TabIndex = 9;
            lblMediaVendas.Text = "Média de Vendas";
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.BackColor = Color.Green;
            lblTotalVendas.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVendas.ForeColor = Color.White;
            lblTotalVendas.Location = new Point(42, 133);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(372, 62);
            lblTotalVendas.TabIndex = 8;
            lblTotalVendas.Text = "Total de Vendas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(582, 6);
            label1.Name = "label1";
            label1.Size = new Size(181, 46);
            label1.TabIndex = 10;
            label1.Text = "Relatórios";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(btnVoltar);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(btnGerarRelatorio);
            panelPrincipal.Controls.Add(tableLayoutPanel1);
            panelPrincipal.Controls.Add(lblMediaVendas);
            panelPrincipal.Controls.Add(lblTotalVendas);
            panelPrincipal.Location = new Point(3, 3);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1333, 737);
            panelPrincipal.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(22, 19);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(228, 64);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar para tela inicial";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // Relatórios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1338, 740);
            Controls.Add(panelPrincipal);
            Name = "Relatórios";
            Text = "Relatórios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDataInicio;
        private DateTimePicker dtpDataFim;
        private Button btnGerarRelatorio;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDataInicio;
        private Label lblDataFim;
        private Label lblTotalVendas;
        private Label lblMediaVendas;
        private Label label1;
        private Panel panelPrincipal;
        private Button btnVoltar;
    }
}
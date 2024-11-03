namespace FazendaUrbana
{
    partial class TelaInicial
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
            btnProducao = new Button();
            btnFornecedores = new Button();
            btnVendas = new Button();
            btnRelatorios = new Button();
            lblDesconectar = new Label();
            label1 = new Label();
            panelPrincipal = new Panel();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnProducao
            // 
            btnProducao.BackColor = Color.DarkGreen;
            btnProducao.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducao.ForeColor = Color.White;
            btnProducao.Location = new Point(358, 198);
            btnProducao.Name = "btnProducao";
            btnProducao.Size = new Size(656, 92);
            btnProducao.TabIndex = 0;
            btnProducao.Text = "Produção";
            btnProducao.UseVisualStyleBackColor = false;
            btnProducao.Click += btnProducao_Click;
            // 
            // btnFornecedores
            // 
            btnFornecedores.BackColor = Color.DarkGreen;
            btnFornecedores.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFornecedores.ForeColor = Color.White;
            btnFornecedores.Location = new Point(358, 296);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Size = new Size(656, 92);
            btnFornecedores.TabIndex = 1;
            btnFornecedores.Text = "Fornecedores";
            btnFornecedores.UseVisualStyleBackColor = false;
            btnFornecedores.Click += btnFornecedores_Click;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.DarkGreen;
            btnVendas.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendas.ForeColor = Color.White;
            btnVendas.Location = new Point(358, 394);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(656, 92);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.DarkGreen;
            btnRelatorios.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Location = new Point(358, 492);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(656, 92);
            btnRelatorios.TabIndex = 3;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // lblDesconectar
            // 
            lblDesconectar.AutoSize = true;
            lblDesconectar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesconectar.ForeColor = Color.GreenYellow;
            lblDesconectar.Location = new Point(520, 605);
            lblDesconectar.Name = "lblDesconectar";
            lblDesconectar.Size = new Size(335, 25);
            lblDesconectar.TabIndex = 4;
            lblDesconectar.Text = "Quer desconectar a conta? Clique aqui.";
            lblDesconectar.Click += lblDesconectar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(282, 114);
            label1.Name = "label1";
            label1.Size = new Size(798, 46);
            label1.TabIndex = 5;
            label1.Text = "Bem-vindo ao sistema de controle da GMT Farm!";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(lblDesconectar);
            panelPrincipal.Controls.Add(btnProducao);
            panelPrincipal.Controls.Add(btnRelatorios);
            panelPrincipal.Controls.Add(btnFornecedores);
            panelPrincipal.Controls.Add(btnVendas);
            panelPrincipal.Location = new Point(1, 1);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1344, 710);
            panelPrincipal.TabIndex = 6;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1343, 715);
            Controls.Add(panelPrincipal);
            Name = "TelaInicial";
            Text = "Tela Inicial";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProducao;
        private Button btnFornecedores;
        private Button btnVendas;
        private Button btnRelatorios;
        private Label lblDesconectar;
        private Label label1;
        private Panel panelPrincipal;
    }
}
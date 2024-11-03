namespace FazendaUrbana
{
    partial class Vendas
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
            DGV_Estoque = new DataGridView();
            DGV_Entregas = new DataGridView();
            btnExcluirEstoque = new Button();
            btnAdicionarEstoque = new Button();
            btnAdicionarEntrega = new Button();
            btnExcluirEntrega = new Button();
            txtPesquisaEstoque = new TextBox();
            txtPesquisaEntrega = new TextBox();
            btnPesquisarEstoque = new Button();
            btnPesquisarEntrega = new Button();
            lblEstoque = new Label();
            lblEntregas = new Label();
            panelPrincipal = new Label();
            panelVendas = new Panel();
            btnEditarEntrega = new Button();
            btnEditarEstoque = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Estoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Entregas).BeginInit();
            panelVendas.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_Estoque
            // 
            DGV_Estoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Estoque.GridColor = Color.FromArgb(192, 255, 192);
            DGV_Estoque.Location = new Point(12, 206);
            DGV_Estoque.Name = "DGV_Estoque";
            DGV_Estoque.RowHeadersWidth = 51;
            DGV_Estoque.Size = new Size(649, 382);
            DGV_Estoque.TabIndex = 0;
            // 
            // DGV_Entregas
            // 
            DGV_Entregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Entregas.GridColor = Color.FromArgb(192, 255, 192);
            DGV_Entregas.Location = new Point(678, 208);
            DGV_Entregas.Name = "DGV_Entregas";
            DGV_Entregas.RowHeadersWidth = 51;
            DGV_Entregas.Size = new Size(649, 382);
            DGV_Entregas.TabIndex = 1;
            // 
            // btnExcluirEstoque
            // 
            btnExcluirEstoque.BackColor = Color.DarkGreen;
            btnExcluirEstoque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirEstoque.ForeColor = Color.White;
            btnExcluirEstoque.Location = new Point(443, 155);
            btnExcluirEstoque.Name = "btnExcluirEstoque";
            btnExcluirEstoque.Size = new Size(204, 47);
            btnExcluirEstoque.TabIndex = 3;
            btnExcluirEstoque.Text = "Excluir Estoque";
            btnExcluirEstoque.UseVisualStyleBackColor = false;
            btnExcluirEstoque.Click += btnExcluirEstoque_Click;
            // 
            // btnAdicionarEstoque
            // 
            btnAdicionarEstoque.BackColor = Color.DarkGreen;
            btnAdicionarEstoque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarEstoque.ForeColor = Color.White;
            btnAdicionarEstoque.Location = new Point(23, 154);
            btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            btnAdicionarEstoque.Size = new Size(204, 47);
            btnAdicionarEstoque.TabIndex = 4;
            btnAdicionarEstoque.Text = "Adicionar Estoque";
            btnAdicionarEstoque.UseVisualStyleBackColor = false;
            btnAdicionarEstoque.Click += btnAdicionarEstoque_Click;
            // 
            // btnAdicionarEntrega
            // 
            btnAdicionarEntrega.BackColor = Color.DarkGreen;
            btnAdicionarEntrega.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarEntrega.ForeColor = Color.White;
            btnAdicionarEntrega.Location = new Point(683, 155);
            btnAdicionarEntrega.Name = "btnAdicionarEntrega";
            btnAdicionarEntrega.Size = new Size(214, 47);
            btnAdicionarEntrega.TabIndex = 5;
            btnAdicionarEntrega.Text = "Adicionar Entrega";
            btnAdicionarEntrega.UseVisualStyleBackColor = false;
            btnAdicionarEntrega.Click += btnAdicionarEntrega_Click;
            // 
            // btnExcluirEntrega
            // 
            btnExcluirEntrega.BackColor = Color.DarkGreen;
            btnExcluirEntrega.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirEntrega.ForeColor = Color.White;
            btnExcluirEntrega.Location = new Point(1123, 155);
            btnExcluirEntrega.Name = "btnExcluirEntrega";
            btnExcluirEntrega.Size = new Size(204, 47);
            btnExcluirEntrega.TabIndex = 6;
            btnExcluirEntrega.Text = "Excluir Entrega";
            btnExcluirEntrega.UseVisualStyleBackColor = false;
            btnExcluirEntrega.Click += btnExcluirEntrega_Click;
            // 
            // txtPesquisaEstoque
            // 
            txtPesquisaEstoque.Location = new Point(167, 596);
            txtPesquisaEstoque.Name = "txtPesquisaEstoque";
            txtPesquisaEstoque.Size = new Size(331, 27);
            txtPesquisaEstoque.TabIndex = 9;
            txtPesquisaEstoque.Text = "Procure estoque...";
            // 
            // txtPesquisaEntrega
            // 
            txtPesquisaEntrega.Location = new Point(861, 596);
            txtPesquisaEntrega.Name = "txtPesquisaEntrega";
            txtPesquisaEntrega.Size = new Size(331, 27);
            txtPesquisaEntrega.TabIndex = 10;
            txtPesquisaEntrega.Text = "Pesquise entrega...";
            // 
            // btnPesquisarEstoque
            // 
            btnPesquisarEstoque.BackColor = Color.DarkGreen;
            btnPesquisarEstoque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarEstoque.ForeColor = Color.White;
            btnPesquisarEstoque.Location = new Point(250, 629);
            btnPesquisarEstoque.Name = "btnPesquisarEstoque";
            btnPesquisarEstoque.Size = new Size(169, 53);
            btnPesquisarEstoque.TabIndex = 12;
            btnPesquisarEstoque.Text = "Pesquisar";
            btnPesquisarEstoque.UseVisualStyleBackColor = false;
            btnPesquisarEstoque.Click += btnPesquisarEstoque_Click;
            // 
            // btnPesquisarEntrega
            // 
            btnPesquisarEntrega.BackColor = Color.DarkGreen;
            btnPesquisarEntrega.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarEntrega.ForeColor = Color.White;
            btnPesquisarEntrega.Location = new Point(944, 629);
            btnPesquisarEntrega.Name = "btnPesquisarEntrega";
            btnPesquisarEntrega.Size = new Size(169, 53);
            btnPesquisarEntrega.TabIndex = 13;
            btnPesquisarEntrega.Text = "Pesquisar";
            btnPesquisarEntrega.UseVisualStyleBackColor = false;
            btnPesquisarEntrega.Click += btnPesquisarEntrega_Click;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstoque.ForeColor = Color.White;
            lblEstoque.Location = new Point(289, 111);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(87, 28);
            lblEstoque.TabIndex = 14;
            lblEstoque.Text = "Estoque";
            // 
            // lblEntregas
            // 
            lblEntregas.AutoSize = true;
            lblEntregas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntregas.ForeColor = Color.White;
            lblEntregas.Location = new Point(944, 111);
            lblEntregas.Name = "lblEntregas";
            lblEntregas.Size = new Size(94, 28);
            lblEntregas.TabIndex = 15;
            lblEntregas.Text = "Entregas";
            // 
            // panelPrincipal
            // 
            panelPrincipal.AutoSize = true;
            panelPrincipal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelPrincipal.ForeColor = Color.White;
            panelPrincipal.Location = new Point(601, 4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(134, 46);
            panelPrincipal.TabIndex = 16;
            panelPrincipal.Text = "Vendas";
            // 
            // panelVendas
            // 
            panelVendas.Controls.Add(btnEditarEntrega);
            panelVendas.Controls.Add(btnEditarEstoque);
            panelVendas.Controls.Add(btnVoltar);
            panelVendas.Controls.Add(panelPrincipal);
            panelVendas.Controls.Add(btnPesquisarEntrega);
            panelVendas.Controls.Add(lblEntregas);
            panelVendas.Controls.Add(txtPesquisaEntrega);
            panelVendas.Controls.Add(lblEstoque);
            panelVendas.Controls.Add(DGV_Entregas);
            panelVendas.Controls.Add(btnExcluirEntrega);
            panelVendas.Controls.Add(btnAdicionarEstoque);
            panelVendas.Controls.Add(btnAdicionarEntrega);
            panelVendas.Controls.Add(btnPesquisarEstoque);
            panelVendas.Controls.Add(btnExcluirEstoque);
            panelVendas.Controls.Add(DGV_Estoque);
            panelVendas.Controls.Add(txtPesquisaEstoque);
            panelVendas.Location = new Point(0, 5);
            panelVendas.Name = "panelVendas";
            panelVendas.Size = new Size(1350, 738);
            panelVendas.TabIndex = 17;
            // 
            // btnEditarEntrega
            // 
            btnEditarEntrega.BackColor = Color.DarkGreen;
            btnEditarEntrega.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEntrega.ForeColor = Color.White;
            btnEditarEntrega.Location = new Point(903, 158);
            btnEditarEntrega.Name = "btnEditarEntrega";
            btnEditarEntrega.Size = new Size(214, 44);
            btnEditarEntrega.TabIndex = 19;
            btnEditarEntrega.Text = "Editar Entrega";
            btnEditarEntrega.UseVisualStyleBackColor = false;
            btnEditarEntrega.Click += btnEditarEntrega_Click;
            // 
            // btnEditarEstoque
            // 
            btnEditarEstoque.BackColor = Color.DarkGreen;
            btnEditarEstoque.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEstoque.ForeColor = Color.White;
            btnEditarEstoque.Location = new Point(233, 154);
            btnEditarEstoque.Name = "btnEditarEstoque";
            btnEditarEstoque.Size = new Size(204, 46);
            btnEditarEstoque.TabIndex = 18;
            btnEditarEstoque.Text = "Editar Estoque";
            btnEditarEstoque.UseVisualStyleBackColor = false;
            btnEditarEstoque.Click += btnEditarEstoque_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(40, 21);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(238, 55);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar para tela inicial";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1378, 740);
            Controls.Add(panelVendas);
            Name = "Vendas";
            Text = "Vendas";
            Click += Vendas_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Estoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Entregas).EndInit();
            panelVendas.ResumeLayout(false);
            panelVendas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_Estoque;
        private DataGridView DGV_Entregas;
        private Button btnExcluirEstoque;
        private Button btnAdicionarEstoque;
        private Button btnAdicionarEntrega;
        private Button btnExcluirEntrega;
        private TextBox txtPesquisaEstoque;
        private TextBox txtPesquisaEntrega;
        private Button btnPesquisarEstoque;
        private Button btnPesquisarEntrega;
        private Label lblEstoque;
        private Label lblEntregas;
        private Label panelPrincipal;
        private Panel panelVendas;
        private Button btnVoltar;
        private Button btnEditarEstoque;
        private Button btnEditarEntrega;
    }
}
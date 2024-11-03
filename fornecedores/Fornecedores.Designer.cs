namespace FazendaUrbana
{
    partial class Fornecedores
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
            dgvPessoasFisicas = new DataGridView();
            dgvPessoasJuridicas = new DataGridView();
            btnAdicionarPessoaFisica = new Button();
            btnEditarPessoaFisica = new Button();
            btnExcluirPessoaFisica = new Button();
            btnAdicionarPessoaJuridica = new Button();
            btnEditarPessoaJuridica = new Button();
            btnExcluirPessoaJuridica = new Button();
            txtPessoaFisica = new TextBox();
            txtPessoaJuridica = new TextBox();
            btnPesquisarPessoaFisica = new Button();
            btnPesquisarPessoaJurídica = new Button();
            lblPessoaFisica = new Label();
            label2 = new Label();
            label1 = new Label();
            panelPrincipal = new Panel();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPessoasFisicas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPessoasJuridicas).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPessoasFisicas
            // 
            dgvPessoasFisicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPessoasFisicas.Location = new Point(36, 208);
            dgvPessoasFisicas.Name = "dgvPessoasFisicas";
            dgvPessoasFisicas.RowHeadersWidth = 51;
            dgvPessoasFisicas.Size = new Size(617, 382);
            dgvPessoasFisicas.TabIndex = 0;
            // 
            // dgvPessoasJuridicas
            // 
            dgvPessoasJuridicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPessoasJuridicas.Location = new Point(688, 208);
            dgvPessoasJuridicas.Name = "dgvPessoasJuridicas";
            dgvPessoasJuridicas.RowHeadersWidth = 51;
            dgvPessoasJuridicas.Size = new Size(624, 382);
            dgvPessoasJuridicas.TabIndex = 1;
            // 
            // btnAdicionarPessoaFisica
            // 
            btnAdicionarPessoaFisica.BackColor = Color.DarkGreen;
            btnAdicionarPessoaFisica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarPessoaFisica.ForeColor = Color.White;
            btnAdicionarPessoaFisica.Location = new Point(36, 173);
            btnAdicionarPessoaFisica.Name = "btnAdicionarPessoaFisica";
            btnAdicionarPessoaFisica.Size = new Size(204, 29);
            btnAdicionarPessoaFisica.TabIndex = 2;
            btnAdicionarPessoaFisica.Text = "Adicionar Pessoa Física";
            btnAdicionarPessoaFisica.UseVisualStyleBackColor = false;
            btnAdicionarPessoaFisica.Click += btnAdicionarPessoaFisica_Click;
            // 
            // btnEditarPessoaFisica
            // 
            btnEditarPessoaFisica.BackColor = Color.DarkGreen;
            btnEditarPessoaFisica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarPessoaFisica.ForeColor = Color.White;
            btnEditarPessoaFisica.Location = new Point(246, 173);
            btnEditarPessoaFisica.Name = "btnEditarPessoaFisica";
            btnEditarPessoaFisica.Size = new Size(197, 29);
            btnEditarPessoaFisica.TabIndex = 3;
            btnEditarPessoaFisica.Text = "Editar Pessoa Física";
            btnEditarPessoaFisica.UseVisualStyleBackColor = false;
            btnEditarPessoaFisica.Click += btnEditarPessoaFisica_Click;
            // 
            // btnExcluirPessoaFisica
            // 
            btnExcluirPessoaFisica.BackColor = Color.DarkGreen;
            btnExcluirPessoaFisica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirPessoaFisica.ForeColor = Color.White;
            btnExcluirPessoaFisica.Location = new Point(449, 173);
            btnExcluirPessoaFisica.Name = "btnExcluirPessoaFisica";
            btnExcluirPessoaFisica.Size = new Size(204, 29);
            btnExcluirPessoaFisica.TabIndex = 4;
            btnExcluirPessoaFisica.Text = "Excluir Pessoa Física";
            btnExcluirPessoaFisica.UseVisualStyleBackColor = false;
            btnExcluirPessoaFisica.Click += btnExcluirPessoaFisica_Click;
            // 
            // btnAdicionarPessoaJuridica
            // 
            btnAdicionarPessoaJuridica.BackColor = Color.DarkGreen;
            btnAdicionarPessoaJuridica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarPessoaJuridica.ForeColor = Color.White;
            btnAdicionarPessoaJuridica.Location = new Point(688, 173);
            btnAdicionarPessoaJuridica.Name = "btnAdicionarPessoaJuridica";
            btnAdicionarPessoaJuridica.Size = new Size(204, 29);
            btnAdicionarPessoaJuridica.TabIndex = 5;
            btnAdicionarPessoaJuridica.Text = "Adicionar Pessoa Jurídica";
            btnAdicionarPessoaJuridica.UseVisualStyleBackColor = false;
            btnAdicionarPessoaJuridica.MouseCaptureChanged += btnAdicionarPessoaJuridica_Click;
            // 
            // btnEditarPessoaJuridica
            // 
            btnEditarPessoaJuridica.BackColor = Color.DarkGreen;
            btnEditarPessoaJuridica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarPessoaJuridica.ForeColor = Color.White;
            btnEditarPessoaJuridica.Location = new Point(898, 173);
            btnEditarPessoaJuridica.Name = "btnEditarPessoaJuridica";
            btnEditarPessoaJuridica.Size = new Size(204, 29);
            btnEditarPessoaJuridica.TabIndex = 6;
            btnEditarPessoaJuridica.Text = "Editar Pessoa Jurídica";
            btnEditarPessoaJuridica.UseVisualStyleBackColor = false;
            btnEditarPessoaJuridica.MouseCaptureChanged += btnEditarPessoaJuridica_Click;
            // 
            // btnExcluirPessoaJuridica
            // 
            btnExcluirPessoaJuridica.BackColor = Color.DarkGreen;
            btnExcluirPessoaJuridica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirPessoaJuridica.ForeColor = Color.White;
            btnExcluirPessoaJuridica.Location = new Point(1108, 173);
            btnExcluirPessoaJuridica.Name = "btnExcluirPessoaJuridica";
            btnExcluirPessoaJuridica.Size = new Size(204, 29);
            btnExcluirPessoaJuridica.TabIndex = 7;
            btnExcluirPessoaJuridica.Text = "Excluir Pessoa Jurídica";
            btnExcluirPessoaJuridica.UseVisualStyleBackColor = false;
            btnExcluirPessoaJuridica.Click += btnExcluirPessoaJuridica_Click;
            // 
            // txtPessoaFisica
            // 
            txtPessoaFisica.BackColor = Color.DarkSeaGreen;
            txtPessoaFisica.Location = new Point(36, 596);
            txtPessoaFisica.Name = "txtPessoaFisica";
            txtPessoaFisica.Size = new Size(617, 27);
            txtPessoaFisica.TabIndex = 8;
            // 
            // txtPessoaJuridica
            // 
            txtPessoaJuridica.BackColor = Color.DarkSeaGreen;
            txtPessoaJuridica.Location = new Point(688, 596);
            txtPessoaJuridica.Name = "txtPessoaJuridica";
            txtPessoaJuridica.Size = new Size(624, 27);
            txtPessoaJuridica.TabIndex = 9;
            // 
            // btnPesquisarPessoaFisica
            // 
            btnPesquisarPessoaFisica.BackColor = Color.DarkGreen;
            btnPesquisarPessoaFisica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarPessoaFisica.ForeColor = Color.White;
            btnPesquisarPessoaFisica.Location = new Point(213, 629);
            btnPesquisarPessoaFisica.Name = "btnPesquisarPessoaFisica";
            btnPesquisarPessoaFisica.Size = new Size(236, 29);
            btnPesquisarPessoaFisica.TabIndex = 10;
            btnPesquisarPessoaFisica.Text = "Pesquisar Pessoa Física";
            btnPesquisarPessoaFisica.UseVisualStyleBackColor = false;
            btnPesquisarPessoaFisica.Click += btnPesquisarPessoaFisica_Click;
            // 
            // btnPesquisarPessoaJurídica
            // 
            btnPesquisarPessoaJurídica.BackColor = Color.DarkGreen;
            btnPesquisarPessoaJurídica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarPessoaJurídica.ForeColor = Color.White;
            btnPesquisarPessoaJurídica.Location = new Point(887, 629);
            btnPesquisarPessoaJurídica.Name = "btnPesquisarPessoaJurídica";
            btnPesquisarPessoaJurídica.Size = new Size(235, 29);
            btnPesquisarPessoaJurídica.TabIndex = 11;
            btnPesquisarPessoaJurídica.Text = "Pesquisar Pessoa Jurídica";
            btnPesquisarPessoaJurídica.UseVisualStyleBackColor = false;
            btnPesquisarPessoaJurídica.Click += btnPesquisarPessoaJuridica_Click;
            // 
            // lblPessoaFisica
            // 
            lblPessoaFisica.AutoSize = true;
            lblPessoaFisica.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPessoaFisica.ForeColor = Color.White;
            lblPessoaFisica.Location = new Point(36, 142);
            lblPessoaFisica.Name = "lblPessoaFisica";
            lblPessoaFisica.Size = new Size(265, 28);
            lblPessoaFisica.TabIndex = 12;
            lblPessoaFisica.Text = "Fornecedores Pessoa Física";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(688, 142);
            label2.Name = "label2";
            label2.Size = new Size(287, 28);
            label2.TabIndex = 13;
            label2.Text = "Fornecedores Pessoa Jurídica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(549, 12);
            label1.Name = "label1";
            label1.Size = new Size(235, 46);
            label1.TabIndex = 14;
            label1.Text = "Fornecedores";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(btnVoltar);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(dgvPessoasJuridicas);
            panelPrincipal.Controls.Add(btnPesquisarPessoaJurídica);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(txtPessoaJuridica);
            panelPrincipal.Controls.Add(lblPessoaFisica);
            panelPrincipal.Controls.Add(btnExcluirPessoaJuridica);
            panelPrincipal.Controls.Add(btnAdicionarPessoaFisica);
            panelPrincipal.Controls.Add(btnEditarPessoaJuridica);
            panelPrincipal.Controls.Add(btnPesquisarPessoaFisica);
            panelPrincipal.Controls.Add(btnAdicionarPessoaJuridica);
            panelPrincipal.Controls.Add(btnEditarPessoaFisica);
            panelPrincipal.Controls.Add(btnExcluirPessoaFisica);
            panelPrincipal.Controls.Add(txtPessoaFisica);
            panelPrincipal.Controls.Add(dgvPessoasFisicas);
            panelPrincipal.Location = new Point(-2, -3);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1334, 749);
            panelPrincipal.TabIndex = 15;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(35, 33);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(235, 68);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar para tela inicial";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // Fornecedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1334, 741);
            Controls.Add(panelPrincipal);
            Name = "Fornecedores";
            Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)dgvPessoasFisicas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPessoasJuridicas).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPessoasFisicas;
        private DataGridView dgvPessoasJuridicas;
        private Button btnAdicionarPessoaFisica;
        private Button btnEditarPessoaFisica;
        private Button btnExcluirPessoaFisica;
        private Button btnAdicionarPessoaJuridica;
        private Button btnEditarPessoaJuridica;
        private Button btnExcluirPessoaJuridica;
        private TextBox txtPessoaFisica;
        private TextBox txtPessoaJuridica;
        private Button btnPesquisarPessoaFisica;
        private Button btnPesquisarPessoaJurídica;
        private Label lblPessoaFisica;
        private Label label2;
        private Label label1;
        private Panel panelPrincipal;
        private Button btnVoltar;
    }
}
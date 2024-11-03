namespace FazendaUrbana
{
    partial class Producao
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
            dgvProducao = new DataGridView();
            dgvIrrigacao = new DataGridView();
            dgvColheita = new DataGridView();
            dgvFertilizacao = new DataGridView();
            btnAdicionarProducao = new Button();
            btnEditarProducao = new Button();
            btnExcluirProducao = new Button();
            btnAdicionarColheita = new Button();
            btnEditarColheita = new Button();
            btnExcluirColheita = new Button();
            btnAdicionarIrrigacao = new Button();
            btnEditarIrrigacao = new Button();
            btnExcluirIrrigacao = new Button();
            btnAdicionarFertilizacao = new Button();
            btnEditarFertilizacao = new Button();
            btnExcluirFertilizacao = new Button();
            lblProducao = new Label();
            lblColheita = new Label();
            lblIrrigacao = new Label();
            lblFertlizacao = new Label();
            panelPrincipal = new Panel();
            label1 = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIrrigacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvColheita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFertilizacao).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducao
            // 
            dgvProducao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducao.Location = new Point(84, 113);
            dgvProducao.Name = "dgvProducao";
            dgvProducao.RowHeadersWidth = 51;
            dgvProducao.Size = new Size(570, 217);
            dgvProducao.TabIndex = 0;
            // 
            // dgvIrrigacao
            // 
            dgvIrrigacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIrrigacao.Location = new Point(84, 422);
            dgvIrrigacao.Name = "dgvIrrigacao";
            dgvIrrigacao.RowHeadersWidth = 51;
            dgvIrrigacao.Size = new Size(570, 217);
            dgvIrrigacao.TabIndex = 1;
            // 
            // dgvColheita
            // 
            dgvColheita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColheita.Location = new Point(706, 113);
            dgvColheita.Name = "dgvColheita";
            dgvColheita.RowHeadersWidth = 51;
            dgvColheita.Size = new Size(570, 217);
            dgvColheita.TabIndex = 2;
            // 
            // dgvFertilizacao
            // 
            dgvFertilizacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFertilizacao.Location = new Point(706, 422);
            dgvFertilizacao.Name = "dgvFertilizacao";
            dgvFertilizacao.RowHeadersWidth = 51;
            dgvFertilizacao.Size = new Size(570, 217);
            dgvFertilizacao.TabIndex = 3;
            // 
            // btnAdicionarProducao
            // 
            btnAdicionarProducao.BackColor = Color.DarkGreen;
            btnAdicionarProducao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarProducao.ForeColor = Color.White;
            btnAdicionarProducao.Location = new Point(203, 336);
            btnAdicionarProducao.Name = "btnAdicionarProducao";
            btnAdicionarProducao.Size = new Size(94, 29);
            btnAdicionarProducao.TabIndex = 4;
            btnAdicionarProducao.Text = "Adicionar";
            btnAdicionarProducao.UseVisualStyleBackColor = false;
            btnAdicionarProducao.Click += btnAdicionarProducao_Click;
            // 
            // btnEditarProducao
            // 
            btnEditarProducao.BackColor = Color.DarkGreen;
            btnEditarProducao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarProducao.ForeColor = Color.White;
            btnEditarProducao.Location = new Point(303, 336);
            btnEditarProducao.Name = "btnEditarProducao";
            btnEditarProducao.Size = new Size(94, 29);
            btnEditarProducao.TabIndex = 5;
            btnEditarProducao.Text = "Editar";
            btnEditarProducao.UseVisualStyleBackColor = false;
            btnEditarProducao.Click += btnEditarProducao_Click;
            // 
            // btnExcluirProducao
            // 
            btnExcluirProducao.BackColor = Color.DarkGreen;
            btnExcluirProducao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirProducao.ForeColor = Color.White;
            btnExcluirProducao.Location = new Point(403, 336);
            btnExcluirProducao.Name = "btnExcluirProducao";
            btnExcluirProducao.Size = new Size(94, 29);
            btnExcluirProducao.TabIndex = 6;
            btnExcluirProducao.Text = "Excluir";
            btnExcluirProducao.UseVisualStyleBackColor = false;
            btnExcluirProducao.Click += btnExcluirProducao_Click;
            // 
            // btnAdicionarColheita
            // 
            btnAdicionarColheita.BackColor = Color.DarkGreen;
            btnAdicionarColheita.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarColheita.ForeColor = Color.White;
            btnAdicionarColheita.Location = new Point(828, 336);
            btnAdicionarColheita.Name = "btnAdicionarColheita";
            btnAdicionarColheita.Size = new Size(94, 29);
            btnAdicionarColheita.TabIndex = 7;
            btnAdicionarColheita.Text = "Adicionar";
            btnAdicionarColheita.UseVisualStyleBackColor = false;
            btnAdicionarColheita.Click += btnAdicionarColheita_Click;
            // 
            // btnEditarColheita
            // 
            btnEditarColheita.BackColor = Color.DarkGreen;
            btnEditarColheita.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarColheita.ForeColor = Color.White;
            btnEditarColheita.Location = new Point(928, 336);
            btnEditarColheita.Name = "btnEditarColheita";
            btnEditarColheita.Size = new Size(94, 29);
            btnEditarColheita.TabIndex = 8;
            btnEditarColheita.Text = "Editar";
            btnEditarColheita.UseVisualStyleBackColor = false;
            btnEditarColheita.Click += btnEditarColheita_Click;
            // 
            // btnExcluirColheita
            // 
            btnExcluirColheita.BackColor = Color.DarkGreen;
            btnExcluirColheita.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirColheita.ForeColor = Color.White;
            btnExcluirColheita.Location = new Point(1028, 336);
            btnExcluirColheita.Name = "btnExcluirColheita";
            btnExcluirColheita.Size = new Size(94, 29);
            btnExcluirColheita.TabIndex = 9;
            btnExcluirColheita.Text = "Excluir";
            btnExcluirColheita.UseVisualStyleBackColor = false;
            btnExcluirColheita.Click += btnExcluirColheita_Click;
            // 
            // btnAdicionarIrrigacao
            // 
            btnAdicionarIrrigacao.BackColor = Color.DarkGreen;
            btnAdicionarIrrigacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarIrrigacao.ForeColor = Color.White;
            btnAdicionarIrrigacao.Location = new Point(203, 645);
            btnAdicionarIrrigacao.Name = "btnAdicionarIrrigacao";
            btnAdicionarIrrigacao.Size = new Size(94, 29);
            btnAdicionarIrrigacao.TabIndex = 10;
            btnAdicionarIrrigacao.Text = "Adicionar";
            btnAdicionarIrrigacao.UseVisualStyleBackColor = false;
            btnAdicionarIrrigacao.Click += btnAdicionarIrrigacao_Click;
            // 
            // btnEditarIrrigacao
            // 
            btnEditarIrrigacao.BackColor = Color.DarkGreen;
            btnEditarIrrigacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarIrrigacao.ForeColor = Color.White;
            btnEditarIrrigacao.Location = new Point(303, 645);
            btnEditarIrrigacao.Name = "btnEditarIrrigacao";
            btnEditarIrrigacao.Size = new Size(94, 29);
            btnEditarIrrigacao.TabIndex = 11;
            btnEditarIrrigacao.Text = "Editar";
            btnEditarIrrigacao.UseVisualStyleBackColor = false;
            btnEditarIrrigacao.Click += btnEditarIrrigacao_Click;
            // 
            // btnExcluirIrrigacao
            // 
            btnExcluirIrrigacao.BackColor = Color.DarkGreen;
            btnExcluirIrrigacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirIrrigacao.ForeColor = Color.White;
            btnExcluirIrrigacao.Location = new Point(403, 645);
            btnExcluirIrrigacao.Name = "btnExcluirIrrigacao";
            btnExcluirIrrigacao.Size = new Size(94, 29);
            btnExcluirIrrigacao.TabIndex = 12;
            btnExcluirIrrigacao.Text = "Excluir";
            btnExcluirIrrigacao.UseVisualStyleBackColor = false;
            btnExcluirIrrigacao.Click += btnExcluirIrrigacao_Click;
            // 
            // btnAdicionarFertilizacao
            // 
            btnAdicionarFertilizacao.BackColor = Color.DarkGreen;
            btnAdicionarFertilizacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarFertilizacao.ForeColor = Color.White;
            btnAdicionarFertilizacao.Location = new Point(828, 645);
            btnAdicionarFertilizacao.Name = "btnAdicionarFertilizacao";
            btnAdicionarFertilizacao.Size = new Size(94, 29);
            btnAdicionarFertilizacao.TabIndex = 13;
            btnAdicionarFertilizacao.Text = "Adicionar";
            btnAdicionarFertilizacao.UseVisualStyleBackColor = false;
            btnAdicionarFertilizacao.Click += btnAdicionarFertilizacao_Click;
            // 
            // btnEditarFertilizacao
            // 
            btnEditarFertilizacao.BackColor = Color.DarkGreen;
            btnEditarFertilizacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarFertilizacao.ForeColor = Color.White;
            btnEditarFertilizacao.Location = new Point(928, 645);
            btnEditarFertilizacao.Name = "btnEditarFertilizacao";
            btnEditarFertilizacao.Size = new Size(94, 29);
            btnEditarFertilizacao.TabIndex = 14;
            btnEditarFertilizacao.Text = "Editar";
            btnEditarFertilizacao.UseVisualStyleBackColor = false;
            btnEditarFertilizacao.Click += btnEditarFertilizacao_Click;
            // 
            // btnExcluirFertilizacao
            // 
            btnExcluirFertilizacao.BackColor = Color.DarkGreen;
            btnExcluirFertilizacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirFertilizacao.ForeColor = Color.White;
            btnExcluirFertilizacao.Location = new Point(1028, 645);
            btnExcluirFertilizacao.Name = "btnExcluirFertilizacao";
            btnExcluirFertilizacao.Size = new Size(94, 29);
            btnExcluirFertilizacao.TabIndex = 15;
            btnExcluirFertilizacao.Text = "Excluir";
            btnExcluirFertilizacao.UseVisualStyleBackColor = false;
            btnExcluirFertilizacao.Click += btnExcluirFertilizacao_Click;
            // 
            // lblProducao
            // 
            lblProducao.AutoSize = true;
            lblProducao.BackColor = Color.Green;
            lblProducao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducao.ForeColor = Color.White;
            lblProducao.Location = new Point(84, 82);
            lblProducao.Name = "lblProducao";
            lblProducao.Size = new Size(101, 28);
            lblProducao.TabIndex = 16;
            lblProducao.Text = "Produção";
            // 
            // lblColheita
            // 
            lblColheita.AutoSize = true;
            lblColheita.BackColor = Color.Green;
            lblColheita.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColheita.ForeColor = Color.White;
            lblColheita.Location = new Point(706, 82);
            lblColheita.Name = "lblColheita";
            lblColheita.Size = new Size(90, 28);
            lblColheita.TabIndex = 17;
            lblColheita.Text = "Colheita";
            // 
            // lblIrrigacao
            // 
            lblIrrigacao.AutoSize = true;
            lblIrrigacao.BackColor = Color.Green;
            lblIrrigacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIrrigacao.ForeColor = Color.White;
            lblIrrigacao.Location = new Point(84, 391);
            lblIrrigacao.Name = "lblIrrigacao";
            lblIrrigacao.Size = new Size(96, 28);
            lblIrrigacao.TabIndex = 18;
            lblIrrigacao.Text = "Irrigação";
            // 
            // lblFertlizacao
            // 
            lblFertlizacao.AutoSize = true;
            lblFertlizacao.BackColor = Color.Green;
            lblFertlizacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFertlizacao.ForeColor = Color.White;
            lblFertlizacao.Location = new Point(706, 391);
            lblFertlizacao.Name = "lblFertlizacao";
            lblFertlizacao.Size = new Size(122, 28);
            lblFertlizacao.TabIndex = 19;
            lblFertlizacao.Text = "Fertilização";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(btnVoltar);
            panelPrincipal.Controls.Add(lblProducao);
            panelPrincipal.Controls.Add(btnExcluirFertilizacao);
            panelPrincipal.Controls.Add(lblFertlizacao);
            panelPrincipal.Controls.Add(btnEditarFertilizacao);
            panelPrincipal.Controls.Add(dgvProducao);
            panelPrincipal.Controls.Add(btnAdicionarFertilizacao);
            panelPrincipal.Controls.Add(lblIrrigacao);
            panelPrincipal.Controls.Add(btnExcluirIrrigacao);
            panelPrincipal.Controls.Add(btnAdicionarProducao);
            panelPrincipal.Controls.Add(btnEditarIrrigacao);
            panelPrincipal.Controls.Add(lblColheita);
            panelPrincipal.Controls.Add(btnAdicionarIrrigacao);
            panelPrincipal.Controls.Add(btnEditarProducao);
            panelPrincipal.Controls.Add(dgvFertilizacao);
            panelPrincipal.Controls.Add(btnExcluirProducao);
            panelPrincipal.Controls.Add(dgvColheita);
            panelPrincipal.Controls.Add(btnAdicionarColheita);
            panelPrincipal.Controls.Add(dgvIrrigacao);
            panelPrincipal.Controls.Add(btnEditarColheita);
            panelPrincipal.Controls.Add(btnExcluirColheita);
            panelPrincipal.Location = new Point(0, -2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1334, 744);
            panelPrincipal.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(592, 11);
            label1.Name = "label1";
            label1.Size = new Size(151, 41);
            label1.TabIndex = 21;
            label1.Text = "Produção";
            label1.Click += BtnVoltar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DarkGreen;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(12, 8);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(227, 64);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar para tela inicial";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // Producao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1336, 741);
            Controls.Add(panelPrincipal);
            Name = "Producao";
            Text = "Produção - GMT Farm";
            ((System.ComponentModel.ISupportInitialize)dgvProducao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIrrigacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvColheita).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFertilizacao).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducao;
        private DataGridView dgvIrrigacao;
        private DataGridView dgvColheita;
        private DataGridView dgvFertilizacao;
        private Button btnAdicionarProducao;
        private Button btnEditarProducao;
        private Button btnExcluirProducao;
        private Button btnAdicionarColheita;
        private Button btnEditarColheita;
        private Button btnExcluirColheita;
        private Button btnAdicionarIrrigacao;
        private Button btnEditarIrrigacao;
        private Button btnExcluirIrrigacao;
        private Button btnAdicionarFertilizacao;
        private Button btnEditarFertilizacao;
        private Button btnExcluirFertilizacao;
        private Label lblProducao;
        private Label lblColheita;
        private Label lblIrrigacao;
        private Label lblFertlizacao;
        private Panel panelPrincipal;
        private Button btnVoltar;
        private Label label1;
    }
}
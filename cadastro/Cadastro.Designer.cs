namespace FazendaUrbana
{
    partial class Cadastro
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
            txtNomeCompleto = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnCadastrar = new Button();
            lblMensagem = new Label();
            lblJaTemConta = new Label();
            lblNomeCompleto = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            label1 = new Label();
            txtTelefone = new TextBox();
            label2 = new Label();
            panelPrincipal = new Panel();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(486, 228);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(389, 27);
            txtNomeCompleto.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(355, 316);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(747, 316);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(268, 27);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(747, 386);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(268, 27);
            txtConfirmarSenha.TabIndex = 3;
            txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(583, 473);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(188, 53);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar-se";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(618, 108);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 20);
            lblMensagem.TabIndex = 5;
            // 
            // lblJaTemConta
            // 
            lblJaTemConta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJaTemConta.ForeColor = Color.GreenYellow;
            lblJaTemConta.Location = new Point(495, 529);
            lblJaTemConta.Name = "lblJaTemConta";
            lblJaTemConta.Size = new Size(402, 34);
            lblJaTemConta.TabIndex = 6;
            lblJaTemConta.Text = "Já tem conta? Clique aqui para fazer login.";
            lblJaTemConta.Click += lblJaTemConta_Click;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCompleto.ForeColor = Color.White;
            lblNomeCompleto.Location = new Point(486, 202);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(137, 23);
            lblNomeCompleto.TabIndex = 7;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(355, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(747, 288);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(62, 25);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmarSenha.ForeColor = Color.White;
            lblConfirmarSenha.Location = new Point(747, 358);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(150, 25);
            lblConfirmarSenha.TabIndex = 10;
            lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(265, 109);
            label1.Name = "label1";
            label1.Size = new Size(810, 46);
            label1.TabIndex = 11;
            label1.Text = "Cadastre-se no sistema de controle da GMT Farm!";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(355, 384);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(268, 27);
            txtTelefone.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(355, 358);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 13;
            label2.Text = "Telefone";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(lblJaTemConta);
            panelPrincipal.Controls.Add(lblConfirmarSenha);
            panelPrincipal.Controls.Add(txtTelefone);
            panelPrincipal.Controls.Add(btnCadastrar);
            panelPrincipal.Controls.Add(lblSenha);
            panelPrincipal.Controls.Add(txtConfirmarSenha);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(lblNomeCompleto);
            panelPrincipal.Controls.Add(txtNomeCompleto);
            panelPrincipal.Controls.Add(txtSenha);
            panelPrincipal.Controls.Add(lblEmail);
            panelPrincipal.Controls.Add(txtEmail);
            panelPrincipal.Location = new Point(-5, -1);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1341, 748);
            panelPrincipal.TabIndex = 14;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1337, 746);
            Controls.Add(panelPrincipal);
            Controls.Add(lblMensagem);
            Name = "Cadastro";
            Text = "Cadastro";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Button btnCadastrar;
        private Label lblMensagem;
        private Label lblJaTemConta;
        private Label lblNomeCompleto;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblConfirmarSenha;
        private Label label1;
        private TextBox txtTelefone;
        private Label label2;
        private Panel panelPrincipal;
    }
}
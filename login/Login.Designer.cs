namespace FazendaUrbana
{
    partial class Login
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
            txtSenhaLogin = new TextBox();
            btnLogin = new Button();
            lblMensagemLogin = new Label();
            lblEsqueceuSenha = new Label();
            txtInserirEmail = new TextBox();
            lblInserirEmail = new Label();
            btnVerificarEmail = new Button();
            txtNovaSenha = new TextBox();
            btnRedefinirSenha = new Button();
            txtCodigoGerado = new TextBox();
            lblInserirCodigo = new Label();
            btnValidarCodigo = new Button();
            txtConfirmarSenha = new TextBox();
            lblNovaSenha = new Label();
            lblSenhaNov = new Label();
            panelPrincipal = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmailLogin = new TextBox();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenhaLogin.Location = new Point(338, 226);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PasswordChar = '*';
            txtSenhaLogin.Size = new Size(699, 27);
            txtSenhaLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.ImageAlign = ContentAlignment.TopCenter;
            btnLogin.Location = new Point(601, 259);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Fazer Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMensagemLogin
            // 
            lblMensagemLogin.AutoSize = true;
            lblMensagemLogin.Location = new Point(658, 469);
            lblMensagemLogin.Name = "lblMensagemLogin";
            lblMensagemLogin.Size = new Size(0, 20);
            lblMensagemLogin.TabIndex = 3;
            // 
            // lblEsqueceuSenha
            // 
            lblEsqueceuSenha.Anchor = AnchorStyles.None;
            lblEsqueceuSenha.AutoSize = true;
            lblEsqueceuSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEsqueceuSenha.ForeColor = Color.GreenYellow;
            lblEsqueceuSenha.Location = new Point(591, 306);
            lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            lblEsqueceuSenha.Size = new Size(220, 28);
            lblEsqueceuSenha.TabIndex = 4;
            lblEsqueceuSenha.Text = "Esqueceu a sua senha?";
            lblEsqueceuSenha.Click += lblEsqueceuSenha_Click;
            // 
            // txtInserirEmail
            // 
            txtInserirEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInserirEmail.Location = new Point(26, 406);
            txtInserirEmail.Name = "txtInserirEmail";
            txtInserirEmail.Size = new Size(590, 27);
            txtInserirEmail.TabIndex = 8;
            txtInserirEmail.Visible = false;
            // 
            // lblInserirEmail
            // 
            lblInserirEmail.AutoSize = true;
            lblInserirEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInserirEmail.ForeColor = Color.White;
            lblInserirEmail.ImageAlign = ContentAlignment.BottomLeft;
            lblInserirEmail.Location = new Point(26, 375);
            lblInserirEmail.Name = "lblInserirEmail";
            lblInserirEmail.Size = new Size(162, 28);
            lblInserirEmail.TabIndex = 9;
            lblInserirEmail.Text = "Insira seu e-mail";
            lblInserirEmail.TextAlign = ContentAlignment.BottomLeft;
            lblInserirEmail.Visible = false;
            // 
            // btnVerificarEmail
            // 
            btnVerificarEmail.Anchor = AnchorStyles.None;
            btnVerificarEmail.BackColor = Color.DarkGreen;
            btnVerificarEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificarEmail.ForeColor = Color.White;
            btnVerificarEmail.Location = new Point(206, 439);
            btnVerificarEmail.Name = "btnVerificarEmail";
            btnVerificarEmail.Size = new Size(170, 38);
            btnVerificarEmail.TabIndex = 10;
            btnVerificarEmail.Text = "Verificar e-mail";
            btnVerificarEmail.UseVisualStyleBackColor = false;
            btnVerificarEmail.Visible = false;
            btnVerificarEmail.Click += btnVerificarEmail_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNovaSenha.Location = new Point(338, 543);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '*';
            txtNovaSenha.Size = new Size(699, 27);
            txtNovaSenha.TabIndex = 11;
            txtNovaSenha.Visible = false;
            // 
            // btnRedefinirSenha
            // 
            btnRedefinirSenha.Anchor = AnchorStyles.None;
            btnRedefinirSenha.BackColor = Color.DarkGreen;
            btnRedefinirSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedefinirSenha.ForeColor = Color.White;
            btnRedefinirSenha.Location = new Point(591, 644);
            btnRedefinirSenha.Name = "btnRedefinirSenha";
            btnRedefinirSenha.Size = new Size(168, 46);
            btnRedefinirSenha.TabIndex = 13;
            btnRedefinirSenha.Text = "Redefinir Senha";
            btnRedefinirSenha.UseVisualStyleBackColor = false;
            btnRedefinirSenha.Visible = false;
            btnRedefinirSenha.Click += btnRedefinirSenha_Click;
            // 
            // txtCodigoGerado
            // 
            txtCodigoGerado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigoGerado.Location = new Point(756, 406);
            txtCodigoGerado.Name = "txtCodigoGerado";
            txtCodigoGerado.PasswordChar = '*';
            txtCodigoGerado.Size = new Size(590, 27);
            txtCodigoGerado.TabIndex = 14;
            txtCodigoGerado.Visible = false;
            // 
            // lblInserirCodigo
            // 
            lblInserirCodigo.AutoSize = true;
            lblInserirCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInserirCodigo.ForeColor = Color.White;
            lblInserirCodigo.Location = new Point(756, 375);
            lblInserirCodigo.Name = "lblInserirCodigo";
            lblInserirCodigo.Size = new Size(147, 28);
            lblInserirCodigo.TabIndex = 16;
            lblInserirCodigo.Text = "Insira o código";
            lblInserirCodigo.Visible = false;
            // 
            // btnValidarCodigo
            // 
            btnValidarCodigo.Anchor = AnchorStyles.None;
            btnValidarCodigo.BackColor = Color.DarkGreen;
            btnValidarCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidarCodigo.ForeColor = Color.White;
            btnValidarCodigo.Location = new Point(963, 439);
            btnValidarCodigo.Name = "btnValidarCodigo";
            btnValidarCodigo.Size = new Size(170, 38);
            btnValidarCodigo.TabIndex = 17;
            btnValidarCodigo.Text = "Validar Código";
            btnValidarCodigo.UseVisualStyleBackColor = false;
            btnValidarCodigo.Visible = false;
            btnValidarCodigo.Click += btnValidarCodigo_Click;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmarSenha.Location = new Point(338, 611);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(699, 27);
            txtConfirmarSenha.TabIndex = 12;
            txtConfirmarSenha.Visible = false;
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNovaSenha.ForeColor = Color.White;
            lblNovaSenha.Location = new Point(338, 512);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(187, 28);
            lblNovaSenha.TabIndex = 18;
            lblNovaSenha.Text = "Insira a nova senha";
            lblNovaSenha.Visible = false;
            // 
            // lblSenhaNov
            // 
            lblSenhaNov.AutoSize = true;
            lblSenhaNov.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhaNov.ForeColor = Color.White;
            lblSenhaNov.Location = new Point(338, 580);
            lblSenhaNov.Name = "lblSenhaNov";
            lblSenhaNov.Size = new Size(296, 28);
            lblSenhaNov.TabIndex = 19;
            lblSenhaNov.Text = "Insira a nova senha novamente";
            lblSenhaNov.Visible = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(txtEmailLogin);
            panelPrincipal.Controls.Add(btnLogin);
            panelPrincipal.Controls.Add(txtSenhaLogin);
            panelPrincipal.Controls.Add(lblEsqueceuSenha);
            panelPrincipal.Controls.Add(lblInserirEmail);
            panelPrincipal.Controls.Add(btnValidarCodigo);
            panelPrincipal.Controls.Add(txtCodigoGerado);
            panelPrincipal.Controls.Add(lblInserirCodigo);
            panelPrincipal.Controls.Add(btnRedefinirSenha);
            panelPrincipal.Controls.Add(txtNovaSenha);
            panelPrincipal.Controls.Add(txtConfirmarSenha);
            panelPrincipal.Controls.Add(txtInserirEmail);
            panelPrincipal.Controls.Add(lblSenhaNov);
            panelPrincipal.Controls.Add(lblNovaSenha);
            panelPrincipal.Controls.Add(btnVerificarEmail);
            panelPrincipal.Location = new Point(-14, -1);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1355, 744);
            panelPrincipal.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(338, 195);
            label3.Name = "label3";
            label3.Size = new Size(239, 28);
            label3.TabIndex = 23;
            label3.Text = "Insira a senha cadastrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(338, 134);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 22;
            label2.Text = "Insira o e-mail cadastrado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(221, 84);
            label1.Name = "label1";
            label1.Size = new Size(982, 38);
            label1.TabIndex = 21;
            label1.Text = "Já possui cadastro no sistema de controle da GMT Farm? Faça o seu login.";
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.Location = new Point(338, 165);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(691, 27);
            txtEmailLogin.TabIndex = 20;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1336, 746);
            Controls.Add(panelPrincipal);
            Controls.Add(lblMensagemLogin);
            Name = "Login";
            Text = "Login";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSenhaLogin;
        private Button btnLogin;
        private Label lblMensagemLogin;
        private Label lblEsqueceuSenha;
        private TextBox txtInserirEmail;
        private Label lblInserirEmail;
        private Button btnVerificarEmail;
        private TextBox txtNovaSenha;
        private Button btnRedefinirSenha;
        private TextBox txtCodigoGerado;
        private Label lblInserirCodigo;
        private Button btnValidarCodigo;
        private TextBox txtConfirmarSenha;
        private Label lblNovaSenha;
        private Label lblSenhaNov;
        private Panel panelPrincipal;
        private TextBox txtEmailLogin;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
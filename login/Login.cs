using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FazendaUrbana
{
    public partial class Login : Form
    {
        private string codigoGerado = string.Empty; // Armazena o código gerado para redefinição de senha
        private string emailParaRedefinicao = string.Empty; // Armazena o email para redefinição de senha

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            CentralizarPanelPrincipal();

            // Configurações de visibilidade inicial
            OcultarComponentesRedefinicaoSenha();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CentralizarPanelPrincipal();
        }

        private void CentralizarPanelPrincipal()
        {
            panelPrincipal.Anchor = AnchorStyles.None;
            panelPrincipal.Location = new Point(
                (this.ClientSize.Width - panelPrincipal.Width) / 2,
                (this.ClientSize.Height - panelPrincipal.Height) / 2
            );
        }

        // Evento do botão de login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailLogin.Text) || string.IsNullOrWhiteSpace(txtSenhaLogin.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conexaoBanco = ObterStringConexao();
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE email = @Email AND senha = @Senha";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Email", txtEmailLogin.Text);
                        comando.Parameters.AddWithValue("@Senha", txtSenhaLogin.Text);

                        int resultado = Convert.ToInt32(comando.ExecuteScalar());
                        if (resultado > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TelaInicial telaInicial = new TelaInicial();
                            telaInicial.Show();
                            this.Hide(); // Oculta o formulário de login
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento da label "Esqueceu sua senha"
        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            MostrarComponentesRedefinicaoSenhaFase1();
        }

        // Evento do botão para verificar o email
        private void btnVerificarEmail_Click(object sender, EventArgs e)
        {
            string conexaoBanco = ObterStringConexao();
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE email = @Email";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Email", txtInserirEmail.Text);
                        int resultado = Convert.ToInt32(comando.ExecuteScalar());

                        if (resultado > 0)
                        {
                            emailParaRedefinicao = txtInserirEmail.Text;
                            codigoGerado = GerarCodigoAleatorio();
                            MessageBox.Show("Código de verificação: " + codigoGerado, "Código Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarComponentesRedefinicaoSenhaFase2();
                        }
                        else
                        {
                            MessageBox.Show("Email não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar email: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para validar o código gerado
        private void btnValidarCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigoGerado.Text == codigoGerado)
            {
                MostrarComponentesRedefinicaoSenhaFase3();
            }
            else
            {
                MessageBox.Show("Código incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para redefinir a senha
        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNovaSenha.Text) || string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNovaSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string conexaoBanco = ObterStringConexao();
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    string query = "UPDATE usuarios SET senha = @NovaSenha WHERE email = @Email";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@NovaSenha", txtNovaSenha.Text);
                        comando.Parameters.AddWithValue("@Email", emailParaRedefinicao);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ocultar componentes de redefinição de senha após o sucesso
                        OcultarComponentesRedefinicaoSenha();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao redefinir senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gera um código aleatório de 6 caracteres
        private string GerarCodigoAleatorio()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // Oculta componentes de redefinição de senha
        private void OcultarComponentesRedefinicaoSenha()
        {
            lblInserirEmail.Visible = false;
            lblInserirCodigo.Visible = false;
            lblNovaSenha.Visible = false;
            lblSenhaNov.Visible = false;
            txtInserirEmail.Visible = false;
            btnVerificarEmail.Visible = false;
            txtCodigoGerado.Visible = false;
            btnValidarCodigo.Visible = false;
            txtNovaSenha.Visible = false;
            txtConfirmarSenha.Visible = false;
            btnRedefinirSenha.Visible = false;
        }

        // Mostra a primeira fase da redefinição de senha (verificar email)
        private void MostrarComponentesRedefinicaoSenhaFase1()
        {
            lblInserirEmail.Visible = true;
            txtInserirEmail.Visible = true;
            btnVerificarEmail.Visible = true;
        }

        // Mostra a segunda fase da redefinição de senha (validar código)
        private void MostrarComponentesRedefinicaoSenhaFase2()
        {
            lblInserirCodigo.Visible = true;
            txtCodigoGerado.Visible = true;
            btnValidarCodigo.Visible = true;
        }

        // Mostra a terceira fase da redefinição de senha (nova senha)
        private void MostrarComponentesRedefinicaoSenhaFase3()
        {
            lblNovaSenha.Visible = true;
            lblSenhaNov.Visible = true;
            txtNovaSenha.Visible = true;
            txtConfirmarSenha.Visible = true;
            btnRedefinirSenha.Visible = true;
        }

        // Método para obter a string de conexão
        private string ObterStringConexao()
        {
            const string servidor = "localhost";
            const string bancoDados = "gmtfarm";
            const string usuario = "root";
            const string senha = "12345678";
            return $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha};";
        }
    }
}

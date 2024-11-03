using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FazendaUrbana
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            CentralizarPanelPrincipal();
        }

        private void Cadastro_Load(object sender, EventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarSenha.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text)) // Novo campo
            {
                lblMensagem.Text = "Por favor, preencha todos os campos.";
                return;
            }

            // Verifica se as senhas coincidem
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                lblMensagem.Text = "As senhas não coincidem.";
                return;
            }

            // Conectar ao banco de dados
            const string servidor = "localhost";
            const string bancoDados = "gmtfarm";
            const string usuario = "root";
            const string senha = "12345678";
            string conexaoBanco = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();

                    // Query SQL para inserir os dados no banco, incluindo o telefone celular
                    string query = "INSERT INTO usuarios (nome_completo, email, senha, telefone_celular) VALUES (@nome, @email, @senha, @telefone)";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        // Parametrizando as variáveis para evitar SQL Injection
                        comando.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                        comando.Parameters.AddWithValue("@email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@senha", txtSenha.Text); // Em um sistema real, a senha deve ser criptografada!
                        comando.Parameters.AddWithValue("@telefone", txtTelefone.Text); // Novo campo

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cadastro realizado com sucesso! Você pode fazer login agora.");

                    // Aqui, você pode redirecionar para a tela de login
                    Login loginForm = new Login();
                    loginForm.Show(); // Exibe o formulário de login
                    this.Hide(); // Fecha o formulário de cadastro
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void lblJaTemConta_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário de login
            Login loginForm = new Login();
            loginForm.Show(); // Exibe o formulário de login
            this.Hide(); // Fecha o formulário de cadastro atual
        }
    }
}
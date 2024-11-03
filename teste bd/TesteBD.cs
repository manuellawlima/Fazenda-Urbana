using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FazendaUrbana
{
    public partial class TesteBD : Form
    {
        public TesteBD()
        {
            InitializeComponent();
        }

        private void TesteBD_Load(object sender, EventArgs e)
        {
            try
            {
                // 4 variáveis declaradas com as informações do banco de dados.
                const string servidor = "localhost"; // Caso o banco esteja no mesmo computador
                const string bancoDados = "gmtfarm";
                const string usuario = "root";
                const string senha = "12345678";

                // Declarando a conexão com o banco de dados usando interpolação de variáveis.
                string conexaoBanco = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";

                // Criando uma nova conexão MySQL
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open(); // Abrindo a conexão

                    // Se a conexão for bem-sucedida, altera o texto do lbTeste
                    lbTeste.Text = $"A conexão com o banco {bancoDados} foi realizada com sucesso.";
                }
            }
            catch (Exception ex)
            {
                // Caso ocorra um erro, exibe uma mensagem com a descrição do erro
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
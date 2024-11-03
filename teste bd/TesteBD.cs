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
                // 4 vari�veis declaradas com as informa��es do banco de dados.
                const string servidor = "localhost"; // Caso o banco esteja no mesmo computador
                const string bancoDados = "gmtfarm";
                const string usuario = "root";
                const string senha = "12345678";

                // Declarando a conex�o com o banco de dados usando interpola��o de vari�veis.
                string conexaoBanco = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";

                // Criando uma nova conex�o MySQL
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open(); // Abrindo a conex�o

                    // Se a conex�o for bem-sucedida, altera o texto do lbTeste
                    lbTeste.Text = $"A conex�o com o banco {bancoDados} foi realizada com sucesso.";
                }
            }
            catch (Exception ex)
            {
                // Caso ocorra um erro, exibe uma mensagem com a descri��o do erro
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
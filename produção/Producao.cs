using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FazendaUrbana
{
    public partial class Producao : Form
    {
        // Conexão com o banco de dados
        string connectionString = "server=localhost;database=gmtfarm;uid=root;pwd=12345678";

        public Producao()
        {
            InitializeComponent();
            CarregarDados();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            CentralizarPanelPrincipal();
        }

        private void Producao_Load(object sender, EventArgs e)
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

        private void InicializarBotaoVoltar()
        {
            // Configurações do botão "Voltar"
            btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.Size = new System.Drawing.Size(100, 30);
            btnVoltar.Location = new System.Drawing.Point(10, 10); // Posição no formulário
            btnVoltar.Click += BtnVoltar_Click;

            // Adiciona o botão ao formulário
            this.Controls.Add(btnVoltar);
        }

        // Evento de clique para voltar à Tela Inicial
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            // Mostra a tela inicial e fecha o formulário atual
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Close();
        }

        // Carregar os dados das tabelas no DGV
        private void CarregarDados()
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    // Carregar dados da produção
                    MySqlDataAdapter daProducao = new MySqlDataAdapter("SELECT codigo, cultivo, plantio, quantidade FROM p1producao", conexao);
                    DataTable dtProducao = new DataTable();
                    daProducao.Fill(dtProducao);
                    dgvProducao.DataSource = dtProducao;

                    // Carregar dados da colheita
                    MySqlDataAdapter daColheita = new MySqlDataAdapter("SELECT colheita, data_colheita, quantidade FROM p2colheita", conexao);
                    DataTable dtColheita = new DataTable();
                    daColheita.Fill(dtColheita);
                    dgvColheita.DataSource = dtColheita;

                    // Carregar dados da irrigação
                    MySqlDataAdapter daIrrigacao = new MySqlDataAdapter("SELECT codigo, frequencia, quantidade, horario, duracao FROM p3irrigacao", conexao);
                    DataTable dtIrrigacao = new DataTable();
                    daIrrigacao.Fill(dtIrrigacao);
                    dgvIrrigacao.DataSource = dtIrrigacao;

                    // Carregar dados da fertilização
                    MySqlDataAdapter daFertilizacao = new MySqlDataAdapter("SELECT codigo, frequencia, quantidade FROM p4fertilizacao", conexao);
                    DataTable dtFertilizacao = new DataTable();
                    daFertilizacao.Fill(dtFertilizacao);
                    dgvFertilizacao.DataSource = dtFertilizacao;

                    // Ajuste de colunas
                    dgvProducao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvColheita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvIrrigacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvFertilizacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 200,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen,
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
            }
        }

        // Funções para produção
        private void btnAdicionarProducao_Click(object sender, EventArgs e)
        {
            string? cultivo = Prompt.ShowDialog("Cultivo:", "Adicionar Produção");
            string? plantio = Prompt.ShowDialog("Data de Plantio (DD/MM/YYYY):", "Adicionar Produção");
            string? quantidade = Prompt.ShowDialog("Quantidade:", "Adicionar Produção");

            if (!string.IsNullOrWhiteSpace(cultivo) && !string.IsNullOrWhiteSpace(plantio) && !string.IsNullOrWhiteSpace(quantidade))
            {
                // Tente converter a data para o formato YYYY-MM-DD
                DateTime dataPlantio;
                try
                {
                    dataPlantio = DateTime.ParseExact(plantio, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Data de plantio deve estar no formato DD/MM/YYYY.");
                    return; // Saia do método se a conversão falhar
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO p1producao (cultivo, plantio, quantidade) VALUES (@cultivo, @plantio, @quantidade)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cultivo", cultivo);
                    cmd.Parameters.AddWithValue("@plantio", dataPlantio.ToString("yyyy-MM-dd")); // Converte a data para o formato correto
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.ExecuteNonQuery();
                }
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
        }

        private void btnEditarProducao_Click(object sender, EventArgs e)
        {
            if (dgvProducao.SelectedRows.Count > 0)
            {
                string codigo = dgvProducao.SelectedRows[0].Cells[0].Value?.ToString();
                string cultivo = Prompt.ShowDialog("Novo Cultivo:", "Editar Produção");
                string plantio = Prompt.ShowDialog("Nova Data de Plantio (DD/MM/YYYY):", "Editar Produção");
                string quantidade = Prompt.ShowDialog("Nova Quantidade:", "Editar Produção");

                if (!string.IsNullOrWhiteSpace(codigo) && !string.IsNullOrWhiteSpace(cultivo) && !string.IsNullOrWhiteSpace(plantio) && !string.IsNullOrWhiteSpace(quantidade))
                {
                    // Tente converter a nova data para  o formato YYYY-MM-DD
                    DateTime novaDataPlantio;
                    try
                    {
                        novaDataPlantio = DateTime.ParseExact(plantio, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nova data de plantio deve estar no formato DD/MM/YYYY.");
                        return; // Saia do método se a conversão falhar
                    }

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE p1producao SET cultivo = @cultivo, plantio = @plantio, quantidade = @quantidade WHERE codigo = @codigo";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@cultivo", cultivo);
                        cmd.Parameters.AddWithValue("@plantio", novaDataPlantio.ToString("yyyy-MM-dd")); // Converte a nova data para o formato correto
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }
        }

        private void btnExcluirProducao_Click(object sender, EventArgs e)
        {
            if (dgvProducao.SelectedRows.Count > 0)
            {
                string? codigo = dgvProducao.SelectedRows[0].Cells[0].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(codigo))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM p1producao WHERE codigo = @codigo";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }

        // Funções para colheita
        private void btnAdicionarColheita_Click(object sender, EventArgs e)
        {
            string? colheita = Prompt.ShowDialog("Colheita:", "Adicionar Colheita");
            string? dataColheita = Prompt.ShowDialog("Data de Colheita (DD/MM/YYYY):", "Adicionar Colheita");
            string? quantidade = Prompt.ShowDialog("Quantidade:", "Adicionar Colheita");

            if (!string.IsNullOrWhiteSpace(colheita) && !string.IsNullOrWhiteSpace(dataColheita) && !string.IsNullOrWhiteSpace(quantidade))
            {
                // Tente converter a data de colheita para o formato YYYY-MM-DD
                DateTime dataColheitaFormatada;
                try
                {
                    dataColheitaFormatada = DateTime.ParseExact(dataColheita, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Data de colheita deve estar no formato DD/MM/YYYY.");
                    return; // Saia do método se a conversão falhar
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO p2colheita (colheita, data_colheita, quantidade) VALUES (@colheita, @data_colheita, @quantidade)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@colheita", colheita);
                    cmd.Parameters.AddWithValue("@data_colheita", dataColheitaFormatada.ToString("yyyy-MM-dd")); // Converte a data para o formato correto
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.ExecuteNonQuery();
                }
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
        }

        private void btnEditarColheita_Click(object sender, EventArgs e)
        {
            if (dgvColheita.SelectedRows.Count > 0)
            {
                string codigo = dgvColheita.SelectedRows[0].Cells[0].Value?.ToString();
                string colheita = Prompt.ShowDialog("Nova Colheita:", "Editar Colheita");
                string dataColheita = Prompt.ShowDialog("Nova Data de Colheita (DD/MM/YYYY):", "Editar Colheita");
                string quantidade = Prompt.ShowDialog("Nova Quantidade:", "Editar Colheita");

                if (!string.IsNullOrWhiteSpace(codigo) && !string.IsNullOrWhiteSpace(colheita) && !string.IsNullOrWhiteSpace(dataColheita) && !string.IsNullOrWhiteSpace(quantidade))
                {
                    // Tente converter a nova data de colheita para o formato YYYY-MM-DD
                    DateTime novaDataColheita;
                    try
                    {
                        novaDataColheita = DateTime.ParseExact(dataColheita, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nova data de colheita deve estar no formato DD/MM/YYYY.");
                        return; // Saia do método se a conversão falhar
                    }

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE p2colheita SET colheita = @colheita, data_colheita = @data_colheita, quantidade = @quantidade WHERE colheita = @codigo"; // Verifique se está correto usar o campo de colheita como referência
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@colheita", colheita);
                        cmd.Parameters.AddWithValue("@data_colheita", novaDataColheita.ToString("yyyy-MM-dd")); // Converte a nova data para o formato correto
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }
        }

        private void btnExcluirColheita_Click(object sender, EventArgs e)
        {
            if (dgvColheita.SelectedRows.Count > 0)
            {
                string? colheita = dgvColheita.SelectedRows[0].Cells[0].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(colheita))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM p2colheita WHERE colheita = @colheita";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@colheita", colheita);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }

        // Funções para irrigação
        private void btnAdicionarIrrigacao_Click(object sender, EventArgs e)
        {
            string? codigo = Prompt.ShowDialog("Código:", "Adicionar Irrigação");
            string? frequencia = Prompt.ShowDialog("Frequência:", "Adicionar Irrigação");
            string? quantidade = Prompt.ShowDialog("Quantidade:", "Adicionar Irrigação");
            string? horario = Prompt.ShowDialog("Horário:", "Adicionar Irrigação");
            string? duracao = Prompt.ShowDialog("Duração:", "Adicionar Irrigação");

            if (!string.IsNullOrWhiteSpace(codigo) && !string.IsNullOrWhiteSpace(frequencia) && !string.IsNullOrWhiteSpace(quantidade) && !string.IsNullOrWhiteSpace(horario) && !string.IsNullOrWhiteSpace(duracao))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO p3irrigacao (codigo, frequencia, quantidade, horario, duracao) VALUES (@codigo, @frequencia, @quantidade, @horario, @duracao)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@frequencia", frequencia);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@horario", horario);
                    cmd.Parameters.AddWithValue("@duracao", duracao);
                    cmd.ExecuteNonQuery();
                }
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
        }

        private void btnEditarIrrigacao_Click(object sender, EventArgs e)
        {
            if (dgvIrrigacao.SelectedRows.Count > 0)
            {
                string codigo = dgvIrrigacao.SelectedRows[0].Cells[0].Value?.ToString();
                string novaFrequencia = Prompt.ShowDialog("Nova Frequência:", "Editar Irrigação");
                string novaQuantidade = Prompt.ShowDialog("Nova Quantidade:", "Editar Irrigação");
                string novoHorario = Prompt.ShowDialog("Novo Horário:", "Editar Irrigação");
                string novaDuracao = Prompt.ShowDialog("Nova Duração:", "Editar Irrigação");

                if (!string.IsNullOrWhiteSpace(codigo) && !string.IsNullOrWhiteSpace(novaFrequencia) && !string.IsNullOrWhiteSpace(novaQuantidade) && !string.IsNullOrWhiteSpace(novoHorario) && !string.IsNullOrWhiteSpace(novaDuracao))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE p3irrigacao SET frequencia = @novaFrequencia, quantidade = @novaQuantidade, horario = @novoHorario, duracao = @novaDuracao WHERE codigo = @codigo";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@novaFrequencia", novaFrequencia);
                        cmd.Parameters.AddWithValue("@novaQuantidade", novaQuantidade);
                        cmd.Parameters.AddWithValue("@novoHorario", novoHorario);
                        cmd.Parameters.AddWithValue("@novaDuracao", novaDuracao);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }
        }

        private void btnExcluirIrrigacao_Click(object sender, EventArgs e)
        {
            if (dgvIrrigacao.SelectedRows.Count > 0)
            {
                string? codigo = dgvIrrigacao.SelectedRows[0].Cells[0].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(codigo))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM p3irrigacao WHERE codigo = @codigo";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }

        // Funções para fertilização
        private void btnAdicionarFertilizacao_Click(object sender, EventArgs e)
        {
            string? codigo = Prompt.ShowDialog("Código:", "Adicionar Fertilização");
            string? frequencia = Prompt.ShowDialog("Frequência:", "Adicionar Fertilização");
            string? quantidade = Prompt.ShowDialog("Quantidade:", "Adicionar Fertilização");

            if (!string.IsNullOrWhiteSpace(codigo) && !string.IsNullOrWhiteSpace(frequencia) && !string.IsNullOrWhiteSpace(quantidade))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO p4fertilizacao (codigo, frequencia, quantidade) VALUES (@codigo, @frequencia, @quantidade)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@frequencia", frequencia);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.ExecuteNonQuery();
                }
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
        }

        private void btnEditarFertilizacao_Click(object sender, EventArgs e)
        {
            if (dgvFertilizacao.SelectedRows.Count > 0)
            {
                string codigo = dgvFertilizacao.SelectedRows[0].Cells[0].Value?.ToString();
                string novaFrequencia = Prompt.ShowDialog("Nova Frequência:", "Editar Fertilização");
                string novaQuantidade = Prompt.ShowDialog("Nova Quantidade:", "Editar Fertilização");

                if (!string.IsNullOrWhiteSpace(codigo) && !string.IsNullOrWhiteSpace(novaFrequencia) && !string.IsNullOrWhiteSpace(novaQuantidade))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE p4fertilizacao SET frequencia = @novaFrequencia, quantidade = @novaQuantidade WHERE codigo = @codigo";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@novaFrequencia", novaFrequencia);
                        cmd.Parameters.AddWithValue("@novaQuantidade", novaQuantidade);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }
        }

        private void btnExcluirFertilizacao_Click(object sender, EventArgs e)
        {
            if (dgvFertilizacao.SelectedRows.Count > 0)
            {
                string? codigo = dgvFertilizacao.SelectedRows[0].Cells[0].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(codigo))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM p4fertilizacao WHERE codigo = @codigo";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }
    }
}
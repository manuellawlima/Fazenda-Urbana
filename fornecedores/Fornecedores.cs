using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FazendaUrbana
{
    public partial class Fornecedores : Form
    {
        string connectionString = "Server=localhost;Database=gmtfarm;Uid=root;Pwd=12345678;";

        public Fornecedores()
        {
            InitializeComponent();
            CarregarDados();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            CentralizarPanelPrincipal();
        }
    
        private void Fornecedores_Load(object sender, EventArgs e)
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

        // Carregar dados das tabelas no DGV
        private void CarregarDados()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Carregar dados das pessoas físicas
                    MySqlDataAdapter daPessoasFisicas = new MySqlDataAdapter("SELECT * FROM fornecedores_pessoafisica", conn);
                    DataTable dtPessoasFisicas = new DataTable();
                    daPessoasFisicas.Fill(dtPessoasFisicas);
                    dgvPessoasFisicas.DataSource = dtPessoasFisicas;

                    // Carregar dados das pessoas jurídicas
                    MySqlDataAdapter daPessoasJuridicas = new MySqlDataAdapter("SELECT * FROM fornecedores_pessoajuridica", conn);
                    DataTable dtPessoasJuridicas = new DataTable();
                    daPessoasJuridicas.Fill(dtPessoasJuridicas);
                    dgvPessoasJuridicas.DataSource = dtPessoasJuridicas;

                    // Ajuste de colunas
                    dgvPessoasFisicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvPessoasJuridicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        // Função para adicionar uma nova pessoa física
        private void btnAdicionarPessoaFisica_Click(object sender, EventArgs e)
        {
            string nomeCompleto = Prompt.ShowDialog("Nome Completo:", "Adicionar Pessoa Física");
            string cpf = Prompt.ShowDialog("CPF:", "Adicionar Pessoa Física");
            string rg = Prompt.ShowDialog("RG:", "Adicionar Pessoa Física");
            string dtNasc = Prompt.ShowDialog("Data de Nascimento (DD/MM/YYYY):", "Adicionar Pessoa Física");
            string telefone = Prompt.ShowDialog("Telefone:", "Adicionar Pessoa Física");
            string celular = Prompt.ShowDialog("Celular:", "Adicionar Pessoa Física");
            string email = Prompt.ShowDialog("Email:", "Adicionar Pessoa Física");
            string cep = Prompt.ShowDialog("CEP:", "Adicionar Pessoa Física");
            string estado = Prompt.ShowDialog("Estado:", "Adicionar Pessoa Física");
            string cidade = Prompt.ShowDialog("Cidade:", "Adicionar Pessoa Física");
            string endereco = Prompt.ShowDialog("Endereço:", "Adicionar Pessoa Física");
            string bairro = Prompt.ShowDialog("Bairro:", "Adicionar Pessoa Física");
            string numero = Prompt.ShowDialog("Número:", "Adicionar Pessoa Física");
            string complemento = Prompt.ShowDialog("Complemento:", "Adicionar Pessoa Física");

            // Verifica se o nome completo e CPF foram informados
            if (!string.IsNullOrWhiteSpace(nomeCompleto) && !string.IsNullOrWhiteSpace(cpf))
            {
                // Tenta converter a data de nascimento para o formato YYYY-MM-DD
                DateTime dataNascimento;
                bool dataValida = DateTime.TryParseExact(dtNasc, "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture,
                                System.Globalization.DateTimeStyles.None, out dataNascimento);

                if (!dataValida)
                {
                    MessageBox.Show("Data de Nascimento inválida. Use o formato DD/MM/YYYY.");
                    return;
                }

                string dtNascFormatada = dataNascimento.ToString("yyyy-MM-dd");

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO fornecedores_pessoafisica (nome_completo, cpf, rg, dt_nasc, telefone, celular, email, cep, estado, cidade, endereco, bairro, numero, complemento) " +
                                       "VALUES (@nome_completo, @cpf, @rg, @dt_nasc, @telefone, @celular, @email, @cep, @estado, @cidade, @endereco, @bairro, @numero, @complemento)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nome_completo", nomeCompleto);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@rg", rg);
                        cmd.Parameters.AddWithValue("@dt_nasc", dtNascFormatada); // Usa a data formatada.
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@celular", celular);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@cep", cep);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@cidade", cidade);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@bairro", bairro);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@complemento", complemento);
                        cmd.ExecuteNonQuery();
                        CarregarDados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao adicionar pessoa física: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nome e CPF são obrigatórios.");
            }
        }


        // Função para editar uma pessoa física
        private void btnEditarPessoaFisica_Click(object sender, EventArgs e)
        {
            if (dgvPessoasFisicas.SelectedRows.Count > 0)
            {
                string id = dgvPessoasFisicas.SelectedRows[0].Cells[0].Value.ToString();
                string nomeCompleto = Prompt.ShowDialog("Nome Completo:", "Editar Pessoa Física", dgvPessoasFisicas.SelectedRows[0].Cells["nome_completo"].Value.ToString());
                string cpf = Prompt.ShowDialog("CPF:", "Editar Pessoa Física", dgvPessoasFisicas.SelectedRows[0].Cells["cpf"].Value.ToString());
                string dtNasc = Prompt.ShowDialog("Data de Nascimento (DD/MM/YYYY):", "Editar Pessoa Física", dgvPessoasFisicas.SelectedRows[0].Cells["dt_nasc"].Value.ToString());

                if (!string.IsNullOrWhiteSpace(nomeCompleto) && !string.IsNullOrWhiteSpace(cpf))
                {
                    // Tenta converter a data de nascimento para o formato YYYY-MM-DD
                    DateTime dataNascimento;
                    bool dataValida = DateTime.TryParseExact(dtNasc, "dd/MM/yyyy",
                                    System.Globalization.CultureInfo.InvariantCulture,
                                    System.Globalization.DateTimeStyles.None, out dataNascimento);

                    if (!dataValida)
                    {
                        MessageBox.Show("Data de Nascimento inválida. Use o formato DD/MM/YYYY.");
                        return;
                    }

                    string dtNascFormatada = dataNascimento.ToString("yyyy-MM-dd");

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "UPDATE fornecedores_pessoafisica SET nome_completo = @nome_completo, cpf = @cpf, dt_nasc = @dt_nasc WHERE id = @id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@nome_completo", nomeCompleto);
                            cmd.Parameters.AddWithValue("@cpf", cpf);
                            cmd.Parameters.AddWithValue("@dt_nasc", dtNascFormatada); // Usa a data formatada
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            CarregarDados();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao editar pessoa física: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nome e CPF são obrigatórios.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }
        }


        // Função para excluir uma pessoa física
        private void btnExcluirPessoaFisica_Click(object sender, EventArgs e)
        {
            if (dgvPessoasFisicas.SelectedRows.Count > 0)
            {
                string id = dgvPessoasFisicas.SelectedRows[0].Cells[0].Value.ToString();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM fornecedores_pessoafisica WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        CarregarDados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir pessoa física: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }

        // Função para pesquisar pessoas físicas
        private void btnPesquisarPessoaFisica_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPessoaFisica.Text;

            if (!string.IsNullOrWhiteSpace(termoPesquisa))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM fornecedores_pessoafisica WHERE nome_completo LIKE @termo OR cpf LIKE @termo";
                        MySqlDataAdapter daPessoasFisicas = new MySqlDataAdapter(query, conn);
                        daPessoasFisicas.SelectCommand.Parameters.AddWithValue("@termo", "%" + termoPesquisa + "%");
                        DataTable dtPessoasFisicas = new DataTable();
                        daPessoasFisicas.Fill(dtPessoasFisicas);
                        dgvPessoasFisicas.DataSource = dtPessoasFisicas;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao pesquisar pessoa física: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa.");
            }
        }

        // Função para adicionar uma nova pessoa jurídica
        private void btnAdicionarPessoaJuridica_Click(object sender, EventArgs e)
        {
            string razaoSocial = Prompt.ShowDialog("Razão Social:", "Adicionar Pessoa Jurídica");
            string cnpj = Prompt.ShowDialog("CNPJ:", "Adicionar Pessoa Jurídica");
            string nomeCompleto = Prompt.ShowDialog("Nome Completo:", "Adicionar Pessoa Jurídica");
            string dtNasc = Prompt.ShowDialog("Data de Nascimento (DD/MM/YYYY):", "Adicionar Pessoa Jurídica");
            string inscricaoEstadual = Prompt.ShowDialog("Inscrição Estadual:", "Adicionar Pessoa Jurídica");
            string telefone = Prompt.ShowDialog("Telefone:", "Adicionar Pessoa Jurídica");
            string celular = Prompt.ShowDialog("Celular:", "Adicionar Pessoa Jurídica");
            string email = Prompt.ShowDialog("Email:", "Adicionar Pessoa Jurídica");
            string cep = Prompt.ShowDialog("CEP:", "Adicionar Pessoa Jurídica");
            string estado = Prompt.ShowDialog("Estado:", "Adicionar Pessoa Jurídica");
            string cidade = Prompt.ShowDialog("Cidade:", "Adicionar Pessoa Jurídica");
            string endereco = Prompt.ShowDialog("Endereço:", "Adicionar Pessoa Jurídica");
            string bairro = Prompt.ShowDialog("Bairro:", "Adicionar Pessoa Jurídica");
            string numero = Prompt.ShowDialog("Número:", "Adicionar Pessoa Jurídica");
            string complemento = Prompt.ShowDialog("Complemento:", "Adicionar Pessoa Jurídica");

            if (!string.IsNullOrWhiteSpace(razaoSocial) && !string.IsNullOrWhiteSpace(cnpj))
            {
                // Tenta converter a data de nascimento para o formato YYYY-MM-DD
                DateTime dataNascimento;
                bool dataValida = DateTime.TryParseExact(dtNasc, "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture,
                                System.Globalization.DateTimeStyles.None, out dataNascimento);

                if (!dataValida)
                {
                    MessageBox.Show("Data de Nascimento inválida. Use o formato DD/MM/YYYY.");
                    return;
                }

                string dtNascFormatada = dataNascimento.ToString("yyyy-MM-dd");

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO fornecedores_pessoajuridica (razao_social, cnpj, nome_completo, dt_nasc, insc_estadual, telefone, celular, email, cep, estado, cidade, endereco, bairro, numero, complemento) " +
                                       "VALUES (@razao_social, @cnpj, @nome_completo, @dt_nasc, @insc_estadual, @telefone, @celular, @email, @cep, @estado, @cidade, @endereco, @bairro, @numero, @complemento)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@razao_social", razaoSocial);
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        cmd.Parameters.AddWithValue("@nome_completo", nomeCompleto);
                        cmd.Parameters.AddWithValue("@dt_nasc", dtNascFormatada); // Usa a data formatada
                        cmd.Parameters.AddWithValue("@insc_estadual", inscricaoEstadual);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@celular", celular);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@cep", cep);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@cidade", cidade);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@bairro", bairro);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@complemento", complemento);
                        cmd.ExecuteNonQuery();
                        CarregarDados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao adicionar pessoa jurídica: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Razão Social e CNPJ são obrigatórios.");
            }
        }

        // Função para editar uma pessoa jurídica
        private void btnEditarPessoaJuridica_Click(object sender, EventArgs e)
        {
            if (dgvPessoasJuridicas.SelectedRows.Count > 0)
            {
                string cnpj = dgvPessoasJuridicas.SelectedRows[0].Cells["cnpj"].Value.ToString(); // Usando CNPJ como identificador
                string razaoSocial = Prompt.ShowDialog("Razão Social:", "Editar Pessoa Jurídica", dgvPessoasJuridicas.SelectedRows[0].Cells["razao_social"].Value.ToString());
                string dtNasc = Prompt.ShowDialog("Data de Nascimento (DD/MM/YYYY):", "Editar Pessoa Jurídica", dgvPessoasJuridicas.SelectedRows[0].Cells["dt_nasc"].Value.ToString());

                DateTime dataNascimento;
                bool dataValida = DateTime.TryParseExact(dtNasc, "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture,
                                System.Globalization.DateTimeStyles.None, out dataNascimento);

                if (!string.IsNullOrWhiteSpace(razaoSocial) && !string.IsNullOrWhiteSpace(cnpj) && dataValida)
                {
                    string dtNascFormatada = dataNascimento.ToString("yyyy-MM-dd");

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            // Atualizando a consulta para usar CNPJ como critério
                            string query = "UPDATE fornecedores_pessoajuridica SET razao_social = @razao_social, dt_nasc = @dt_nasc WHERE cnpj = @cnpj";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@razao_social", razaoSocial);
                            cmd.Parameters.AddWithValue("@cnpj", cnpj); // Usa o CNPJ existente como parâmetro
                            cmd.Parameters.AddWithValue("@dt_nasc", dtNascFormatada);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Pessoa Jurídica editada com sucesso!");
                                CarregarDados(); // Certifique-se de que isso atualiza o DataGridView corretamente
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma alteração realizada. Verifique se os dados são diferentes.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao editar pessoa jurídica: " + ex.Message);
                        }
                    }
                }
                else
                {
                    string mensagemErro = "Razão Social e CNPJ são obrigatórios.";
                    if (!dataValida)
                    {
                        mensagemErro += "\nData de Nascimento inválida. Use o formato DD/MM/YYYY.";
                    }
                    MessageBox.Show(mensagemErro);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }
        }

        // Função para excluir uma pessoa jurídica
        private void btnExcluirPessoaJuridica_Click(object sender, EventArgs e)
        {
            if (dgvPessoasJuridicas.SelectedRows.Count > 0)
            {
                string razaoSocial = dgvPessoasJuridicas.SelectedRows[0].Cells[0].Value.ToString();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM fornecedores_pessoajuridica WHERE razao_social = @razao_social";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@razao_social", razaoSocial);
                        cmd.ExecuteNonQuery();
                        CarregarDados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir pessoa jurídica: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }

        // Função para pesquisar pessoas jurídicas
        private void btnPesquisarPessoaJuridica_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPessoaJuridica.Text;

            if (!string.IsNullOrWhiteSpace(termoPesquisa))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM fornecedores_pessoajuridica WHERE razao_social LIKE @termo OR cnpj LIKE @termo";
                        MySqlDataAdapter daPessoasJuridicas = new MySqlDataAdapter(query, conn);
                        daPessoasJuridicas.SelectCommand.Parameters.AddWithValue("@termo", "%" + termoPesquisa + "%");
                        DataTable dtPessoasJuridicas = new DataTable();
                        daPessoasJuridicas.Fill(dtPessoasJuridicas);
                        dgvPessoasJuridicas.DataSource = dtPessoasJuridicas;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao pesquisar pessoa jurídica: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa.");
            }
        }
    }

    // Classe para prompts de entrada
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string input = "")
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 200,
                Text = caption,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300, Text = input };
            Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}

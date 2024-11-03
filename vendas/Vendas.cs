using Microsoft.Identity.Client;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FazendaUrbana
{
    public partial class Vendas : Form
    {
        string connectionString = "Server=localhost;Database=gmtfarm;Uid=root;Pwd=12345678;";

        public Vendas()
        {
            InitializeComponent();
            CarregarDados();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            CentralizarPanelPrincipal();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            CentralizarPanelPrincipal();
        }

        private void CentralizarPanelPrincipal()
        {
            if (panelPrincipal != null)
            {
                panelVendas.Anchor = AnchorStyles.None;
                panelVendas.Location = new Point(
                    (this.ClientSize.Width - panelVendas.Width) / 2,
                    (this.ClientSize.Height - panelVendas.Height) / 2
                );
            }
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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Carregar dados do estoque
                    MySqlDataAdapter daEstoque = new MySqlDataAdapter("SELECT * FROM v1estoque", conn);
                    DataTable dtEstoque = new DataTable();
                    daEstoque.Fill(dtEstoque);
                    DGV_Estoque.DataSource = dtEstoque;

                    // Carregar dados das entregas
                    MySqlDataAdapter daEntregas = new MySqlDataAdapter("SELECT * FROM v2entregas", conn);
                    DataTable dtEntregas = new DataTable();
                    daEntregas.Fill(dtEntregas);
                    DGV_Entregas.DataSource = dtEntregas;

                    // Ajuste de colunas
                    DGV_Estoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DGV_Entregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        // Função para pesquisar dados no estoque
        private void btnPesquisarEstoque_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisaEstoque.Text;

            if (!string.IsNullOrWhiteSpace(termoPesquisa))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM v1estoque WHERE produto LIKE @termo OR categoria LIKE @termo";
                        MySqlDataAdapter daEstoque = new MySqlDataAdapter(query, conn);
                        daEstoque.SelectCommand.Parameters.AddWithValue("@termo", "%" + termoPesquisa + "%");
                        DataTable dtEstoque = new DataTable();
                        daEstoque.Fill(dtEstoque);

                        DGV_Estoque.DataSource = null; // Limpa os dados anteriores
                        DGV_Estoque.DataSource = dtEstoque;
                    }
                    catch (MySqlException sqlEx)
                    {
                        MessageBox.Show("Erro ao pesquisar no estoque: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro inesperado: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa.");
            }
        }

        // Função para pesquisar dados nas entregas
        private void btnPesquisarEntrega_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisaEntrega.Text;

            if (!string.IsNullOrWhiteSpace(termoPesquisa))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        // Modifique a consulta para incluir nome_cliente e id_pedido
                        string query = "SELECT * FROM v2entregas WHERE cliente LIKE @termo OR pedido LIKE @termo";
                        MySqlDataAdapter daEntregas = new MySqlDataAdapter(query, conn);
                        daEntregas.SelectCommand.Parameters.AddWithValue("@termo", "%" + termoPesquisa + "%");
                        DataTable dtEntregas = new DataTable();
                        daEntregas.Fill(dtEntregas);

                        DGV_Entregas.DataSource = null; // Limpa os dados anteriores
                        DGV_Entregas.DataSource = dtEntregas;
                    }
                    catch (MySqlException sqlEx)
                    {
                        MessageBox.Show("Erro ao pesquisar nas entregas: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro inesperado: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa.");
            }
        }



        // Função para adicionar um novo registro no estoque
        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            string? produto = Prompt.ShowDialog("Produto:", "Adicionar Produto");
            string? qtd_total = Prompt.ShowDialog("Quantidade Total:", "Adicionar Produto");
            string? categoria = Prompt.ShowDialog("Categoria:", "Adicionar Produto");

            if (!string.IsNullOrWhiteSpace(produto) && !string.IsNullOrWhiteSpace(qtd_total) && !string.IsNullOrWhiteSpace(categoria))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO v1estoque (produto, qtd_total, categoria) VALUES (@produto, @qtd_total, @categoria)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@produto", produto);
                    cmd.Parameters.AddWithValue("@qtd_total", qtd_total);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.ExecuteNonQuery();
                }
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
        }
        private void btnEditarEstoque_Click(object sender, EventArgs e)
        {
            if (DGV_Estoque.SelectedRows.Count > 0)
            {
                // Obter o id da linha selecionada
                string id = DGV_Estoque.SelectedRows[0].Cells[0].Value?.ToString();

                // Pedir os novos dados
                string? produto = Prompt.ShowDialog("Novo Produto:", "Editar Produto");
                string? qtd_total = Prompt.ShowDialog("Nova Quantidade Total:", "Editar Produto");
                string? categoria = Prompt.ShowDialog("Nova Categoria:", "Editar Produto");

                if (!string.IsNullOrWhiteSpace(produto) && !string.IsNullOrWhiteSpace(qtd_total) && !string.IsNullOrWhiteSpace(categoria))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE v1estoque SET produto = @produto, qtd_total = @qtd_total, categoria = @categoria WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@produto", produto);
                        cmd.Parameters.AddWithValue("@qtd_total", qtd_total);
                        cmd.Parameters.AddWithValue("@categoria", categoria);
                        cmd.Parameters.AddWithValue("@id", id);
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


        // Função para excluir um registro do estoque
        private void btnExcluirEstoque_Click(object sender, EventArgs e)
        {
            if (DGV_Estoque.SelectedRows.Count > 0)
            {
                string? id = DGV_Estoque.SelectedRows[0].Cells[0].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(id))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM v1estoque WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
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

        // Função para adicionar uma nova entrega
        private void btnAdicionarEntrega_Click(object sender, EventArgs e)
        {
            string? entrega = Prompt.ShowDialog("Entrega:", "Adicionar Entrega");
            string? situacao = Prompt.ShowDialog("Situação:", "Adicionar Entrega");
            string? cod_rastreio = Prompt.ShowDialog("Código de Rastreio:", "Adicionar Entrega");
            string? cliente = Prompt.ShowDialog("Cliente:", "Adicionar Entrega");
            string? totalPagamento = Prompt.ShowDialog("Total de Pagamento:", "Adicionar Entrega");
            string? pagamento = Prompt.ShowDialog("Pagamento:", "Adicionar Entrega");

            if (!string.IsNullOrWhiteSpace(entrega) && !string.IsNullOrWhiteSpace(situacao) && !string.IsNullOrWhiteSpace(cod_rastreio) &&
                !string.IsNullOrWhiteSpace(cliente) && !string.IsNullOrWhiteSpace(totalPagamento) && !string.IsNullOrWhiteSpace(pagamento))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO v2entregas (entrega, situacao, cod_rastreio, cliente, total_pagamento, pagamento) VALUES (@entrega, @situacao, @cod_rastreio, @cliente, @totalPagamento, @pagamento)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@entrega", entrega);
                    cmd.Parameters.AddWithValue("@situacao", situacao);
                    cmd.Parameters.AddWithValue("@cod_rastreio", cod_rastreio);
                    // Removido: cmd.Parameters.AddWithValue("@dataPed", dataPed); - não é mais necessário
                    cmd.Parameters.AddWithValue("@cliente", cliente);
                    cmd.Parameters.AddWithValue("@totalPagamento", totalPagamento);
                    cmd.Parameters.AddWithValue("@pagamento", pagamento);
                    cmd.ExecuteNonQuery();
                }
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
        }

        private void btnEditarEntrega_Click(object sender, EventArgs e)
        {
            if (DGV_Entregas.SelectedRows.Count > 0)
            {
                // Obter o pedido da linha selecionada
                string pedido = DGV_Entregas.SelectedRows[0].Cells["pedido"].Value?.ToString();

                // Pedir os novos dados
                string? entrega = Prompt.ShowDialog("Nova Entrega:", "Editar Entrega");
                string? situacao = Prompt.ShowDialog("Nova Situação:", "Editar Entrega");
                string? cod_rastreio = Prompt.ShowDialog("Novo Código de Rastreio:", "Editar Entrega");
                string? cliente = Prompt.ShowDialog("Novo Cliente:", "Editar Entrega");
                string? totalPagamento = Prompt.ShowDialog("Novo Total de Pagamento:", "Editar Entrega");
                string? pagamento = Prompt.ShowDialog("Novo Pagamento:", "Editar Entrega");

                if (!string.IsNullOrWhiteSpace(entrega) && !string.IsNullOrWhiteSpace(situacao) &&
                    !string.IsNullOrWhiteSpace(cod_rastreio) && !string.IsNullOrWhiteSpace(cliente) &&
                    !string.IsNullOrWhiteSpace(totalPagamento) && !string.IsNullOrWhiteSpace(pagamento))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE v2entregas SET entrega = @entrega, situacao = @situacao, cod_rastreio = @cod_rastreio, cliente = @cliente, total_pagamento = @totalPagamento, pagamento = @pagamento WHERE pedido = @pedido";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@entrega", entrega);
                        cmd.Parameters.AddWithValue("@situacao", situacao);
                        cmd.Parameters.AddWithValue("@cod_rastreio", cod_rastreio);
                        cmd.Parameters.AddWithValue("@cliente", cliente);
                        cmd.Parameters.AddWithValue("@totalPagamento", totalPagamento);
                        cmd.Parameters.AddWithValue("@pagamento", pagamento);
                        cmd.Parameters.AddWithValue("@pedido", pedido);
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

        // Função para excluir uma entrega
        private void btnExcluirEntrega_Click(object sender, EventArgs e)
        {
            if (DGV_Entregas.SelectedRows.Count > 0)
            {
                // Obter o valor da coluna 'pedido' da linha selecionada
                string? pedido = DGV_Entregas.SelectedRows[0].Cells["pedido"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(pedido))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        // Alterar para usar o nome correto da coluna
                        string query = "DELETE FROM v2entregas WHERE pedido = @pedido";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@pedido", pedido);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarDados(); // Recarrega os dados após a exclusão
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }

    }
}

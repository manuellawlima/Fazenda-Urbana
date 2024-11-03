using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FazendaUrbana
{
    public partial class Relatórios : Form
    {
        private string connectionString = "Server=localhost;Database=gmtfarm;Uid=root;Pwd=12345678;";

        public Relatórios()
        {
            InitializeComponent();
            ConfigurarLayout(); // Chama o método para configurar o layout
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            CentralizarPanelPrincipal();
        }

        private void Relatórios_Load(object sender, EventArgs e)
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

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpDataInicio.Value;
            DateTime endDate = dtpDataFim.Value;

            // Validação das datas
            if (startDate > endDate)
            {
                MessageBox.Show("A data de início não pode ser posterior à data de fim.");
                return;
            }

            // Chama o método para gerar o relatório
            GerarRelatorio(startDate, endDate);
        }

        private void GerarRelatorio(DateTime startDate, DateTime endDate)
        {
            double totalVendas = 0;
            int totalVendasCount = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query para buscar os valores de venda entre as datas
                    string query = "SELECT total_pagamento FROM v2entregas WHERE data_ped BETWEEN @startDate AND @endDate";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            totalVendas += reader.GetDouble("total_pagamento"); // Acumula o total de vendas
                            totalVendasCount++; // Conta quantas vendas foram feitas
                        }
                    }

                    // Atualiza os Labels com o total e a média
                    lblTotalVendas.Text = $"Total de Vendas: R$ {totalVendas:F2}";
                    lblMediaVendas.Text = totalVendasCount > 0
                        ? $"Média de Vendas: R$ {(totalVendas / totalVendasCount):F2}"
                        : "Média de Vendas: R$ 0,00"; // Caso não haja vendas
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar relatório: " + ex.Message);
                }
            }
        }

        private void ConfigurarLayout()
        {
            // Código para configurar o layout do formulário (opcional)
        }
    }
}



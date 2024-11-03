using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FazendaUrbana
{
    public partial class TelaInicial : Form
    {
        // Declaração de uma instância da tela de Produção
        private Producao telaProducao;

        public TelaInicial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            CentralizarPanelPrincipal();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
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

        private void lblDesconectar_Click(object sender, EventArgs e)
        {
            // Confirmação de logout
            var resultado = MessageBox.Show("Tem certeza que deseja desconectar?", "Desconectar-se", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cria uma nova instância do formulário de login
                Login loginForm = new Login();
                loginForm.Show(); // Exibe o formulário de login

                // Fecha o formulário atual (a tela inicial)
                this.Close(); // Fecha o formulário ao invés de ocultar
            }
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            // Se a tela já estiver aberta, fecha para "reiniciar"
            if (telaProducao != null && !telaProducao.IsDisposed)
            {
                telaProducao.Close();
            }

            // Cria uma nova instância da tela de Produção
            telaProducao = new Producao();
            telaProducao.Show();
        }
        private Fornecedores telaFornecedores;

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Se a tela já estiver aberta, fecha para "reiniciar"
                    if (telaFornecedores != null && !telaFornecedores.IsDisposed)
                    {
                        telaFornecedores.Close();
                    }

                    // Cria uma nova instância da tela de Fornecedores
                    telaFornecedores = new Fornecedores();
                    telaFornecedores.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir a tela de Fornecedores: " + ex.Message);
                }
            }
        }
        private Vendas telaVendas;
        private void btnVendas_Click(object sender, EventArgs e)
        {
            // Se a tela de vendas já estiver aberta, fecha para "reiniciar"
            if (telaVendas != null && !telaVendas.IsDisposed)
            {
                telaVendas.Close();
            }

            // Cria uma nova instância da tela de Vendas
            telaVendas = new Vendas();
            telaVendas.Show();
        }

        private Relatórios telaRelatórios;
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if(telaRelatórios != null && !telaRelatórios.IsDisposed)
            {
                telaRelatórios.Close();
            }

            // Cria uma nova instância para a tela de Relatórios
            telaRelatórios = new Relatórios();
            telaRelatórios .Show();
        }
    }
}

using System.Diagnostics;
namespace SisPadoca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Local = DateTime.Now;
            TssDataHora.Text = Local.ToString();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes CadClientes = new FrmClientes();
            CadClientes.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciação de objetos
            FrmProdutos CadProdutos = new FrmProdutos();
            CadProdutos.StartPosition = FormStartPosition.CenterScreen;
            // CadProdutos.WindowState = FormWindowState.Maximized;
            CadProdutos.ShowDialog();
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "chrome",
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
                string[] caminhos =
                {
        @"C:\Program Files\Google\Chrome\Application\chrome.exe",
        @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
    };

                foreach (var caminho in caminhos)
                {
                    if (System.IO.File.Exists(caminho))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = caminho,
                            UseShellExecute = true
                        });
                        return;
                    }
                }

                MessageBox.Show("Google Chrome não encontrado neste computador.");
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "notepad.exe",
                UseShellExecute = true
            });
        }
    }
}

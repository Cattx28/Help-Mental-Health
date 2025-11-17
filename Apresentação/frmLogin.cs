using Dados;
using Negocio;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Apresentação
{
    public partial class frmLogin : Form
    {
        private readonly ModeradorService _moderadorService;

        private bool ImagensIguais(Image img1, Image img2)
        {
            // Verifica se as imagens são nulas
            if (img1 == null || img2 == null)
                return false;
            // Verifica se as dimensões das imagens são diferentes
            if (img1.Width != img2.Width || img1.Height != img2.Height)
                return false;
            // Cria bitmap para comparação
            Bitmap bmp1 = new Bitmap(img1);
            Bitmap bmp2 = new Bitmap(img2);
            // Compara pixel a pixel
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        return false;
                }
            }
            return true; // As imagens são iguais
        }

        public frmLogin()
        {
            InitializeComponent();
            _moderadorService = new ModeradorService();
            imgOlho.Image = Properties.Resources.olho;
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (_moderadorService.acessar(login, senha)) // Envia a senha em texto puro
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

                // Login bem-sucedido - mostrar formulário principal
                var mainForm = new frmInicial();

               /* // Configurar para encerrar aplicação quando o mainForm fechar
                mainForm.FormClosed += (s, e) => Application.Exit();*/

                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos!", "ERRO!",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgOlho_Click(object sender, EventArgs e)
        {
            if (ImagensIguais(imgOlho.Image, Properties.Resources.olho))
            {
            imgOlho.Image = Properties.Resources.estrabismo;
            txtSenha.UseSystemPasswordChar = false;
            }
             else
             {
                 imgOlho.Image = Properties.Resources.olho;
                 txtSenha.UseSystemPasswordChar = true;
             }
        }
    }
}


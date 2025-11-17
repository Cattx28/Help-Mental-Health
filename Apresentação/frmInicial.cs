using ZstdSharp.Unsafe;
using System.Net.Mail;

namespace Apresentação
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private List<Form> filhos = new List<Form>();

        private void Posicao(Form filho)
        {
            filho.Size = new Size(this.ClientSize.Width - panel1.Width - 5, this.ClientSize.Height - panel2.Height - 5);
            filho.Location = new Point(panel1.Width, 0);
        }


        private void btnModerador_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmModerador>().Count() == 0)
            {
                frmModerador filhoMod = new(this);
                filhoMod.MdiParent = this;
                filhos.Add(filhoMod);
                filhoMod.Show();

                Posicao(filhoMod);
            }
            else
            {
                frmModerador filhoMod = Application.OpenForms.OfType<frmModerador>().First();
                filhoMod.BringToFront();
                Posicao(filhoMod);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmUsuario>().Count() == 0)
            {
                frmUsuario filhoUser = new(this);
                filhoUser.MdiParent = this;
                filhos.Add(filhoUser);
                filhoUser.Show();

                Posicao(filhoUser);
            }
            else
            {
                frmUsuario filhoUser = Application.OpenForms.OfType<frmUsuario>().First();
                filhoUser.BringToFront();
                Posicao(filhoUser);
            }
        }

        private void btnPsicologos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPsicologo>().Count() == 0)
            {
                frmPsicologo filhoPsi = new(this);
                filhoPsi.MdiParent = this;
                filhos.Add(filhoPsi);
                filhoPsi.Show();

                Posicao(filhoPsi);
            }
            else
            {
                frmPsicologo filhoPsi = Application.OpenForms.OfType<frmPsicologo>().First();
                filhoPsi.BringToFront();
                Posicao(filhoPsi);
            }
        }

        private void btnDenuncias_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmDenuncia>().Count() == 0)
            {
                frmDenuncia filhoDenuncia = new(this);
                filhoDenuncia.MdiParent = this;
                filhos.Add(filhoDenuncia);
                filhoDenuncia.Show();

                Posicao(filhoDenuncia);
            }
            else
            {
                frmDenuncia filhoDenuncia = Application.OpenForms.OfType<frmDenuncia>().First();
                filhoDenuncia.BringToFront();
                Posicao(filhoDenuncia);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmDashboard>().Count() == 0)
            {
                FrmDashboard filhoDashboard = new(this);
                filhoDashboard.MdiParent = this;
                filhos.Add(filhoDashboard);
                filhoDashboard.Show();

                Posicao(filhoDashboard);
            }
            else
            {
                FrmDashboard filhoDashboard = Application.OpenForms.OfType<FrmDashboard>().First();
                filhoDashboard.BringToFront();
                Posicao(filhoDashboard);
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmLogs>().Count() == 0)
            {
                frmLogs filhoLogs = new(this);
                filhoLogs.MdiParent = this;
                filhos.Add(filhoLogs);
                filhoLogs.Show();

                Posicao(filhoLogs);
            }
            else
            {
                frmLogs filhoLogs = Application.OpenForms.OfType<frmLogs>().First();
                filhoLogs.BringToFront();
                Posicao(filhoLogs);
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPerfil>().Count() == 0)
            {
                frmPerfil filhoPerfil = new(this);
                filhoPerfil.MdiParent = this;
                filhos.Add(filhoPerfil);
                filhoPerfil.Show();

                Posicao(filhoPerfil);
            }
            else
            {
                frmPerfil filhoPerfil = Application.OpenForms.OfType<frmPerfil>().First();
                filhoPerfil.BringToFront();
                Posicao(filhoPerfil);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            var login = new frmLogin();
            login.Show();

        }
    }
}

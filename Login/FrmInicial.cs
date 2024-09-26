using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmUsuarios>().Count() == 0)
            {
                FrmUsuarios fForn = new FrmUsuarios();
                fForn.MdiParent = this;
                fForn.Show();
            }
            else
            {
                FrmUsuarios fForn = Application.OpenForms.OfType<FrmUsuarios>().First();
                fForn.BringToFront();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPsicologos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmPsicologo>().Count() == 0)
            {
                FrmPsicologo fForn = new FrmPsicologo();
                fForn.MdiParent = this;
                fForn.Show();
            }
            else
            {
                FrmPsicologo fForn = Application.OpenForms.OfType<FrmPsicologo>().First();
                fForn.BringToFront();
            }
        }

        private void btnDenuncias_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmDenuncias>().Count() == 0)
            {
                FrmDenuncias fForn = new FrmDenuncias();
                fForn.MdiParent = this;
                fForn.Show();
            }
            else
            {
                FrmDenuncias fForn = Application.OpenForms.OfType<FrmDenuncias>().First();
                fForn.BringToFront();
            }
        }

        private void btnModerador_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmModerador>().Count() == 0)
            {
                FrmModerador fForn = new FrmModerador();
                fForn.MdiParent = this;
                fForn.Show();
            }
            else
            {
                FrmModerador fForn = Application.OpenForms.OfType<FrmModerador>().First();
                fForn.BringToFront();
            }
        }
    }
}

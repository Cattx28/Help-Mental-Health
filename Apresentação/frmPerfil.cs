using Dados;
using FluentValidation.Results;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Apresentação
{
    public partial class frmPerfil : Form
    {
        private frmInicial parentFrm;

        private int modo = 0;

        private readonly ModeradorService _moderadorService;

        public frmPerfil(frmInicial parent)
        {
            _moderadorService = new ModeradorService();
            InitializeComponent();
            parentFrm = parent;

            Habilita();
        }
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

        private void Habilita()
        {
            switch (modo)
            {
                case 0: //neutro
                    txtEmail.Enabled = false;
                    txtNome.Enabled = false;
                    txtSenha.Enabled = false;
                    txtConfirma.Enabled = false;
                    txtSenha.UseSystemPasswordChar = true;
                    txtConfirma.UseSystemPasswordChar = true;
                    btnAtualizarDados.Visible = true;
                    btnMudarSenha.Visible = true;
                    btnSalvarDados.Visible = false;
                    btnSalvarSenha.Visible = false;
                    btnVoltarDados.Visible = false;
                    btnVoltarSenha.Visible = false;
                    grpDados.Enabled = false;
                    grpSenha.Enabled = false;
                    break;
                case 1: //editar dados
                    txtEmail.Enabled = true;
                    txtNome.Enabled = true;
                    txtSenha.Enabled = false;
                    txtConfirma.Enabled = false;
                    txtSenha.UseSystemPasswordChar = true;
                    txtConfirma.UseSystemPasswordChar = true;
                    btnAtualizarDados.Visible = false;
                    btnMudarSenha.Visible = false;
                    btnSalvarDados.Visible = true;
                    btnSalvarSenha.Visible = false;
                    btnVoltarDados.Visible = true;
                    btnVoltarSenha.Visible = false;
                    grpDados.Enabled = true;
                    grpSenha.Enabled = false;
                    break;
                case 2://editar senha
                    txtEmail.Enabled = false;
                    txtNome.Enabled = false;
                    txtSenha.Enabled = true;
                    txtConfirma.Enabled = true;
                    txtSenha.UseSystemPasswordChar = true;
                    txtConfirma.UseSystemPasswordChar = true;
                    btnAtualizarDados.Visible = false;
                    btnMudarSenha.Visible = false;
                    btnSalvarDados.Visible = false;
                    btnSalvarSenha.Visible = true;
                    btnVoltarDados.Visible = false;
                    btnVoltarSenha.Visible = true;
                    grpDados.Enabled = false;
                    grpSenha.Enabled = true;
                    break;
            }
        }

        private void Salvar()
        {
            int id = 0;
            string nome;
            string email;
            string senha;
            string confirma;

            string resultado;
            string msg;

            Moderador moderador = new Moderador();

            if (string.IsNullOrEmpty(txtId.Text))
                id = 0;
            else
                id = Convert.ToInt32(txtId.Text);

            nome = txtNome.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;
            confirma = txtConfirma.Text;

            string senhaHash = PasswordHasher.HashPassword(senha);

            moderador.nome = nome;
            moderador.email = email;
            moderador.senha = senhaHash;

            //Validator
            if (moderador != null)
            {
                ModeradorValidator validator = new ModeradorValidator();
                FluentValidation.Results.ValidationResult results = validator.Validate(moderador);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Aviso do sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                }
            }


            if (modo == 1)
            {
                resultado = _moderadorService.Update(id, nome, email);
                if (resultado == "SUCESSO")
                {
                    msg = "PERFIL atualizado com sucesso!";
                }
                else
                {
                    msg = "Falha ao atualizar PERFIL!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (modo == 2)
            {
                if (confirma == senha)
                {
                    resultado = _moderadorService.UpdateSenha(id, senhaHash);
                    if (resultado == "SUCESSO")
                    {
                        msg = "SENHA atualizado com sucesso!";
                    }
                    else
                    {
                        msg = "Falha ao atualizar SENHA!";
                    }
                    MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("As senha não são iguais!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            modo = 0;
            Habilita();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(UsuarioLogado.Id);
            txtNome.Text = UsuarioLogado.Nome;
            txtEmail.Text = UsuarioLogado.Email;
        }

        private void btnSalvarSenha_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            modo = 1;
            Habilita();
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtConfirma.Clear();
            txtSenha.Focus();
            modo = 2;
            Habilita();
        }

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void imgOlho1_Click(object sender, EventArgs e)
        {
            if (ImagensIguais(imgOlho1.Image, Properties.Resources.olho))
            {
                imgOlho1.Image = Properties.Resources.estrabismo;
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                imgOlho1.Image = Properties.Resources.olho;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void imgOlho2_Click(object sender, EventArgs e)
        {
            if (ImagensIguais(imgOlho2.Image, Properties.Resources.olho))
            {
                imgOlho2.Image = Properties.Resources.estrabismo;
                txtConfirma.UseSystemPasswordChar = false;
            }
            else
            {
                imgOlho2.Image = Properties.Resources.olho;
                txtConfirma.UseSystemPasswordChar = true;
            }
        }
    }
}

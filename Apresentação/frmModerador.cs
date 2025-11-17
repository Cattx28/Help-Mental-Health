using Dados;
using FluentValidation.Results;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Negocio;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Apresentação
{
    public partial class frmModerador : Form
    {
        private readonly ModeradorService _moderadorService;
        private readonly LogsService _logsService;
        private DataTable tblModerador = new DataTable();

        private int modo = 0;
        internal DataTable dt;

        private frmInicial parentForm;

        //Log
        int idModerador = (int)UsuarioLogado.Id;

        public frmModerador(frmInicial parent)
        {
            InitializeComponent();
            _moderadorService = new ModeradorService();
            _logsService = new LogsService();

            ConfiguraDataGridView();
            carregaGridView();
            Habilita();

            parentForm = parent;
        }

        public frmModerador()
        {
        }

        public void EnviarEmail(string email,string assunto, string body)
        {
            try
            {
                var mensagem = new MimeMessage();
                mensagem.From.Add(new MailboxAddress("HelpMentalHealth", "helpmentalhealthhmh@gmail.com"));
                mensagem.To.Add(new MailboxAddress("Moderador(a)", email));
                mensagem.Subject = assunto;
                mensagem.Body = new TextPart("plain") { Text = body };

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (var smtpclient = new SmtpClient())
                {
                    smtpclient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    smtpclient.Authenticate("helpmentalhealthhmh@gmail.com", "ejxn axnb ezxr qczq");

                    smtpclient.Send(mensagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            }

        private void ConfiguraDataGridView()
        {
            // Configuração do DataGridView em um método separado
            dgModerador.ColumnCount = 4;
            dgModerador.AutoGenerateColumns = false;
            dgModerador.Columns[0].Width = 60;
            dgModerador.Columns[0].HeaderText = "ID";
            dgModerador.Columns[0].DataPropertyName = "idModerador";
            dgModerador.Columns[1].Width = 300;
            dgModerador.Columns[1].HeaderText = "NOME";
            dgModerador.Columns[1].DataPropertyName = "nome";
            dgModerador.Columns[2].Width = 325;
            dgModerador.Columns[2].HeaderText = "EMAIL";
            dgModerador.Columns[2].DataPropertyName = "email";
            dgModerador.Columns[3].Width = 220;
            dgModerador.Columns[3].HeaderText = "SENHA";
            dgModerador.Columns[3].DataPropertyName = "senha";

            dgModerador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgModerador.AllowUserToAddRows = false;
            dgModerador.AllowUserToDeleteRows = false;
            dgModerador.AllowUserToOrderColumns = true;
            dgModerador.ReadOnly = true;
        }

        // Método para limpar os campos do formulário
        public void LimpaForm()
        {
            txtNome?.Clear();
            txtEmail?.Clear();
            txtId?.Clear();
            txtSenha?.Clear();

            txtNome?.Focus();
        }

        private void carregaGridView()
        {
            dgModerador.DataSource = _moderadorService.getAll();
            dgModerador.Refresh();
        }

        private void Habilita()
        {
            switch (modo)
            {
                case 0: //neutro
                    txtEmail.Enabled = false;
                    txtSenha.Enabled = false;
                    txtSenha.UseSystemPasswordChar = true;
                    btnAdicionar.Visible = true;
                    btnEditar.Visible = true;
                    btnExcluir.Visible = true;
                    btnSalvar.Visible = false;
                    btnVoltar.Visible = false;
                    grpDados.Enabled = false;
                    dgModerador.Enabled = true;
                    break;
                case 1: //inclusão
                    txtEmail.Enabled = true;
                    txtSenha.Enabled= true;
                    txtSenha.UseSystemPasswordChar = false;
                    btnAdicionar.Visible = false;
                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = true;
                    btnVoltar.Visible = true;
                    grpDados.Enabled = true;
                    dgModerador.Enabled = false;
                    break;
                case 2:
                    txtEmail.Enabled = false;
                    txtSenha.Enabled = false;
                    txtSenha.UseSystemPasswordChar = true;
                    btnAdicionar.Visible = false;
                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = true;
                    btnVoltar.Visible = true;
                    grpDados.Enabled = true;
                    dgModerador.Enabled = false;
                    break;
            }
        }

        private void dgModerador_SelectionChanged(object sender, EventArgs e)
        {
            if (dgModerador.CurrentRow == null) return;

            // Limpando e preenchendo os TextBoxes com os valores da linha selecionada
            txtId.Text = Convert.ToString(dgModerador.CurrentRow.Cells[0].Value);
            txtNome.Text = Convert.ToString(dgModerador.CurrentRow.Cells[1].Value);
            txtEmail.Text = Convert.ToString(dgModerador.CurrentRow.Cells[2].Value);
            txtSenha.Text = Convert.ToString(dgModerador.CurrentRow.Cells[3].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusca busca = new frmBusca();
            busca.ShowDialog();
            int? idBusca = busca.Busca; // Obtém o ID do formulário

            if (idBusca.HasValue)
            {
                DataTable tblModerador = _moderadorService.filterById(idBusca.Value); // Método para buscar por ID
                if (tblModerador != null)
                {
                    dgModerador.DataSource = tblModerador;
                    dgModerador.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Nenhum ID foi informado.");
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            modo = 1;
            Habilita();
            LimpaForm();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = 2;
            Habilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nome;
            string email;
            string senha;

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
                resultado = _moderadorService.Insert(nome, email, senhaHash);

                if (resultado == "SUCESSO")
                {
                    msg = "MODERADOR cadastrado com sucesso!";
                    carregaGridView();

                    EnviarEmail(email, "Novo cadastro Moderador HelpMentalHealth",
                       "Parabéns você acaba de´fazer parte da equipe de moderação do HelpMentalHealth!!!\n\n" +
                       "Acesse seu perfil com nome de login (" + nome + ") ou email (" + email + ") e senha (" + senha + ").\n" +
                       "Mude a senha nas configurações para maior segurança!");

                    _logsService.CriarLog(null, idModerador, "Novo Cadastro MODERADOR", null, "Email cadastrado: " + email);
                }
                else
                {
                    msg = "Falha ao cadastrar MODERADOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (modo == 2)
            {
                resultado = _moderadorService.Update(id, nome, email);

                if (resultado == "SUCESSO")
                {
                    msg = "MODERADOR atualizado com sucesso!";
                    carregaGridView();

                    //Motivo
                    frmMotivo motivo = new frmMotivo();
                    motivo.ShowDialog();
                    string? body ="Por motivos de: " + motivo.Motivo;

                    EnviarEmail(email,"Atualização de conta Moderador HelpMentalHealth", body);

                   _logsService.CriarLog(null, idModerador, "Atualização MODERADOR", id, motivo.Motivo);
                }
                else
                {
                    msg = "Falha ao atualizar MODERADOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            modo = 0;
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma exclusão?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.OK)
            {
                //Motivo
                frmMotivo motivo = new frmMotivo();
                motivo.ShowDialog();
                string? body = "Por motivos de: " + motivo.Motivo;

                EnviarEmail(txtEmail.Text, "Exclusão de conta Moderador HelpMentalHealth", body);

                int.TryParse(txtId.Text, out int id);

                _logsService.CriarLog(null, idModerador, "Exclusão MODERADOR", id,  motivo.Motivo);

                resultado = _moderadorService.Delete(id);

                if (resultado == "SUCESSO")
                {
                    msg = "MODERADOR excluido com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao excluir MODERADOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            carregaGridView();
            modo = 0;
            Habilita();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            dgModerador.DataSource = _moderadorService.getAllAdm();
            dgModerador.Refresh();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            dgModerador.DataSource = _moderadorService.getAllMod();
            dgModerador.Refresh();
        }

        private void btnTornarAdm_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma a ação?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {

                int.TryParse(txtId.Text, out int id);

                resultado = _moderadorService.TornarAdm(id);

                if (resultado == "SUCESSO")
                {
                    msg = "O MODERADOR agora é ADMINISTRADOR!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao tornar MODERADOR em ADMINISTRADOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

using Dados;
using FluentValidation.Results;
using Negocio;
using System.Data;

namespace Apresentação
{
    public partial class frmUsuario : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly LogsService _logsService;

        private DataTable tblUsuario = new DataTable();

        private int modo = 0;
        internal DataTable dt;

        private frmInicial parentForm;

        int idModerador = (int)UsuarioLogado.Id;

        public frmUsuario(frmInicial parent)
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            _logsService = new LogsService();

            ConfiguraDataGridView();
            carregaGridView();
            Habilita();

            parentForm = parent;
        }

        public frmUsuario()
        {
        }

        private void ConfiguraDataGridView()
        {
            // Configuração do DataGridView em um método separado
            dgUsuario.ColumnCount = 3;
            dgUsuario.AutoGenerateColumns = false;
            dgUsuario.Columns[0].Width = 60;
            dgUsuario.Columns[0].HeaderText = "ID";
            dgUsuario.Columns[0].DataPropertyName = "id_usuario";
            dgUsuario.Columns[1].Width = 400;
            dgUsuario.Columns[1].HeaderText = "NOME";
            dgUsuario.Columns[1].DataPropertyName = "nome";
            dgUsuario.Columns[2].Width = 445;
            dgUsuario.Columns[2].HeaderText = "EMAIL";
            dgUsuario.Columns[2].DataPropertyName = "email";

            dgUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuario.AllowUserToAddRows = false;
            dgUsuario.AllowUserToDeleteRows = false;
            dgUsuario.AllowUserToOrderColumns = true;
            dgUsuario.ReadOnly = true;
        }

        // Método para limpar os campos do formulário
        public void LimpaForm()
        {
            txtId?.Clear();
            txtNome?.Clear();
            txtIdade?.Clear();
            txtEmail?.Clear();

            txtNome?.Focus();
        }

        private void carregaGridView()
        {
            dgUsuario.DataSource = _usuarioService.getAll();
            dgUsuario.Refresh();
        }

        private void Habilita()
        {
            switch (modo)
            {
                case 0: //neutro
                    btnInativar.Visible = true;
                    btnEditar.Visible = true;
                    btnExcluir.Visible = true;
                    btnSalvar.Visible = false;
                    btnMostraInativos.Visible = true;
                    grpDados.Enabled = false;
                    dgUsuario.Enabled = true;
                    break;
                case 1: //inclusão
                    btnInativar.Visible = false;
                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = true;
                    btnMostraInativos.Visible= false;
                    grpDados.Enabled = true;
                    dgUsuario.Enabled = false;
                    break;
        }
        }

        private void dgUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuario.CurrentRow == null) return;

            // Limpando e preenchendo os TextBoxes com os valores da linha selecionada
            txtId.Text = Convert.ToString(dgUsuario.CurrentRow.Cells[0].Value);
            txtNome.Text = Convert.ToString(dgUsuario.CurrentRow.Cells[1].Value);
            txtEmail.Text = Convert.ToString(dgUsuario.CurrentRow.Cells[2].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusca busca = new frmBusca();
            busca.ShowDialog();
            int? idBusca = busca.Busca; // Obtém o ID do formulário

            if (idBusca.HasValue)
            {
                DataTable tblUsuario = _usuarioService.filterById(idBusca.Value); // Método para buscar por ID
                if (tblUsuario != null)
                {
                    dgUsuario.DataSource = tblUsuario;
                    dgUsuario.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Nenhum ID foi informado.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = 1;
            Habilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nome;
            int idade = 0;
            string email;
            string senha;

            string resultado;
            string msg;

            Usuario usuario = new Usuario();

            int regAtual = 0;


            if (string.IsNullOrEmpty(txtId.Text))
                id = 0;
            else
                id = Convert.ToInt32(txtId.Text);

            nome = txtNome.Text;
            try
            {
                idade = Convert.ToInt32(txtIdade.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
            email = txtEmail.Text;

            usuario.nome = nome;
            usuario.idade = idade;
            usuario.email = email;

            //Validator
            if (usuario != null)
            {
                UsuarioValidator validator = new UsuarioValidator();
                ValidationResult results = validator.Validate(usuario);
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
                resultado = _usuarioService.Update(id, nome, idade, email);
                if (resultado == "SUCESSO")
                {
                //Motivo
                frmMotivo motivo = new frmMotivo();
                motivo.ShowDialog();
                string? body = "Por motivos de: " + motivo.Motivo;

                frmModerador moderador = new frmModerador();
                moderador.EnviarEmail(email, "Sua Conta no HelpMentalHealth foi atualizada", body);

                _logsService.CriarLog(null, idModerador, "Atualização USUÁRIO", id , motivo.Motivo);

                msg = "USUÁRIO atualizado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao atualizar USUÁRIO!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                frmModerador moderador = new frmModerador();
                moderador.EnviarEmail(txtEmail.Text, "Sua Conta no HelpMentalHealth foi excluída", body);

                int.TryParse(txtId.Text, out int id);

                _logsService.CriarLog(null, idModerador, "Exclusão USUÁRIO", id, motivo.Motivo);

                resultado = _usuarioService.Delete(id);

                if (resultado == "SUCESSO")
                {
                    msg = "USUÁRIO excluido com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao excluir USUÁRIO!";
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

        private void btnInativar_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma inativação?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {

                int.TryParse(txtId.Text, out int id);

                resultado = _usuarioService.Inative(id);

                //Motivo
                frmMotivo motivo = new frmMotivo();
                motivo.ShowDialog();
                string? body = "Por motivos de: " + motivo.Motivo;

                frmModerador moderador = new frmModerador();
                moderador.EnviarEmail(txtEmail.Text, "Sua Conta no HelpMentalHealth foi inativada", body);

                _logsService.CriarLog(null, idModerador, "Inativação USUÁRIO", id, motivo.Motivo);


                if (resultado == "SUCESSO")
                {
                    msg = "USUÁRIO inativado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao inativar USUÁRIO!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostraInativos_Click(object sender, EventArgs e)
        {
            dgUsuario.DataSource = _usuarioService.GetAllInativos();
            dgUsuario.Refresh();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

using Dados;
using FluentValidation.Results;
using Negocio;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Apresentação
{
    public partial class frmPsicologo : Form
    {
        private readonly PsicologoService _psicologoService;
        private readonly LogsService _logsService;
        private DataTable tblPsicologo = new DataTable();

        private int modo = 0;
        internal DataTable dt;

        private frmInicial parentForm;

        int idModerador = (int)UsuarioLogado.Id;

        public frmPsicologo(frmInicial parent)
        {
            InitializeComponent();
            _psicologoService = new PsicologoService();
            _logsService = new LogsService();

            ConfiguraDataGridView();
            carregaGridView();
            Habilita();

            parentForm = parent;
        }

        private void ConfiguraDataGridView()
        {
            // Configuração do DataGridView em um método separado
            dgPsicologo.ColumnCount = 5;
            dgPsicologo.AutoGenerateColumns = false;
            dgPsicologo.Columns[0].Width = 60;
            dgPsicologo.Columns[0].HeaderText = "ID";
            dgPsicologo.Columns[0].DataPropertyName = "id_psicologo";
            dgPsicologo.Columns[1].Width = 240;
            dgPsicologo.Columns[1].HeaderText = "NOME";
            dgPsicologo.Columns[1].DataPropertyName = "nome";
            dgPsicologo.Columns[2].Width = 220;
            dgPsicologo.Columns[2].HeaderText = "CPF";
            dgPsicologo.Columns[2].DataPropertyName = "cpf";
            dgPsicologo.Columns[3].Width = 85;
            dgPsicologo.Columns[3].HeaderText = "ESTADO";
            dgPsicologo.Columns[3].DataPropertyName = "estado";
            dgPsicologo.Columns[4].Width = 300;
            dgPsicologo.Columns[4].HeaderText = "EMAIL";
            dgPsicologo.Columns[4].DataPropertyName = "email";

            dgPsicologo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPsicologo.AllowUserToAddRows = false;
            dgPsicologo.AllowUserToDeleteRows = false;
            dgPsicologo.AllowUserToOrderColumns = true;
            dgPsicologo.ReadOnly = true;
        }

        // Método para limpar os campos do formulário
        public void LimpaForm()
        {
            txtId?.Clear();
            txtNome?.Clear();
            txtCpf?.Clear();
            txtRegiao?.Clear();
            txtEmail?.Clear();

            txtNome?.Focus();
        }

        private void carregaGridView()
        {
            dgPsicologo.DataSource = _psicologoService.getAll();
            dgPsicologo.Refresh();
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
                    dgPsicologo.Enabled = true;
                    break;
                case 1: //inclusão
                    btnInativar.Visible = false;
                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = true;
                    btnMostraInativos.Visible = true;
                    grpDados.Enabled = true;
                    dgPsicologo.Enabled = false;
                    break;
            }
        }

        private void dgPsicologo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPsicologo.CurrentRow == null) return;

            // Limpando e preenchendo os TextBoxes com os valores da linha selecionada
            txtId.Text = Convert.ToString(dgPsicologo.CurrentRow.Cells[0].Value);
            txtNome.Text = Convert.ToString(dgPsicologo.CurrentRow.Cells[1].Value);
            txtCpf.Text = Convert.ToString(dgPsicologo.CurrentRow.Cells[2].Value);
            txtRegiao.Text = Convert.ToString(dgPsicologo.CurrentRow.Cells[3].Value);
            txtEmail.Text = Convert.ToString(dgPsicologo.CurrentRow.Cells[4].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusca busca = new frmBusca();
            busca.ShowDialog();
            int? idBusca = busca.Busca; // Obtém o ID do formulário

            if (idBusca.HasValue)
            {
                DataTable tblPsicologo = _psicologoService.filterById(idBusca.Value); // Método para buscar por ID
                if (tblPsicologo != null)
                {
                    dgPsicologo.DataSource = tblPsicologo;
                    dgPsicologo.Refresh();
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
            string cpf;
            string regiao;
            string cidade;
            string email;
            string senha;

            string resultado;
            string msg;

            Psicologo psicologo = new Psicologo();

            int regAtual = 0;


            if (string.IsNullOrEmpty(txtId.Text))
                id = 0;
            else
                id = Convert.ToInt32(txtId.Text);

            nome = txtNome.Text;
            email = txtEmail.Text;
            cpf = txtCpf.Text;
            regiao = txtRegiao.Text;

            psicologo.nome = nome;
            psicologo.cpf = cpf;
            psicologo.regiao = regiao;
            psicologo.email = email;

           
            //Validator
            if (psicologo != null)
            {
                PsicologoValidator validator = new PsicologoValidator();
                FluentValidation.Results.ValidationResult results = validator.Validate(psicologo);
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

            resultado = _psicologoService.Update(id, nome, cpf, regiao, email);
            if (resultado == "SUCESSO")
            {
                //Motivo
                frmMotivo motivo = new frmMotivo();
                motivo.ShowDialog();
                string? body = "Por motivos de: " + motivo.Motivo;

                frmModerador moderador = new frmModerador();
                moderador.EnviarEmail(email, "Sua Conta no HelpMentalHealth foi atualizada", body);

                _logsService.CriarLog(null, idModerador, "Atualização PSICÓLOGO", id, motivo.Motivo);

                msg = "PSICOLOGO atualizado com sucesso!";
                carregaGridView();
            }
            else
            {
                msg = "Falha ao atualizar PSICOLOGO!";
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

                _logsService.CriarLog(null, idModerador, "Exclusão PSICÓLOGO", id, motivo.Motivo);

                resultado = _psicologoService.Delete(id);

                if (resultado == "SUCESSO")
                {
                    msg = "PSICOLOGO excluido com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao excluir PSICOLOGO!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            modo = 0;
            Habilita();
            carregaGridView();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma inativação?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {
                //Motivo
                frmMotivo motivo = new frmMotivo();
                motivo.ShowDialog();
                string? body = "Por motivos de: " + motivo.Motivo;

                frmModerador moderador = new frmModerador();
                moderador.EnviarEmail(txtEmail.Text, "Sua Conta no HelpMentalHealth foi inativada", body);

                int.TryParse(txtId.Text, out int id);

                _logsService.CriarLog(null, idModerador, "Inativação PSICÓLOGO", id, motivo.Motivo);

                resultado = _psicologoService.Inative(id);

                if (resultado == "SUCESSO")
                {
                    msg = "PSICOLOGO inativado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao inativar PSICOLOGO!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostraInativos_Click(object sender, EventArgs e)
        {
            dgPsicologo.DataSource = _psicologoService.GetAllInativos();
            dgPsicologo.Refresh();
        }
    }
}

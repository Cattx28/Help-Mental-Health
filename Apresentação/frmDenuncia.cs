using Dados;
using Negocio;
using Org.BouncyCastle.Asn1.Cmp;
using System.Data;

namespace Apresentação
{
    public partial class frmDenuncia : Form
    {
        private readonly DenunciaService _denunciaService;
        private DataTable tblDenuncia = new DataTable();

        private int modo = 0;
        internal DataTable dt;

        private frmInicial parentForm;

        public frmDenuncia(frmInicial parent)
        {
            InitializeComponent();
            _denunciaService = new DenunciaService();
            dgDenuncia.ColumnCount = 4;
            parentForm = parent;
        }

        public frmDenuncia()
        {
        }

        private void ConfiguraDataGridViewMensagem()
        {
            // Configuração do DataGridView em um método separado
            dgDenuncia.AutoGenerateColumns = false;
            dgDenuncia.Columns[0].Width = 75;
            dgDenuncia.Columns[0].HeaderText = "Id";
            dgDenuncia.Columns[0].DataPropertyName = "idConversaDefinitiva";
            dgDenuncia.Columns[1].Width = 300;
            dgDenuncia.Columns[1].HeaderText = "Usuário";
            dgDenuncia.Columns[1].DataPropertyName = "usuario";
            dgDenuncia.Columns[2].Width = 75;
            dgDenuncia.Columns[2].HeaderText = "Psicólogo";
            dgDenuncia.Columns[2].DataPropertyName = "psicologo";
            dgDenuncia.Columns[3].Width = 170;
            dgDenuncia.Columns[3].HeaderText = "Denuncia";
            dgDenuncia.Columns[3].DataPropertyName = "denuncia_do_usuario";

            dgDenuncia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDenuncia.AllowUserToAddRows = false;
            dgDenuncia.AllowUserToDeleteRows = false;
            dgDenuncia.AllowUserToOrderColumns = true;
            dgDenuncia.ReadOnly = true;
        }

        public void ConfiguraDataGridViewResposta()
        {
            dgDenuncia.AutoGenerateColumns = false;
            dgDenuncia.Columns[0].Width = 75;
            dgDenuncia.Columns[0].HeaderText = "Id";
            dgDenuncia.Columns[0].DataPropertyName = "idConversaDefinitiva";
            dgDenuncia.Columns[1].Width = 300;
            dgDenuncia.Columns[1].HeaderText = "Usuário";
            dgDenuncia.Columns[1].DataPropertyName = "usuario";
            dgDenuncia.Columns[2].Width = 75;
            dgDenuncia.Columns[2].HeaderText = "Psicólogo";
            dgDenuncia.Columns[2].DataPropertyName = "psicologo";
            dgDenuncia.Columns[3].Width = 170;
            dgDenuncia.Columns[3].HeaderText = "Denúncia";
            dgDenuncia.Columns[3].DataPropertyName = "denuncia_do_psicologo";

        }

        public void ConfiguraDataGridViewPostagem()
        {
            dgDenuncia.AutoGenerateColumns = false;
            dgDenuncia.Columns[0].Width = 75;
            dgDenuncia.Columns[0].HeaderText = "ID";
            dgDenuncia.Columns[0].DataPropertyName = "idDenuncia_Postagem";
            dgDenuncia.Columns[1].Width = 300;
            dgDenuncia.Columns[1].HeaderText = "MOTIVO";
            dgDenuncia.Columns[1].DataPropertyName = "motivo";
            dgDenuncia.Columns[2].Width = 75;
            dgDenuncia.Columns[2].HeaderText = "ID POSTAGEM";
            dgDenuncia.Columns[2].DataPropertyName = "postagem";
            dgDenuncia.Columns[3].Width = 170;
            dgDenuncia.Columns[3].HeaderText = "TÌTULO";
            dgDenuncia.Columns[3].DataPropertyName = "titulo";
            dgDenuncia.Columns[4].Width = 75;
            dgDenuncia.Columns[4].HeaderText = "ID AUTOR";
            dgDenuncia.Columns[4].DataPropertyName = "autor";

        }

        private void carregaGridViewMensagem()
        {
            dgDenuncia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDenuncia.AllowUserToAddRows = false;
            dgDenuncia.AllowUserToDeleteRows = false;
            dgDenuncia.AllowUserToOrderColumns = true;
            dgDenuncia.ReadOnly = true;

            dgDenuncia.DataSource = _denunciaService.getAllMensagem();
            dgDenuncia.Refresh();
        }
        private void carregaGridViewResposta()

        {
            dgDenuncia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDenuncia.AllowUserToAddRows = false;
            dgDenuncia.AllowUserToDeleteRows = false;
            dgDenuncia.AllowUserToOrderColumns = true;
            dgDenuncia.ReadOnly = true;

            dgDenuncia.DataSource = _denunciaService.getAllResposta();
            dgDenuncia.Refresh();
        }

        private void carregaGridViewPostagens()

        {
            dgDenuncia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDenuncia.AllowUserToAddRows = false;
            dgDenuncia.AllowUserToDeleteRows = false;
            dgDenuncia.AllowUserToOrderColumns = true;
            dgDenuncia.ReadOnly = true;

            dgDenuncia.DataSource = _denunciaService.getAllPostagem();
            dgDenuncia.Refresh();
        }

        private void dgDenuncia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDenuncia.CurrentRow == null) return;

            // Limpando e preenchendo os TextBoxes com os valores da linha selecionada
            txtId.Text = Convert.ToString(dgDenuncia.CurrentRow.Cells[3].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string resultado;
            string msg;

            DialogResult resposta;
            resposta = MessageBox.Show("Confirma exclusão?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.OK)
            {

                int.TryParse(txtId.Text, out int id);

                if (modo == 1)
                {
                    resultado = _denunciaService.DeleteMensagem(id);

                    if (resultado == "SUCESSO")
                    {
                        msg = "MENSAGEM excluida com sucesso!";
                        carregaGridViewMensagem();
                    }
                    else
                    {
                        msg = "Falha ao excluir MENSAGEM!";
                    }
                    MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (modo == 2)
                {

                    resultado = _denunciaService.DeleteResposta(id);

                    if (resultado == "SUCESSO")
                    {
                        msg = "MENSAGEM excluida com sucesso!";
                        carregaGridViewResposta();
                    }
                    else
                    {
                        msg = "Falha ao excluir MENSAGEM!";
                    }
                    MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            ConfiguraDataGridViewMensagem();
            modo = 1;
            carregaGridViewMensagem();
        }

        private void btnRespostas_Click(object sender, EventArgs e)
        {
            ConfiguraDataGridViewResposta();
            modo = 2;
            carregaGridViewResposta();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusca busca = new frmBusca();
            busca.ShowDialog();
            int? idBusca = busca.Busca; // Obtém o ID do formulário

            if (modo == 1)
            {
                if (idBusca.HasValue)
                {
                    DataTable tblDenuncia = _denunciaService.filterByIdMensagem(idBusca.Value); // Método para buscar por ID
                    if (tblDenuncia != null)
                    {
                        dgDenuncia.DataSource = tblDenuncia;
                        dgDenuncia.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum ID foi informado.");
                }
            }
            else if (modo == 2)
            {
                if (idBusca.HasValue)
                {
                    DataTable tblDenuncia = _denunciaService.filterByIdResposta(idBusca.Value); // Método para buscar por ID
                    if (tblDenuncia != null)
                    {
                        dgDenuncia.DataSource = tblDenuncia;
                        dgDenuncia.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum ID foi informado.");
                }
            }
        }


        private void btnPostagens_Click(object sender, EventArgs e)
        {
            ConfiguraDataGridViewPostagem();
            modo = 1;
            carregaGridViewPostagens();
        }
    }
}

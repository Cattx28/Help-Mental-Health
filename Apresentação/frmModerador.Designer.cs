namespace Apresentação
{
    partial class frmModerador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModerador));
            dgModerador = new DataGridView();
            grpDados = new GroupBox();
            txtSenha = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnVoltar = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgModerador).BeginInit();
            grpDados.SuspendLayout();
            SuspendLayout();
            // 
            // dgModerador
            // 
            dataGridViewCellStyle21.BackColor = Color.FromArgb(180, 202, 232);
            dataGridViewCellStyle21.ForeColor = Color.FromArgb(19, 62, 112);
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(104, 160, 205);
            dataGridViewCellStyle21.SelectionForeColor = Color.FromArgb(19, 62, 112);
            dgModerador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dgModerador.BackgroundColor = Color.FromArgb(208, 226, 241);
            dgModerador.BorderStyle = BorderStyle.None;
            dgModerador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(38, 68, 102);
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(30, 99, 159);
            dataGridViewCellStyle22.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dgModerador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dgModerador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(108, 138, 182);
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(64, 118, 166);
            dataGridViewCellStyle23.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            dgModerador.DefaultCellStyle = dataGridViewCellStyle23;
            dgModerador.EnableHeadersVisualStyles = false;
            dgModerador.GridColor = Color.FromArgb(208, 226, 241);
            dgModerador.Location = new Point(33, 207);
            dgModerador.Name = "dgModerador";
            dgModerador.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dgModerador.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dgModerador.RowHeadersVisible = false;
            dgModerador.RowHeadersWidth = 51;
            dgModerador.Size = new Size(1035, 525);
            dgModerador.TabIndex = 0;
            dgModerador.SelectionChanged += dgModerador_SelectionChanged;
            // 
            // grpDados
            // 
            grpDados.BackColor = Color.FromArgb(208, 226, 241);
            grpDados.Controls.Add(txtSenha);
            grpDados.Controls.Add(label5);
            grpDados.Controls.Add(txtEmail);
            grpDados.Controls.Add(label4);
            grpDados.Controls.Add(txtNome);
            grpDados.Controls.Add(label2);
            grpDados.Controls.Add(txtId);
            grpDados.Controls.Add(label1);
            grpDados.FlatStyle = FlatStyle.System;
            grpDados.Location = new Point(30, 30);
            grpDados.Name = "grpDados";
            grpDados.Size = new Size(958, 155);
            grpDados.TabIndex = 1;
            grpDados.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(208, 226, 241);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(38, 68, 102);
            txtSenha.Location = new Point(642, 113);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(254, 30);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.FromArgb(38, 68, 102);
            label5.Location = new Point(571, 113);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 27;
            label5.Text = "SENHA:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(208, 226, 241);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(38, 68, 102);
            txtEmail.Location = new Point(71, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(494, 30);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(38, 68, 102);
            label4.Location = new Point(2, 113);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 25;
            label4.Text = "EMAIL:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(208, 226, 241);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(38, 68, 102);
            txtNome.Location = new Point(71, 67);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(825, 30);
            txtNome.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(38, 68, 102);
            label2.Location = new Point(2, 67);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 21;
            label2.Text = "NOME:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(208, 226, 241);
            txtId.BorderStyle = BorderStyle.None;
            txtId.Cursor = Cursors.No;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Semibold", 12.7000008F, FontStyle.Bold);
            txtId.ForeColor = Color.FromArgb(38, 68, 102);
            txtId.Location = new Point(35, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 29);
            txtId.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(38, 68, 102);
            label1.Location = new Point(2, 10);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 19;
            label1.Text = "ID: ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(19, 62, 112);
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(19, 62, 112);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(997, 126);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(71, 50);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Green;
            btnAdicionar.FlatStyle = FlatStyle.Popup;
            btnAdicionar.Font = new Font("Segoe UI Semilight", 12F);
            btnAdicionar.ForeColor = Color.FromArgb(226, 239, 239);
            btnAdicionar.Location = new Point(33, 748);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(335, 40);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(192, 0, 0);
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI Semilight", 12F);
            btnExcluir.ForeColor = Color.FromArgb(226, 239, 239);
            btnExcluir.Location = new Point(383, 748);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(335, 40);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(19, 62, 112);
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI Semilight", 12F);
            btnEditar.ForeColor = Color.FromArgb(226, 239, 239);
            btnEditar.Location = new Point(733, 748);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(335, 40);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(19, 62, 112);
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.FromArgb(226, 239, 239);
            btnSalvar.Location = new Point(31, 748);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(941, 40);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(19, 62, 112);
            btnVoltar.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.FromArgb(226, 239, 239);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(985, 748);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(83, 40);
            btnVoltar.TabIndex = 5;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // frmModerador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1090, 800);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(grpDados);
            Controls.Add(dgModerador);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmModerador";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmModerador";
            ((System.ComponentModel.ISupportInitialize)dgModerador).EndInit();
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgModerador;
        private GroupBox grpDados;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnVoltar;
        private Button btnBuscar;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private TextBox txtSenha;
        private Label label5;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
namespace Apresentação
{
    partial class frmPsicologo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPsicologo));
            dgPsicologo = new DataGridView();
            grpDados = new GroupBox();
            txtRegiao = new TextBox();
            label7 = new Label();
            txtCpf = new MaskedTextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnInativar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnVoltar = new Button();
            btnMostraInativos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPsicologo).BeginInit();
            grpDados.SuspendLayout();
            SuspendLayout();
            // 
            // dgPsicologo
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(180, 202, 232);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(19, 62, 112);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(104, 160, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(19, 62, 112);
            dgPsicologo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgPsicologo.BackgroundColor = Color.FromArgb(208, 226, 241);
            dgPsicologo.BorderStyle = BorderStyle.None;
            dgPsicologo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 68, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 99, 159);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgPsicologo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgPsicologo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 138, 182);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 118, 166);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgPsicologo.DefaultCellStyle = dataGridViewCellStyle3;
            dgPsicologo.EnableHeadersVisualStyles = false;
            dgPsicologo.GridColor = Color.FromArgb(208, 226, 241);
            dgPsicologo.Location = new Point(33, 207);
            dgPsicologo.Name = "dgPsicologo";
            dgPsicologo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgPsicologo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgPsicologo.RowHeadersVisible = false;
            dgPsicologo.RowHeadersWidth = 51;
            dgPsicologo.Size = new Size(1035, 525);
            dgPsicologo.TabIndex = 0;
            dgPsicologo.SelectionChanged += dgPsicologo_SelectionChanged;
            // 
            // grpDados
            // 
            grpDados.BackColor = Color.FromArgb(208, 226, 241);
            grpDados.Controls.Add(txtRegiao);
            grpDados.Controls.Add(label7);
            grpDados.Controls.Add(txtCpf);
            grpDados.Controls.Add(txtEmail);
            grpDados.Controls.Add(label4);
            grpDados.Controls.Add(label3);
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
            // txtRegiao
            // 
            txtRegiao.BackColor = Color.FromArgb(208, 226, 241);
            txtRegiao.BorderStyle = BorderStyle.FixedSingle;
            txtRegiao.Cursor = Cursors.IBeam;
            txtRegiao.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegiao.ForeColor = Color.FromArgb(38, 68, 102);
            txtRegiao.Location = new Point(81, 111);
            txtRegiao.Name = "txtRegiao";
            txtRegiao.Size = new Size(122, 30);
            txtRegiao.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.FromArgb(38, 68, 102);
            label7.Location = new Point(2, 113);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 30;
            label7.Text = "REGIÃO:";
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.FromArgb(208, 226, 241);
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Cursor = Cursors.IBeam;
            txtCpf.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCpf.ForeColor = Color.FromArgb(38, 68, 102);
            txtCpf.Location = new Point(773, 67);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(124, 30);
            txtCpf.TabIndex = 29;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(208, 226, 241);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(38, 68, 102);
            txtEmail.Location = new Point(281, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(616, 30);
            txtEmail.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(38, 68, 102);
            label4.Location = new Point(209, 113);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 25;
            label4.Text = "EMAIL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(38, 68, 102);
            label3.Location = new Point(727, 67);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 23;
            label3.Text = "CPF:";
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
            txtNome.Size = new Size(649, 30);
            txtNome.TabIndex = 22;
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
            txtId.Font = new Font("Segoe UI Semibold", 12.7000008F, FontStyle.Bold);
            txtId.ForeColor = Color.FromArgb(38, 68, 102);
            txtId.Location = new Point(35, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(44, 29);
            txtId.TabIndex = 20;
            txtId.Text = "1";
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
            btnBuscar.ForeColor = Color.FromArgb(226, 239, 239);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(997, 126);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(71, 50);
            btnBuscar.TabIndex = 7;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnInativar
            // 
            btnInativar.BackColor = Color.Maroon;
            btnInativar.FlatStyle = FlatStyle.Popup;
            btnInativar.Font = new Font("Segoe UI Semilight", 12F);
            btnInativar.ForeColor = Color.FromArgb(226, 239, 239);
            btnInativar.Location = new Point(271, 748);
            btnInativar.Name = "btnInativar";
            btnInativar.Size = new Size(230, 40);
            btnInativar.TabIndex = 2;
            btnInativar.Text = "Inativar";
            btnInativar.UseVisualStyleBackColor = false;
            btnInativar.Click += btnInativar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Maroon;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI Semilight", 12F);
            btnExcluir.ForeColor = Color.FromArgb(226, 239, 239);
            btnExcluir.Location = new Point(33, 748);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(230, 40);
            btnExcluir.TabIndex = 3;
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
            btnEditar.Location = new Point(508, 748);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(230, 40);
            btnEditar.TabIndex = 4;
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
            btnSalvar.Location = new Point(33, 748);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(943, 40);
            btnSalvar.TabIndex = 5;
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
            btnVoltar.Size = new Size(83, 40);
            btnVoltar.TabIndex = 6;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnMostraInativos
            // 
            btnMostraInativos.BackColor = Color.FromArgb(108, 138, 182);
            btnMostraInativos.FlatStyle = FlatStyle.Popup;
            btnMostraInativos.Font = new Font("Segoe UI Semilight", 12F);
            btnMostraInativos.ForeColor = Color.FromArgb(226, 239, 239);
            btnMostraInativos.Location = new Point(746, 748);
            btnMostraInativos.Name = "btnMostraInativos";
            btnMostraInativos.Size = new Size(230, 40);
            btnMostraInativos.TabIndex = 8;
            btnMostraInativos.Text = "Mostrar Inativos";
            btnMostraInativos.UseVisualStyleBackColor = false;
            btnMostraInativos.Click += btnMostraInativos_Click;
            // 
            // frmPsicologo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1090, 800);
            Controls.Add(btnMostraInativos);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnInativar);
            Controls.Add(grpDados);
            Controls.Add(dgPsicologo);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPsicologo";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmPsicologo";
            ((System.ComponentModel.ISupportInitialize)dgPsicologo).EndInit();
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPsicologo;
        private GroupBox grpDados;
        private Button btnInativar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnVoltar;
        private Button btnBuscar;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private MaskedTextBox txtCpf;
        private TextBox txtRegiao;
        private Label label7;
        private Button btnMostraInativos;
    }
}
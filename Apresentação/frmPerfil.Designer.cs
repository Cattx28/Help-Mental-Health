namespace Apresentação
{
    partial class frmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            grpDados = new GroupBox();
            txtId = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtNome = new TextBox();
            label7 = new Label();
            label8 = new Label();
            grpSenha = new GroupBox();
            imgOlho2 = new PictureBox();
            imgOlho1 = new PictureBox();
            txtConfirma = new TextBox();
            label1 = new Label();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAtualizarDados = new Button();
            btnMudarSenha = new Button();
            btnSalvarDados = new Button();
            btnSalvarSenha = new Button();
            btnVoltarDados = new Button();
            btnVoltarSenha = new Button();
            grpDados.SuspendLayout();
            grpSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgOlho2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgOlho1).BeginInit();
            SuspendLayout();
            // 
            // grpDados
            // 
            grpDados.BackColor = Color.FromArgb(208, 226, 241);
            grpDados.Controls.Add(txtId);
            grpDados.Controls.Add(txtEmail);
            grpDados.Controls.Add(label6);
            grpDados.Controls.Add(txtNome);
            grpDados.Controls.Add(label7);
            grpDados.Controls.Add(label8);
            grpDados.FlatStyle = FlatStyle.System;
            grpDados.Location = new Point(32, 30);
            grpDados.Name = "grpDados";
            grpDados.Size = new Size(1024, 219);
            grpDados.TabIndex = 28;
            grpDados.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(384, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 26;
            txtId.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(208, 226, 241);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(38, 68, 102);
            txtEmail.Location = new Point(7, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(998, 30);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.FromArgb(38, 68, 102);
            label6.Location = new Point(3, 144);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 25;
            label6.Text = "Email:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(208, 226, 241);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(38, 68, 102);
            txtNome.Location = new Point(7, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(998, 30);
            txtNome.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.FromArgb(38, 68, 102);
            label7.Location = new Point(2, 67);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 21;
            label7.Text = "Nome:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(38, 68, 102);
            label8.Location = new Point(2, 11);
            label8.Name = "label8";
            label8.Size = new Size(245, 31);
            label8.TabIndex = 19;
            label8.Text = "Informações do Perfil";
            // 
            // grpSenha
            // 
            grpSenha.BackColor = Color.FromArgb(208, 226, 241);
            grpSenha.Controls.Add(imgOlho2);
            grpSenha.Controls.Add(imgOlho1);
            grpSenha.Controls.Add(txtConfirma);
            grpSenha.Controls.Add(label1);
            grpSenha.Controls.Add(txtSenha);
            grpSenha.Controls.Add(label2);
            grpSenha.Controls.Add(label3);
            grpSenha.FlatStyle = FlatStyle.System;
            grpSenha.Location = new Point(32, 341);
            grpSenha.Name = "grpSenha";
            grpSenha.Size = new Size(1024, 221);
            grpSenha.TabIndex = 29;
            grpSenha.TabStop = false;
            // 
            // imgOlho2
            // 
            imgOlho2.Image = Properties.Resources.olho;
            imgOlho2.Location = new Point(968, 176);
            imgOlho2.Name = "imgOlho2";
            imgOlho2.Size = new Size(30, 26);
            imgOlho2.SizeMode = PictureBoxSizeMode.Zoom;
            imgOlho2.TabIndex = 28;
            imgOlho2.TabStop = false;
            imgOlho2.Click += imgOlho2_Click;
            // 
            // imgOlho1
            // 
            imgOlho1.Image = Properties.Resources.olho;
            imgOlho1.Location = new Point(968, 97);
            imgOlho1.Name = "imgOlho1";
            imgOlho1.Size = new Size(30, 26);
            imgOlho1.SizeMode = PictureBoxSizeMode.Zoom;
            imgOlho1.TabIndex = 27;
            imgOlho1.TabStop = false;
            imgOlho1.Click += imgOlho1_Click;
            // 
            // txtConfirma
            // 
            txtConfirma.BackColor = Color.FromArgb(208, 226, 241);
            txtConfirma.BorderStyle = BorderStyle.FixedSingle;
            txtConfirma.Cursor = Cursors.IBeam;
            txtConfirma.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirma.ForeColor = Color.FromArgb(38, 68, 102);
            txtConfirma.Location = new Point(6, 174);
            txtConfirma.Name = "txtConfirma";
            txtConfirma.Size = new Size(997, 30);
            txtConfirma.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.FromArgb(38, 68, 102);
            label1.Location = new Point(3, 146);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 25;
            label1.Text = "Confirmar Senha:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(208, 226, 241);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(38, 68, 102);
            txtSenha.Location = new Point(6, 95);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(997, 30);
            txtSenha.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(38, 68, 102);
            label2.Location = new Point(2, 67);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 21;
            label2.Text = "Nova Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(38, 68, 102);
            label3.Location = new Point(2, 11);
            label3.Name = "label3";
            label3.Size = new Size(219, 31);
            label3.TabIndex = 19;
            label3.Text = "Alteração de Senha";
            // 
            // btnAtualizarDados
            // 
            btnAtualizarDados.BackColor = Color.FromArgb(19, 62, 112);
            btnAtualizarDados.FlatStyle = FlatStyle.Popup;
            btnAtualizarDados.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizarDados.ForeColor = Color.FromArgb(226, 239, 239);
            btnAtualizarDados.Location = new Point(39, 255);
            btnAtualizarDados.Name = "btnAtualizarDados";
            btnAtualizarDados.Size = new Size(998, 40);
            btnAtualizarDados.TabIndex = 30;
            btnAtualizarDados.Text = "Atualizar dados";
            btnAtualizarDados.UseVisualStyleBackColor = false;
            btnAtualizarDados.Click += btnAtualizarDados_Click;
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = Color.FromArgb(19, 62, 112);
            btnMudarSenha.FlatStyle = FlatStyle.Popup;
            btnMudarSenha.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMudarSenha.ForeColor = Color.FromArgb(226, 239, 239);
            btnMudarSenha.Location = new Point(39, 568);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(996, 40);
            btnMudarSenha.TabIndex = 26;
            btnMudarSenha.Text = "Mudar senha";
            btnMudarSenha.UseVisualStyleBackColor = false;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // btnSalvarDados
            // 
            btnSalvarDados.BackColor = Color.FromArgb(19, 62, 112);
            btnSalvarDados.FlatStyle = FlatStyle.Popup;
            btnSalvarDados.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarDados.ForeColor = Color.FromArgb(226, 239, 239);
            btnSalvarDados.Location = new Point(39, 255);
            btnSalvarDados.Name = "btnSalvarDados";
            btnSalvarDados.Size = new Size(894, 40);
            btnSalvarDados.TabIndex = 26;
            btnSalvarDados.Text = "Salvar";
            btnSalvarDados.UseVisualStyleBackColor = false;
            btnSalvarDados.Click += btnSalvarDados_Click;
            // 
            // btnSalvarSenha
            // 
            btnSalvarSenha.BackColor = Color.FromArgb(19, 62, 112);
            btnSalvarSenha.FlatStyle = FlatStyle.Popup;
            btnSalvarSenha.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarSenha.ForeColor = Color.FromArgb(226, 239, 239);
            btnSalvarSenha.Location = new Point(39, 568);
            btnSalvarSenha.Name = "btnSalvarSenha";
            btnSalvarSenha.Size = new Size(894, 40);
            btnSalvarSenha.TabIndex = 31;
            btnSalvarSenha.Text = "Salvar";
            btnSalvarSenha.UseVisualStyleBackColor = false;
            btnSalvarSenha.Click += btnSalvarSenha_Click;
            // 
            // btnVoltarDados
            // 
            btnVoltarDados.BackColor = Color.FromArgb(19, 62, 112);
            btnVoltarDados.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoltarDados.FlatStyle = FlatStyle.Popup;
            btnVoltarDados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarDados.ForeColor = Color.FromArgb(226, 239, 239);
            btnVoltarDados.Image = (Image)resources.GetObject("btnVoltarDados.Image");
            btnVoltarDados.Location = new Point(954, 255);
            btnVoltarDados.Name = "btnVoltarDados";
            btnVoltarDados.RightToLeft = RightToLeft.No;
            btnVoltarDados.Size = new Size(83, 40);
            btnVoltarDados.TabIndex = 32;
            btnVoltarDados.UseVisualStyleBackColor = false;
            // 
            // btnVoltarSenha
            // 
            btnVoltarSenha.BackColor = Color.FromArgb(19, 62, 112);
            btnVoltarSenha.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoltarSenha.FlatStyle = FlatStyle.Popup;
            btnVoltarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarSenha.ForeColor = Color.FromArgb(226, 239, 239);
            btnVoltarSenha.Image = (Image)resources.GetObject("btnVoltarSenha.Image");
            btnVoltarSenha.Location = new Point(954, 568);
            btnVoltarSenha.Name = "btnVoltarSenha";
            btnVoltarSenha.RightToLeft = RightToLeft.No;
            btnVoltarSenha.Size = new Size(83, 40);
            btnVoltarSenha.TabIndex = 33;
            btnVoltarSenha.UseVisualStyleBackColor = false;
            // 
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1090, 800);
            Controls.Add(btnVoltarSenha);
            Controls.Add(btnVoltarDados);
            Controls.Add(btnSalvarSenha);
            Controls.Add(btnSalvarDados);
            Controls.Add(btnMudarSenha);
            Controls.Add(btnAtualizarDados);
            Controls.Add(grpSenha);
            Controls.Add(grpDados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPerfil";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "frmLogs";
            Load += frmPerfil_Load;
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            grpSenha.ResumeLayout(false);
            grpSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgOlho2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgOlho1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDados;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtNome;
        private Label label7;
        private Label label8;
        private GroupBox grpSenha;
        private TextBox txtConfirma;
        private Label label1;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private Button btnAtualizarDados;
        private Button btnMudarSenha;
        private TextBox txtId;
        private Button btnSalvarDados;
        private Button btnSalvarSenha;
        private Button btnVoltarDados;
        private Button btnVoltarSenha;
        private PictureBox imgOlho1;
        private PictureBox imgOlho2;
    }
}
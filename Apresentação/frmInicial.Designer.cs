namespace Apresentação
{
    partial class frmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            panel1 = new Panel();
            btnSair = new Button();
            btnConfig = new Button();
            btnLogs = new Button();
            btnDashboard = new Button();
            btnModerador = new Button();
            btnDenuncias = new Button();
            btnPsicologos = new Button();
            btnUsuarios = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnFechar = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 62, 112);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(btnLogs);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnModerador);
            panel1.Controls.Add(btnDenuncias);
            panel1.Controls.Add(btnPsicologos);
            panel1.Controls.Add(btnUsuarios);
            panel1.Location = new Point(-1, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1114);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Maroon;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.Font = new Font("Segoe UI Semilight", 11F);
            btnSair.ForeColor = Color.FromArgb(226, 239, 239);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(-2, 852);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(233, 40);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(19, 62, 112);
            btnConfig.FlatStyle = FlatStyle.Popup;
            btnConfig.Font = new Font("Segoe UI Semilight", 11F);
            btnConfig.ForeColor = Color.FromArgb(226, 239, 239);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(0, 329);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(233, 40);
            btnConfig.TabIndex = 7;
            btnConfig.Text = "Confiigurações";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnLogs
            // 
            btnLogs.BackColor = Color.FromArgb(19, 62, 112);
            btnLogs.FlatStyle = FlatStyle.Popup;
            btnLogs.Font = new Font("Segoe UI Semilight", 11F);
            btnLogs.ForeColor = Color.FromArgb(226, 239, 239);
            btnLogs.Image = (Image)resources.GetObject("btnLogs.Image");
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(0, 95);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(233, 40);
            btnLogs.TabIndex = 6;
            btnLogs.Text = "Histórico Ações";
            btnLogs.UseVisualStyleBackColor = false;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(19, 62, 112);
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Segoe UI Semilight", 11F);
            btnDashboard.ForeColor = Color.FromArgb(226, 239, 239);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 134);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(233, 40);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnModerador
            // 
            btnModerador.BackColor = Color.FromArgb(19, 62, 112);
            btnModerador.BackgroundImageLayout = ImageLayout.Zoom;
            btnModerador.FlatStyle = FlatStyle.Popup;
            btnModerador.Font = new Font("Segoe UI Semilight", 11F);
            btnModerador.ForeColor = Color.FromArgb(226, 239, 239);
            btnModerador.Image = (Image)resources.GetObject("btnModerador.Image");
            btnModerador.ImageAlign = ContentAlignment.MiddleLeft;
            btnModerador.Location = new Point(0, 173);
            btnModerador.Name = "btnModerador";
            btnModerador.Size = new Size(233, 40);
            btnModerador.TabIndex = 1;
            btnModerador.Text = "Moderadores";
            btnModerador.UseVisualStyleBackColor = false;
            btnModerador.Click += btnModerador_Click;
            // 
            // btnDenuncias
            // 
            btnDenuncias.BackColor = Color.FromArgb(19, 62, 112);
            btnDenuncias.FlatStyle = FlatStyle.Popup;
            btnDenuncias.Font = new Font("Segoe UI Semilight", 11F);
            btnDenuncias.ForeColor = Color.FromArgb(226, 239, 239);
            btnDenuncias.Image = (Image)resources.GetObject("btnDenuncias.Image");
            btnDenuncias.ImageAlign = ContentAlignment.MiddleLeft;
            btnDenuncias.Location = new Point(0, 290);
            btnDenuncias.Name = "btnDenuncias";
            btnDenuncias.Size = new Size(233, 40);
            btnDenuncias.TabIndex = 4;
            btnDenuncias.Text = "Denúncias";
            btnDenuncias.UseVisualStyleBackColor = false;
            btnDenuncias.Click += btnDenuncias_Click;
            // 
            // btnPsicologos
            // 
            btnPsicologos.BackColor = Color.FromArgb(19, 62, 112);
            btnPsicologos.BackgroundImageLayout = ImageLayout.Zoom;
            btnPsicologos.FlatStyle = FlatStyle.Popup;
            btnPsicologos.Font = new Font("Segoe UI Semilight", 11F);
            btnPsicologos.ForeColor = Color.FromArgb(226, 239, 239);
            btnPsicologos.Image = (Image)resources.GetObject("btnPsicologos.Image");
            btnPsicologos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPsicologos.Location = new Point(0, 251);
            btnPsicologos.Name = "btnPsicologos";
            btnPsicologos.Size = new Size(233, 40);
            btnPsicologos.TabIndex = 3;
            btnPsicologos.Text = "Psicólogos";
            btnPsicologos.UseVisualStyleBackColor = false;
            btnPsicologos.Click += btnPsicologos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(19, 62, 112);
            btnUsuarios.BackgroundImageLayout = ImageLayout.Zoom;
            btnUsuarios.FlatStyle = FlatStyle.Popup;
            btnUsuarios.Font = new Font("Segoe UI Semilight", 11F);
            btnUsuarios.ForeColor = Color.FromArgb(226, 239, 239);
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 212);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(233, 40);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 62, 112);
            label1.Location = new Point(248, 25);
            label1.Name = "label1";
            label1.Size = new Size(319, 41);
            label1.TabIndex = 1;
            label1.Text = "MODO MODERADOR";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(180, 202, 232);
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1500, 86);
            panel2.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(226, 239, 239);
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Zoom;
            btnFechar.Location = new Point(1431, 25);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 41);
            btnFechar.TabIndex = 7;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._64_Sem_Título_20240908014550;
            pictureBox1.Location = new Point(0, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 227, 241);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 881);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(192, 255, 255);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmInicial";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnUsuarios;
        private Button btnPsicologos;
        private Button btnDenuncias;
        private Label label1;
        private Panel panel2;
        private Button btnModerador;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnLogs;
        private Button btnFechar;
        private Button btnConfig;
        private Button btnSair;
    }
}
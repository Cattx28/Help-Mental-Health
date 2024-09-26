namespace View
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            panel1 = new Panel();
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
            panel1.BackColor = Color.FromArgb(108, 138, 182);
            panel1.Controls.Add(btnModerador);
            panel1.Controls.Add(btnDenuncias);
            panel1.Controls.Add(btnPsicologos);
            panel1.Controls.Add(btnUsuarios);
            panel1.Location = new Point(-8, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 742);
            panel1.TabIndex = 0;
            // 
            // btnModerador
            // 
            btnModerador.BackColor = Color.FromArgb(108, 138, 182);
            btnModerador.BackgroundImageLayout = ImageLayout.Zoom;
            btnModerador.FlatStyle = FlatStyle.Flat;
            btnModerador.Font = new Font("Segoe UI Semilight", 11F);
            btnModerador.ForeColor = Color.FromArgb(226, 239, 239);
            btnModerador.Image = (Image)resources.GetObject("btnModerador.Image");
            btnModerador.ImageAlign = ContentAlignment.MiddleLeft;
            btnModerador.Location = new Point(8, 99);
            btnModerador.Name = "btnModerador";
            btnModerador.Size = new Size(233, 62);
            btnModerador.TabIndex = 1;
            btnModerador.Text = "          MODERADORES";
            btnModerador.UseVisualStyleBackColor = false;
            btnModerador.Click += btnModerador_Click;
            // 
            // btnDenuncias
            // 
            btnDenuncias.BackColor = Color.FromArgb(108, 138, 182);
            btnDenuncias.FlatStyle = FlatStyle.Flat;
            btnDenuncias.Font = new Font("Segoe UI Semilight", 11F);
            btnDenuncias.ForeColor = Color.FromArgb(226, 239, 239);
            btnDenuncias.Image = (Image)resources.GetObject("btnDenuncias.Image");
            btnDenuncias.ImageAlign = ContentAlignment.MiddleLeft;
            btnDenuncias.Location = new Point(8, 293);
            btnDenuncias.Name = "btnDenuncias";
            btnDenuncias.Size = new Size(233, 62);
            btnDenuncias.TabIndex = 4;
            btnDenuncias.Text = "    DENÚNCIAS";
            btnDenuncias.UseVisualStyleBackColor = false;
            btnDenuncias.Click += btnDenuncias_Click;
            // 
            // btnPsicologos
            // 
            btnPsicologos.BackColor = Color.FromArgb(108, 138, 182);
            btnPsicologos.BackgroundImageLayout = ImageLayout.Zoom;
            btnPsicologos.FlatStyle = FlatStyle.Flat;
            btnPsicologos.Font = new Font("Segoe UI Semilight", 11F);
            btnPsicologos.ForeColor = Color.FromArgb(226, 239, 239);
            btnPsicologos.Image = (Image)resources.GetObject("btnPsicologos.Image");
            btnPsicologos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPsicologos.Location = new Point(8, 228);
            btnPsicologos.Name = "btnPsicologos";
            btnPsicologos.Size = new Size(233, 62);
            btnPsicologos.TabIndex = 3;
            btnPsicologos.Text = "      PSICÓLOGOS";
            btnPsicologos.UseVisualStyleBackColor = false;
            btnPsicologos.Click += btnPsicologos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(108, 138, 182);
            btnUsuarios.BackgroundImageLayout = ImageLayout.Zoom;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semilight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.FromArgb(226, 239, 239);
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(8, 164);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(233, 62);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "USUÁRIOS";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 18F);
            label1.ForeColor = Color.FromArgb(108, 138, 182);
            label1.Location = new Point(246, 25);
            label1.Name = "label1";
            label1.Size = new Size(301, 41);
            label1.TabIndex = 1;
            label1.Text = "MODO MODERADOR";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(180, 202, 232);
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1333, 89);
            panel2.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(180, 202, 232);
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Center;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(1277, 25);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 38);
            btnFechar.TabIndex = 6;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 227, 241);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1330, 730);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(192, 255, 255);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FrmInicial";
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
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnFechar;
        private Button btnModerador;
    }
}
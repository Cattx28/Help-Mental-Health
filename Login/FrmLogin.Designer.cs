namespace Login
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            imgLogo = new PictureBox();
            imgUsuario = new PictureBox();
            imgSenha = new PictureBox();
            txtUsuario = new TextBox();
            lblLogin = new Label();
            txtSenha = new TextBox();
            label1 = new Label();
            btnEntrar = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgSenha).BeginInit();
            SuspendLayout();
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.Transparent;
            imgLogo.Image = (Image)resources.GetObject("imgLogo.Image");
            imgLogo.Location = new Point(46, 20);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(361, 217);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // imgUsuario
            // 
            imgUsuario.BackColor = Color.Transparent;
            imgUsuario.Image = (Image)resources.GetObject("imgUsuario.Image");
            imgUsuario.Location = new Point(42, 282);
            imgUsuario.Name = "imgUsuario";
            imgUsuario.Padding = new Padding(2);
            imgUsuario.Size = new Size(36, 36);
            imgUsuario.SizeMode = PictureBoxSizeMode.AutoSize;
            imgUsuario.TabIndex = 2;
            imgUsuario.TabStop = false;
            // 
            // imgSenha
            // 
            imgSenha.BackColor = Color.Transparent;
            imgSenha.Image = (Image)resources.GetObject("imgSenha.Image");
            imgSenha.Location = new Point(42, 341);
            imgSenha.Name = "imgSenha";
            imgSenha.Size = new Size(32, 34);
            imgSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSenha.TabIndex = 3;
            imgSenha.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtUsuario.BackColor = Color.FromArgb(226, 239, 239);
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(93, 123, 167);
            txtUsuario.Location = new Point(81, 285);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(326, 31);
            txtUsuario.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI Semilight", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(93, 123, 167);
            lblLogin.Location = new Point(148, 197);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(161, 62);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSenha.BackColor = Color.FromArgb(226, 239, 239);
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(93, 123, 167);
            txtSenha.Location = new Point(81, 342);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(326, 31);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(93, 123, 167);
            label1.Location = new Point(40, 380);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 4;
            label1.Text = "Esqueceu sua senha?";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(93, 123, 167);
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(226, 239, 239);
            btnEntrar.Location = new Point(40, 429);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(367, 52);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(226, 239, 239);
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Zoom;
            btnFechar.Location = new Point(405, 21);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 33);
            btnFechar.TabIndex = 6;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(452, 524);
            Controls.Add(btnFechar);
            Controls.Add(btnEntrar);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(lblLogin);
            Controls.Add(imgSenha);
            Controls.Add(txtUsuario);
            Controls.Add(imgLogo);
            Controls.Add(imgUsuario);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgLogo;
        private PictureBox imgUsuario;
        private PictureBox imgSenha;
        private TextBox txtUsuario;
        private Label lblLogin;
        private Label label1;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnFechar;
    }
}

namespace View
{
    partial class FrmBusca
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
            panel1 = new Panel();
            label1 = new Label();
            txtBusca = new TextBox();
            btnEnviar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 138, 182);
            panel1.Controls.Add(btnEnviar);
            panel1.Controls.Add(txtBusca);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 126);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(226, 239, 239);
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "ID DO USUÁRIO:";
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.FromArgb(208, 226, 241);
            txtBusca.Font = new Font("Segoe UI", 12.8F);
            txtBusca.Location = new Point(18, 60);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(340, 36);
            txtBusca.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(188, 215, 227);
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.FromArgb(19, 62, 112);
            btnEnviar.Location = new Point(387, 62);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 31);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FrmBusca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 62, 112);
            ClientSize = new Size(533, 150);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBusca";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmBusca";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtBusca;
        private Label label1;
        private Button btnEnviar;
    }
}
namespace View
{
    partial class FrmDenuncias
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDenuncias));
            dgUsuarios = new DataGridView();
            btnVoltar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(180, 202, 232);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(19, 62, 112);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(104, 160, 205);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(19, 62, 112);
            dgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgUsuarios.BackgroundColor = Color.FromArgb(208, 226, 241);
            dgUsuarios.BorderStyle = BorderStyle.None;
            dgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(38, 68, 102);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(30, 99, 159);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(108, 138, 182);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(64, 118, 166);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgUsuarios.DefaultCellStyle = dataGridViewCellStyle7;
            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.GridColor = Color.FromArgb(208, 226, 241);
            dgUsuarios.Location = new Point(280, 122);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgUsuarios.RowHeadersVisible = false;
            dgUsuarios.RowHeadersWidth = 51;
            dgUsuarios.Size = new Size(998, 507);
            dgUsuarios.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(108, 138, 182);
            btnVoltar.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.FromArgb(226, 239, 239);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(1194, 644);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(83, 55);
            btnVoltar.TabIndex = 6;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(108, 138, 182);
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI Semilight", 12F);
            btnExcluir.ForeColor = Color.FromArgb(226, 239, 239);
            btnExcluir.Location = new Point(280, 644);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(264, 55);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "EXCLUIR MENSAGEM";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // FrmDenuncias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1325, 725);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(dgUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDenuncias";
            Text = "FrmDenuncias";
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgUsuarios;
        private Button btnVoltar;
        private Button btnExcluir;
    }
}
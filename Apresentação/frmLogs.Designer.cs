using Dados;

namespace Apresentação
{
    partial class frmLogs
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
            dgLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgLogs).BeginInit();
            SuspendLayout();
            // 
            // dgLogs
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(180, 202, 232);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(19, 62, 112);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(104, 160, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(19, 62, 112);
            dgLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgLogs.BackgroundColor = Color.FromArgb(208, 226, 241);
            dgLogs.BorderStyle = BorderStyle.None;
            dgLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 68, 102);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 99, 159);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 138, 182);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 118, 166);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(226, 239, 239);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgLogs.DefaultCellStyle = dataGridViewCellStyle3;
            dgLogs.EnableHeadersVisualStyles = false;
            dgLogs.GridColor = Color.FromArgb(208, 226, 241);
            dgLogs.Location = new Point(12, 12);
            dgLogs.Name = "dgLogs";
            dgLogs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgLogs.RowHeadersVisible = false;
            dgLogs.RowHeadersWidth = 51;
            dgLogs.Size = new Size(1066, 776);
            dgLogs.TabIndex = 0;
            dgLogs.CellContentClick += dgLogs_CellContentClick;
            // 
            // frmLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 226, 241);
            ClientSize = new Size(1090, 800);
            Controls.Add(dgLogs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogs";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "frmLogs";
            ((System.ComponentModel.ISupportInitialize)dgLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgLogs;
    }
}
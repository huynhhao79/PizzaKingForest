namespace DXApplication1
{
    partial class frmXemBaoCaoTK
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
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBaoCao.DocumentMapWidth = 28;
            this.rpvBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.Size = new System.Drawing.Size(635, 482);
            this.rpvBaoCao.TabIndex = 1;
            // 
            // frmXemBaoCaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 482);
            this.Controls.Add(this.rpvBaoCao);
            this.Name = "frmXemBaoCaoTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem báo cáo";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
    }
}
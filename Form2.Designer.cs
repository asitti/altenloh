namespace MysqlApplication
{
    partial class BerichtForm
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
            this.reportViewerAngebot = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerAngebot
            // 
            this.reportViewerAngebot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerAngebot.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAngebot.Name = "reportViewerAngebot";
            this.reportViewerAngebot.Size = new System.Drawing.Size(815, 573);
            this.reportViewerAngebot.TabIndex = 0;
            // 
            // BerichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 573);
            this.Controls.Add(this.reportViewerAngebot);
            this.Name = "BerichtForm";
            this.Text = "                    ";
            this.Load += new System.EventHandler(this.BerichtForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAngebot;
    }
}
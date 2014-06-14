namespace MysqlApplication
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnfragenabwicklung = new System.Windows.Forms.Button();
            this.btnStammdaten = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnEinstellungen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.81356F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.18644F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Controls.Add(this.btnAnfragenabwicklung, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStammdaten, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBeenden, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEinstellungen, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAnfragenabwicklung
            // 
            this.btnAnfragenabwicklung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnfragenabwicklung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnfragenabwicklung.Image = global::MysqlApplication.Properties.Resources.table;
            this.btnAnfragenabwicklung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnfragenabwicklung.Location = new System.Drawing.Point(3, 3);
            this.btnAnfragenabwicklung.Name = "btnAnfragenabwicklung";
            this.btnAnfragenabwicklung.Size = new System.Drawing.Size(146, 38);
            this.btnAnfragenabwicklung.TabIndex = 0;
            this.btnAnfragenabwicklung.Text = "Anfragen";
            this.btnAnfragenabwicklung.UseVisualStyleBackColor = true;
            this.btnAnfragenabwicklung.Click += new System.EventHandler(this.btnAnfragenabwicklung_Click);
            // 
            // btnStammdaten
            // 
            this.btnStammdaten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStammdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStammdaten.Image = global::MysqlApplication.Properties.Resources.database_connect;
            this.btnStammdaten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStammdaten.Location = new System.Drawing.Point(155, 3);
            this.btnStammdaten.Name = "btnStammdaten";
            this.btnStammdaten.Size = new System.Drawing.Size(154, 38);
            this.btnStammdaten.TabIndex = 1;
            this.btnStammdaten.Text = "Stammdaten";
            this.btnStammdaten.UseVisualStyleBackColor = true;
            this.btnStammdaten.Click += new System.EventHandler(this.btnStammdaten_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::MysqlApplication.Properties.Resources.door_in;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(494, 3);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(117, 38);
            this.btnBeenden.TabIndex = 2;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnEinstellungen
            // 
            this.btnEinstellungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEinstellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinstellungen.Image = global::MysqlApplication.Properties.Resources.wrenchscrewdriver;
            this.btnEinstellungen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEinstellungen.Location = new System.Drawing.Point(315, 3);
            this.btnEinstellungen.Name = "btnEinstellungen";
            this.btnEinstellungen.Size = new System.Drawing.Size(173, 38);
            this.btnEinstellungen.TabIndex = 3;
            this.btnEinstellungen.Text = "Einstellungen";
            this.btnEinstellungen.UseVisualStyleBackColor = true;
            this.btnEinstellungen.Click += new System.EventHandler(this.btnEinstellungen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 44);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angebotsabwicklung";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAnfragenabwicklung;
        private System.Windows.Forms.Button btnStammdaten;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnEinstellungen;

    }
}
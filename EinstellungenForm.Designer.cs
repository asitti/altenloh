namespace MysqlApplication
{
    partial class EinstellungenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EinstellungenForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDatabaseServerPort = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabaseUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatebaseServer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseVerzeichnis = new System.Windows.Forms.Button();
            this.txtCustomerFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailServerPort = new System.Windows.Forms.TextBox();
            this.txtEmailServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZurueck = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDatabaseServerPort);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDatabasePassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDatabaseUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDatebaseServer);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtDatabaseServerPort
            // 
            resources.ApplyResources(this.txtDatabaseServerPort, "txtDatabaseServerPort");
            this.txtDatabaseServerPort.Name = "txtDatabaseServerPort";
            // 
            // txtDatabaseName
            // 
            resources.ApplyResources(this.txtDatabaseName, "txtDatabaseName");
            this.txtDatabaseName.Name = "txtDatabaseName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtDatabasePassword
            // 
            resources.ApplyResources(this.txtDatabasePassword, "txtDatabasePassword");
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtDatabaseUser
            // 
            resources.ApplyResources(this.txtDatabaseUser, "txtDatabaseUser");
            this.txtDatabaseUser.Name = "txtDatabaseUser";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtDatebaseServer
            // 
            resources.ApplyResources(this.txtDatebaseServer, "txtDatebaseServer");
            this.txtDatebaseServer.Name = "txtDatebaseServer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowseVerzeichnis);
            this.groupBox2.Controls.Add(this.txtCustomerFolder);
            this.groupBox2.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnBrowseVerzeichnis
            // 
            this.btnBrowseVerzeichnis.Image = global::MysqlApplication.Properties.Resources.magnifierleft;
            resources.ApplyResources(this.btnBrowseVerzeichnis, "btnBrowseVerzeichnis");
            this.btnBrowseVerzeichnis.Name = "btnBrowseVerzeichnis";
            this.btnBrowseVerzeichnis.UseVisualStyleBackColor = true;
            this.btnBrowseVerzeichnis.Click += new System.EventHandler(this.btnBrowseVerzeichnis_Click);
            // 
            // txtCustomerFolder
            // 
            resources.ApplyResources(this.txtCustomerFolder, "txtCustomerFolder");
            this.txtCustomerFolder.Name = "txtCustomerFolder";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEmailPassword);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtEmailServerPort);
            this.groupBox3.Controls.Add(this.txtEmailServer);
            this.groupBox3.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtEmailPassword
            // 
            resources.ApplyResources(this.txtEmailPassword, "txtEmailPassword");
            this.txtEmailPassword.Name = "txtEmailPassword";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtEmailServerPort
            // 
            resources.ApplyResources(this.txtEmailServerPort, "txtEmailServerPort");
            this.txtEmailServerPort.Name = "txtEmailServerPort";
            // 
            // txtEmailServer
            // 
            resources.ApplyResources(this.txtEmailServer, "txtEmailServer");
            this.txtEmailServer.Name = "txtEmailServer";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnZurueck
            // 
            this.btnZurueck.Image = global::MysqlApplication.Properties.Resources.door_in;
            resources.ApplyResources(this.btnZurueck, "btnZurueck");
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnSpeichern
            // 
            resources.ApplyResources(this.btnSpeichern, "btnSpeichern");
            this.btnSpeichern.Image = global::MysqlApplication.Properties.Resources.diskblack;
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // EinstellungenForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZurueck);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EinstellungenForm";
            this.Load += new System.EventHandler(this.EinstellungenForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDatebaseServer;
        private System.Windows.Forms.TextBox txtDatabaseUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerFolder;
        private System.Windows.Forms.Button btnBrowseVerzeichnis;
        private System.Windows.Forms.TextBox txtEmailServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailServerPort;
        private System.Windows.Forms.TextBox txtDatabaseServerPort;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnSpeichern;

    }
}
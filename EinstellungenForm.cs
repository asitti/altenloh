using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MysqlApplication.Properties;
using System.IO;
using System.Globalization;

namespace MysqlApplication
{
    public partial class EinstellungenForm : Form
    {
        public EinstellungenForm()
        {
            InitializeComponent();

            //txtEmailServer.Text = Settings.Default.EmailServer.ToString();
            //txtEmail.Text = Settings.Default.Email.ToString();
            //txtEmailServerPort.Text = Settings.Default.EmailServerPort.ToString();
            //txtEmailPassword.Text = Settings.Default.EmailPassword.ToString();
            //txtDatebaseServer.Text = Settings.Default.DatabaseServer.ToString();
            //txtDatabaseServerPort.Text = Settings.Default.DatabaseServerPort.ToString();
            //txtDatabaseUser.Text = Settings.Default.DatabaseUser.ToString();
            //txtDatabasePassword.Text = Settings.Default.DatabasePassword.ToString();
            //txtDatabaseName.Text = Settings.Default.DatabaseName.ToString();
            //txtCustomerFolder.Text = Settings.Default.CustomerFolder.ToString();

            var inifile = new IniFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini");
            txtEmailServer.Text = inifile.IniReadValue("Email","EmailServer");
            txtEmail.Text = inifile.IniReadValue("Email", "Email");
            txtEmailServerPort.Text = inifile.IniReadValue("Email", "EmailServerPort");
            txtEmailPassword.Text = inifile.IniReadValue("Email", "EmailPassword");
            txtDatebaseServer.Text = inifile.IniReadValue("Database", "DatabaseServer");
            txtDatabaseServerPort.Text = inifile.IniReadValue("Database", "DatabaseServerPort");
            txtDatabaseUser.Text = inifile.IniReadValue("Database", "DatabaseUser");
            txtDatabasePassword.Text = inifile.IniReadValue("Database", "DatabasePassword");
            txtDatabaseName.Text = inifile.IniReadValue("Database", "DatabaseName");
            txtCustomerFolder.Text = inifile.IniReadValue("Folder", "CustomerFolder");
        }

        private void btnBrowseVerzeichnis_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCustomerFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            //Settings.Default.EmailServer = txtEmailServer.Text;
            //Settings.Default.Email = txtEmail.Text;
            //Settings.Default.EmailServerPort = txtEmailServerPort.Text;
            //Settings.Default.EmailPassword = txtEmailPassword.Text;
            //Settings.Default.DatabaseServer = txtDatebaseServer.Text;
            //Settings.Default.DatabaseServerPort = txtDatabaseServerPort.Text;
            //Settings.Default.DatabaseUser = txtDatabaseUser.Text;
            //Settings.Default.DatabasePassword = txtDatabasePassword.Text;
            //Settings.Default.DatabaseName = txtDatabaseName.Text;
            //Settings.Default.CustomerFolder = txtCustomerFolder.Text;
   
            //Settings.Default.Save();
            var inifile = new IniFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini");

            inifile.IniWriteValue("Email", "EmailServer", txtEmailServer.Text);
            inifile.IniWriteValue("Email", "Email", txtEmail.Text);
            inifile.IniWriteValue("Email", "EmailServerPort", txtEmailServerPort.Text);
            inifile.IniWriteValue("Email", "EmailPassword", txtEmailPassword.Text);
            inifile.IniWriteValue("Database", "DatabaseServer", txtDatebaseServer.Text);
            inifile.IniWriteValue("Database", "DatabaseServerPort", txtDatabaseServerPort.Text);
            inifile.IniWriteValue("Database", "DatabaseUser", txtDatabaseUser.Text);
            inifile.IniWriteValue("Database", "DatabasePassword", txtDatabasePassword.Text);
            inifile.IniWriteValue("Database", "DatabaseName", txtDatabaseName.Text);
            inifile.IniWriteValue("Folder", "CustomerFolder", txtCustomerFolder.Text);

            MessageBox.Show("Einstellungen wurden erfolgreich gespeichert.", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    
        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(EinstellungenForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void EinstellungenForm_Load(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MysqlApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            InitializeComponent();           
        }

        private void btnAnfragenabwicklung_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            var form = new KundenanfragenForm();
            form.Show();
            Cursor = Cursors.Default;
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStammdaten_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            var form = new StammdatenForm();
            form.Show();
            Cursor = Cursors.Default;
        }



        private void btnEinstellungen_Click(object sender, EventArgs e)
        {
            var form = new EinstellungenForm();            
            form.ShowDialog();
        }
    }
}

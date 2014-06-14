using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MysqlApplication
{
    public partial class BerichtForm : Form
    {
        public BerichtForm()
        {
            InitializeComponent();
        }

        private void BerichtForm_Load(object sender, EventArgs e)
        {

            this.reportViewerAngebot.RefreshReport();
        }
    }
}

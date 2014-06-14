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
    public partial class MengenPositionForm : Form
    {
        private m_mengenpos mp;
        private ka_kundenanfrage ka;
        private angebotserstellungEntities _context;


        public MengenPositionForm(BindingSource m_mengenposBindingSource)
        {
            InitializeComponent();
            m_mengenposBindingSource = m_mengenposBindingSource;
            _context = new angebotserstellungEntities();
            txtJahresmenge.Focus();
        }

   
        private void btnMengenPositionSpeichern_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

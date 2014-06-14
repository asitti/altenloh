
using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MysqlApplication
{

    public partial class KundenAuswahl : Form
    {

        private angebotserstellungEntities _context;
        private int _kundePosition = 0;
        private int _einkaeuferPosition = 0;

        public KundenAuswahl()
        {
            InitializeComponent();
        }

        public DataGridViewRow getSelectedKundeRow()
        {
            return k_kundeDataGridView.CurrentRow;
        }

        public int? getSelectedEinkauferId()
        {
            var row = e_einkaeuferDataGridView.CurrentRow;

            if (row == null) { return null; }

            return (int)row.Cells["EinkaeuferID"].Value;
        }

        private void KundenAuswahl_Load(object sender, EventArgs e)
        {
            _context = new angebotserstellungEntities();

            var queryVertreter = from v in _context.v_vertreter
                                 orderby v.v_name
                                 select new { v.v_vertreter_ID, v.v_name };
            binvvertreterBindingSource.DataSource = queryVertreter.ToList();

            var queryKundengruppe = from k in _context.kg_kundengruppe
                                 orderby k.kg_bezeichnung
                                 select k;
            binkgkundengruppeBindingSource.DataSource = queryKundengruppe.ToList();
           
            var queryKunde = from q in _context.k_kunde select q;
            k_kundeBindingSource.DataSource = new SortableBindingList<k_kunde>(queryKunde.ToList());




        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

   
        private void kunde_AddingNew(object sender, AddingNewEventArgs e)
        {           
            var newkunde = new k_kunde();
            newkunde.k_angelegt_von = Environment.UserName;
            newkunde.k_angelegt_am = System.DateTime.Now;
            newkunde.k_status = "Y"; // FIXME: should be enum
            e.NewObject = newkunde;
        }



        private void k_kundeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.Out.WriteLine(e.ToString());
        }

        private void e_einkaeuferDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.Out.WriteLine(e.ToString());
        }


        private void radKundeGueltig_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            var status = "";

            if (rb.Checked)
            {

                if (rb != null && rb.Name == "radKundeGueltig")
                {
                    status = "Y";
                }

                else if (rb != null && rb.Name == "radKundeUngueltig")
                {
                    status = "N";
                }
                
                if (status != "")
                {
                    k_kundeBindingSource.Filter = "e_status='" + status + "'";
                }
                else
                {
                    k_kundeBindingSource.Filter = "";                    
                }

                k_kundeBindingSource.ResetBindings(false);
            }

        }

        private void radEinkaeuferGueltig_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            var status = "";

            if (rb.Checked)
            {

                if (rb != null && rb.Name == "radEinkaeuferGueltig")
                {
                    status = "Y";
                }

                else if (rb != null && rb.Name == "radEinkaeuferUngueltig")
                {
                    status = "N";
                }


                if (status != "")
                {
                    e_einkaeuferBindingSource.Filter = "e_status='" + status + "'";
                }
                else {
                    e_einkaeuferBindingSource.Filter = "";
                }
            }
        }

 
        private void k_kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                k_kundeDataGridView.EndEdit();
                e_einkaeuferDataGridView.EndEdit();
                _context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            
        }

        private void e_einkaeuferBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            var neweinkauefer = new e_einkaeufer();
            neweinkauefer.e_angelegt_von = Environment.UserName;
            neweinkauefer.e_angelegt_am = System.DateTime.Now;
            neweinkauefer.e_status = "Y"; // FIXME: should be enum
            e.NewObject = neweinkauefer;
        }

        private void btnAuswaehlen_Click(object sender, EventArgs e)
        {
            k_kundeBindingNavigatorSaveItem.PerformClick();
            this.DialogResult = DialogResult.OK;
        }

    }
}

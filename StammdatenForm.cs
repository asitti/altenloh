using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace MysqlApplication
{
    public partial class StammdatenForm : Form
    {

        private angebotserstellungEntities _context;
        private int _position;
        private bool _adding = false;

        public StammdatenForm()
        {
            InitializeComponent();
            _context = new angebotserstellungEntities();
            tabControl1.SelectedIndex = 0;
        }

        private void LoadBindings()
        {

            try
            {

                if (tabControl1.SelectedIndex == 0)
                {
                    var queryVertreter = (from q in _context.v_vertreter select q);
                    v_vertreterBindingSource.DataSource = queryVertreter.ToList();
                    v_vertreterDataGridView.DataSource = v_vertreterBindingSource;
                }

                else if (tabControl1.SelectedIndex == 1)
                {
                    var queryHersteller = (from q in _context.h_hersteller select q);
                    h_herstellerBindingSource.DataSource = queryHersteller.ToList();
                    h_herstellerDataGridView.DataSource = h_herstellerBindingSource;
                }
                else if (tabControl1.SelectedIndex == 2)
                {
                    var queryMitarbeiter = (from q in _context.mv_mitarbeiter_vertrieb select q);
                    mv_mitarbeiter_vertriebBindingSource.DataSource = queryMitarbeiter.ToList();
                    mv_mitarbeiterDataGridView.DataSource = mv_mitarbeiter_vertriebBindingSource;
                }
                else if (tabControl1.SelectedIndex == 3)
                {
                    var queryProduktgruppe = (from q in _context.pg_produktgruppe select q);
                    pg_produktgruppeBindingSource.DataSource = queryProduktgruppe.ToList();
                    pg_produktgruppeDataGridView.DataSource = pg_produktgruppeBindingSource;
                }

                statusStrip1.Items[0].Image = null;
                statusStrip1.Items[0].Text = "Bereit";

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }

        }

        private void v_vertreterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                //v_vertreterBindingSource.EndEdit();
                v_vertreterDataGridView.EndEdit();

                if (_adding = true)
                {
                    //v_vertreter vertreter = (v_vertreter)v_vertreterBindingSource.Current;
                    foreach (v_vertreter vertreter in v_vertreterBindingSource.List)
                    {
                        if (vertreter != null)
                        {

                            if (vertreter.v_vertreter_ID == 0)
                                _context.v_vertreter.Add(vertreter);
                        }
                    }

                }

                _context.SaveChanges();
                statusStrip1.Items[0].Image = imgimageList1.Images[94];
                statusStrip1.Items[0].Text = "Änderungen wurden gespeichert.";

                System.Timers.Timer timer = new System.Timers.Timer(3000) { Enabled = true };
                timer.Elapsed += (object source, ElapsedEventArgs args) =>
                  {
                      statusStrip1.Items[0].Image = null;
                      statusStrip1.Items[0].Text = "Bereit";
                      timer.Dispose();
                  };
                v_vertreterDataGridView.Refresh();
                //LoadBindings();
            }

            catch (Exception)
            {

                MessageBox.Show("Speichern fehlgeschlagen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBindings();
        }

        private void StammdatenForm_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            LoadBindings();
        }

        private void v_vertreterBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            _adding = true;
        }



        private void toolStripButtonHerstellerLoeschen_MouseDown(object sender, MouseEventArgs e)
        {
            h_hersteller hersteller = (h_hersteller)h_herstellerBindingSource.Current;

            if (hersteller != null)
            {
                _context.h_hersteller.Remove(hersteller);
            }
        }

        private void toolStripButtonHerstellerSpeichern_Click(object sender, EventArgs e)
        {

            try
            {
                //h_herstellerBindingSource.EndEdit();
                h_herstellerDataGridView.EndEdit();

                if (_adding = true)
                {
                    //h_hersteller hersteller = (h_hersteller)h_herstellerBindingSource.Current;
                    foreach (h_hersteller hersteller in h_herstellerBindingSource.List)
                    {
                        if (hersteller != null)
                        {

                            if (hersteller.h_hersteller_ID == 0)
                                _context.h_hersteller.Add(hersteller);
                        }
                    }

                }

                _context.SaveChanges();
                statusStrip1.Items[0].Image = imgimageList1.Images[94];
                statusStrip1.Items[0].Text = "Änderungen wurden gespeichert.";

                System.Timers.Timer timer = new System.Timers.Timer(3000) { Enabled = true };
                timer.Elapsed += (object source, ElapsedEventArgs args) =>
                  {
                      statusStrip1.Items[0].Image = null;
                      statusStrip1.Items[0].Text = "Bereit";
                      timer.Dispose();
                  };
                h_herstellerDataGridView.Refresh();
                //LoadBindings();
            }

            catch (Exception)
            {

                MessageBox.Show("Speichern fehlgeschlagen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void h_herstellerBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            _adding = true;
        }

        private void toolStripButtonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

   

        private void toolStripButtonMvMitarbeiterSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                //mv_mitarbeiter_vertriebBindingSource.EndEdit();
                mv_mitarbeiterDataGridView.EndEdit();

                if (_adding = true)
                {
                   // mv_mitarbeiter_vertrieb mitarbeiter = (mv_mitarbeiter_vertrieb)mv_mitarbeiter_vertriebBindingSource.Current;
                    
                        foreach (mv_mitarbeiter_vertrieb mitarbeiter in mv_mitarbeiter_vertriebBindingSource.List)
                        {
                            if (mitarbeiter != null)
                            {
                            if (mitarbeiter.mv_mitarbeiter_ID == 0)
                                _context.mv_mitarbeiter_vertrieb.Add(mitarbeiter);
                        }
                    }

                }

                _context.SaveChanges();
                statusStrip1.Items[0].Image = imgimageList1.Images[94];
                statusStrip1.Items[0].Text = "Änderungen wurden gespeichert.";

                System.Timers.Timer timer = new System.Timers.Timer(3000) { Enabled = true };
                timer.Elapsed += (object source, ElapsedEventArgs args) =>
                  {
                      statusStrip1.Items[0].Image = null;
                      statusStrip1.Items[0].Text = "Bereit";
                      timer.Dispose();
                  };
                mv_mitarbeiterDataGridView.Refresh();
                //LoadBindings();
            }

            catch (Exception)
            {

                MessageBox.Show("Speichern fehlgeschlagen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mv_mitarbeiter_vertriebBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            _adding = true;
        }


        private void pg_produktgruppeBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            _adding = true;
        }


        private void toolStripButtonProduktGruppeSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                //pg_produktgruppe_vertriebBindingSource.EndEdit();
                pg_produktgruppeDataGridView.EndEdit();

                if (_adding = true)
                {
                    //pg_produktgruppe produktgruppe = (pg_produktgruppe)pg_produktgruppeBindingSource.Current;
                    foreach (pg_produktgruppe produktgruppe in pg_produktgruppeBindingSource.List)
                    {
                        if (produktgruppe != null)
                        {

                            if (produktgruppe.pg_produktgruppe_ID == 0)
                                _context.pg_produktgruppe.Add(produktgruppe);
                        }
                    }
                }

                _context.SaveChanges();
                statusStrip1.Items[0].Image = imgimageList1.Images[94];
                statusStrip1.Items[0].Text = "Änderungen wurden gespeichert.";

                System.Timers.Timer timer = new System.Timers.Timer(3000) { Enabled = true };
                timer.Elapsed += (object source, ElapsedEventArgs args) =>
                  {
                      statusStrip1.Items[0].Image = null;
                      statusStrip1.Items[0].Text = "Bereit";
                      timer.Dispose();
                  };
                pg_produktgruppeDataGridView.Refresh();
                //LoadBindings();
            }

            catch (Exception)
            {

                MessageBox.Show("Speichern fehlgeschlagen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void v_vertreterBindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            v_vertreter vertreter = (v_vertreter)v_vertreterBindingSource.Current;

            if (vertreter != null)
            {
                _context.v_vertreter.Remove(vertreter);
            }
        }

        private void toolStripButtonMvMitarbeiterLoeschen_MouseDown(object sender, MouseEventArgs e)
        {
            mv_mitarbeiter_vertrieb mitarbeiter = (mv_mitarbeiter_vertrieb)mv_mitarbeiter_vertriebBindingSource.Current;

            if (mitarbeiter != null)
            {
                _context.mv_mitarbeiter_vertrieb.Remove(mitarbeiter);
            }
        }

        private void toolStripButtonProduktGruppeLoeschen_MouseDown(object sender, MouseEventArgs e)
        {
            pg_produktgruppe produktgruppe = (pg_produktgruppe)pg_produktgruppeBindingSource.Current;
            if (produktgruppe != null)
            {
                _context.pg_produktgruppe.Remove(produktgruppe);
            }
        }

    }
}

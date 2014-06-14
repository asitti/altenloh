
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Timers;

namespace MysqlApplication
{

    public partial class KundenanfragenForm : Form
    {

        private angebotserstellungEntities _context;

        private bool _adding;

        private NumberFormatInfo _numberFormatInfo;
        private string _decimalSeparator;
        private CultureInfo _currentCultureInfo;
        private int _kundenanfragePosition;

        public KundenanfragenForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _currentCultureInfo = CultureInfo.CurrentCulture;
            _numberFormatInfo = _currentCultureInfo.NumberFormat;
            _decimalSeparator = _numberFormatInfo.NumberDecimalSeparator;

            _context = new angebotserstellungEntities();
            InitComboBoxes();
            InitAnfrageBindings("");
            _adding = false;
            Cursor = Cursors.Default;
            textBox_Kunde.Focus();
            textBox_Kunde.SelectAll();
            statusStrip1.Items[0].Text = "Bereit";
        }

        private void binkakundenanfrageBindingSource_PositionChanged(object sender, EventArgs e)
        {

            if (binkakundenanfrageBindingSource.Current != null)
            {
                var ka = (ka_kundenanfrage)binkakundenanfrageBindingSource.Current;
                lblAnfrageNummer1.Text = ka.ka_anfragenummer.ToString();
            }
        }

        private void radUngltig_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            var status = "";

            if (rb != null && rb.Name == "radGLtig")
            {
                status = "Y";
            }

            else if (rb != null && rb.Name == "radUngltig")
            {
                status = "N";
            }
            InitAnfrageBindings(status);
        }

        private void InitAnfrageBindings(String status)
        {

            dataGridView_Kundenanfrage.DataSource = null;

            if (status != "")
            {
                var queryKundenanfrage = from q in _context.ka_kundenanfrage
                                         where q.ka_status == status
                                         orderby q.ka_anfragenummer
                                         select q;
                binkakundenanfrageBindingSource.DataSource =
                    new SortableBindingList<ka_kundenanfrage>(queryKundenanfrage.ToList());
            }

            else
            {
                var queryKundenanfrage = from q in _context.ka_kundenanfrage orderby q.ka_anfragenummer select q;
                binkakundenanfrageBindingSource.DataSource =
                    new SortableBindingList<ka_kundenanfrage>(queryKundenanfrage.ToList());
            }

            binkakundenanfrageBindingSource.Position = _kundenanfragePosition;
            dataGridView_Kundenanfrage.DataSource = binkakundenanfrageBindingSource;

            if (binkakundenanfrageBindingSource.Count > 0)
            {
                dataGridView_Kundenanfrage.DataSource = binkakundenanfrageBindingSource;
                dataGridView_Kundenanfrage.Sort(dataGridView_Kundenanfrage.Columns[1], ListSortDirection.Descending);
                //binkakundenanfrageBindingSource.MoveFirst();
                var ka = (ka_kundenanfrage)binkakundenanfrageBindingSource.Current;
                lblAnfrageNummer1.Text = ka.ka_anfragenummer.ToString();
            }

            else
            {
                ClearAnfrageBindings();
            }
        }

        private void InitComboBoxes()
        {
            /*
            * Fill Combo Boxes
            */
            var queryProduktGruppe = from q in _context.pg_produktgruppe
                                     orderby q.pg_bezeichnung
                                     select new { q.pg_bezeichnung };
            binpgproduktgruppeBindingSource.DataSource = queryProduktGruppe.ToList();

            var queryBezeichnung = from q in _context.ab_artikelbezeichnung
                                   orderby q.ab_artikelbezeichnung1
                                   select new { q.ab_artikelbezeichnung1 };
            binabartikelbezeichnungBindingSource.DataSource = queryBezeichnung.ToList();

            var queryEinkaufer = from q in _context.e_einkaeufer
                                 where q.e_status=="Y"
                                 orderby q.e_einkaeufer1
                                 select new { q.e_einkaeufer_ID, e_einkaeufer1 = q.e_anrede + " " + q.e_einkaeufer1 };
            bineeinkaeuferBindingSource.DataSource = queryEinkaufer.ToList();

            var queryVertreter = from q in _context.v_vertreter
                                 orderby q.v_name
                                 select new { q.v_vertreter_ID, q.v_name };
            binvvertreterBindingSource.DataSource = queryVertreter.ToList();

            var queryZustaendig = from q in _context.mv_mitarbeiter_vertrieb                                  
                                  orderby q.mv_name
                                  select new { q.mv_name };
            binmvmitarbeitervertriebBindingSource.DataSource = queryZustaendig.ToList();

            var queryHersteller = from q in _context.h_hersteller
                                  orderby q.h_hersteller1
                                  select new { q.h_hersteller1 };
            binhherstellerBindingSource.DataSource = queryHersteller.ToList();
        }

        private void ClearAnfrageBindings()
        {
            cmbEinkaeufer.SelectedIndex = -1;
            cmbVertreter.SelectedIndex = -1;
            cmbProduktgruppe.SelectedIndex = -1;
            cmbBezeichnung.SelectedIndex = -1;
            cmbZustaendigkeit.SelectedIndex = -1;
            cmbHersteller.SelectedIndex = -1;
        }

        private void EnableFields()
        {
            grpKundenanfragen.Enabled = true;
            grpDateien.Enabled = true;
            grpMengenPositionen.Enabled = true;
        }

        private void DisableFields()
        {
            grpKundenanfragen.Enabled = false;
            grpDateien.Enabled = false;
            grpMengenPositionen.Enabled = false;
        }

        private void radDateiUngueltig_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            var status = "";

            if (rb.Checked)
            {

                if (rb != null && rb.Name == "radDateiGueltig")
                {
                    status = "Y";
                }

                else if (rb != null && rb.Name == "radDateiUngueltig")
                {
                    status = "N";
                }

                if (status != "")
                    d_dateiBindingSource.Filter = "d_status='" + status + "'";

                else
                    d_dateiBindingSource.Filter = "";

                dataGridView_Dateien.DataSource = null;
                dataGridView_Dateien.DataSource = d_dateiBindingSource;
            }
        }

        private void textBox_FilterKA_KeyUp(object sender, KeyEventArgs e)
        {
            var tb = sender as TextBox;

            if (tb != null && tb.Text != "")
            {

                foreach (DataGridViewRow row in dataGridView_Kundenanfrage.Rows)
                {

                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(tb.Text))
                    {
                        int rowIndex = row.Index;
                        dataGridView_Kundenanfrage.ClearSelection();
                        dataGridView_Kundenanfrage.Rows[rowIndex].Selected = true;
                        dataGridView_Kundenanfrage.FirstDisplayedScrollingRowIndex = rowIndex;
                        binkakundenanfrageBindingSource.Position = rowIndex;
                        break;
                    }
                }
            }
        }

        private void textBox_Durchmesser_KeyPress(object sender, KeyPressEventArgs e)
        {
            char token = _decimalSeparator.ToCharArray()[0];

            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != token)
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == token
                && ((TextBox)sender).Text.IndexOf(token) > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox_Laenge_Validating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
            float laenge;

            if (tb != null && float.TryParse(tb.Text, out laenge))
            {
                tb.Text = laenge.ToString(CultureInfo.InvariantCulture);
            }

            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein.");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _adding = true;
            textBox_Kunde.Focus();
            textBox_Kunde.SelectAll();
        }

        private void ka_kundenanfrageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox_Kunde.Text))
            {
                MessageBox.Show("Bitte geben Sie fehlende Daten ein und versuchen es noch mal", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                binkakundenanfrageBindingSource.EndEdit();

                var ka = (ka_kundenanfrage)binkakundenanfrageBindingSource.Current;

                if (_adding)
                {
                    //var query = (from q in _context.ka_kundenanfrage
                    //    select q.ka_anfragenummer).Max() ?? 1;

                    //var kaAnfragenummerNew = query;

                    //var ka = new ka_kundenanfrage();                   
                    //ka.ka_anfragenummer = kaAnfragenummerNew;
                    if (ka != null)
                    {

                        ka.ka_kunde = textBox_Kunde.Text;
                        ka.ka_kundengruppe = textBox_Kundengruppe.Text;
                        ka.ka_vertreter = cmbVertreter.Text;
                        ka.ka_einkaeufer_name = cmbEinkaeufer.Text;
                        ka.ka_kundenkommentar = textBox_Kundenkommentar.Text;
                        ka.ka_artikelnummer = textBox_Artikelnummer.Text;
                        ka.ka_zeichnungsnummer = textBox_Zeichnungsnummer.Text;
                        ka.ka_aenderungsindex = textBox_Aenderungsindex.Text;
                        ka.ka_produktgruppe = cmbProduktgruppe.Text;
                        ka.ka_artikelbezeichnung = cmbBezeichnung.Text;
                        ka.ka_hersteller = cmbHersteller.Text;
                        ka.ka_zustaendig = cmbZustaendigkeit.Text;

                        if (!String.IsNullOrEmpty(textBox_Durchmesser.Text))
                            ka.ka_durchmesser = Convert.ToSingle(textBox_Durchmesser.Text, _currentCultureInfo);

                        if (!String.IsNullOrEmpty(textBox_Laenge.Text))
                            ka.ka_laenge = Convert.ToSingle(textBox_Laenge.Text, _currentCultureInfo);

                        if (!String.IsNullOrEmpty(textBox_Gewindesteigung.Text))
                            ka.ka_gewindesteigung = Convert.ToSingle(textBox_Gewindesteigung.Text, _currentCultureInfo);
                        ka.ka_guete = textBox_Guete.Text;

                        if (!String.IsNullOrEmpty(textBox_Einsatzgewicht.Text))
                            ka.ka_einsatzgewicht = Convert.ToSingle(textBox_Einsatzgewicht.Text, _currentCultureInfo);

                        if (!String.IsNullOrEmpty(textBox_Fertiggewicht.Text))
                            ka.ka_fertiggewicht = Convert.ToSingle(textBox_Fertiggewicht.Text, _currentCultureInfo);
                        ka.ka_kommentar = textBox_Kommentar.Text;
                        ka.ka_angefragt_am = textBox_Anfragedatum.Value;
                        ka.ka_angebotsfrist = textBox_Angebotsfrist.Value;
                        ka.ka_angelegt_am = DateTime.Now;
                        ka.ka_angelegt_von = "user";
                        ka.ka_status = "Y";

                        if (radInteressant.Checked)
                        {
                            ka.ka_potenzial = "Interessant";
                        }

                        else if (radWenigerInteressant.Checked)
                        {
                            ka.ka_potenzial = "Uninteressant";
                        }
                    }
                    _context.ka_kundenanfrage.Add(ka);
                    _kundenanfragePosition = 0;
                    _adding = false;
                }

                else
                {
                    _kundenanfragePosition = binkakundenanfrageBindingSource.Position;

                    if (ka != null)
                    {
                        ka.ka_kunde = textBox_Kunde.Text;
                        ka.ka_kundengruppe = textBox_Kundengruppe.Text;
                        ka.ka_vertreter = cmbVertreter.Text;
                        ka.ka_einkaeufer_name = cmbEinkaeufer.Text;
                        ka.ka_kundenkommentar = textBox_Kundenkommentar.Text;
                        ka.ka_artikelnummer = textBox_Artikelnummer.Text;
                        ka.ka_zeichnungsnummer = textBox_Zeichnungsnummer.Text;
                        ka.ka_aenderungsindex = textBox_Aenderungsindex.Text;
                        ka.ka_produktgruppe = cmbProduktgruppe.Text;
                        ka.ka_artikelbezeichnung = cmbBezeichnung.Text;
                        ka.ka_hersteller = cmbHersteller.Text;
                        ka.ka_zustaendig = cmbZustaendigkeit.Text;

                        if (!String.IsNullOrEmpty(textBox_Durchmesser.Text))
                            ka.ka_durchmesser = Convert.ToSingle(textBox_Durchmesser.Text);

                        if (!String.IsNullOrEmpty(textBox_Laenge.Text))
                            ka.ka_laenge = Convert.ToSingle(textBox_Laenge.Text);

                        if (!String.IsNullOrEmpty(textBox_Gewindesteigung.Text))
                            ka.ka_gewindesteigung = Convert.ToSingle(textBox_Gewindesteigung.Text);
                        ka.ka_guete = textBox_Guete.Text;

                        if (!String.IsNullOrEmpty(textBox_Einsatzgewicht.Text))
                            ka.ka_einsatzgewicht = Convert.ToSingle(textBox_Einsatzgewicht.Text);

                        if (!String.IsNullOrEmpty(textBox_Fertiggewicht.Text))
                            ka.ka_fertiggewicht = Convert.ToSingle(textBox_Fertiggewicht.Text);
                        ka.ka_kommentar = textBox_Kommentar.Text;
                        ka.ka_angefragt_am = textBox_Anfragedatum.Value;
                        ka.ka_angebotsfrist = textBox_Angebotsfrist.Value;
                        ka.ka_angelegt_von = "user";

                        if (radInteressant.Checked)
                        {
                            ka.ka_potenzial = "Interessant";
                        }

                        else if (radWenigerInteressant.Checked)
                        {
                            ka.ka_potenzial = "Uninteressant";
                        }
                        _context.Entry(ka).State = EntityState.Modified;
                    }
                }

                _context.SaveChanges();
                RefreshAnfragen();
   	
            } catch(Exception ex)
            {
                Console.Out.WriteLine(ex.Message);             	
            }
                       
            statusStrip1.Items[0].Image = imgimageList1.Images[94];
            statusStrip1.Items[0].Text = " Änderungen wurden gespeichert.";

            System.Timers.Timer timer = new System.Timers.Timer(3000) { Enabled = true };
            timer.Elapsed += (object  source, ElapsedEventArgs args) =>
              {
                  statusStrip1.Items[0].Image = null;
                  statusStrip1.Items[0].Text = "Bereit";
                  timer.Dispose();
              };

        }

        private void toolStripButtonAnfrageRefresh_Click(object sender, EventArgs e)
        {
            binkakundenanfrageBindingSource.CancelEdit();
            _kundenanfragePosition = 0;
            //RefreshAnfragen();
        }

        private void RefreshAnfragen()
        {
            var status = "";

            if (radGLtig.Checked)
            {
                status = "Y";
            }

            else if (radUngltig.Checked)
            {
                status = "N";
            }
            InitAnfrageBindings(status);
        }

        private void toolStripButtonDateiHinzufugen_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                var filepath = Path.GetDirectoryName(file);
                var filename = Path.GetFileName(file);
                var ka = (ka_kundenanfrage)binkakundenanfrageBindingSource.Current;

                if (ka != null)
                {
                    d_dateiBindingSource.AddNew();
                    var ddatei = (d_datei)d_dateiBindingSource.Current;
                    ddatei.d_kundenanfrage_ID = ka.ka_kundenanfrage_ID;
                    ddatei.d_pfad = filepath;
                    ddatei.d_name = filename;
                    ddatei.d_status = "Y";
                    ddatei.d_angelegt_am = DateTime.Now;
                    d_dateiBindingSource.EndEdit();
                    _context.d_datei.Add(ddatei);
                }
            }
        }

        private void toolStripButtonDateiRefresh_Click(object sender, EventArgs e)
        {
            d_dateiBindingSource.CancelEdit();
            var status = "";

            if (radDateiGueltig.Checked)
            {
                status = "Y";
            }

            else if (radDateiUngueltig.Checked)
            {
                status = "N";
            }

            foreach (DbEntityEntry<d_datei> entry in _context.ChangeTracker.Entries<d_datei>())
            {

                switch (entry.State)
                {

                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;

                    case EntityState.Deleted:
                        entry.Reload();
                        break;

                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }

            if (binkakundenanfrageBindingSource.Count > 0)
            {

                if (binkakundenanfrageBindingSource.Current != null)
                {

                    if (status != "")
                        d_dateiBindingSource.Filter = "d_status='" + status + "'";
                    dataGridView_Dateien.DataSource = null;
                    dataGridView_Dateien.DataSource = d_dateiBindingSource;
                }
            }
        }

        private void dataGridView_Dateien_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void dataGridView_Dateien_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var ka = (ka_kundenanfrage)binkakundenanfrageBindingSource.Current;

                var files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (var file in files)
                {
                    var filepath = Path.GetDirectoryName(file);
                    var filename = Path.GetFileName(file);

                    if (ka != null)
                    {
                        d_dateiBindingSource.AddNew();
                        var ddatei = (d_datei)d_dateiBindingSource.Current;
                        ddatei.d_kundenanfrage_ID = ka.ka_kundenanfrage_ID;
                        ddatei.d_pfad = filepath;
                        ddatei.d_name = filename;
                        ddatei.d_status = "Y";
                        ddatei.d_angelegt_am = DateTime.Now;
                        d_dateiBindingSource.EndEdit();
                        _context.d_datei.Add(ddatei);
                    }
                }
            }
        }

        private void textBox_Dateibeschreibung_KeyUp(object sender, KeyEventArgs e)
        {
            var tb = sender as TextBox;

            if (tb != null && !String.IsNullOrEmpty(tb.Text))
            {
                var ddatei = (d_datei)d_dateiBindingSource.Current;
                ddatei.d_beschreibung = tb.Text;
                _context.Entry(ddatei).State = EntityState.Modified;
            }
        }

        private void toolStripButtonSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonAnfrageKopieren_Click(object sender, EventArgs e)
        {
            _context.Configuration.ProxyCreationEnabled = false;

            if (dataGridView_Kundenanfrage.CurrentRow != null)
            {
                var ka = binkakundenanfrageBindingSource.Current;
                var kacopy = (ka_kundenanfrage)_context.Entry(ka).GetDatabaseValues().ToObject();

                if (kacopy == null) return;
                kacopy.ka_anfragenummer = NeuAnfrageNummer();
                _context.ka_kundenanfrage.Add(kacopy);
                _context.SaveChanges();
                dataGridView_Kundenanfrage.DataSource = null;
                dataGridView_Kundenanfrage.DataSource = binkakundenanfrageBindingSource;
                RefreshAnfragen();
            }
        }

        private void binkakundenanfrageBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            var ka = new ka_kundenanfrage();
            ka.ka_anfragenummer = NeuAnfrageNummer();
            e.NewObject = ka;
        }

        private int NeuAnfrageNummer()
        {
            var query = (from q in _context.ka_kundenanfrage
                         select q.ka_anfragenummer).Max() ?? 0;

            var kaAnfragenummerNew = query + 1;
            return kaAnfragenummerNew;
        }

        private void btnKunde_Click(object sender, EventArgs e)
        {
            KundenAuswahl auswahl = new KundenAuswahl();

            if (auswahl.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            
            // Get the new data and fill in the combo boxes in case there is added data
            InitComboBoxes();

            var selectedKunde = auswahl.getSelectedKundeRow();

            if (selectedKunde != null)
            {
                var cells = selectedKunde.Cells;
                textBox_Kunde.Text = (string) cells["Kundenname"].Value;
                textBox_Kundengruppe.Text = (string) cells["Kundengruppe"].Value;
                string vertreter = (string)cells["Vertreter"].Value;

                var queryVertreter = from v in _context.v_vertreter
                                     where v.v_name == vertreter
                                     orderby v.v_name
                                     select new { v.v_vertreter_ID, v.v_name };
                binvvertreterBindingSource.DataSource = queryVertreter.ToList();
            }
            
            var einkauferId = auswahl.getSelectedEinkauferId();

            if (einkauferId != null)
            {
                cmbEinkaeufer.SelectedValue = (int)einkauferId;
            }
        }

        private void cmbProduktgruppe_SelectedIndexChanged(object sender, EventArgs e)
        {
            binkakundenanfrageBindingSource.EndEdit();
        }

        private void toolStripButtonMengenpositionHinzufuegen_Click(object sender, EventArgs e)
        {
            var ka = (ka_kundenanfrage)binkakundenanfrageBindingSource.Current;
            var mengenPositionForm = new MengenPositionForm(m_mengenposBindingSource);

            if (mengenPositionForm.ShowDialog() == DialogResult.OK)
            {
                 
            }
        }

        private void binkakundenanfrageBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
          
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MysqlApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class ka_kundenanfrage
    {
        public ka_kundenanfrage()
        {
            this.d_datei = new SortableBindingList<d_datei>();
            this.extpos_teilposition = new SortableBindingList<extpos_teilposition>();
            this.m_mengenpos = new SortableBindingList<m_mengenpos>();
        }
    
        public int ka_kundenanfrage_ID { get; set; }
        public Nullable<int> ka_anfragenummer { get; set; }
        public string ka_artikelnummer { get; set; }
        public string ka_verwendung { get; set; }
        public string ka_kommentar { get; set; }
        public Nullable<System.DateTime> ka_angefragt_am { get; set; }
        public Nullable<System.DateTime> ka_angebotsfrist { get; set; }
        public string ka_hersteller { get; set; }
        public string ka_zustaendig { get; set; }
        public System.DateTime ka_angelegt_am { get; set; }
        public string ka_angelegt_von { get; set; }
        public string ka_status { get; set; }
        public Nullable<System.DateTime> ka_ungueltig_am { get; set; }
        public string ka_ungueltig_von { get; set; }
        public string ka_modus { get; set; }
        public string ka_kunde { get; set; }
        public string ka_produktgruppe { get; set; }
        public string ka_artikelbezeichnung { get; set; }
        public string ka_guete { get; set; }
        public string ka_zeichnungsnummer { get; set; }
        public string ka_aenderungsindex { get; set; }
        public Nullable<float> ka_durchmesser { get; set; }
        public Nullable<float> ka_laenge { get; set; }
        public Nullable<float> ka_gewindesteigung { get; set; }
        public Nullable<float> ka_fertiggewicht { get; set; }
        public Nullable<float> ka_einsatzgewicht { get; set; }
        public string ka_abc_artikelnummer { get; set; }
        public string ka_einkaeufer_name { get; set; }
        public string ka_einkaeufer_email { get; set; }
        public string ka_einkaeufer_telefon { get; set; }
        public string ka_einkaeufer_fax { get; set; }
        public string ka_einkaeufer_mobil { get; set; }
        public string ka_einkaeufer_anrede { get; set; }
        public string ka_kundengruppe { get; set; }
        public string ka_vertreter { get; set; }
        public string ka_kundenkommentar { get; set; }
        public Nullable<int> ka_einkaeufer_ID { get; set; }
        public Nullable<int> ka_offen_vertrieb { get; set; }
        public Nullable<int> ka_offen_te { get; set; }
        public Nullable<int> ka_vk_angefordert { get; set; }
        public string ka_vk_kommentar { get; set; }
        public string ka_potenzial { get; set; }

        public virtual SortableBindingList<d_datei> d_datei { get; set; }
        public virtual e_einkaeufer e_einkaeufer { get; set; }
        public virtual SortableBindingList<extpos_teilposition> extpos_teilposition { get; set; }
        public virtual SortableBindingList<m_mengenpos> m_mengenpos { get; set; }
    }
}

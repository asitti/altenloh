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
    
    public partial class m_mengenpos
    {
        public m_mengenpos()
        {
            this.vk_vorkalkulation = new SortableBindingList<vk_vorkalkulation>();
        }
    
        public Nullable<int> m_nummer { get; set; }
        public int m_mengenPos_ID { get; set; }
        public Nullable<int> m_jahresmenge { get; set; }
        public string m_anfragenummer { get; set; }
        public string m_status { get; set; }
        public Nullable<System.DateTime> m_ungueltig_am { get; set; }
        public string m_ungueltig_von { get; set; }
        public Nullable<System.DateTime> m_abgelehnt_am { get; set; }
        public string m_abgelehnt_von { get; set; }
        public Nullable<float> m_preis_vertrieb { get; set; }
        public Nullable<float> m_marge { get; set; }
        public Nullable<float> m_umsatz { get; set; }
        public Nullable<float> m_werkzeugkosten { get; set; }
        public Nullable<float> m_tonnenerloes { get; set; }
        public Nullable<float> m_tonage { get; set; }
        public System.DateTime m_angelegt_am { get; set; }
        public string m_angelegt_von { get; set; }
        public Nullable<System.DateTime> m_angeboten_am { get; set; }
        public Nullable<System.DateTime> m_auftrag_erhalten_am { get; set; }
        public Nullable<float> m_preis_wettbewerber { get; set; }
        public Nullable<System.DateTime> m_SOP { get; set; }
        public string m_ablehnungsgrund { get; set; }
        public Nullable<int> m_kundenanfrage_ID { get; set; }
        public string m_abteilungsstatus { get; set; }
        public Nullable<int> m_vk_angefordert { get; set; }
        public Nullable<int> m_wettbewerber { get; set; }
        public Nullable<int> m_abgelehnt { get; set; }
        public Nullable<int> m_ungueltig { get; set; }
        public Nullable<int> m_angeboten { get; set; }
        public string m_te_email { get; set; }
        public string m_vk_kommentar { get; set; }
        public Nullable<int> m_herstellbar { get; set; }
        public Nullable<int> m_kapazitaet { get; set; }
        public Nullable<int> m_auftrag { get; set; }
        public string m_abgelehnt_kommentar { get; set; }
        public string m_wettbewerber_kommentar { get; set; }
        public string m_nachgefasst_kommentar { get; set; }
        public Nullable<float> m_gesamtumsatz { get; set; }
        public Nullable<float> m_angebotspreis { get; set; }
        public string m_vertriebsstatus { get; set; }
    
        public virtual ka_kundenanfrage ka_kundenanfrage { get; set; }
        public virtual SortableBindingList<vk_vorkalkulation> vk_vorkalkulation { get; set; }
    }
}

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
    
    public partial class dt_vk_vertrieb_join
    {
        public int vk_vorkalkulation_ID { get; set; }
        public Nullable<int> vk_mengenPos_ID { get; set; }
        public System.DateTime vk_angelegt_am { get; set; }
        public string vk_angelegt_von { get; set; }
        public Nullable<System.DateTime> vk_bearbeitet_am { get; set; }
        public string vk_bearbeitet_von { get; set; }
        public Nullable<System.DateTime> vk_abgelehnt_am { get; set; }
        public string vk_abgelehnt_von { get; set; }
        public string vk_status { get; set; }
        public string vk_ungültig_am { get; set; }
        public string vk_ungültig_von { get; set; }
        public string vk_kommentar_vertrieb { get; set; }
        public string vk_kommentar_te { get; set; }
        public Nullable<int> vk_gueltigkeit_tage { get; set; }
        public Nullable<System.DateTime> vk_gueltigkeit_datum { get; set; }
        public Nullable<int> vk_ta_te_anfrage_ID { get; set; }
        public Nullable<int> vk_anlagendatensatz_ID { get; set; }
        public Nullable<float> vk_lieferzeit_in_wochen { get; set; }
        public Nullable<float> vk_rohstoffkosten { get; set; }
        public Nullable<float> vk_dienstleistungskosten { get; set; }
        public Nullable<float> vk_werkzeugkosten { get; set; }
        public Nullable<float> vk_teilkosten { get; set; }
        public Nullable<float> vk_materialkosten { get; set; }
        public Nullable<float> vk_produktionskosten { get; set; }
        public Nullable<float> vk_ruestkosten { get; set; }
        public Nullable<float> vk_fertigungskosten { get; set; }
        public Nullable<float> vk_grenzherstellkosten { get; set; }
        public Nullable<float> vk_herstellkosten { get; set; }
        public Nullable<float> vk_verwaltungsgemeinkosten { get; set; }
        public Nullable<float> vk_selbstkosten { get; set; }
        public Nullable<float> vk_sonderkosten { get; set; }
        public Nullable<int> vk_drahtpreisdatensatz_ID { get; set; }
        public Nullable<int> vk_gemeinkostendatensatz_ID { get; set; }
        public Nullable<int> vk_dienstleistungsdatensatz_ID { get; set; }
        public Nullable<int> vk_werkzeugdatensatz_ID { get; set; }
        public Nullable<int> vk_teildatensatz_ID { get; set; }
        public Nullable<int> vk_sonderkostendatensatz_ID { get; set; }
        public bool vk_dspr1 { get; set; }
        public bool vk_dspr2 { get; set; }
        public bool vk_dspr3 { get; set; }
        public bool vk_dspr4 { get; set; }
        public bool vk_dspr5 { get; set; }
        public bool vk_dspr6 { get; set; }
        public bool vk_dspr7 { get; set; }
        public bool vk_dspr8 { get; set; }
        public Nullable<int> vk_geschlossen { get; set; }
        public Nullable<int> vk_abgelehnt { get; set; }
        public Nullable<int> vk_gf_freigabe { get; set; }
        public Nullable<int> vk_freigegeben { get; set; }
        public Nullable<int> vk_veroeffentlicht { get; set; }
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
    }
}
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
    
    public partial class exd_dienstleistungspreis
    {
        public int exd_dienstleistungspreis_ID { get; set; }
        public Nullable<int> exd_nummer { get; set; }
        public string exd_gruppe { get; set; }
        public string exd_bezeichnung { get; set; }
        public string exd_abmessung { get; set; }
        public string exd_lieferant { get; set; }
        public string exd_mengeneinheit { get; set; }
        public Nullable<float> exd_preis_pro_me { get; set; }
        public Nullable<float> exd_leistungsfaktor { get; set; }
        public System.DateTime exd_angelegt_am { get; set; }
        public string exd_angelegt_von { get; set; }
        public int exd_dienstleistungsdatensatz_ID { get; set; }
    
        public virtual ds_exd_dienstleistungsdatensatz ds_exd_dienstleistungsdatensatz { get; set; }
        public virtual me_mengeneinheit me_mengeneinheit { get; set; }
    }
}

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
    
    public partial class e_einkaeufer
    {
        public e_einkaeufer()
        {
            this.ka_kundenanfrage = new SortableBindingList<ka_kundenanfrage>();
        }
    
        public int e_einkaeufer_ID { get; set; }
        public int e_kunde_ID { get; set; }
        public string e_anrede { get; set; }
        public string e_einkaeufer1 { get; set; }
        public string e_email { get; set; }
        public string e_telefon { get; set; }
        public string e_mobil { get; set; }
        public string e_fax { get; set; }
        public string e_kommentar { get; set; }
        public Nullable<System.DateTime> e_angelegt_am { get; set; }
        public string e_angelegt_von { get; set; }
        public string e_status { get; set; }
        public Nullable<System.DateTime> e_ungueltig_am { get; set; }
        public string e_ungueltig_von { get; set; }
    
        public virtual SortableBindingList<ka_kundenanfrage> ka_kundenanfrage { get; set; }
        public virtual k_kunde k_kunde { get; set; }
    }
}

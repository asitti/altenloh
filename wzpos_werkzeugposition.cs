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
    
    public partial class wzpos_werkzeugposition
    {
        public wzpos_werkzeugposition()
        {
            this.vk_wzpos = new HashSet<vk_wzpos>();
        }
    
        public int wzpos_werkzeugposition_ID { get; set; }
        public Nullable<int> wzpos_nummer { get; set; }
        public string wzpos_werkzeugpositioncol { get; set; }
        public string wzpos_gruppe { get; set; }
        public string wzpos_bezeichnung { get; set; }
        public Nullable<int> wzpos_stufe { get; set; }
        public Nullable<float> wzpos_standzeit { get; set; }
        public Nullable<float> wzpos_preis { get; set; }
        public Nullable<float> wzpos_mgk3_faktor { get; set; }
        public Nullable<int> wzpos_anzahl { get; set; }
        public Nullable<float> wzpos_kosten { get; set; }
        public Nullable<int> wzpos_anzahl_bereinigt { get; set; }
        public Nullable<int> wzpos_ds_ID { get; set; }
        public string wzpos_angelegt_von { get; set; }
        public Nullable<System.DateTime> wzpos_angelegt_am { get; set; }
    
        public virtual ICollection<vk_wzpos> vk_wzpos { get; set; }
    }
}

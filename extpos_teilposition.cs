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
    
    public partial class extpos_teilposition
    {
        public extpos_teilposition()
        {
            this.vk_extpos = new HashSet<vk_extpos>();
        }
    
        public int extpos_teilposition_ID { get; set; }
        public Nullable<int> extpos_kundenanfrage_ID { get; set; }
        public Nullable<int> extpos_nummer { get; set; }
        public string extpos_gruppe { get; set; }
        public string extpos_bezeichnung { get; set; }
        public string extpos_abmessung { get; set; }
        public string extpos_mengeneinheit { get; set; }
        public Nullable<float> extpos_preis_pro_me { get; set; }
        public Nullable<float> extpos_menge_in_me { get; set; }
        public string extpos_lieferant { get; set; }
        public Nullable<float> extpos_leistungsfaktor { get; set; }
        public Nullable<float> extpos_mgk2_faktor { get; set; }
        public Nullable<float> extpos_kosten { get; set; }
        public Nullable<int> extpos_setze_gk_0 { get; set; }
        public Nullable<int> extpos_ds_ID { get; set; }
        public string extpos_angelegt_von { get; set; }
    
        public virtual ICollection<vk_extpos> vk_extpos { get; set; }
        public virtual ka_kundenanfrage ka_kundenanfrage { get; set; }
        public virtual me_mengeneinheit me_mengeneinheit { get; set; }
    }
}

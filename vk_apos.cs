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
    
    public partial class vk_apos
    {
        public int vk_apos_ID { get; set; }
        public Nullable<int> vk_apos_vorkalkulation_ID { get; set; }
        public Nullable<int> vk_apos_anlagenposition_ID { get; set; }
    
        public virtual apos_anlagenposition apos_anlagenposition { get; set; }
    }
}

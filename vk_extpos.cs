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
    
    public partial class vk_extpos
    {
        public int vk_extpos_ID { get; set; }
        public Nullable<int> vk_extpos_vorkalkulation_ID { get; set; }
        public Nullable<int> vk_extpos_teilposition_ID { get; set; }
    
        public virtual extpos_teilposition extpos_teilposition { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIS_TRY_02.Data_Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class ph_topics
    {
        public ph_topics()
        {
            this.ph_topicshistory = new HashSet<ph_topicshistory>();
        }
    
        public int id_phdTopic { get; set; }
        public int id_phdAssignment { get; set; }
        public string Name { get; set; }
        public string NameLatin { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
    
        public virtual ph_assignments ph_assignments { get; set; }
        public virtual ICollection<ph_topicshistory> ph_topicshistory { get; set; }
    }
}

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
    
    public partial class un_sciencehistory
    {
        public int id_sciencehistory { get; set; }
        public Nullable<int> id_person { get; set; }
        public Nullable<int> id_educationLevel { get; set; }
        public Nullable<System.DateTime> DiplomDate { get; set; }
        public string DiplomNumber { get; set; }
        public string IssuedBy { get; set; }
        public string Speciality { get; set; }
        public Nullable<int> id_userEdit { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> id_module { get; set; }
    
        public virtual un_educationlevels un_educationlevels { get; set; }
    }
}

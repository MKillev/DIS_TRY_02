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
    
    public partial class ph_tutors
    {
        public int id_tutor { get; set; }
        public Nullable<int> id_tutorName { get; set; }
        public int id_phdAssignment { get; set; }
        public string Name { get; set; }
    
        public virtual ph_assignments ph_assignments { get; set; }
        public virtual ph_tutornames ph_tutornames { get; set; }
    }
}

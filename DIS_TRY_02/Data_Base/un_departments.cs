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
    
    public partial class un_departments
    {
        public un_departments()
        {
            this.ph_assignments = new HashSet<ph_assignments>();
            this.un_assignments = new HashSet<un_assignments>();
            this.un_departmentshistory = new HashSet<un_departmentshistory>();
            this.un_departmenttree = new HashSet<un_departmenttree>();
            this.un_specialities = new HashSet<un_specialities>();
        }
    
        public int id_department { get; set; }
        public int id_city { get; set; }
        public string Address { get; set; }
        public string BULSTAT { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string email { get; set; }
        public string Name { get; set; }
        public string NameLatin { get; set; }
        public string NameShort { get; set; }
        public int id_departmentType { get; set; }
        public Nullable<int> id_userEdit { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> id_module { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
    
        public virtual ICollection<ph_assignments> ph_assignments { get; set; }
        public virtual ICollection<un_assignments> un_assignments { get; set; }
        public virtual un_departmenttypes un_departmenttypes { get; set; }
        public virtual ICollection<un_departmentshistory> un_departmentshistory { get; set; }
        public virtual ICollection<un_departmenttree> un_departmenttree { get; set; }
        public virtual ICollection<un_specialities> un_specialities { get; set; }
    }
}

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
    
    public partial class un_gender
    {
        public un_gender()
        {
            this.un_persons = new HashSet<un_persons>();
            this.un_personshistory = new HashSet<un_personshistory>();
        }
    
        public int id_gender { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<un_persons> un_persons { get; set; }
        public virtual ICollection<un_personshistory> un_personshistory { get; set; }
    }
}

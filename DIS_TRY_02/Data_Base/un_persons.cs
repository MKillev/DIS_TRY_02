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
    
    public partial class un_persons
    {
        public un_persons()
        {
            this.un_assignments = new HashSet<un_assignments>();
            this.un_citizenship = new HashSet<un_citizenship>();
            this.un_contactdata = new HashSet<un_contactdata>();
            this.un_healthinsuranse = new HashSet<un_healthinsuranse>();
            this.un_identitycards = new HashSet<un_identitycards>();
            this.un_identitycardshistory = new HashSet<un_identitycardshistory>();
            this.un_messages = new HashSet<un_messages>();
            this.un_personlanguages = new HashSet<un_personlanguages>();
            this.un_personshistory = new HashSet<un_personshistory>();
            this.un_users = new HashSet<un_users>();
        }
    
        public int id_person { get; set; }
        public string FirstName { get; set; }
        public string SirName { get; set; }
        public string LastName { get; set; }
        public string FirstNameLatin { get; set; }
        public string SirNameLatin { get; set; }
        public string LastNameLatin { get; set; }
        public int? id_gender { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public Nullable<int> id_userEdit { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> id_module { get; set; }
    
        public virtual ICollection<un_assignments> un_assignments { get; set; }
        public virtual ICollection<un_citizenship> un_citizenship { get; set; }
        public virtual ICollection<un_contactdata> un_contactdata { get; set; }
        public virtual un_gender un_gender { get; set; }
        public virtual ICollection<un_healthinsuranse> un_healthinsuranse { get; set; }
        public virtual ICollection<un_identitycards> un_identitycards { get; set; }
        public virtual ICollection<un_identitycardshistory> un_identitycardshistory { get; set; }
        public virtual ICollection<un_messages> un_messages { get; set; }
        public virtual ICollection<un_personlanguages> un_personlanguages { get; set; }
        public virtual ICollection<un_personshistory> un_personshistory { get; set; }
        public virtual ICollection<un_users> un_users { get; set; }
    }
}

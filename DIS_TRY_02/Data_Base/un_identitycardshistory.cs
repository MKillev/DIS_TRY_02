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
    
    public partial class un_identitycardshistory
    {
        public int id_identityCard { get; set; }
        public int Number { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string IssuedBy { get; set; }
        public int id_city { get; set; }
        public string Address { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> id_userEdit { get; set; }
        public string EGN { get; set; }
        public int id_egnType { get; set; }
        public int id_person { get; set; }
        public Nullable<int> id_cityBirth { get; set; }
        public string PicturePath { get; set; }
        public Nullable<int> id_module { get; set; }
        public string WhatIsChanged { get; set; }
        public int id_identityCardParent { get; set; }
    
        public virtual un_cities un_cities { get; set; }
        public virtual un_cities un_cities1 { get; set; }
        public virtual un_identitycards un_identitycards { get; set; }
        public virtual un_persons un_persons { get; set; }
    }
}

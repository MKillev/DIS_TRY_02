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
    
    public partial class un_userrights
    {
        public int id_userright { get; set; }
        public int id_user { get; set; }
        public int id_module { get; set; }
    
        public virtual un_users un_users { get; set; }
    }
}

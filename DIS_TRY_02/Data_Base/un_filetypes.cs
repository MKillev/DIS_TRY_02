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
    
    public partial class un_filetypes
    {
        public un_filetypes()
        {
            this.un_binaryfiles = new HashSet<un_binaryfiles>();
        }
    
        public int id_fileType { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
    
        public virtual ICollection<un_binaryfiles> un_binaryfiles { get; set; }
    }
}

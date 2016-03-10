using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TuBL.Models
{
    public class CitizenshipViewModel
    {        
        public int id_person
        {
            get;
            set;
        }
        
        public int id_citizenship
        {
            get;
            set;
        }
        
      
        public int id_country
        {
            get;
            set;
        }

        public bool isModified
        {
            get {return isModified; }
            set {isModified = false;}
        }
    }
}
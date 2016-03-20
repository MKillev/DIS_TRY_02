using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace TuBL.Models
{
    public class PersonLanguagesViewModel
    {
       
        public int id_personLanguage
        {
            get;
            set;
        }

          
        public int id_person
        {
            get;
            set;
        }
      
        public int id_language
        {
            get;
            set;
        }
    
        public int? id_languageLevel
        {
            get;
            set;
        }
        public bool isModified { get; set; }

    }
}
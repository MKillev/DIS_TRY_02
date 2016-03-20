using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace TuBL.Models
{
    public class ContactDataViewModel
    {
        public string email
        {
            get;
            set;
        }
     
        public string Phone
        {
            get;
            set;
        }
        public int id_person
        {
            get;
            set;
        }
        public bool isModified { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace TuBL.Models
{
    public class CitiesViewModel
    {
        
        public int id_city
        {
            get;
            set;
        }

       
        public string Name
        {
            get;
            set;
        }
        public int id_ekatte
        {
            get;
            set;
        }
        
        public string Municipality
        {
            get;
            set;
        }
       
        public string Region
        {
            get;
            set;
        }
        public int id_country
        {
            get;
            set;
        }
    }
}
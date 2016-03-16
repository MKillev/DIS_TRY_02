using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS_TRY_02.ViewModels
{
    public class General_View
    {
        
            public int id { get; set; }
            public string FirstName { get; set; }
            public string SirName { get; set; }
            public string LastName { get; set; }
            public string EGN { get; set; }
            public string Gender { get; set; }
            public string Citizenship { get; set; }
            public string University { get; set; }
            public int? id_dep { get; set; }
            public string Faculty { get; set; }
            public int? id_fac { get; set; }
            public string Department { get; set; }
            public int? id_uni { get; set; }
            public string Type { get; set; }
            public DateTime? Start { get; set; }
            public DateTime? End { get; set; }
            public int? id_educationform { get; set; }
            public int id_city { get; set; }
            public int? id_gender { get; set; }
    }

    }


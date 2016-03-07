using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TuBL.Models
{
    public class PHDDiplomDataViewModel
    {
        public int id_phdDiplomData { get; set; }
        public int id_phdAssignment { get; set; }
        public int id_person { get; set; }
        public string LastEducationUniversity { get; set; }
        public string LastEducationSubject { get; set; }
        public string LastEducationEndYear { get; set; }
        public string LastDiplomNumber { get; set; }
        public DateTime? LastDiplomDate { get; set; }        
        //[Required(ErrorMessage = TuBl.Constants.SelectCitiesLastEducation)]
     
        public int? id_citiesLastEducation { get; set; }
        //[Required(ErrorMessage = TuBl.Constants.SelectCountryLastEducation)]
    
        public int? id_countryLastEducation{ get; set; }        
        //[Required(ErrorMessage = TuBl.Constants.SelectEducationLast)]
     
        public int? id_educationLast { get; set; }
        public int RegionIndex { get; set; }
        public int MunicipalityIndex { get; set; }
        public int CityIndex { get; set; }
    }
}

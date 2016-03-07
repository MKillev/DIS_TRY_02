using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuBL.Models
{
    public class PhdPersonViewModel : GenericPersonViewModel
    {
        public PHDDiplomDataViewModel PHDDiplomDataViewModel { get; set; }
        public PHDAssignmentViewModel PHDAssignmentViewModel { get; set; }
		//public PersonIDCardViewModel PersonIdCardViewModel { get; set; }
		//public ContactDataViewModel ContactDataViewModel { get; set; }
       
    }
}

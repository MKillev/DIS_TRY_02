using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.Data_Base;

namespace DIS_TRY_02.ViewModels.EditWindow
{
    public class TableUpdateViewModel
    {
        public un_persons Persons { get; set; }
        public ph_assignments PHAssigments { get; set; }
        public ph_diplomdata DiplomData { get; set; }
        public un_identitycards Identitycards { get; set; }
        public un_citizenship Citizenship { get; set; }
        public ph_tutors Tutors { get; set; }
        public ph_topics Topics { get; set; }
        public un_contactdata ContactData{ get; set; }
        public un_personlanguages Languages { get; set; }
    }
}

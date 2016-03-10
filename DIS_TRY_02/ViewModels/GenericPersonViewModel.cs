using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using DIS_TRY_02.ViewModels.EditWindow;

namespace TuBL.Models
{
    public class GenericPersonViewModel
    {
        public PersonIDCardViewModel PersonIDCardViewModel { get; set; }
		public PhdPersonViewModel PhdPersonViewModel { get; set; }
        public PersonsViewModel PersonsViewModel { get; set; }
        public PersonLanguagesViewModel PersonLanguagesViewModel { get; set; }
	    public ContactDataViewModel ContactDataViewModel { get; set; }
		public PHDAssignmentViewModel PHDAssignmentViewModel { get; set;}
		public PHDDiplomDataViewModel PHDDiplomDataViewModel { get; set;}
        public CitizenshipViewModel CitizenshipViewModel { get; set; }
        public List<PersonAssignmentViewModel> PersonAssignmentViewModelLst { get; set; }

        public string email
        {
            get;
            /*{
                return ContactDataViewModel.email;
            }*/
            set;
            /*{
                if (ContactDataViewModel == null)
                {
                    ContactDataViewModel = new ContactDataViewModel();
                }
                ContactDataViewModel.email = value;
            }*/
        }

        public string Phone
        {
            get;
            /*{
                return ContactDataViewModel.Phone;
            }*/
            private set;
            /*{
                ContactDataViewModel.Phone = value;
            }*/
        }
    }
}
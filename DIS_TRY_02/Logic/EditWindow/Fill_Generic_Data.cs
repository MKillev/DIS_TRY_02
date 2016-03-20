using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.ViewModels.EditWindow;
using TuBL.Models;

namespace DIS_TRY_02.Logic.EditWindow
{
    public class Fill_Generic_Data : BaseLogic
    {
        public GenericPersonViewModel All(int id)
        {
            GenericPersonViewModel generic = new GenericPersonViewModel();

            generic.CitizenshipViewModel = CitizenshipView(id);
            generic.PHDAssignmentViewModel = Assigment_View(id);
            generic.PHDDiplomDataViewModel = Diplom_Data(id);
            generic.PersonIDCardViewModel = Id_Card(id);
            generic.PersonLanguagesViewModel = LanguagesView(id);
            generic.PersonsViewModel = person_View(id);
            generic.PhdPersonViewModel = Phd_Person_View(generic.PHDAssignmentViewModel);

            return generic;
        }
        public PersonsViewModel person_View(int id_person )
        {
            PersonsViewModel result = new PersonsViewModel();
            un_persons person = Person.GetById(id_person);
            if (person != null)
            {
                result.FirstName = person.FirstName;
                result.SirName = person.SirName;
                result.LastName = person.LastName;
                result.id_person = person.id_person;
                result.id_gender = person.id_gender;
                result.id_module = person.id_module;
                result.FirstName = person.FirstName;
                result.FirstName = person.FirstName;
            }
            return result;
        }

        public PersonIDCardViewModel Id_Card(int id_person)
        {

            PersonIDCardViewModel result = new PersonIDCardViewModel();
            var allIds = identity_cards.GetAll();
            var idCard = allIds.FirstOrDefault(k => k.id_person == id_person);

            if (idCard != null)
            {
                result.Address = idCard.Address;
                result.EGN = idCard.EGN;
                result.BirthDate = idCard.BirthDate;
                result.ExpiryDate = idCard.ExpiryDate;
                result.IssueDate = idCard.IssueDate;
                result.id_cityBirth = idCard.id_cityBirth;
                result.id_egnType = idCard.id_egnType;
                result.id_identityCard = idCard.id_identityCard;
                result.id_city = idCard.id_city;
                result.id_person = idCard.id_person;
                result.id_module =  idCard.id_module;
            }

            return result;
        }

        public PhdPersonViewModel Phd_Person_View(PHDAssignmentViewModel assigment) //PHDDiplomDataViewModel diploma)
        {
            PhdPersonViewModel result = new PhdPersonViewModel();
            result.PHDAssignmentViewModel = assigment;
            //result.PHDDiplomDataViewModel = diploma;

            return result;
        }

        public PHDAssignmentViewModel Assigment_View(int id_person)
        {
            PHDAssignmentViewModel result = new PHDAssignmentViewModel();
            var assigments = Ph_Assigments.GetAll();
            var assigm = assigments.FirstOrDefault(g => g.id_person == id_person);

            if (assigm != null)
            {
                result.id_department = assigm.id_department;
                result.id_phdAssignment = assigm.id_phdAssignment;
                result.id_educationDuration = assigm.id_educationDuration;
                result.id_person = assigm.id_person;
                result.id_educationForm = assigm.id_educationForm;
                result.id_module =  assigm.id_module;
                result.id_speciality = assigm.id_speciality;
                result.StartDate = assigm.StartDate;
                result.EndDate = assigm.EndDate;
                result.id_acceptanceReason = assigm.id_acceptanceReason;
                result.UseDormitory = assigm.UseDormitory;
                result.PHDCode = assigm.PhdCode;
                result.StartOrderNumber = assigm.StartOrderNumber;
                result.StartOrderDate = assigm.StartOrderDate;
                result.EndOrderDate = assigm.EndOrderDate;
                result.UseScholarship = assigm.UseScholarship;
                result.id_status = assigm.id_status;
                result.id_studyType = assigm.id_studyType;
                result.UseHolidayFacilities = assigm.UseHolidayFacilities;
            }

            return result;
        }

        public PHDDiplomDataViewModel Diplom_Data(int id_person)
        {
            PHDDiplomDataViewModel result = new PHDDiplomDataViewModel();
            var assigment = Ph_Assigments.GetAll();
            var diploma = Diploma.GetAll();

            var query = assigment.FirstOrDefault(f => f.id_person == id_person);
            var query1 = diploma.FirstOrDefault(f => query != null && f.id_pdhAssignment == query.id_phdAssignment);
            if (query1 != null)
            {
                result.id_phdDiplomData = query1.id_diplomData;
                result.id_phdAssignment = query1.id_pdhAssignment;
                result.id_person = id_person;
                result.id_countryLastEducation = query1.id_countryLastEducation;
                result.id_citiesLastEducation = query1.id_citiesLastEducation;
                result.id_educationLast = query1.id_educationLast;
            }

            return result;
        }

        public CitizenshipViewModel CitizenshipView(int id_person)
        {
            CitizenshipViewModel result = new CitizenshipViewModel();
            var country = Citizenship.GetAll();
            var query = country.FirstOrDefault(f => f.id_person == id_person);

            if (query != null)
            {
                result.id_person = query.id_person;
                result.id_country = query.id_country;
                result.id_citizenship = query.id_citizenship;
            }

            return result;
        }

        public ContactDataViewModel ContactData(int id_person)
        {
            ContactDataViewModel result = new ContactDataViewModel();
            var cont = Contacts.GetAll();
            var query = cont.FirstOrDefault(f => f.id_person == id_person);

            if (query != null)
            {
                result.Phone = query.Phone;
                result.email = query.email;
                result.id_person = query.id_person;
            }

            return result;
        }

        public PersonLanguagesViewModel LanguagesView(int id_person)
        {
            PersonLanguagesViewModel result = new PersonLanguagesViewModel();
            var per_lang = Person_Language.GetAll();

            var query = per_lang.FirstOrDefault(f => f.id_person == id_person);
            if (query == null)
            {
                result = null;
            }
            else
            {
                result.id_language = query.id_language;
                result.id_person = query.id_person;
                result.id_languageLevel = query.id_languageLevel;
                result.id_personLanguage = query.id_personLanguage;
            }
            return result;
        }

    }
}

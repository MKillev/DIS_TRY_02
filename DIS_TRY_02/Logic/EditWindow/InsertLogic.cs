using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.Data_Base;
using TuBL.Models;

namespace DIS_TRY_02.Logic.EditWindow
{
    public class InsertLogic : BaseLogic
    {
        public void Insert_Entry(GenericPersonViewModel generic)
        {
            un_persons person = new un_persons();
            ph_assignments assigment = new ph_assignments();
            ph_diplomdata diplomData = new ph_diplomdata();
            un_citizenship citizenship = new un_citizenship();
            un_identitycards idCards = new un_identitycards();
            un_contactdata contactData = new un_contactdata();
            un_personlanguages perLanguages = new un_personlanguages();

            person.FirstName = generic.PersonsViewModel.FirstName;
            person.SirName = generic.PersonsViewModel.SirName;
            person.LastName = generic.PersonsViewModel.LastName;
            person.id_gender = generic.PersonsViewModel.id_gender;


            assigment.id_department = generic.PHDAssignmentViewModel.id_department;
            assigment.id_phdAssignment = generic.PHDAssignmentViewModel.id_phdAssignment;
            assigment.id_educationDuration = generic.PHDAssignmentViewModel.id_educationDuration;
            assigment.id_person = generic.PHDAssignmentViewModel.id_person;
            assigment.id_educationForm = generic.PHDAssignmentViewModel.id_educationForm;
            assigment.id_module = generic.PHDAssignmentViewModel.id_module;
            assigment.id_speciality = generic.PHDAssignmentViewModel.id_speciality;
            assigment.StartDate = generic.PHDAssignmentViewModel.StartDate;
            assigment.EndDate = generic.PHDAssignmentViewModel.EndDate;
            assigment.id_acceptanceReason = generic.PHDAssignmentViewModel.id_acceptanceReason;
            assigment.UseDormitory = generic.PHDAssignmentViewModel.UseDormitory;
            assigment.StartOrderNumber = generic.PHDAssignmentViewModel.StartOrderNumber;
            assigment.StartOrderDate = generic.PHDAssignmentViewModel.StartOrderDate;
            assigment.EndOrderDate = generic.PHDAssignmentViewModel.EndOrderDate;
            assigment.UseScholarship = generic.PHDAssignmentViewModel.UseScholarship;
            assigment.id_status = generic.PHDAssignmentViewModel.id_status;
            assigment.id_studyType = generic.PHDAssignmentViewModel.id_studyType;
            assigment.UseHolidayFacilities = generic.PHDAssignmentViewModel.UseHolidayFacilities;


            diplomData.id_diplomData = generic.PHDDiplomDataViewModel.id_phdDiplomData;
            diplomData.id_pdhAssignment = generic.PHDDiplomDataViewModel.id_phdAssignment;
            //diplomData.id_person = id_person;
            diplomData.id_countryLastEducation = generic.PHDDiplomDataViewModel.id_countryLastEducation;
            diplomData.id_citiesLastEducation = generic.PHDDiplomDataViewModel.id_citiesLastEducation;
            diplomData.id_educationLast = generic.PHDDiplomDataViewModel.id_educationLast;

            citizenship.id_person = generic.CitizenshipViewModel.id_person;
            citizenship.id_country = generic.CitizenshipViewModel.id_country;
            citizenship.id_citizenship = generic.CitizenshipViewModel.id_citizenship;

            idCards.Address = generic.PersonIDCardViewModel.Address;
            idCards.EGN = generic.PersonIDCardViewModel.EGN;
            idCards.BirthDate = generic.PersonIDCardViewModel.BirthDate;
            idCards.ExpiryDate = generic.PersonIDCardViewModel.ExpiryDate;
            idCards.IssueDate = generic.PersonIDCardViewModel.IssueDate;
            idCards.id_cityBirth = generic.PersonIDCardViewModel.id_cityBirth;
            idCards.id_egnType = generic.PersonIDCardViewModel.id_egnType;
            idCards.id_identityCard = generic.PersonIDCardViewModel.id_identityCard;
            idCards.id_city = generic.PersonIDCardViewModel.id_city;
            idCards.id_person = generic.PersonIDCardViewModel.id_person;
            idCards.id_module = generic.PersonIDCardViewModel.id_module;


            contactData.Phone = generic.ContactDataViewModel.Phone;
            contactData.email = generic.ContactDataViewModel.email;
            contactData.id_person = generic.ContactDataViewModel.id_person;

            perLanguages.id_language = generic.PersonLanguagesViewModel.id_language;
            perLanguages.id_person = generic.PersonLanguagesViewModel.id_person;
            perLanguages.id_languageLevel = generic.PersonLanguagesViewModel.id_languageLevel;
            perLanguages.id_personLanguage = generic.PersonLanguagesViewModel.id_personLanguage;

           // assigment.un_persons = person;
            citizenship.un_persons = person;
            perLanguages.un_persons = person;
            diplomData.ph_assignments = assigment;
            contactData.un_persons = person;
            idCards.un_persons = person;


            Person.Insert(person);
            Ph_Assigments.Insert(assigment);
            Citizenship.Insert(citizenship);
            Person_Language.Insert(perLanguages);
            Diploma.Insert(diplomData);
            ID_Cards.Insert(idCards);
            Contacts.Insert(contactData);

        }

       
    }
}

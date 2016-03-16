using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.ViewModels;
using DIS_TRY_02.Repository;
using DIS_TRY_02.ViewModels.EditWindow;
using TuBL.Models;

namespace DIS_TRY_02.Logic.EditWindow
{
    public class UpdateLogic
    {

        public TableUpdateViewModel GenUpdate(GenericPersonViewModel generic)
        {
            TableUpdateViewModel data = new TableUpdateViewModel();

            data.Persons = Gen_Person(generic);
            data.PHAssigments = Gen_Assigments(generic);
            data.DiplomData = Gen_DiplomData(generic);
            data.Citizenship = Gen_Citizenship(generic);
            data.Identitycards = Gen_Identitycards(generic);
            data.ContactData = Gen_ContactData(generic);
            data.Languages = Gen_Languages(generic);
            //data.Topics = Gen_Topic(generic);
           // data.Tutors = Gen_Tutor(generic);

            return data;
        }
        private un_persons Gen_Person(GenericPersonViewModel gen)
        {
            un_persons per = new un_persons();
            per.id_person = gen.PersonsViewModel.id_person;
            per.FirstName = gen.PersonsViewModel.FirstName;
            per.SirName = gen.PersonsViewModel.SirName;
            per.LastName = gen.PersonsViewModel.LastName;
            per.id_gender = gen.PersonsViewModel.id_gender;
            per.id_module = gen.PersonsViewModel.id_module;
            per.FirstName = gen.PersonsViewModel.FirstName;
            per.FirstName = gen.PersonsViewModel.FirstName;
            return per;
        }
        private ph_assignments Gen_Assigments(GenericPersonViewModel gen)
        {
            ph_assignments result = new ph_assignments();
            result.id_department = gen.PHDAssignmentViewModel.id_department;
            result.id_phdAssignment = gen.PHDAssignmentViewModel.id_phdAssignment;
            result.id_educationDuration = gen.PHDAssignmentViewModel.id_educationDuration;
            result.id_person = gen.PHDAssignmentViewModel.id_person;
            result.id_educationForm = gen.PHDAssignmentViewModel.id_educationForm;
            result.id_module = gen.PHDAssignmentViewModel.id_module;
            result.id_speciality = gen.PHDAssignmentViewModel.id_speciality;
            result.StartDate = gen.PHDAssignmentViewModel.StartDate;
            result.EndDate = gen.PHDAssignmentViewModel.EndDate;
            result.id_acceptanceReason = gen.PHDAssignmentViewModel.id_acceptanceReason;
            result.UseDormitory = gen.PHDAssignmentViewModel.UseDormitory;
            //result.PHDCode = gen.PHDAssignmentViewModel.PhdCode;
            result.StartOrderNumber = gen.PHDAssignmentViewModel.StartOrderNumber;
            result.StartOrderDate = gen.PHDAssignmentViewModel.StartOrderDate;
            result.EndOrderDate = gen.PHDAssignmentViewModel.EndOrderDate;
            result.UseScholarship = gen.PHDAssignmentViewModel.UseScholarship;
            result.id_status = gen.PHDAssignmentViewModel.id_status;
            result.id_studyType = gen.PHDAssignmentViewModel.id_studyType;
            result.UseHolidayFacilities = gen.PHDAssignmentViewModel.UseHolidayFacilities;
            return result;
        }
        private ph_diplomdata Gen_DiplomData(GenericPersonViewModel gen)
        {
            ph_diplomdata result = new ph_diplomdata();
            result.id_diplomData = gen.PHDDiplomDataViewModel.id_phdDiplomData;
            result.id_pdhAssignment = gen.PHDDiplomDataViewModel.id_phdAssignment;
            //result.id_person = id_person;
            result.id_countryLastEducation = gen.PHDDiplomDataViewModel.id_countryLastEducation;
            result.id_citiesLastEducation = gen.PHDDiplomDataViewModel.id_citiesLastEducation;
            result.id_educationLast = gen.PHDDiplomDataViewModel.id_educationLast;
            return result;
        }
        private un_citizenship Gen_Citizenship(GenericPersonViewModel gen)
        {
            un_citizenship result = new un_citizenship();
            result.id_person = gen.CitizenshipViewModel.id_person;
            result.id_country = gen.CitizenshipViewModel.id_country;
            result.id_citizenship = gen.CitizenshipViewModel.id_citizenship;
            return result;
        }
        private un_identitycards Gen_Identitycards(GenericPersonViewModel gen)
        {
            un_identitycards result = new un_identitycards();
            result.Address = gen.PersonIDCardViewModel.Address;
            result.EGN = gen.PersonIDCardViewModel.EGN;
            result.BirthDate = gen.PersonIDCardViewModel.BirthDate;
            result.ExpiryDate = gen.PersonIDCardViewModel.ExpiryDate;
            result.IssueDate = gen.PersonIDCardViewModel.IssueDate;
            result.id_cityBirth = gen.PersonIDCardViewModel.id_cityBirth;
            result.id_egnType = gen.PersonIDCardViewModel.id_egnType;
            result.id_identityCard = gen.PersonIDCardViewModel.id_identityCard;
            result.id_city = gen.PersonIDCardViewModel.id_city;
            result.id_person = gen.PersonIDCardViewModel.id_person;
            result.id_module = gen.PersonIDCardViewModel.id_module;

            return result;
        }
        //private ph_topics Gen_Topic(GenericPersonViewModel gen)
        //{
        //    ph_topics result = new ph_topics();
        //    result.Name = 
        //}
        //private ph_tutors Gen_Tutor(GenericPersonViewModel gen)
        //{

        //}
        private un_contactdata Gen_ContactData(GenericPersonViewModel gen)
        {
            un_contactdata result = new un_contactdata();
            result.Phone = gen.ContactDataViewModel.Phone;
            result.email = gen.ContactDataViewModel.email;
            result.id_person = gen.ContactDataViewModel.id_person;
            return result;

        }
        private un_personlanguages Gen_Languages(GenericPersonViewModel gen)
        {
            un_personlanguages result = new un_personlanguages();
            result.id_language = gen.PersonLanguagesViewModel.id_language;
            result.id_person = gen.PersonLanguagesViewModel.id_person;
            result.id_languageLevel = gen.PersonLanguagesViewModel.id_languageLevel;
            result.id_personLanguage = gen.PersonLanguagesViewModel.id_personLanguage;
            return result;
        }
    }
}

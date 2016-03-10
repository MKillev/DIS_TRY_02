using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.Logic;
using DIS_TRY_02.Logic.EditWindow;
using DIS_TRY_02.ViewModels;
using TuBL.Models;

namespace DIS_TRY_02.Add_New_Person
{
    /// <summary>
    /// Interaction logic for Add_New_Person.xaml
    /// </summary>
    public partial class Add_New_Person : Window
    {
        private General_View editData { get; set; }
        GenericPersonViewModel generic = new GenericPersonViewModel();
        private un_persons personView;
        private ph_assignments phd_view;
        private un_identitycards identitycards;
        private un_citizenship citizenship;
        private un_contactdata contactdata;
        private ph_diplomdata diplomdata;
        private ph_tutors tutor;
        private ph_topics topic;
       
       
        public Add_New_Person(General_View person)
        {
            InitializeComponent();
            editData = person;
        }

        private void Add_New_Person_OnLoaded(object sender, RoutedEventArgs e)
        {


            Fill_Generic_Data fill = new Fill_Generic_Data();
            ComboBoxLogic comboboxLogic = new ComboBoxLogic();
            TXTLogic txtLogic = new TXTLogic();
            
            if (editData == null)
            {
                personView = new un_persons();
                identitycards = new un_identitycards();
                phd_view = new ph_assignments();
                citizenship = new un_citizenship();
                contactdata = new un_contactdata();
                diplomdata = new ph_diplomdata();
                tutor = new ph_tutors();
                topic = new ph_topics();
                cmbUniversity.ItemsSource = comboboxLogic.Unis();
            }
            else
            {
                generic = fill.All(editData.id);
                tutor = txtLogic.Tutor(editData.id);
                topic = txtLogic.Topic(editData.id);
            }
            cmbSpecialty.ItemsSource = comboboxLogic.SpecialtyList();
            cmbUniversity.ItemsSource = comboboxLogic.Unis();
            cmbCurrentCity.ItemsSource = comboboxLogic.Cities();
            cmbCurrentRegion.ItemsSource = comboboxLogic.Regions();
            cmbRegion.ItemsSource = comboboxLogic.Regions();
            cmbCity.ItemsSource = comboboxLogic.Cities();
            cmbGender.ItemsSource = comboboxLogic.Gender();
            cmbCountry.ItemsSource = comboboxLogic.ReadCountry();
            cmbEgnType.ItemsSource = comboboxLogic.Id_Types();
            cmbAccReason.ItemsSource = comboboxLogic.AccReason();
            cmbFormEdu.ItemsSource = comboboxLogic.FormEdu();
            cmbTypeEdu.ItemsSource = comboboxLogic.Type();
            cmbStatus.ItemsSource = comboboxLogic.Status();
            cmbLastLevel.ItemsSource = comboboxLogic.Levels();
            cmbLastEdu.ItemsSource = comboboxLogic.ReadCountry();
            
            cmbUniversity.DataContext = editData;
            txtPhTutor.DataContext = tutor;
            txtTopic.DataContext = topic;
            this.DataContext = generic;

            //identitycards.un_persons = personView;
        }


        private void cmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbGender.SelectedItem;
            if (editData == null)
            {
                personView.id_gender = sel.id;
            }
            else
            {
                generic.PersonsViewModel.id_gender = sel.id;
                generic.PersonsViewModel.isModified = true;
            }
        }

        private void CmbDepartment_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = new ComboBoxModel();
            sel = (ComboBoxModel) cmbDepartment.SelectedItem;
            if (editData == null)
            {
                phd_view.id_department = sel.id;
            }
            else
            {
                generic.PHDAssignmentViewModel.id_department = sel.id;
                generic.PHDAssignmentViewModel.isModified = true;
            }
            
        }

        private void CmbFaculty_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxLogic comboboxLogic = new ComboBoxLogic();
            ComboBoxModel sel = (ComboBoxModel)cmbFaculty.SelectedItem;
            cmbDepartment.IsEnabled = true;
            if (sel != null)
            {
                cmbDepartment.ItemsSource = comboboxLogic.Department(sel.id);
            }
        }

        private void CmbUniversity_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbDepartment.IsEnabled = false;
            ComboBoxLogic comboboxLogic = new ComboBoxLogic();
            ComboBoxModel sel = (ComboBoxModel)cmbUniversity.SelectedItem;
            cmbFaculty.IsEnabled = true;
            cmbFaculty.ItemsSource = comboboxLogic.Faculties(sel.id);
            cmbFaculty.DataContext = editData;
            cmbDepartment.ItemsSource = null;
            
        }

        private void CmbEgnType_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel egn_type = new ComboBoxModel();
            egn_type = (ComboBoxModel)cmbEgnType.SelectedItem;
            if (editData == null)
            {
                identitycards.id_egnType = egn_type.id;
            }
            else
            {
                generic.PersonIDCardViewModel.id_egnType = egn_type.id;
                generic.PersonIDCardViewModel.isModified = true;
            }
        }

        private void CmbCountry_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbCountry.SelectedItem;
            if (editData == null)
            {
                citizenship.un_persons = personView;
                citizenship.id_country = sel.id;
            }
            else
            {
                generic.CitizenshipViewModel.id_country = sel.id;
                generic.CitizenshipViewModel.isModified = true;
            }
        }
        private void TxtFirstName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtFirstName.Text;
            if (editData == null)
            {
                personView.FirstName = txt;
            }
            else
            {
                generic.PersonsViewModel.FirstName = txt;
                generic.PersonsViewModel.isModified = true;
            }
        }

        private void txtSirName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtSirName.Text;
            if (editData == null)
            {
                personView.SirName = txt;
            }
            else
            {
                generic.PersonsViewModel.SirName = txt;
                generic.PersonsViewModel.isModified = true;
            }
        }

        private void TxtLastName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtLastName.Text;
            if (editData == null)
            {
                personView.LastName = txt;
            }
            else
            {
                generic.PersonsViewModel.LastName = txt;
                generic.PersonsViewModel.isModified = true;
            }
        }

        private void DtpStart_OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = dtpStart.SelectedDate;
            if (editData == null)
            {
                phd_view.StartDate = date;
            }
            else
            {
                generic.PHDAssignmentViewModel.StartDate = date;
                generic.PHDAssignmentViewModel.isModified = true;
            }
        }

        private void DtpEnd_OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = dtpEnd.SelectedDate;
            if (editData == null)
            {
                phd_view.EndDate = date;
            }
            else
            {
                generic.PHDAssignmentViewModel.EndDate = date;
                generic.PHDAssignmentViewModel.isModified = true;
            }
        }

        private void TxtEGN_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtEGN.Text;
            if (editData == null)
            {
                identitycards.EGN = txt;
            }
            else
            {
                generic.PersonIDCardViewModel.EGN = txt;
                generic.PersonIDCardViewModel.isModified = true;
            }
        }

        private void BirthDate_OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = BirthDate.SelectedDate;
            if (editData == null)
            {
                identitycards.BirthDate = date;
            }
            else
            {
                generic.PersonIDCardViewModel.BirthDate = date;
                generic.PersonIDCardViewModel.isModified = true;
            }
        }

        private void CmbCity_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbCity.SelectedItem;
            if (editData == null)
            {
                identitycards.id_cityBirth = sel.id;
            }
            else
            {
                generic.PersonIDCardViewModel.id_cityBirth = sel.id;
                generic.PersonIDCardViewModel.isModified = true;
            }
        }

        private void cmbRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //cascade...
        }

        private void cmbCurrentCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbCurrentCity.SelectedItem;
            if (editData == null)
            {
                identitycards.id_city = sel.id;
            }
            else
            {
                generic.PersonIDCardViewModel.id_city = sel.id;
                generic.PersonIDCardViewModel.isModified = true;
            }
        }

        private void CmbCurrentRegion_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          //cascade...
        }

        private void TxtAddress_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtAddress.Text;
            if (editData == null)
            {
                identitycards.Address = txt;
            }
            else
            {
                generic.PersonIDCardViewModel.Address = txt;
                generic.PersonIDCardViewModel.isModified = true;
            }
        }

        private void TxtEmail_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtEmail.Text;
            if (editData == null)
            {
                contactdata.email = txt;
            }
            else
            {
                generic.ContactDataViewModel.email = txt;
                generic.ContactDataViewModel.isModified = true;
            }
        }

        private void TxtPhone_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtPhone.Text;
            if (editData == null)
            {
                //contactdata.un_persons = personView;
                contactdata.Phone = txt;
            }
            else
            {
                generic.ContactDataViewModel.Phone = txt;
                generic.PersonsViewModel.isModified = true;
            }
        }

        private void CmbSpecialty_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbSpecialty.SelectedItem;
            if (editData == null)
            {
                phd_view.id_speciality = sel.id;
            }
            else
            {
                generic.PHDAssignmentViewModel.id_speciality = sel.id;
                generic.PersonIDCardViewModel.isModified = true;
            }
        }

        private void CmbLastEdu_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbLastEdu.SelectedItem;
            if (editData == null)
            {
                diplomdata.id_countryLastEducation = sel.id;
            }
            else
            {
                generic.PHDDiplomDataViewModel.id_countryLastEducation = sel.id;
                generic.PHDDiplomDataViewModel.isModified = true;
            }
        }

        private void CmbLastLevel_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbLastLevel.SelectedItem;
            if (editData == null)
            {
                diplomdata.id_educationLast = sel.id;
            }
            else
            {
                generic.PHDDiplomDataViewModel.id_educationLast = sel.id;
                generic.PHDDiplomDataViewModel.isModified = true;
            }
        }

        private void CmbAccReason_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbAccReason.SelectedItem;
            if (editData == null)
            {
                phd_view.id_acceptanceReason = sel.id;
            }
            else
            {
                generic.PHDAssignmentViewModel.id_acceptanceReason = sel.id;
                generic.PHDAssignmentViewModel.isModified = true;
            }
        }

        private void CmbFormEdu_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbFormEdu.SelectedItem;
            if (editData == null)
            {
                phd_view.id_educationForm = sel.id;
            }
            else
            {
                generic.PHDAssignmentViewModel.id_educationForm = sel.id;
                generic.PHDAssignmentViewModel.isModified = true;
            }
        }

        private void cmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbStatus.SelectedItem;
            if (editData == null)
            {
                phd_view.id_status = sel.id;
            }
            else
            {
                generic.PHDAssignmentViewModel.id_status = sel.id;
                generic.PHDAssignmentViewModel.isModified = true;
            }
        }

        private void CmbTypeEdu_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbTypeEdu.SelectedItem;
            if (editData == null)
            {
                phd_view.id_studyType = sel.id;
            }
            else
            {
                generic.PHDAssignmentViewModel.id_studyType = sel.id;
                generic.PHDAssignmentViewModel.isModified = true;
            }
        }

        private void TxtPhTutor_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtPhTutor.Text;
            tutor.Name = txt;
        }

        private void TxtTopic_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtTopic.Text;
            topic.Name = txt;
        }
        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            BaseLogic baselogic = new BaseLogic();


            //check whether condtitions are met and warn if not


            if (editData == null)
            {
                citizenship.un_persons = personView;
                identitycards.un_persons = personView;
                identitycards.un_citizenship = citizenship;
                diplomdata.ph_assignments = phd_view;
                tutor.ph_assignments = phd_view;
                topic.ph_assignments = phd_view;
                baselogic.Person.Insert(personView);
                baselogic.Ph_Assigments.Insert(phd_view);
                baselogic.ID_Cards.Insert(identitycards);
                baselogic.citizenship.Insert(citizenship);
                baselogic.Tutors.Insert(tutor);
                baselogic.Topics.Insert(topic);
                baselogic.Diploma.Insert(diplomdata);
            }
            else
            {
                baselogic.Person.Update(personView);
            }
            
                baselogic._databaseContext.SaveChanges();
            
         
            
            //Insert_ALL();

            Close();
        }


        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

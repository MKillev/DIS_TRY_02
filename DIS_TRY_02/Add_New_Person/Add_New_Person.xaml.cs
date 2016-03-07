using System;
using System.Collections.Generic;
using System.Data;
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
        private BaseLogic baselogic;
        private un_persons personView;
        private ph_assignments phd_view;
        private un_citizenship citizenshipView;
        private un_departments departments;
        private un_departments faculty;
        private un_departments university;
        private un_gender gender;
        private StructureModel dep_structView;
        private un_cities citiesView;
        private un_identitycards identitycards;
        private un_egntypes ID_Type;
        private ComboBoxLogic comboboxLogic = new ComboBoxLogic();
        public Add_New_Person(General_View person)
        {
            InitializeComponent();
            editData = person;
        }

        private void Add_New_Person_OnLoaded(object sender, RoutedEventArgs e)
        {


            Fill_Generic_Data fill = new Fill_Generic_Data();
            baselogic = new BaseLogic();
            if (editData == null)
            {

                gender = new un_gender();
                personView = new un_persons();
                citizenshipView = new un_citizenship();
                departments = new un_departments();
                faculty = new un_departments();
                university = new un_departments();
                identitycards = new un_identitycards();
                phd_view = new ph_assignments();
                ID_Type = new un_egntypes();
                cmbUniversity.ItemsSource = comboboxLogic.Unis();
            }
            else
            {
                generic.CitizenshipViewModel = fill.CitizenshipView(editData.id);
                generic.PHDAssignmentViewModel = fill.Assigment_View(editData.id);
                //generic.PHDDiplomDataViewModel = fill.Diplom_Data(editData.id);
                generic.PersonIDCardViewModel = fill.Id_Card(editData.id);
                generic.PersonLanguagesViewModel = fill.LanguagesView(editData.id);
                generic.PersonsViewModel = fill.person_View(editData.id);
                generic.PhdPersonViewModel = fill.Phd_Person_View(generic.PHDAssignmentViewModel);//, generic.PHDDiplomDataViewModel);
                //cmbDepartment.ItemsSource = comboboxLogic.Department(editData.id_fac);
               
                
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
            cmbUniversity.DataContext = editData;
            
            this.DataContext = generic;
            
            


        }


        private void cmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //  if (generic != null)
            //  {
            //ComboBoxModel gen = new ComboBoxModel();
            //gen = (ComboBoxModel) cmbGender.SelectedItem;
            //generic.PersonsViewModel.id_gender = gen.id;
            // }
        }

        private void CmbDepartment_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //cmbFaculty.ItemsSource = comboboxLogic.Faculties(editData.id_uni);
            
        }

        private void CmbFaculty_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbFaculty.SelectedItem;
            if (sel != null)
            {
                cmbDepartment.ItemsSource = comboboxLogic.Department(sel.id);
                //cmbUniversity.DataContext = editData;
            }
        }

        private void CmbUniversity_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = (ComboBoxModel)cmbUniversity.SelectedItem;
            cmbFaculty.ItemsSource = comboboxLogic.Faculties(sel.id);
            cmbFaculty.DataContext = editData;
            cmbDepartment.ItemsSource = null;
        }

        private void CmbEgnType_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBoxModel egn_type = new ComboBoxModel();
            //egn_type = (ComboBoxModel) cmbEgnType.SelectedItem;
            //identitycards.id_egnType = egn_type.id;
        }

        private void CmbCountry_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBoxModel citizenship = new ComboBoxModel();
            //citizenship = (ComboBoxModel)cmbCountry.SelectedItem;
            //citizenshipView.id_citizenship = citizenship.id;
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            if (editData == null)
            {
                //personView.un_citizenship = citizenshipView;
                baselogic.Person.Insert(personView);
            }
            else
            {
                baselogic.Person.Update(personView);
            }
            try
            {
                baselogic._databaseContext.SaveChanges();
            }
            catch (Exception)
            {
                throw new DataException();
            }
            //Insert_ALL();

            Close();
        }


        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

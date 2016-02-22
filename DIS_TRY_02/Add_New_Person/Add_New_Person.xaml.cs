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
        
        public Add_New_Person(General_View person)
        {
            InitializeComponent();
            editData = person;
        }

        private void Add_New_Person_OnLoaded(object sender, RoutedEventArgs e)
        {
            var comboboxLogic = new ComboBoxLogic();
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
          }
            else
            {
                personView = baselogic.Person.GetById(editData.id);
                gender = baselogic.gender.GetById(editData.id_gender);
                phd_view = comboboxLogic.GetAssignment(editData.id);
                citizenshipView = baselogic.citizenship.GetById(editData.id_city);
                departments = baselogic.Departments.GetById((int)editData.id_dep);
                faculty = baselogic.Departments.GetById((int)editData.id_fac);
                university = baselogic.Departments.GetById((int)editData.id_uni);
                identitycards = baselogic.ID_Cards.GetById(editData.id);
                ID_Type = comboboxLogic.Id_Type(editData.id);
            }

            cmbGender.ItemsSource = comboboxLogic.Gender();
            cmbDepartment.ItemsSource = comboboxLogic.Department(departments.id_department, 0, 0);
            cmbFaculty.ItemsSource = comboboxLogic.Department(0, faculty.id_department, 0);
            cmbUniversity.ItemsSource = comboboxLogic.Department(0, 0,university.id_department);
            cmbCountry.ItemsSource = comboboxLogic.ReadCountry();
            cmbEgnType.ItemsSource = comboboxLogic.Id_Types();
            //dtpEnd.SelectedDate = phd_view.EndDate;
            //dtpEnd.SelectedDate = phd_view.StartDate;

            cmbGender.DataContext = gender;
            cmbDepartment.DataContext = departments;
            cmbFaculty.DataContext = faculty;
            cmbUniversity.DataContext = university;
            cmbCountry.DataContext = citizenshipView;
            cmbEgnType.DataContext = ID_Type;
            txtFirstName.DataContext = personView;
            txtSirName.DataContext = personView;
            txtLastName.DataContext = personView;
            txtEGN.DataContext = identitycards;
            dtpEnd.DataContext = phd_view;
            dtpStart.DataContext = phd_view;

        }


        private void cmbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel gen = new ComboBoxModel();
            gen = (ComboBoxModel)cmbGender.SelectedItem;
            personView.id_gender = gen.id;
        }

        private void CmbDepartment_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbFaculty_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbUniversity_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbEgnType_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel egn_type = new ComboBoxModel();
            egn_type = (ComboBoxModel) cmbEgnType.SelectedItem;
            identitycards.id_egnType = egn_type.id;
        }

        private void CmbCountry_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel citizenship = new ComboBoxModel();
            citizenship = (ComboBoxModel)cmbCountry.SelectedItem;
            citizenshipView.id_citizenship = citizenship.id;
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            if (editData == null)
            {
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

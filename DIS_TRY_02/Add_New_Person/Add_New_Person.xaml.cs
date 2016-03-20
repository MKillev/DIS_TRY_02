using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using DIS_TRY_02.ViewModels.EditWindow;
using TuBL.Models;

namespace DIS_TRY_02.Add_New_Person
{
    /// <summary>
    /// Interaction logic for Add_New_Person.xaml
    /// </summary>
    public partial class Add_New_Person : Window
    {
        private General_View EditData { get; set; }
        private GenericPersonViewModel _generic;
   
       
        public Add_New_Person(General_View person)
        {
            InitializeComponent();
            EditData = person;
        }

        private void Add_New_Person_OnLoaded(object sender, RoutedEventArgs e)
        {


            Fill_Generic_Data fill = new Fill_Generic_Data();
            ComboBoxLogic comboboxLogic = new ComboBoxLogic();
            List<ph_tutors> tutor = new List<ph_tutors>();
            TXTLogic txtLogic = new TXTLogic();
            
            if (EditData == null)
            {
              _generic = new GenericPersonViewModel();
                cmbUniversity.ItemsSource = comboboxLogic.Unis();
            }
            else
            {
                _generic = fill.All(EditData.id);
                tutor = txtLogic.Tutor(EditData.id);
               // topic = txtLogic.Topic(editData.id);
            }
            cmbSpecialty.ItemsSource = comboboxLogic.SpecialtyList();
            cmbUniversity.ItemsSource = comboboxLogic.Unis();
            cmbCurrentMunicipality.ItemsSource = comboboxLogic.Regions();
            cmbMunicipality.ItemsSource = comboboxLogic.Regions();
            cmbGender.ItemsSource = comboboxLogic.Gender();
            cmbCountry.ItemsSource = comboboxLogic.ReadCountry();
            cmbEgnType.ItemsSource = comboboxLogic.Id_Types();
            cmbAccReason.ItemsSource = comboboxLogic.AccReason();
            cmbFormEdu.ItemsSource = comboboxLogic.FormEdu();
            cmbTypeEdu.ItemsSource = comboboxLogic.Type();
            cmbStatus.ItemsSource = comboboxLogic.Status();
            cmbLastLevel.ItemsSource = comboboxLogic.Levels();
            cmbLastEdu.ItemsSource = comboboxLogic.ReadCountry();
            
            cmbUniversity.DataContext = EditData;
            dtgrdTutor.DataContext = tutor;
           // txtTopic.DataContext = topic;
            this.DataContext = _generic;

            //identitycards.un_persons = personView;
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void cmbUniversity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbDepartment.IsEnabled = false;
            ComboBoxLogic comboboxLogic = new ComboBoxLogic();
            ComboBoxModel sel = (ComboBoxModel)cmbUniversity.SelectedItem;
            cmbFaculty.IsEnabled = true;
            if (sel != null) cmbFaculty.ItemsSource = comboboxLogic.Faculties(sel.id);
            cmbFaculty.DataContext = EditData;
            cmbDepartment.ItemsSource = null;
            cmbDepartment.IsEnabled = false;
        }

        private void CmbFaculty_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbDepartment.ItemsSource = null;
            ComboBoxLogic comboboxLogic = new ComboBoxLogic();
            ComboBoxModel sel = (ComboBoxModel)cmbFaculty.SelectedItem;
            cmbDepartment.IsEnabled = true;
            if (sel != null)
            {
                cmbDepartment.ItemsSource = comboboxLogic.Department(sel.id);
            }
        }

        private void cmbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBoxModel sel = new ComboBoxModel();
            //sel = (ComboBoxModel)cmbDepartment.SelectedItem;
            //if (sel != null)
            //{
            //    if (EditData == null)
            //    {
            //        _generic.PHDAssignmentViewModel.id_department = sel.id;
            //    }
            //    else
            //    {
            //        _generic.PHDAssignmentViewModel.id_department = sel.id;
            //        _generic.PHDAssignmentViewModel.isModified = true;
            //    }
            //}

        }

        private void CmbCity_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbMunicipality_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         ComboBoxModel sel = new ComboBoxModel();
         ComboBoxLogic comboboxLogic = new ComboBoxLogic();
            sel = (ComboBoxModel) cmbMunicipality.SelectedItem;
            if (sel != null)
            {
                cmbCity.IsEnabled = true;
                cmbCity.ItemsSource = comboboxLogic.Cities(sel.Name);
            }
        }

        private void CmbCurrentCity_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbCurrentMunicipality_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxModel sel = new ComboBoxModel();
            ComboBoxLogic comboboxLogic = new ComboBoxLogic();
            sel = (ComboBoxModel)cmbCurrentMunicipality.SelectedItem;
            if (sel != null)
            {
                cmbCurrentCity.IsEnabled = true;
                cmbCity.ItemsSource = comboboxLogic.Cities(sel.Name);
            }
        }
        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            BaseLogic baselogic = new BaseLogic();
            UpdateLogic updatelogic = new UpdateLogic();
            TableUpdateViewModel data = new TableUpdateViewModel();
            InsertLogic Insert_Logic = new InsertLogic();
            if (_generic.PHDAssignmentViewModel.EndDate == null)
            {
                MessageBox.Show("Моля въведете Крайна Дата");
                return;
            }
            if (_generic.PHDAssignmentViewModel.StartDate == null)
            {
                MessageBox.Show("Моля въведете Начална Дата");
                return;
            }
            if (_generic.PHDAssignmentViewModel.id_department == null)
            {
                MessageBox.Show("Моля въведете Катедра на Обучение");
                return;
            }
            if (_generic.PersonsViewModel.FirstName == null)
            {
                MessageBox.Show("Моля въведете Първо Име");
                return;
            }
            if (_generic.PersonsViewModel.LastName == null)
            {
                MessageBox.Show("Моля въведете Фамилия");
                return;
            }
            if (_generic.PersonsViewModel.id_gender == null)
            {
                MessageBox.Show("Моля въведете ПОЛ");
                return;
            }
            if (EditData == null)
            {
                Insert_Logic.Insert_Entry(_generic);
            }
            else
            {
                updatelogic.Update_Entry(_generic, EditData.id);
            }
            Close();
        }

        private void Grid_OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _generic.IsModified = true;
        }
    }
}

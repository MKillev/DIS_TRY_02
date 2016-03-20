using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TuBL.Models;
using DIS_TRY_02.Logic;
using DIS_TRY_02.Add_New_Person;
using DIS_TRY_02.Logic.EditWindow;
using DIS_TRY_02.ViewModels;

namespace DIS_TRY_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
             InitializeComponent();         
        }
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataGridLogic person = new DataGridLogic();
            var data = person.LoadGridData();

            DataGrid.DataContext = data;
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            General_View person = (General_View)row.DataContext;    
            if (row != null)
            {
                var addnew = new Add_New_Person.Add_New_Person(person);
                addnew.ShowDialog();               
            }
        }

        private void AddNew_OnClick(object sender, RoutedEventArgs e)
        {
            var addnew = new Add_New_Person.Add_New_Person(null);
            addnew.ShowDialog();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Refresh_OnClick(object sender, RoutedEventArgs e)
        {
            DataGrid.Items.Refresh();
        }
    }
}

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
using DIS_TRY_02.Model;
using TuBL.Models;

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

        public void Init()
        {
            //General<PersonsViewModel> person = null;
            //var data = person.Initialize_Grid();
            //DataGrid.DataContext = data;
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            General person = new General();
            var data = person.Initialize_Grid();
            DataGrid.DataContext = data;
        }
    }
}

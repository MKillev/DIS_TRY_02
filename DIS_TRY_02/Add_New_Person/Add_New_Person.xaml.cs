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
using System.Windows.Shapes;
using DIS_TRY_02.Logic.EditWindow;
using DIS_TRY_02.ViewModels;

namespace DIS_TRY_02.Add_New_Person
{
    /// <summary>
    /// Interaction logic for Add_New_Person.xaml
    /// </summary>
    public partial class Add_New_Person : Window
    {
        private General_View editData { get; set; }
        public Add_New_Person(General_View data)
        {
            InitializeComponent();
            editData = data;
        }

        private void Add_New_Person_OnLoaded(object sender, RoutedEventArgs e)
        {
            EditGrid.DataContext = editData;
           EditGrid.CurrentCellChanged += EditGridOnCurrentCellChanged;  
        }

        private void EditGridOnCurrentCellChanged(object sender, EventArgs eventArgs)
        {
            var edit = new EditWindowLogic();
            edit.CellChangeLogic(editData);
        }
    }
}

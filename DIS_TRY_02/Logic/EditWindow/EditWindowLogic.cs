using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.ViewModels;
using DIS_TRY_02.Repository;

namespace DIS_TRY_02.Logic.EditWindow
{
   public class EditWindowLogic
    {
        public void CellChangeLogic(General_View rowView)
        {
            DIS_Entities dbContext;
            var repository = new Repository<General_View>();
           // repository.Update(entry);
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.ViewModels;

namespace DIS_TRY_02.Logic.EditWindow
{
    class DepartmentsLogic : BaseLogic
    {
        private int? id_dep;

        public DepartmentsLogic (int? id_dep)
        {
            this.id_dep = id_dep;
        }

        //public List<ComboBoxModel> GetHierarchy()
        //{
        //    List<ComboBoxModel> result = new List<ComboBoxModel>();
        //    var dep = new un_departments();
        //    var dep_tree = new un_departmenttree();

        //    var query = 
        //}
    }
}

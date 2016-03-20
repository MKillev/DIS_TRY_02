using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.Repository;
using DIS_TRY_02.ViewModels;

namespace DIS_TRY_02.Logic
{
   public class DataGridLogic : InitGrid
   {
       private DIS_Entities dbContext;
       public List<General_View> LoadGridData()
       {   
                   
           List<General_View> DataGridData = new List<General_View>();
           var joinedTables = JoinTables();
           var baselogic = new BaseLogic();
           var departments = baselogic.Departments.GetAll();
           var country = baselogic.Country.GetAll();
           var gender = baselogic.gender.GetAll();
           for (int i = 0; i < joinedTables.Count; i++)
           {
               var query1 =
                   departments.FirstOrDefault(w => w.id_department == joinedTables[i].id_dep);
               joinedTables[i].Department = (query1 != null ? query1.Name: null);
                var query2 =
                   departments.FirstOrDefault(w => w.id_department == joinedTables[i].id_fac);
                joinedTables[i].Faculty = (query2 != null ? query2.Name : null);
                var query3 =
                   departments.FirstOrDefault(w => w.id_department == joinedTables[i].id_uni);
                joinedTables[i].University = (query3 != null ? query3.Name : null);
                var query4 = country.FirstOrDefault(w => w.id_country == joinedTables[i].id_city);
                joinedTables[i].Citizenship = (query4 != null ? query4.Name : null);
                var query5 = gender.FirstOrDefault(w => w.id_gender == joinedTables[i].id_gender);
                joinedTables[i].Gender = (query5 != null ? query5.Name : null);
            }
           
           return joinedTables;   
       }

       //public General_View GetIDs(General_View person)
       //{
       //     General_View result = new General_View();
       //     var baselogic = new BaseLogic();
       //     var departments = baselogic.Departments.GetAll();
       //     var country = baselogic.Country.GetAll();
       //     var gender = baselogic.gender.GetAll();
       //    var query1 = departments.FirstOrDefault(w => w.Name == person.Department);
       //    result.id_dep = query1.id_department;
       //     var query2 = departments.FirstOrDefault(w => w.Name == person.Faculty);
       //    result.id_fac = query2.id_department;
       //     result
       //}
    }
}

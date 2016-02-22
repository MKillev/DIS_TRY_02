using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.ViewModels;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.Logic;

namespace DIS_TRY_02.Logic
{
     public class InitGrid : BaseLogic
    {
        public List<General_View> JoinTables()
        {
            List<General_View> Complete_Data = new List<General_View>();
            var personal = Person.GetAll();
            var assigments = Ph_Assigments.GetAll();
            var country = citizenship.GetAll();
            var Tree = Dep_Tree.GetAll();
            var identityCard = ID_Cards.GetAll();

            var result = (from per in personal
                          join ass in assigments on per.id_person equals ass.id_person into assG
                          from ass1 in assG.DefaultIfEmpty()
                          join id in identityCard on per.id_person equals id.id_person into idG
                          from id1 in idG.DefaultIfEmpty()
                          join cit in country on per.id_person equals cit.id_person into citG
                          from cit1 in citG.DefaultIfEmpty()
                          join dt in Tree on (ass1 == null ? null :ass1.id_department) equals dt.id_department into dtG
                          from dt1 in dtG.DefaultIfEmpty()
                          select new General_View()
                          {
                              EGN = (id1 != null) ? id1.EGN : null,
                              id_dep = (ass1 != null) ? ass1.id_department : 0,
                              id_fac = (dt1 != null) ? dt1.un_departmenttree2.id_department : 0,
                              id_uni = (dt1 != null) ? dt1.un_departmenttree2.un_departmenttree2.id_department : 0,
                              id_educationform = (ass1 != null) ? ass1.id_educationForm : 0,
                              Start = (ass1 != null) ? ass1.StartDate : null,
                              End = (ass1 != null) ? ass1.EndDate : null,
                              FirstName = per.FirstName,
                              SirName = per.SirName,
                              LastName = per.LastName,
                              id = per.id_person,
                              id_gender = per.id_gender,
                              id_city = (cit1 != null) ? cit1.id_country : 0,
                          }).GroupBy(p => p.id);
            foreach (var data in result)
            {
                Complete_Data.Add(data.FirstOrDefault());
            }
            return Complete_Data;
        }
    }
}

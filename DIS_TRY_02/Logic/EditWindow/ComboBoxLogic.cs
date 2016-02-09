using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.ViewModels;

namespace DIS_TRY_02.Logic.EditWindow
{
    public class ComboBoxLogic : BaseLogic
    {
        public List<ComboBoxModel> ReadDepartment(int id_person, string department)
        {
            var departments = Departments.GetAll();
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            if (id_person != 0)
            {
                var query = departments.FirstOrDefault(f => f.Name == department);
                result.Add(new ComboBoxModel {id = (int) query.id_department, Name = query.Name});
            }
            else
            {
                result.AddRange(departments.Select(t => new ComboBoxModel {id = t.id_department, Name = t.Name}));
            }
            return result;
        }

        public List<ComboBoxModel> ReadCountry(int id_person, string citizenship)
        {
            var country = Country.GetAll();
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            if (id_person != 0)
            {
                var query = country.FirstOrDefault(f => f.Name == citizenship);
                result.Add(new ComboBoxModel {id = query.id_country, Name = query.Name});
            }
            else
            {
                result.AddRange(country.Select(t => new ComboBoxModel {id = t.id_country, Name = t.Name}));
            }
            return result;
        }

        public List<ComboBoxModel> Gender(int id_person, string Gender)
        {
            var gen = gender.GetAll();
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            if (id_person != 0)
            {
                var query = gen.FirstOrDefault(f => f.Name == Gender);
                result.Add(new ComboBoxModel {id = query.id_gender, Name = query.Name});
            }
            else
            {
                result.AddRange(gen.Select(t=> new ComboBoxModel {id = t.id_gender, Name = t.Name}));
            }
            return result;
        }
    }
}

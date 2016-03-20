using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.ViewModels;
using TuBL.Models;

namespace DIS_TRY_02.Logic.EditWindow
{
    public class ComboBoxLogic : BaseLogic
    {
        //public List<ComboBoxModel> ReadDepartment(int id_person, string department)
        //{
        //    var departments = Departments.GetAll();
        //    List<ComboBoxModel> result = new List<ComboBoxModel>();

        //    if (id_person != 0)
        //    {
        //        var query = departments.FirstOrDefault(f => f.Name == department);
        //        result.Add(new ComboBoxModel {id = (int) query.id_department, Name = query.Name});
        //    }
        //    else
        //    {
        //        result.AddRange(departments.Select(t => new ComboBoxModel {id = t.id_department, Name = t.Name}));
        //    }
        //    return result;
        //}

        public List<ComboBoxModel> ReadCountry()
        {
            var country = Country.GetAll();
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            result = country.Select(s => new ComboBoxModel {id = s.id_country, Name = s.Name}).ToList();

            return result;
        }

        public List<ComboBoxModel> Gender()
        {
            var gen = gender.GetAll();
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            result = gen.Select(s => new ComboBoxModel {id = s.id_gender, Name = s.Name}).ToList();
            return result;
        }

        public List<ComboBoxModel> Id_Types()
        {
            var gen = ID_Type.GetAll();
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            result = gen.Select(s => new ComboBoxModel {id = s.id_egntype, Name = s.Name}).ToList();
            return result;
        }

        public ph_assignments GetAssignment(int id)
        {
            var assigm = Ph_Assigments.GetAll();
            ph_assignments result = assigm.FirstOrDefault(f => f.id_person == id);
            return result;
        }

        public un_egntypes Id_Type(int id)
        {
            un_egntypes result = new un_egntypes();
            var type = ID_Type.GetAll();
            var id_card = identity_cards.GetAll();
            var query = id_card.FirstOrDefault(f => f.id_person == id);
            return result = type.FirstOrDefault(s => s.id_egntype == query.id_egnType);
        }



        public List<ComboBoxModel> Department(int? id_fac = 0)
        {
            var dep = Departments.GetAll();
            var tree = Dep_Tree.GetAll();
            List<ComboBoxModel> res = new List<ComboBoxModel>();
            //if (id_fac != 0)
           // {
                var query = tree.FirstOrDefault(w => w.id_department == id_fac);
                var query1 = tree.Where(w => w.id_departmentParent == query.id_departmentTree).ToList();
                for (int i = 0; i < query1.Count; i++)
                {
                    var temp = dep.FirstOrDefault(f => f.id_department == query1[i].id_department);
                    res.Add(new ComboBoxModel {id = temp.id_department, Name = temp.Name});
                }
               
           // }
            //else if (id_dep != 0)
            //{
            //    var query = tree.FirstOrDefault(w => w.id_department == id_dep);
            //    var query1 = tree.Where(s => s.id_departmentParent == query.id_departmentParent).ToList();
            //    for (int i = 0; i < query1.Count; i++)
            //    {
            //        var temp = dep.FirstOrDefault(f => f.id_department == query1[i].id_department);
            //        res.Add(new ComboBoxModel { id = temp.id_department, Name = temp.Name });
            //    }
               
            //}
            return res;
        }

        public List<ComboBoxModel> Unis()
        {
            var dep = Departments.GetAll();
            var tree = Dep_Tree.GetAll();
            List<ComboBoxModel> res = new List<ComboBoxModel>();

            var query = tree.Where(w => w.id_departmentTree == w.id_departmentParent).ToList();
           for(int i = 0; i<query.Count; i++)
           {
               var temp = dep.FirstOrDefault(f => f.id_department == query[i].id_department);
                res.Add(new ComboBoxModel {id = temp.id_department, Name = temp.Name});
           }
            return res;
        }
        public List<ComboBoxModel> Faculties(int? id_uni)
        {
            var dep = Departments.GetAll();
            var tree = Dep_Tree.GetAll();
            List<ComboBoxModel> res = new List<ComboBoxModel>();

            var query = tree.FirstOrDefault(w => w.id_department == id_uni);
            var query1 = tree.Where(w => w.id_departmentParent == query.id_departmentTree).ToList();
            for (int i = 0; i < query1.Count; i++)
            {
                var temp = dep.FirstOrDefault(f => f.id_department == query1[i].id_department);
                res.Add(new ComboBoxModel { id = temp.id_department, Name = temp.Name });
            }
            return res;
        }

        public List<ComboBoxModel> Cities(string Name)
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var cities = City.GetAll();
            result = cities.Where(w=> w.Region == Name).Select(s => new ComboBoxModel {id = s.id_city, Name = s.Name}).ToList();
            return result;
        }
        public List<ComboBoxModel> Regions()
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var region = Region.GetAll();
            result = region.Select(s => new ComboBoxModel { id = s.id_Region, Name = s.Name }).ToList();
            return result;
        }

        public List<ComboBoxModel> Municipalitiy()
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var municipality = Municipalities.GetAll();
            result = municipality.Select(s => new ComboBoxModel { id = s.id_municipality, Name = s.Name }).ToList();
            return result;
        } 
        public List<ComboBoxModel> SpecialtyList()
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var spec = SpecialtyTypes.GetAll();
            result = spec.Select(s => new ComboBoxModel {id = s.id_specialityType, Name = s.Name}).ToList();
            return result;
        }
        public List<ComboBoxModel> Levels()
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var lev = EducationLevel.GetAll();
            result = lev.Select(s => new ComboBoxModel { id = s.id_educationLevel, Name = s.Name }).ToList();
            return result;
        }
        public List<ComboBoxModel> AccReason()
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var acc = AcceptanceReasons.GetAll();
            result = acc.Select(s => new ComboBoxModel { id = s.id_acceptanceReason, Name = s.Name }).ToList();
            return result;
        }public List<ComboBoxModel> FormEdu()
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var form = EducationForms.GetAll();
            result = form.Select(s => new ComboBoxModel { id = s.id_educationForm, Name = s.Name }).ToList();
            return result;
        }
        public List<ComboBoxModel> Type()
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var type = StudyType.GetAll();
            result = type.Select(s => new ComboBoxModel { id = s.id_studyType, Name = s.Name }).ToList();
            return result;
        }
        public List<ComboBoxModel> Status()
        {
            List<ComboBoxModel> result = new List<ComboBoxModel>();
            var status = Statuses.GetAll();
            result = status.Select(s => new ComboBoxModel { id = s.id_status, Name = s.Name }).ToList();
            return result;
        }

    }
}

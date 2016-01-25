using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.Data_Base;
using DIS_TRY_02.Repository;
using DIS_TRY_02.ViewModels;
using TuBL.Models;

namespace DIS_TRY_02.Model
{
    public class GetRepo
    {
        public Repository<un_persons> Person
        {
            get { return new Repository<un_persons>(new DIS_Entities()); }
        }

        public Repository<ph_assignments> ph_assigments
        {
            get { return new Repository<ph_assignments>(new DIS_Entities()); }
        }

        public Repository<un_departmenttree> Tree
        {
            get { return new Repository<un_departmenttree>(new DIS_Entities()); }
        }

        public Repository<un_identitycards> ID_Cards
        {
            get {return  new Repository<un_identitycards>(new DIS_Entities()); }
        }

        public Repository<un_departmenttree> Dep_Tree
        {
            get { return new Repository<un_departmenttree>(new DIS_Entities());}
        }

        public Repository<un_departments> Departments
        {
            get { return new Repository<un_departments>(new DIS_Entities());}
        } 
        //  Repository<un_citizenship> citizenship = new Repository<un_citizenship>(new DIS_Entities());
    }
    public class General : GetRepo
    {        
          
        public List<General_View> Initialize_Grid()
        {
            List<General_View> Complete_Data = new List<General_View>();
            General_View Current = new General_View();
            string department, faculty, university;
            var personal = Person.GetAll();
            var assigments = ph_assigments.GetAll();
           // var wherefrom = citizenship.GetAll();
            
            var identityCard = ID_Cards.GetAll();
            
        
            for (int i = 0; i < personal.Count; i++)
            {
                Complete_Data.Add(new General_View());            
                Complete_Data[i].FirstName = personal[i].FirstName;
                Complete_Data[i].LastName = personal[i].LastName;
                Complete_Data[i].SirName = personal[i].SirName;
                Complete_Data[i].id = personal[i].id_person;
                var query = identityCard.FirstOrDefault(w => w.id_person == Complete_Data[i].id);
                Complete_Data[i].EGN = query.EGN;
                //Complete_Data[i].Start = assigments.Where(w => w.id_person == Complete_Data[i].id).Select(s => s.StartDate).ToString();
                //Complete_Data[i].End = assigments.Where(w => w.id_person == Complete_Data[i].id).Select(s => s.EndDate).ToString();
                FindDep(Complete_Data[i].id, assigments, out department, out faculty, out university);
                Complete_Data[i].Department = department;
                Complete_Data[i].Faculty = faculty;
                Complete_Data[i].University = university;
            }
            return Complete_Data;
        }

        private void FindDep(int id_person, List<ph_assignments> assign, out string Department, out string Faculty, out string University)
        {
            var Tree = Dep_Tree.GetAll();
            var Dep = Departments.GetAll();
            var id_dep = assign.Where(w => w.id_person == id_person).Select(s => s.id_department).ToList();
            if (id_dep.Count > 0)
            {
                if (id_dep[0] == null || id_dep[0].Value == 161 || id_dep[0].Value == 162)
                {
                    Department = null;
                    Faculty = null;
                    University = null;
                    return;
                }
            }
            else
            {
                Department = null;
                Faculty = null;
                University = null;
                return;
            }
            Department = Dep.Where(w => w.id_department == id_dep.FirstOrDefault()).Select(s => s.Name).ToString();
            var dep_parent = Tree.Where(w => w.id_department == id_dep.FirstOrDefault()).Select(s => s.id_departmentParent).ToList();
            var id_faculty = Tree.Where(w => w.id_departmentParent == dep_parent.First()).Select(s => s.id_department).ToList();
             Faculty = Dep.Where(w => w.id_department == id_faculty.FirstOrDefault()).Select(s => s.Name).ToString();
            var fac_parent =
                Tree.Where(w => w.id_department == id_faculty.FirstOrDefault())
                    .Select(s => s.id_departmentParent)
                    .ToList();
            var id_uni =
                Tree.Where(w => w.id_departmentParent == fac_parent.FirstOrDefault())
                    .Select(s => s.id_department)
                    .ToList();
            University = Dep.Where(w => w.id_department == id_uni.FirstOrDefault()).Select(s => s.Name).ToString();
        }

        //private string FindFaculty(General_View Department)
        //{
        //    string Faculty;
        //    var Tree = Dep_Tree.GetAll();
        //    var id_parent = Tree.Where(Department.)
        //}
    }
}

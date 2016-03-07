using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TuBL.Models
{
    public class PersonAssignmentViewModel
    {
      
        public int id_person { get; set; }

       
        public int id_university { get; set; }

        private int? id_fac = null;
      
        public int id_faculty
        {
            get
            {
                if (id_fac == null)
                {
                    return id_university;
                }
                else
                {
                    return (int)id_fac;
                }
            }
            set
            {
                id_fac = value;
            }
        }


        private int? id_dep = null;
   
        public int id_department
        {
            get
            {
                if(id_dep == null)
                {
                    return id_faculty;
                }
                else
                {
                    return (int)id_dep;
                }
            }
            set
            {
                id_dep = value;
            }
        }

      
        public int id_position { get; set; }

        public DateTime? Timestamp { get; set; }
        public int id_userEdit { get; set; }

        public int id_assignment { get; set; }

        public int UniversityIndex { get; set; }
        public int FacultyIndex { get; set; }
        public int DepartmentIndex { get; set; }
    }
}

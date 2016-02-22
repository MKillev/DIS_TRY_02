using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TuBL.Models
{
    public class StructureModel
    {

        public string Name
        {
            get;
            set;
        }

        public string OldName
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }
        public int DepartmentType
        {
            get;
            set;
        }
        public int id_departmentParent
        {
            get;
            set;
        }
        public int id_department
        {
            get;
            set;
        }
        public bool hasChildren
        {
            get;
            set;
        }
    }
}

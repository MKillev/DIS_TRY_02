using DIS_TRY_02.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIS_TRY_02.Data_Base;

namespace DIS_TRY_02.Logic
{
    public class BaseLogic
    {
       
            public Repository<un_persons> Person
            {
                get { return new Repository<un_persons>(new DIS_Entities()); }
            }
            public Repository<un_gender> gender
            {
                get { return new Repository<un_gender>(new DIS_Entities()); }
            }
            public Repository<un_countries> Country
            {
                 get { return new Repository<un_countries>(new DIS_Entities()); }
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
                get { return new Repository<un_identitycards>(new DIS_Entities()); }
            }

            public Repository<un_departmenttree> Dep_Tree
            {
                get { return new Repository<un_departmenttree>(new DIS_Entities()); }
            }

            public Repository<un_departments> Departments
            {
                get { return new Repository<un_departments>(new DIS_Entities()); }
            }
            public Repository<un_citizenship> citizenship
            {
                get { return new Repository<un_citizenship>(new DIS_Entities()); }
            }
            //  Repository<un_citizenship> citizenship = new Repository<un_citizenship>(new DIS_Entities());
        
    }
}

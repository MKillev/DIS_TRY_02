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
        internal readonly DIS_Entities _databaseContext;
        public BaseLogic()
        {
            _databaseContext = new DIS_Entities();
            //_databaseContext.Database.Connection.ConnectionString = cs;
        }
        public Repository<un_persons> Person
            {
                get { return new Repository<un_persons>(_databaseContext); }
            }
            public Repository<un_gender> gender
            {
                get { return new Repository<un_gender>(_databaseContext); }
            }
            public Repository<un_countries> Country
            {
                 get { return new Repository<un_countries>(_databaseContext); }
            }

            public Repository<ph_assignments> ph_assigments
            {
                get { return new Repository<ph_assignments>(_databaseContext); }
            }

            public Repository<un_departmenttree> Tree
            {
                get { return new Repository<un_departmenttree>(_databaseContext); }
            }

            public Repository<un_identitycards> ID_Cards
            {
                get { return new Repository<un_identitycards>(_databaseContext); }
            }

            public Repository<un_departmenttree> Dep_Tree
            {
                get { return new Repository<un_departmenttree>(_databaseContext); }
            }

            public Repository<un_departments> Departments
            {
                get { return new Repository<un_departments>(_databaseContext); }
            }
            public Repository<un_citizenship> citizenship
            {
                get { return new Repository<un_citizenship>(_databaseContext); }
            }
       
        
    }
}

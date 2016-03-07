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
        public Repository<un_egntypes> ID_Type
        {
            get { return new Repository<un_egntypes>(_databaseContext); }
        }
        public Repository<un_gender> gender
        {
            get { return new Repository<un_gender>(_databaseContext); }
        }
        public Repository<un_countries> Country
        {
            get { return new Repository<un_countries>(_databaseContext); }
        }
        public Repository<ph_diplomdata> Diploma
        {
            get { return new Repository<ph_diplomdata>(_databaseContext); }
        }
        public Repository<ph_assignments> Ph_Assigments
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
        public Repository<un_contactdata> Contacts
        {
            get { return new Repository<un_contactdata>(_databaseContext); }
        }
        public Repository<un_languages> Languages
        {
            get { return new Repository<un_languages>(_databaseContext); }
        }
        public Repository<un_personlanguages> Person_Language
        {
            get { return new Repository<un_personlanguages>(_databaseContext); }
        }

        public Repository<un_departments> Departments
        {
            get { return new Repository<un_departments>(_databaseContext); }
        }
        public Repository<un_identitycards> identity_cards
        {
            get { return new Repository<un_identitycards>(_databaseContext); }
        }
        public Repository<un_citizenship> citizenship
        {
            get { return new Repository<un_citizenship>(_databaseContext); }
        }
        public Repository<un_cities> City
        {
            get { return new Repository<un_cities>(_databaseContext); }
        }
        public Repository<un_regions> Region
        {
            get { return new Repository<un_regions>(_databaseContext); }
        }
        public Repository<un_specialities> Specialty
        {
            get { return new Repository<un_specialities>(_databaseContext); }
        }
        public Repository<un_specialitytypes> SpecialtyTypes  
        {
            get { return new Repository<un_specialitytypes>(_databaseContext); }
        }

    }
}

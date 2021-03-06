﻿using System;

namespace DIS_TRY_02.ViewModels.EditWindow
{
    public class PersonsViewModel
    {

        
        public int id_person
        {
            get;
            set;
        }
       
        public string FirstName
        {
            get;
            set;
        }
      
        public string SirName
        {
            get;
            set;
        }
     
        public string LastName
        {
            get;
            set;
        }

       
        public string FirstNameLatin
        {
            get;
            set;
        }

      
        public string SirNameLatin
        {
            get;
            set;
        }

       
        public string LastNameLatin
        {
            get;
            set;
        }
       
        public int? id_gender { get; set; }

     
        public string Title
        {
            get;
            set;
        }

     
        public DateTime? ValidFrom
        {
            get;
            set;
        }

        
        public DateTime? ValidTo
        {
            get;
            set;
        }

       
        public int? id_userEdit
        {
            get;
            set;
        }

      
        public DateTime? Timestamp
        {
            get;
            set;
        }

    
        public int? id_module
        {
            get;
            set;
        }
        public bool isModified { get; set; }

    }
}
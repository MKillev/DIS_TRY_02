using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TuBL.Models
{
    public class PersonIDCardViewModel
    {
        public int id_identityCard {get; set;}
        
        public int? Number {get; set;}
        
        public DateTime? ExpiryDate {get; set;}
        
        public DateTime? IssueDate {get; set;}
        public string IssuedBy {get; set;}
        public int RegionIndex { get; set; }
        public int MunicipalityIndex { get; set; }
        public int CityIndex{ get; set; }
        public int? id_city {get; set;}
        public int id_ekatte { get; set; }
        //[Required(ErrorMessage = TuBl.Constants.EnterAddres)]
        
        public string Address {get; set;}
        public DateTime? ValidFrom {get; set;}
        public DateTime? ValidTo {get; set;}
        public DateTime? Timestamp {get; set;}
        public int? id_userEdit {get; set;}
    
        public string EGN {get; set;}
       
        public int? id_egnType { get; set; }
        
        //[Required(ErrorMessage = TuBl.Constants.EnterBirthDate)]
        
       
        public DateTime? BirthDate {get; set;}
        
        [Required]
        public int id_person {get; set;}
        public int RegionBirthIndex { get; set; }
        public int MunicipalityBirthIndex { get; set; }
        public int CityBirthIndex { get; set; }
        public int? id_cityBirth {get; set;}
        public int id_ekatteBirth { get; set; }
        public string PicturePath {get; set;}
        public int? id_module {get; set;}
        public string WhatIsChanged { get; set; }
        public bool isModified { get; set; }
    }
}
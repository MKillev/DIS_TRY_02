using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TuBL.Models
{
    public class PHDAssignmentViewModel
    {
        public int id_phdAssignment { get; set; }
        public int id_person { get; set; }
        public int? id_professionalGroup { get; set; }
        //[Required(ErrorMessage = TuBl.Constants.EnterStartOrderNumber )]
      
        public string StartOrderNumber { get; set; }
        public string PHDCode { get; set; }
        public DateTime? StartOrderDate { get; set; }
        
        public string EndOrderNumber { get; set; }
        public DateTime? EndOrderDate { get; set; }
     
        public DateTime? StartDate { get; set; }
        
     
        public DateTime? EndDate { get; set; }
    
        public int? id_status { get; set; }
        public int id_userEdit { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? id_module { get; set; }

        public int? id_studyType { get; set; }
        public int? id_basicClass { get; set; }
        public int? id_nsiCode { get; set; }
        public int? id_acceptanceReason { get; set; }
        public int? id_educationDuration { get; set; }
      
        public int? id_educationForm { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
     
        public int? id_department { get; set; }
        public int? id_mastertype { get; set; }

        public int? id_speciality { get; set; }

        public bool? UseDormitory { get; set; }
        public bool? UseScholarship { get; set; }
        public bool? UseHolidayFacilities { get; set; }
        public bool? ParticipatedIntProgs { get; set; }
        public bool? TUProvidesHealthInsurance { get; set; } 
        public int UniversityIndex { get; set; }       
        public int FacultyIndex { get; set; }       
        public int DepartmentIndex { get; set; }       
        public int SpecialityIndex { get; set; }
        public bool isModified
        {
            get { return isModified; }
            set { isModified = false; }
        }
    }
}

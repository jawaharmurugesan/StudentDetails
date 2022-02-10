using StudentDetails.edmx;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentDetails.Models.StudentData
{
    public class StudentData_Prop
    {
       
        public int ID { get; set; }
        public string Rollno { get; set; }
        [Required]
        public string Stuname { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Phoneno { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Fathername { get; set; }
        [Required]
        public Nullable<System.DateTime> Admissiondate { get; set; }
        [Required]
        public Nullable<System.DateTime> Passedout { get; set; }
        [Required]
        public string Remarks { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Createdby { get; set; }
        public Nullable<System.DateTime> Createddate { get; set; }
        public Nullable<int> Updatedby { get; set; }
        public Nullable<System.DateTime> Updateddate { get; set; }

    }
}
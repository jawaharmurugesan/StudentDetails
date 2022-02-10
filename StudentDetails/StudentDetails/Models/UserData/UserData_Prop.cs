using StudentDetails.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDetails.Models.UserData
{
    public class UserData_Prop
    {
        //Student_DetailsEntities stu = new Student_DetailsEntities();
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<decimal> Postalcode { get; set; }
        public Nullable<decimal> Mobilenumber { get; set; }
        public string Email { get; set; }
        public Nullable<int> Createdby { get; set; }
        public Nullable<System.DateTime> Createddate { get; set; }
        public Nullable<int> Updatedby { get; set; }
        public Nullable<System.DateTime> Updateddate { get; set; }
    }
}
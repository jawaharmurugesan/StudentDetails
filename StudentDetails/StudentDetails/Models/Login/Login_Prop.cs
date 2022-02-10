using StudentDetails.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDetails.Models.Login
{
   
    public class Login_Prop 
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public bool Status { get; set; }
        public Nullable<int> Createdby { get; set; }
        public Nullable<System.DateTime> Createddate { get; set; }
        public Nullable<int> Updatedby { get; set; }
        public Nullable<System.DateTime> Updateddate { get; set; }
    }
}
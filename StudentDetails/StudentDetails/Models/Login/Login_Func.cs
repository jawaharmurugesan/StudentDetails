using StudentDetails.edmx;
using StudentDetails.Models.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDetails.Models.Login
{
    public class Login_Func
    {
       // Password_Func func = new Password_Func();
        Student_DetailsEntities Entities = new Student_DetailsEntities();
        UserData_Prop user = new UserData_Prop();
        public Login_Prop Login_Verification(string Uname, string Pass)
        {
            try
            {
                Login_Prop data = new Login_Prop();
                //string DePass = func.EncryptPass(Pass);
                if (Entities.Stu_Login.Where(a => a.Username == Uname && a.Password == Pass && a.Status == true).Any())
                {
                    var dbdata = Entities.Stu_Login.Where(b => b.Username == Uname && b.Password == Pass).FirstOrDefault();
                    data.ID = dbdata.ID;
                    //data.Empno = dbdata.Empno;
                    data.Username = dbdata.Username;

                    // data.Dispname = Entities.Canteen_Emp.Where(b => b.Empno == dbdata.Empno).FirstOrDefault().Name;
                    //data.Mailid = dbdata.Mailid;
                    //data.Mobileno = dbdata.Mobileno;
                    //data.Usertype = dbdata.Usertype;

                    return data;
                }

                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
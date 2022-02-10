using StudentDetails.edmx;
using StudentDetails.Models.StudentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDetails.Models.UserData
{
    public class UserData_Func
    {
        Student_DetailsEntities Entities = new Student_DetailsEntities();
        //public string InserAccountDetails1(UserData_Prop data)
        //{

        //    try
        //    {

        //        using (var entities = new Student_DetailsEntities())
        //        {
        //            UserData_Prop prop = new UserData_Prop();
        //            prop.Username = data.Username;
        //            prop.Password = data.Password;
        //            prop.Address = data.Address;
        //            prop.City = data.City;
        //            prop.State = data.State;
        //            prop.Country = data.Country;
        //            prop.Postalcode = data.Postalcode;
        //            prop.Mobilenumber = data.Mobilenumber;
        //            prop.Email = data.Email;
        //            //prop.Createdby = data.Stuname;
        //            prop.Createddate = DateTime.Now;
        //            //entities.Students.Add(prop);
        //            entities.SaveChanges();

        //        }

        //        return Constant.InsertSuccessfully;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


        public string InserAccountDetails(UserData_Prop data)
        {

            try
            {

                using (var entities = new Student_DetailsEntities())
                {
                    var Stu = entities.Users.Where(a => a.Username == data.Username).Count();
                    if(Stu == 0)
                    {
                        User prop = new User
                        {

                            Username = data.Username,
                            Password = data.Password,
                            Address = data.Address,
                            City = data.City,
                            State = data.State,
                            Country = data.Country,
                            Postalcode = data.Postalcode,
                            Mobilenumber = data.Mobilenumber,
                            Email = data.Email,
                            //prop.Createdby = data.Stuname;
                            Createddate = DateTime.Now,
                            //entities.Students.Add(prop);
                            //entities.SaveChanges()
                        };

                        entities.Users.Add(prop);
                        entities.SaveChanges();


                        Stu_Login Sprop = new Stu_Login
                        {
                            Username = data.Username,
                            Password = data.Password,
                            Status = true

                        };
                        entities.Stu_Login.Add(Sprop);
                        entities.SaveChanges();

                        return "User Registered Successfully";
                    }
                    else
                    {
                        return "User Name Already Registered";
                    }
                }



                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
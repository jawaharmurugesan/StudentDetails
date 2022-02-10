using StudentDetails.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDetails.Models.StudentData
{
    public class StudentData_Func
    {
        Student_DetailsEntities Entities = new Student_DetailsEntities();
        public List<StudentData_Prop> GetStudentList()
        {
            try
            {
                var data = Entities.Students.Select(a => new StudentData_Prop
                {
                    ID = a.ID,
                    Rollno = a.Rollno,
                    Stuname = a.Stuname,
                    Class = a.Class,
                    Address = a.Address,
                    Gender = a.Gender,
                    Phoneno = a.Phoneno,
                    Email = a.Email,
                    Fathername = a.Fathername,
                    Passedout = a.Passedout,
                    Remarks = a.Remarks,
                    Status = a.Status
                });

                return data.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string InserStudentDetails(StudentData_Prop data)
        {

            try
            {

                using (var entities = new Student_DetailsEntities())
                {
                    Student  prop=new Student
                    {
                       
                    Rollno = data.Rollno,
                    Stuname = data.Stuname,
                    Class = data.Rollno,
                    Address = data.Address,
                    Gender = data.Gender,
                    Phoneno = data.Phoneno,
                    Email = data.Email,
                    Fathername = data.Fathername,
                    Admissiondate = data.Admissiondate,
                    Passedout = data.Passedout,
                    Remarks = data.Remarks,
                    Status = data.Status,
                };

                    entities.Students.Add(prop);
                    entities.SaveChanges();

                }

                return Constant.InsertSuccessfully;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public StudentData_Prop RetriveBuyerdept(int Id)
        {
            using (var transaction = Entities.Database.BeginTransaction())
            {
                try
                {
                    StudentData_Prop data = new StudentData_Prop();
                    var dbdata = Entities.Students.Where(a => a.ID == Id).FirstOrDefault();
                    data.ID = dbdata.ID;
                    data.Rollno = dbdata.Rollno;
                    data.Stuname = dbdata.Stuname;
                    data.Class = dbdata.Class;
                    data.Address = dbdata.Address;
                    data.Gender = dbdata.Gender;
                    data.Phoneno = dbdata.Phoneno;
                    data.Email = dbdata.Email;
                    data.Fathername = dbdata.Fathername;
                    data.Admissiondate =Convert.ToDateTime( dbdata.Admissiondate);
                    data.Passedout =Convert.ToDateTime( dbdata.Passedout);
                    data.Remarks = dbdata.Remarks;
                    data.Status = dbdata.Status;
                    transaction.Commit();

                    return data;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return null;
                }
            }
        }
        public string UpdateStudent(StudentData_Prop data)
        {
            using (var transaction = Entities.Database.BeginTransaction())
            {
                try
                {
                    var dbdata = Entities.Students.Where(a => a.ID == data.ID).FirstOrDefault();
                    if (Entities.Students.Any(a => a.Stuname == data.Stuname))
                    {
                        var U_Count = Entities.Students.Where(a => a.Stuname == data.Stuname).FirstOrDefault();
                        if (U_Count.ID == dbdata.ID)
                        {
                            dbdata.Rollno = data.Rollno.ToUpper().Trim();
                            dbdata.Stuname = data.Stuname.ToUpper().Trim();
                            dbdata.Class = data.Class.ToUpper().Trim();
                            dbdata.Address = data.Address.ToUpper().Trim();
                            dbdata.Gender = data.Gender;
                            dbdata.Phoneno = data.Phoneno;
                            dbdata.Email = data.Email.ToUpper().Trim();
                            dbdata.Fathername = data.Fathername.ToUpper().Trim();
                            dbdata.Admissiondate = data.Admissiondate;
                            dbdata.Passedout = data.Passedout;
                            dbdata.Remarks = data.Remarks;
                            dbdata.Status = data.Status;
                            dbdata.Updatedby = data.Updatedby;
                            dbdata.Updateddate = DateTime.Now;
                            Entities.SaveChanges();



                            transaction.Commit();
                            return "Student Updated Successfully!";
                        }
                        else
                        {
                            return "Duplicate Values!";
                        }
                    }
                    else
                    {
                        dbdata.Rollno = data.Rollno.ToUpper().Trim();
                        dbdata.Stuname = data.Stuname.ToUpper().Trim();
                        dbdata.Class = data.Class.ToUpper().Trim();
                        dbdata.Address = data.Address.ToUpper().Trim();
                        dbdata.Gender = data.Gender;
                        dbdata.Phoneno = data.Phoneno;
                        dbdata.Email = data.Email.ToUpper().Trim();
                        dbdata.Fathername = data.Fathername.ToUpper().Trim();
                        dbdata.Admissiondate = data.Admissiondate;
                        dbdata.Passedout = data.Passedout;
                        dbdata.Remarks = data.Remarks;
                        dbdata.Status = data.Status;
                        dbdata.Updatedby = data.Updatedby;
                        dbdata.Updateddate = DateTime.Now;
                        Entities.SaveChanges();
                        transaction.Commit();
                        return "Student Updated Successfully!";
                    }
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    return "Something went wrong!";
                }
            }
        }

        public string DeleteStudent(int Id)
        {
            using (var transaction = Entities.Database.BeginTransaction())
            {
                try
                {
                    var dbdata = Entities.Students.Where(a => a.ID == Id).FirstOrDefault();

                    Entities.Students.Remove(dbdata);
                    Entities.SaveChanges();
                    transaction.Commit();
                    return "Student Detail Deleted Successfully!";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return "Something went wrong!";
                    
                }

            }
        }

    }
    public static class Constant
    {

        public const string InsertSuccessfully = "Inesrt Successfully!";
    }

}

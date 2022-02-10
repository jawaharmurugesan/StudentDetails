using StudentDetails.Models.StudentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDetails.Controllers
{
    public class StudentDetailsController : Controller
    {
        StudentData_Prop Prop= new StudentData_Prop();
        StudentData_Func func = new StudentData_Func();
        // GET: StudentDetails
        public ActionResult StudentDetails()
        {
            return View(func.GetStudentList());
        }
        public ActionResult StudentDetails_Add()
        {
            return View();
        }
       // [HttpPost]
        public ActionResult CreateItem(StudentData_Prop collection)
        {
            try
            {
              
                if(collection.ID==0 )
                {
                    var result = func.InserStudentDetails(collection);
                }
                else
                {
                    var result = func.UpdateStudent(collection);
                }
                return RedirectToAction("StudentDetails");

             

            }
            catch
            {
                return View();
            }
        }

        public ActionResult StudentDetails_Edit(int Id)
        {
            Prop = func.RetriveBuyerdept(Id);
            return View(Prop);
        }
        [HttpPost]
        public ActionResult Student_Update(StudentData_Prop data)
        {
            var result = func.UpdateStudent(data);
            return RedirectToAction("StudentDetails");
        }
        public ActionResult Student_Delete(int Id)
        {
           
          var delete = func.DeleteStudent(Id);
            return RedirectToAction("StudentDetails");
        }
    }
}
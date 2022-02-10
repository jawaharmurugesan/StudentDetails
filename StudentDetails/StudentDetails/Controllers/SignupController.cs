using StudentDetails.Models.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDetails.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        UserData_Func func = new UserData_Func();
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult CreateAccount(UserData_Prop collection)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    collection.Createdby = 1;
                    TempData["Message"] = func.InserAccountDetails(collection);
                    if (TempData["Message"].ToString() == "Already Exist!")
                    {
                        return RedirectToAction("Signup");
                    }
                    else
                    {
                        return RedirectToAction("Login","Login");
                    }
                }
                else
                {
                    return RedirectToAction("Signup");
                }

            }
            catch
            {
                return View();
            }
        }
    }

  
}
using StudentDetails.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDetails.Controllers
{
    public class LoginController : Controller
    {
        Login_Func func = new Login_Func();
        Login_Prop Prop = new Login_Prop(); 
        
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login_In(Login_Prop login)

        {
          
            var Userval = func.Login_Verification(login.Username, login.Password);
            if (Userval != null)
            {
                Session["ID"] = Userval.ID;
                Session["UserName"] = Userval.Username;
                Session["UserType"] = Userval.UserType;
                //Session["EditRight"] = "true";
                //Session["DelRight"] = "true";



                return RedirectToAction("StudentDetails", "StudentDetails");
            }
            else
            {
                TempData["LoginError"] = "User Name or Password Incorrect!";
                return RedirectToAction("Login");
            }
        }
        public ActionResult SingOut()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();

            return RedirectToAction("Login");
        }
    }
}
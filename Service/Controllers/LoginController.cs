using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using servisi.Models;

namespace servisi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginPost()
        {
            int id; string message;
            string un = Request.Form["txtUN"];
            string pwd = Request.Form["txtPWD"];
            Perdorues perdor = new Perdorues(un, pwd);
            if(perdor.Identify(out id,out message) == true)
            {
                Session["login"] = id;
                return RedirectToAction("LoggedIn", "Login");
            }
            else
            {
                ViewBag.Message = message;
                return View("Login");
            }
            
        }

        public ActionResult LoggedIn()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            return View("Login");
        }
    }
}
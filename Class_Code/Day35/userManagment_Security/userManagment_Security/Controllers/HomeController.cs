using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using userManagment_Security.Security;

namespace userManagment_Security.Controllers
{
    [GuardController]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("UserLoginValidate", "User");
        }
    }
}





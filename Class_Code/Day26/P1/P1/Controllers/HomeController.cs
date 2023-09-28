using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CreateEmployee()
        {
            Console.WriteLine();
            return View();
        }
    }
}

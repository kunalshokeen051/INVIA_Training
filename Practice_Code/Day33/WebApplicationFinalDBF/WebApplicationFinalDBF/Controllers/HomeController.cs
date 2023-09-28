using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationFinalDBF.Repository;

namespace WebApplicationFinalDBF.Controllers
{
    public class HomeController : Controller
    {
        IStudentRepository Repo = new StudentRepository();


        public ActionResult Index()
        {
            return View();
        }

       public ActionResult StudentOperation()
        {
            var list = Repo.GetStudentData();

            return View(list);
        }

        public ActionResult StudentSearchById(int id)
        {
            var temp = Repo.Search(id);
            return View(temp);
        }
    }
}
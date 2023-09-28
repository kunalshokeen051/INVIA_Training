using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;
using WebApplication1.Database;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        IStudentRepository Repo = new StudentRepository();
        StudentContext Context = new StudentContext();

        public ActionResult Index()
        {

            return View();
        }


        public ActionResult StudentOperation()
        {
            var list = Repo.GetStudentData();

            return View(list);
        }
        

        public ActionResult Search(string searchType, string searchTerm)
       {
            List<Student> query = null;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                if (string.Equals(searchType,"Id"))
                {
                    if (int.TryParse(searchTerm, out int id))
                    {
                        query = Context.Students.Where(s => s.Id == id).ToList();
                    }
                    else
                    {
                        query = Context.Students.Where(s => s.Id == -1).ToList();
                    }
                }
                else if (searchType == "Name")
                {
                    query = Context.Students.Where(s => s.Name.Contains(searchTerm)).ToList();
                }
            }
            ViewBag.temp = (query == null ? new List<Student>() : query);

            return View();
        }


        [HttpGet]
        public ActionResult CreateEmployee()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult CreateEmployee(Student student)
        {
            if (ModelState.IsValid)
            {
                Context.Students.Add(student);
                Context.SaveChanges();
                return RedirectToAction("StudentOperation"); 
            }

            return View(student);
        }

        public ActionResult DeleteEmployee(int id)
        {
            if(id == 0)
            {
                return Content("Error: No id Found");
            }
            else
            {
               var status = Repo.Delete(id);
                if (status)
                {
                    return RedirectToAction("StudentOperation");
                }
                else
                {
                    return Content("Error: ERROR while deleting the records");
                }

            }
        }

        public ActionResult Details(int id)
        {
           var Student = Repo.Details(id);

            return View(Student);
        }


        [HttpGet]
        public ActionResult UpdateEmployee(int? id)
        {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
               Student student = Context.Students.Find(id);
                if (student == null)
                {
                    return HttpNotFound();
                }
                return View(student);
   
        }


        [HttpPost]
        public ActionResult UpdateEmployee(Student student)
        {
            if (ModelState.IsValid)
            {
                Context.Entry(student).State = EntityState.Modified;
                Context.SaveChanges();
                return RedirectToAction("StudentOperation");  
            }
            return View(student);

        }



    }
}
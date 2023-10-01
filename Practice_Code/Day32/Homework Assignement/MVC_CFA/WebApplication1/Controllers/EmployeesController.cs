
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class EmployeesController : Controller
    {
        IEmployeeRepository empRepo = new EmployeeRepository();
   

        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        } 
        
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult  CreateEmployee(Employee e)
        {
            Salary salary = new Salary
            {
                CTC = e.Salary.CTC,
                Basic_Pay = e.Salary.Basic_Pay,
                ESIC = e.Salary.ESIC,
                EPF = e.Salary.EPF,
                Allowance = e.Salary.Allowance,
                Bonus = e.Salary.Bonus,
                Income_Tax = e.Salary.Income_Tax,
                Mis_Deductions = e.Salary.Mis_Deductions
            };

            Employee emp = new Employee
            {
                Name = e.Name,
                Age = e.Age,
                Department = e.Department,
                Email = e.Email,
               Salary = salary
            };


            empRepo.CreateEmployee(emp);

            return View();
        }


        [HttpGet]
        public ActionResult GetEmployees()
        {
           IEnumerable<EmployeeSalaryViewModel> MyList= empRepo.GetEmployees();  
           
            return View(MyList);
        }

       
        public ActionResult SearchEmployee(int employeeId)
        {   
            var searchResult = empRepo.SearchEmployees(employeeId);

            return PartialView("SearchEmployee", searchResult);
        }

       [HttpPost]
       public ActionResult DeleteEmployee( int employeeId)
        { 
            var status = empRepo.DeleteEmployee(employeeId);

            if (status == 1)
            {
                return Content("<script>alert('Employee Successfully Deleted')</script>");
            }
            else
            {
                return Content("<script>alert('Error Occured !')</script>");

            }
        }


        [HttpPost]
            public ActionResult UpdateEmployee(Employee editedData)
                {
               int Status = empRepo.UpdateEmployee(editedData);
                 
                 if (Status == 1)
                 {
                     return Json(new { success = true });
                 }
                 else
                 {
                     return Json(new { success = false });
                 }
            } 
    }
}

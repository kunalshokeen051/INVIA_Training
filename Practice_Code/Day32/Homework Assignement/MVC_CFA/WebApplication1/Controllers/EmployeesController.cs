
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
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
                Salary_Id = e.Salary.Salary_Id,
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

        public void  SearchEmployee()
        {

        }

       [HttpPost]
       public JsonResult DeleteEmployee( int employeeId)
        { 
            var status = empRepo.DeleteEmployee(employeeId);

            if (status == 1)
            {
                return Json(new { success = true, message = "Employee deleted successfully." });
            }
            else
            {
                return Json(new { success = false, message = "Employee not found." });
            }
        }

        public void UpdateEmployee(int id, string name)
        {
            var employee = empRepo.UpdateEmployee(id, name);
            if (employee == 0)
            {
                Response.Write("Employee not found");
            }
            else
                Response.Write("Employee data successfully updated");
        }
       
    }
}

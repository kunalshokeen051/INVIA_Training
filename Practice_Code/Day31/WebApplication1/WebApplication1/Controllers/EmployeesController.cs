
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
        //Employee emp = new Employee();
          //emp.Name = e["Name"];
          //emp.Age = Convert.ToInt32(e["Age"]);
          //empRepo.CreateEmployee(emp);

            Employee emp = new Employee();
            emp.Name = e.Name;
            emp.Age = e.Age;
            empRepo.CreateEmployee(emp);

            return View();
        }

        [HttpGet]
        public ActionResult GetEmployees()
        {
            var MyList= empRepo.GetEmployees();  
            ViewBag.Employees = MyList;
            return View();
        }        

        public void  SearchEmployee(int id)
        {
            var employee = empRepo.SearchEmployees(id);
            if (employee == null)
            {
                Response.Write("Employee not found");
            }
            else
                Response.Write(employee.Name);
        }


       public void DeleteEmployee(int id)
        {
            var employee = empRepo.DeleteEmployee(id);
            if (employee == 0)
            {
                Response.Write("Employee not found");
            }
            else
                Response.Write("Employee data Deleted");
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

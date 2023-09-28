
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

         [HttpPost]
        public ActionResult Login(Auth AuthToken)
        {

            return RedirectToAction("GetEmployees");
        }


        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult  CreateEmployee(Employee e)
        {
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

       [HttpGet]
       public ActionResult DeleteEmployee()
        {

            return View();
        }

       [HttpPost]
       public void DeleteEmployee(Employee emp)
        {
            var employee = empRepo.DeleteEmployee(emp.Id);
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

using System.Web.Mvc;
using Day1MVC.Models; 

namespace Day1MVC.Controllers
{
	public class StudentController : Controller
	{
	   
		//Function-1
		public ActionResult CourseDetails()
		{
			//string Course = "MVC 5.0";    
			// Course is a local variable cannot be accessible outside of the function 
		   // ViewBag.Course = Course;


			Course obj = new Course();
			obj.Id = 101;
			obj.Name = "JAVA";

			ViewBag.Temp = obj;

			return View();
		}

		// Function-2
		public ActionResult Address()
		{
			string Address = "Sector -59 Noida";
			ViewBag.Address = Address;
			
			return View();
		}

		public 
	}
}
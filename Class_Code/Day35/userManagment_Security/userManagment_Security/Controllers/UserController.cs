using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using userManagment_Security.Models;
using userManagment_Security.Repository;

namespace userManagment_Security.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository Repo = new UserRepository();


        [HttpGet]
        public ActionResult CreateUserAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUserAccount(User user)
        {
            Repo.CreateAccount(user);
            return View();
        }

        [HttpGet]
        public ActionResult UserLoginValidate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult UserLoginValidate(LoginViewModel user)
            {
            bool value = Repo.LoginValidate(user.UserName, user.Password);

            if (value == true)
            {
                //usr is a variable of session Type 
                //Session will be persist in IIS Memory for next 20 minutes
                Session["Usr"] = user.UserName;
                Session["Password"] = user.Password;
                

                return RedirectToAction("Index", "Home");
            }

            else
            {
                return Content("Error");
            }
        }

    }
}





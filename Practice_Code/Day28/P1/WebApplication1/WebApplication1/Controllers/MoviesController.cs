using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    { 

        [Route("index")]                  //Simpe attribute route accessed by localhost:44311/index
        public ActionResult Index(int? id)
        {

            ViewBag.Id = id;
            return View();
        }
    }
}
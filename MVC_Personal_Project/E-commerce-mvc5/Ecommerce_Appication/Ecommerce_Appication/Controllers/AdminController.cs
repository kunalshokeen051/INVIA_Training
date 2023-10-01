using Ecommerce_Appication.Auth;
using Ecommerce_Appication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_Appication.Controllers
{
    public class AdminController : Controller
    {
        private DbeMarketingEntities db = new DbeMarketingEntities();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(tbl_admin person)
        {
            tbl_admin ad = db.tbl_admin
                .Where(x => x.ad_password == person.ad_password  && x.ad_password == person.ad_password)
                .FirstOrDefault();
                 
            if(ad != null) 
            {
                Session["ad_id"] = ad.ad_id.ToString();
                return RedirectToAction("Create");
            }

            else
            {
                ViewBag.error = "Invalid Username or Password";
            }

            return View();
        }

        
        public ActionResult SignOut()
        {
            Session.Abandon();

            return RedirectToAction("Login");
        }

        [HttpGet]
        [AuthController]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_category CatObj, HttpPostedFileBase imgFile)
        {
            string path = uploadingFile(imgFile);
            if (path.Equals("-1"))
            {
                ViewBag.error = "Image Could not be uploaded .....";
            }
            else
            {
                tbl_category cat = new tbl_category();
                cat.cat_name = CatObj.cat_name;
                cat.cat_image = path;
                cat.cat_status = 1;
                cat.cat_fk_ad = Convert.ToInt32(Session["ad_id"].ToString()); 
                db.tbl_category.Add(cat);
                db.SaveChanges();


                return RedirectToAction("create");
            }

            return View();
        }


        public string uploadingFile(HttpPostedFileBase file)
        {
            Random rnd = new Random();
            string path = "-1";
            int random = rnd.Next();


            // ContentLength is a method which return size of file in Bytes
            if(file != null && file.ContentLength > 0 ) 
            {
                // GetExtension provide us the file extension
                //Path is a method of System.io
                string extension = Path.GetExtension(file.FileName);

                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals("png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/upload"), random + Path.GetFileName(file.FileName));
                    }

                    catch(Exception ex)
                    {
                        path = "-1";
                        Response.Write("<Script>alert('Error Occured');</Script>");

                    }
                }

                else 
                {
                    Response.Write("<Script>alert('Only jpg,jpeg and png formats are allowed');</Script>");
                }
            }

            else
            {
                Response.Write("<Script>alert('Please Select a File');</Script>");
            }

            return path;
        }
    }
}
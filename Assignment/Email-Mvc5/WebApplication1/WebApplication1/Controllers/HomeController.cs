using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMail(EmailModel model)
        {
            try
            {
                // MailMessage is a class to get Mail content (body, to, subject, etc.)
                // using parameterized constructor with params (From_Mail, To_Mail, subject, body)
                // Has 3 overloads

                if (!ModelState.IsValid)
                {
                    // Return to the view with validation errors
                    ViewBag.Message = "Model state isn't valid";
                    return View();
                }

                using (MailMessage mm = new MailMessage(model.Email, model.To, model.Subject, model.Body))
                {
                    if (model.Attachment != null && model.Attachment.ContentLength > 0)
                    {
                        string fileName = Path.GetFileName(model.Attachment.FileName);
                        mm.Attachments.Add(new Attachment(model.Attachment.InputStream, fileName));
                    }

                    // bool function -> checks whether the mail body is HTML or not
                    mm.IsBodyHtml = false;

                    // SmtpClient is a class which uses SMTP protocol to send mail
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";

                        // Secure Sockets Layer (SSL) is a standard security technology
                        // for establishing an encrypted link between a server and a client
                        smtp.EnableSsl = true;

                        // Use your Gmail email address and App Password for authentication(if two-factor auth is enabled)
                        NetworkCredential cred = new NetworkCredential(model.Email, "qcui ztyn doln lnmj");

                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = cred;

                        smtp.Port = 587;

                        smtp.Send(mm);

                        ViewBag.Message = "Email Sent 😊";
                    }
                }

                return View();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the email sending process
                ViewBag.Message = ($"An error occurred while sending the email. ☹️ {ex.Message} Please try again later");
                return View();
            }
        }
    }
}

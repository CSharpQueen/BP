using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.IO;
using GradFIlmaProjekat.Models;

namespace GradFIlmaProjekat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var model = new Mail();
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(Mail model)
        {

            if (ModelState.IsValid)
            {
                MailMessage m = new MailMessage("aidagranulo@gmail.com", "aidagranulo@gmail.com");
              // m.Subject=model.Subject;
               string poruka = "Ime: " + model.Name + " Email: " + model.Email + " Telefon: " + model.Phone + " Poruka: " + model.Message; 
                m.Body = poruka;
               m.IsBodyHtml = true;
               SmtpClient s = new SmtpClient("smtp.gmail.com",587);
                s.Credentials = new System.Net.NetworkCredential()
                { UserName="aidagranulo@gmail.com",
                 Password="subhanAllah"
                };

                s.EnableSsl=true;
                s.Send(m);
                ViewBag.Message = "Email poslan!";
                Response.Write("Email poslan!");
               
            }
        return View(model);
        }
             
    }
}
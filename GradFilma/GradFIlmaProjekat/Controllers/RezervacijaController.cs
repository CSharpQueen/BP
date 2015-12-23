using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GradFIlmaProjekat.Controllers
{
    public class RezervacijaController : Controller
    {
        //
        // GET: /Sjedista/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sjedista()
        {
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            List<GradFilmaModel.Sjediste> lista = client.dajSjedistaSale(1);
            return View(lista);
        }
    }
}
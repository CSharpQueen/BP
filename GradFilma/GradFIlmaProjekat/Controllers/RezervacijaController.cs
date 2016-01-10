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
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            List<GradFilmaModel.Film> lista = client.dajFilmove();
            return View(lista);
        }

        public ActionResult Projekcija()
        {
            return View();
        }

        public ActionResult Sjedista()
        {
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            List<GradFilmaModel.Sjediste> lista = client.dajSjedistaSale(1);
            return View(lista);
        }

        [HttpPost, ActionName("Potvrdi")]
        public ActionResult Potvrdi()
        {
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            string idStr = Request.Form["skriveni"];
            int id = Convert.ToInt32(idStr);
            client.zauzmiSjediste(id);
            return View();
        }
    }
}
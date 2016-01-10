using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace GradFIlmaProjekat.Controllers
{
    public class SadrzajController : Controller
    {
        // GET: Sadrzaj
        public ActionResult Index()
        {
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            List<GradFilmaModel.Film> lista = client.dajFilmove();
            return View(lista);
        }

        public ActionResult Details(int id)
        {
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            if (id == null)
            {
                throw new ArgumentException("Id nije ispravan");
            }           

            GradFilmaModel.Film film = client.dajFilm(id);

            if (film.naziv == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Novost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Novost/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GradFilmaModel.Film film)
        {
            GradFilmaModel.Film f = new GradFilmaModel.Film();
            if (ModelState.IsValid)
            {
                var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();           
                client.dodajFIlm(film);               
                client.Close();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        // GET: Novost/Edit/5
        public ActionResult Edit(int id)
        {

            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            GradFilmaModel.Film film = client.dajFilm(id);

            if (film.naziv == null)
            {
                return HttpNotFound();
            }
            return View(film);

        }

        // POST: Novost/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GradFilmaModel.Film filmM)
        {
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            client.editujFIlm(id, filmM);
            GradFilmaModel.Film film = client.dajFilm(id);
            return View(film);
        }

        // GET: Novost/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            GradFilmaModel.Film film = client.dajFilm(id);

            if (film.naziv == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Novost/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
            //GradFilmaModel.Film film = client.dajFilm(id);

            //if (film.naziv == null)
            //{
            //    return HttpNotFound();
            //}
            client.obrisiFilm(id);
            return RedirectToAction("Index");
        }

        public ActionResult CreateProjekcija()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProjekcija(GradFilmaModel.Projekcija projekcija)
        {
            if (ModelState.IsValid)
            {
                var client = new GradFIlmaProjekat.ServiceGradFilma.GradFilmaServiceClient();
                client.dodajProjekciju(projekcija);
                client.Close();
                return RedirectToAction("Index");
            }
            return View(projekcija);
        }


    }
}
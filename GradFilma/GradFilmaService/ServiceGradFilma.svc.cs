using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GradFilmaModel;
using GradFilmaBEntity;

namespace GradFilmaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceGradFilma : IGradFilmaService
    {

        public GradFilmaModel.Korisnik Login(GradFilmaModel.Korisnik korisnik)
        {
            //enkripcija passworda?
            var ctx = new GradFilmaEntities();

            var kor = ctx.Korisnik.FirstOrDefault(k => k.username == korisnik.Username & k.password == korisnik.Password);

            if (kor == null)
            {
                throw new Exception("Nepostojeci korisnik!");
                //return false;
            }

            var korLog = new GradFilmaModel.Korisnik()
            {
                Username = kor.username,
                Password=kor.password
            };
            return korLog;
        }

        public void Register(GradFilmaModel.Korisnik korisnik)
        {

            using (var ctx = new GradFilmaEntities())
            {

                var kor = ctx.Korisnik.FirstOrDefault(k => k.username == korisnik.Username);
                var ul = ctx.Uloga.Find(1);

                if (kor != null)
                {
                    throw new Exception("Postoji korisnik sa tim imenom");
                }

                //Praksa2014.Data.Model.Type userType = GetUserType("User", ctx);

                kor = new GradFilmaBEntity.Korisnik()
                {
                    idKorisnik = '3',
                    ime = korisnik.Ime,
                    prezime = korisnik.Prezime,
                    jmbg = korisnik.JMBG,
                    telefon = korisnik.Telefon,
                    adresa = korisnik.Adresa,
                    username = korisnik.Username,
                    password = korisnik.Password,
                   // ulogaId= '1',
                   
                    ulogaId=ul.idUloga
                };
                
                ctx.Korisnik.Add(kor);

                ctx.SaveChanges();
            }

        }


        public List<GradFilmaModel.Film> dajFilmove()
        {
            var ctx = new GradFilmaEntities();
            // List<String> lista = new List<string>();
            //proc kroz listu
            List<GradFilmaBEntity.Film> filmoviB = ctx.Film.ToList(); 
            List<GradFilmaModel.Film> filmovi = new List<GradFilmaModel.Film>();
            foreach (GradFilmaBEntity.Film film in filmoviB)
            {
                GradFilmaModel.Film novi = new GradFilmaModel.Film
                {
                    naziv=film.naziv,
                    glumci=film.glumci,
                    reziser=film.reziser,
                    opis=film.opis,
                    filmID=film.idFilm
                    
                };
                filmovi.Add(novi);
            }
            return filmovi;
        }

        public GradFilmaModel.Film dajFilm(int id)
        {
            var ctx = new GradFilmaEntities();
            var kor = ctx.Film.FirstOrDefault(k => k.idFilm == id);

            if (kor == null)
            {
                throw new Exception("Nepostojeci film!");
                //return false;
            }

            var korLog = new GradFilmaModel.Film()
            {
                naziv = kor.naziv,
                glumci = kor.glumci,
                reziser = kor.reziser,
                opis = kor.opis
            };
            return korLog;
        }

        public void dodajFIlm(GradFilmaModel.Film film)
        {

            using (var ctx = new GradFilmaEntities())
            {

                var fil = ctx.Film.FirstOrDefault(f => f.naziv == film.naziv);


                if (fil != null)
                {
                    throw new Exception("Postoji film sa tim imenom");
                }

                //Praksa2014.Data.Model.Type userType = GetUserType("User", ctx);

                fil = new GradFilmaBEntity.Film()
                {
                    idFilm = '3',
                    naziv = film.naziv,
                    glumci = film.glumci,
                    reziser = film.reziser,
                    opis = film.opis,


                };

                ctx.Film.Add(fil);

                ctx.SaveChanges();
            }

        }

        public void obrisiFilm(GradFilmaModel.Film film)
        {
            var ctx = new GradFilmaEntities();

            var kor = ctx.Film.FirstOrDefault(k => k.idFilm == film.filmID && k.naziv == film.naziv);
            ctx.Film.Remove(kor);
            ctx.SaveChanges();
        }

        public GradFilmaModel.Korisnik dajKorisnika(string username)
        {
            var ctx = new GradFilmaEntities();
            var kor = ctx.Korisnik.FirstOrDefault(k => k.username == username);

            if (kor == null)
            {
                throw new Exception("Nepostojeci korisnik!");
                //return false;
            }

            var korLog = new GradFilmaModel.Korisnik()
            {
               Username=kor.username,
               Password=kor.password,
               Ime=kor.ime,
               Prezime=kor.prezime,
               Adresa=kor.adresa,
               JMBG=kor.jmbg,
               Telefon=kor.telefon,
               UlogaID=kor.ulogaId
            };
            return korLog;
        }


    }
}

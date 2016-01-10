using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GradFilmaModel;
using GradFilmaEntity;

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

                kor = new GradFilmaEntity.Korisnik()
                {
                    ime = korisnik.Ime,
                    prezime = korisnik.Prezime,
                    jmbg = korisnik.JMBG,
                    telefon = korisnik.Telefon,
                    adresa = korisnik.Adresa,
                    username = korisnik.Username,
                    password = korisnik.Password,
                    ulogaId= 2,
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
            List<GradFilmaEntity.Film> filmoviB = ctx.Film.ToList(); 
            List<GradFilmaModel.Film> filmovi = new List<GradFilmaModel.Film>();
            foreach (GradFilmaEntity.Film film in filmoviB)
            {
                GradFilmaModel.Film novi = new GradFilmaModel.Film
                {
                    naziv=film.naziv,
                    glumci=film.glumci,
                    reziser=film.reziser,
                    opis=film.opis,
                    filmID=film.idFilm,
                    slika=film.slika,
                    trajanje = Convert.ToDateTime(film.trajanje.ToString())
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
                opis = kor.opis,
                slika = kor.slika,
                trajanje = Convert.ToDateTime(kor.trajanje.ToString())
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
                
                fil = new GradFilmaEntity.Film()
                {
                    naziv = film.naziv,
                    glumci = film.glumci,
                    reziser = film.reziser,
                    opis = film.opis,
                    slika= film.slika,
                    trajanje = film.trajanje.TimeOfDay
                    
                };

                ctx.Film.Add(fil);

                ctx.SaveChanges();
            }

        }

        public void editujFIlm(int id, GradFilmaModel.Film filmM)
        {

            using (var ctx = new GradFilmaEntities())
            {
                var x = id;
                var film = ctx.Film.FirstOrDefault(f => f.idFilm == id);

                //Praksa2014.Data.Model.Type userType = GetUserType("User", ctx);
                 film.naziv = filmM.naziv;
                 film.glumci = filmM.glumci;
                 film.reziser = filmM.reziser;
                 film.opis = filmM.opis;
                 //slika = filmM.slika,
                 //trajanje = filmM.trajanje.TimeOfDay
                ctx.SaveChanges();
            }

        }

        public void obrisiFilm(int id)
        {
            var ctx = new GradFilmaEntities();
            var kor = ctx.Film.FirstOrDefault(k => k.idFilm == id);
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

        public void dodajKinoSalu(GradFilmaModel.KinoSala kinoSala)
        {

            using (var ctx = new GradFilmaEntities())
            {

                var kinoS = ctx.KinoSala.FirstOrDefault(ks => ks.brojSale == kinoSala.brojSale);


                if (kinoS != null)
                {
                    throw new Exception("Postoji takva kino sala!");
                }

 
                kinoS= new GradFilmaEntity.KinoSala()
                {
                    idKinoSala = '1',
                    brojSale = kinoSala.brojSale,
                    brojMjesta = kinoSala.brojMjesta
                    

                };

                ctx.KinoSala.Add(kinoS);

                ctx.SaveChanges();
            }

        }




        public GradFilmaModel.KinoSala dajKinoSalu(int brojSale)
        {
            var ctx = new GradFilmaEntities();
            var kinoS = ctx.KinoSala.FirstOrDefault(k => k.brojSale == brojSale);

            if (kinoS == null)
            {
                throw new Exception("Nepostojeca kino sala!");
                //return false;
            }

            var kinoSala = new GradFilmaModel.KinoSala()
            {
                brojMjesta = kinoS.brojMjesta,
                brojSale = kinoS.brojSale
            };
            return kinoSala;
        }


        public void dodajSjediste(GradFilmaModel.Sjediste sjediste)
        {

            using (var ctx = new GradFilmaEntities())
            {

                var sjed = ctx.Sjediste.FirstOrDefault(s =>s.idSjedista  == sjediste.idSjedista);


                if (sjed != null)
                {
                    throw new Exception("Postoji sjediste sa tim id brojem");
                }

                //Praksa2014.Data.Model.Type userType = GetUserType("User", ctx);

                sjed = new GradFilmaEntity.Sjediste()
                {
                    idSjedista=sjed.idSjedista,
                    brojReda=sjed.brojReda,
                    brojKolone=sjed.brojKolone,
                    tip=sjed.tip,
                    zauzeto=sjed.zauzeto,
                    SalaID=sjed.SalaID
                    

                };

                ctx.Sjediste.Add(sjed);

                ctx.SaveChanges();
            }

        }


        public GradFilmaModel.Sjediste dajSjediste(int brojSale, int brojR, int brojK)
        {
            var ctx = new GradFilmaEntities();
            var sjed = ctx.Sjediste.FirstOrDefault(s => s.SalaID == brojSale &&  s.brojReda == brojR && s.brojKolone == brojK );

            if (sjed == null)
            {
                throw new Exception("Nepostojece sjediste!");
                //return false;
            }

            var sjediste = new GradFilmaModel.Sjediste()
            {
                idSjedista=sjed.idSjedista,
                brojReda=sjed.brojReda,
                brojKolone=sjed.brojKolone,
                tip=sjed.tip,
                zauzeto=sjed.zauzeto,
                SalaID=sjed.SalaID
            };
            return sjediste;
        }


        public List<GradFilmaModel.Sjediste> dajSjedistaSale(int brojSale)
        {
            var ctx = new GradFilmaEntities();
           //proc kroz listu
            List<GradFilmaEntity.Sjediste> sjedistaB = ctx.Sjediste.ToList();
            List<GradFilmaEntity.Sjediste> sjedistaKraj = new List<GradFilmaEntity.Sjediste>();
           foreach(GradFilmaEntity.Sjediste s in sjedistaB)
           {

               if (s.SalaID == brojSale)
                   sjedistaKraj.Add(s);
           }
            List<GradFilmaModel.Sjediste> sjedista = new List<GradFilmaModel.Sjediste>();
            foreach (GradFilmaEntity.Sjediste sjediste in sjedistaKraj)
            {
                GradFilmaModel.Sjediste novi = new GradFilmaModel.Sjediste
                {
                    idSjedista = sjediste.idSjedista,
                    brojReda = sjediste.brojReda,
                    brojKolone= sjediste.brojKolone,
                    tip=sjediste.tip,
                    zauzeto= sjediste.zauzeto,
                    SalaID= sjediste.SalaID

                };
                sjedista.Add(novi);
            }
            return sjedista;
        }

        public void zauzmiSjediste(int IDsjediste)
        {
            using (var ctx = new GradFilmaEntities())
            {

                var sjed = ctx.Sjediste.FirstOrDefault(s => s.idSjedista == IDsjediste);
                sjed.zauzeto = 1;
                ctx.SaveChanges();
            }
        }

        public void dodajProjekciju(GradFilmaModel.Projekcija projekcija)
        {
            using (var ctx = new GradFilmaEntities())
            {

                var proj = ctx.Projekcija.FirstOrDefault(p => p.vrijemePrikazivanja == projekcija.vrijemePrikazivanja);


                if (proj != null)
                {
                    throw new Exception("Postoji projekcija u tom terminu!");
                }

                proj = new GradFilmaEntity.Projekcija()
                {
                   vrijemePrikazivanja = projekcija.vrijemePrikazivanja,
                   tipProjekcijeId = projekcija.tipProjekcijeId,
                   filmId = projekcija.filmId,
                   kinoSalaId = projekcija.kinoSalaId

                };

                ctx.Projekcija.Add(proj);

                ctx.SaveChanges();
            }
        }

    }
}

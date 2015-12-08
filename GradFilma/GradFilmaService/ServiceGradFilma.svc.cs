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

            var kor = ctx.Korisniks.FirstOrDefault(k => k.username == korisnik.Username & k.password == korisnik.Password);

            if (kor == null)
            {
                throw new Exception("Nepostojeci korisnik!");
                //return false;
            }

            var korLog = new GradFilmaModel.Korisnik()
            {
                Username = kor.username
            };
            return korLog;
        }

        public void Register(GradFilmaModel.Korisnik korisnik)
        {

            using (var ctx = new GradFilmaEntities())
            {

                var kor = ctx.Korisniks.FirstOrDefault(k => k.username == korisnik.Username);


                if (kor != null)
                {
                    throw new Exception("Postoji korisnik sa tim imenom");
                }

                //Praksa2014.Data.Model.Type userType = GetUserType("User", ctx);

                kor = new GradFilmaEntity.Korisnik()
                {
                    idKorisnik = '3',
                    ime = korisnik.Username,
                    prezime = korisnik.Username,
                    jmbg = korisnik.Username,
                    telefon = korisnik.Username,
                    adresa = korisnik.Username,
                    username = korisnik.Username,
                    password = korisnik.Password,
                    
                };

                ctx.Korisniks.Add(kor);

                ctx.SaveChanges();
            }

        }

    }
}

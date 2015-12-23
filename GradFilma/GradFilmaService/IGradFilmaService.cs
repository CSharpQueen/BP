using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GradFilmaModel;

namespace GradFilmaService
{
  
    [ServiceContract]
    public interface IGradFilmaService
    {

        [OperationContract]
        Korisnik Login(Korisnik korisnik);

        [OperationContract]
        void Register(Korisnik korisnik);

        [OperationContract]
        List<GradFilmaModel.Film> dajFilmove();
        
        [OperationContract]
        GradFilmaModel.Film dajFilm(int id);

        [OperationContract]
        void dodajFIlm(GradFilmaModel.Film film);

        [OperationContract]
        void obrisiFilm(GradFilmaModel.Film film);

        [OperationContract]
        GradFilmaModel.Korisnik dajKorisnika(string username);


        [OperationContract]
     void  dodajKinoSalu(GradFilmaModel.KinoSala kinoSala);

        [OperationContract]
        GradFilmaModel.KinoSala dajKinoSalu(int brojSale);


        [OperationContract]
        void dodajSjediste(GradFilmaModel.Sjediste sjediste);

        [OperationContract]
        GradFilmaModel.Sjediste dajSjediste(int brojSale, int brojR, int brojK);



        [OperationContract]
        List<GradFilmaModel.Sjediste> dajSjedistaSale(int brojSale);


//        [OperationContract]
  //      void Register_Uposlenik(Uposlenik uposlenik);

        //isto i za uposlenika
    }


}

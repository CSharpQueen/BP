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


//        [OperationContract]
  //      void Register_Uposlenik(Uposlenik uposlenik);

        //isto i za uposlenika
    }


}

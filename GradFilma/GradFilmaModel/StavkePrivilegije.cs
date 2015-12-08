using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GradFilmaModel
{    [DataContract]
    public class StavkePrivilegije
    {


        //public int idStavkePrivilegije { get; set; }
        //public int privilegijaId { get; set; }

          [DataMember]
        public Nullable<int> dodavanjeKorisnika { get; set; }

          [DataMember]
        public Nullable<int> brisanjeKorisnika { get; set; }
          [DataMember]
        public Nullable<int> rezervacija { get; set; }
     
    [DataMember]
        public Nullable<int> otkazivanjeRezervacije { get; set; }
    
    [DataMember]
        public Nullable<int> rezervacijaDodatnogSadrzaja { get; set; }
    
    [DataMember]
        public Nullable<int> dodavanjeUposlenika { get; set; }
    
    [DataMember]
        public Nullable<int> brisanjeUposlenika { get; set; }
    
    [DataMember]
        public Nullable<int> registracija { get; set; }
    
    [DataMember]
        public Nullable<int> dodavanjeSadrzaja { get; set; }
    
    [DataMember]
        public Nullable<int> brisanjeSadrzaja { get; set; }

       // public virtual Privilegije Privilegije { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GradFilmaModel
{   [DataContract]
    public class Karta
    {

        [DataMember]
        public int idKarta { get; set; }

        [DataMember]
        public int RezervacijaId { get; set; }

        [DataMember]
        public string barkod { get; set; }

       // public virtual Rezervacija Rezervacija { get; set; }

    }
}

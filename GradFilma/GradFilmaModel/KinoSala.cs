using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GradFilmaModel
{    [DataContract]
    public class KinoSala
    {


       
        [DataMember]
        public int idKinoSala { get; set; }

        [DataMember]
        public int brojSale { get; set; }

        [DataMember]
        public int brojMjesta { get; set; }

        [DataMember]
        public int brojRedova { get; set; }
        [DataMember]
        public int brojKolona { get; set; }
       
       [DataMember]
       public int TipMjestaId { get; set; }

    }
}

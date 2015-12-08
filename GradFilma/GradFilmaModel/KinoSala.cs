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
       

    //    public int idKinoSala { get; set; }

        [DataMember]
        public int brojSale { get; set; }

        [DataMember]
        public int brojMjesta { get; set; }

        [DataMember]
        public string tipMjesta { get; set; }

        [DataMember]
        public int TipMjestaId { get; set; }

     //   public virtual TipMjesta TipMjesta1 { get; set; }
       // public virtual ICollection<Projekcija> Projekcijas { get; set; }


        public KinoSala()
        {
            //      this.Projekcijas = new HashSet<Projekcija>();
        }
    }
}

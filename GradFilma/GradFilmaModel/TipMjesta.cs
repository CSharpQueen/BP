using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace GradFilmaModel
{    [DataContract]
    class TipMjesta
    {
       
      //  public int idTipMjesta { get; set; }
      [DataMember]
        public Nullable<int> mjestoZaParove { get; set; }

        [DataMember]
        public Nullable<int> mjestoZaOsobeSaInv { get; set; }

        [DataMember]
        public Nullable<int> mjesto { get; set; }

      //  public virtual ICollection<KinoSala> KinoSalas { get; set; }

        public TipMjesta()
        {
          //  this.KinoSalas = new HashSet<KinoSala>();
        }

    }
}

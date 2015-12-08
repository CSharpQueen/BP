using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GradFilmaModel
{[DataContract]
  public  class Projekcija
    {

       
       // public int idProjekcija { get; set; }
      [DataMember]
        public System.DateTime vrijemePrikazivanja { get; set; }
      [DataMember]
        public int tipProjekcijeId { get; set; }
      [DataMember]
        public int filmId { get; set; }
      [DataMember]
        public int kinoSalaId { get; set; }

      /*  public virtual Film Film { get; set; }
        public virtual KinoSala KinoSala { get; set; }
        public virtual TipProjekcije TipProjekcije { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }*/


        public Projekcija()
        {
           // this.Rezervacijas = new HashSet<Rezervacija>();
        }
    }
}

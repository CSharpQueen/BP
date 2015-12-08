using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
namespace GradFilmaModel
{   [DataContract]
   public class Rezervacija
    {
       
      //  public int idRezervacije { get; set; }
      [DataMember]
        public int brojMjesta { get; set; }
      [DataMember]
        public decimal cijena { get; set; }
      [DataMember]
        public int specijalnaPonudaId { get; set; }
      [DataMember]
        public int projekcijaId { get; set; }
      [DataMember]
        public Nullable<int> uposlenikId { get; set; }
      [DataMember]
        public Nullable<int> korisnikId { get; set; }

    /*    public virtual ICollection<Karta> Kartas { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Projekcija Projekcija { get; set; }
        public virtual SpecijalnePonude SpecijalnePonude { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }*/
        public Rezervacija()
        {
         //   this.Kartas = new HashSet<Karta>();
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace GradFilmaModel
{  [DataContract]
   public class Privilegije
    {

      
      //public int idPrivilegije { get; set; }
      //public int ulogaId { get; set; }
      [DataMember]
        public Nullable<int> manipulacijaKorisnicima { get; set; }
      [DataMember]
        public Nullable<int> manipulacijaPodacima { get; set; }
      [DataMember]
        public Nullable<int> manipulacijaRezervacijama { get; set; }
      [DataMember]
        public Nullable<int> manipulacijaSadrzajem { get; set; }
      [DataMember]
        public Nullable<int> manipulacijaUposlenicima { get; set; }
      [DataMember]
        public Nullable<int> registracija { get; set; }

     //   public virtual Uloga Uloga { get; set; }
     //   public virtual ICollection<StavkePrivilegije> StavkePrivilegijes { get; set; }

        public Privilegije()
        {
            //  this.StavkePrivilegijes = new HashSet<StavkePrivilegije>();
        }
    }
}

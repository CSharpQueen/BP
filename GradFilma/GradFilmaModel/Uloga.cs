using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GradFilmaModel
{    [DataContract]
   public class Uloga
    {
       

       // public int idUloga { get; set; }
        [DataMember]
        public Nullable<int> administrator { get; set; }

        [DataMember]
        public Nullable<int> upravnik { get; set; }
        
        [DataMember]
        public Nullable<int> menadzer { get; set; }

       // public virtual ICollection<Privilegije> Privilegijes { get; set; }
        //public virtual ICollection<Uposlenik> Uposleniks { get; set; }

        public Uloga()
        {
           // this.Privilegijes = new HashSet<Privilegije>();
           // this.Uposleniks = new HashSet<Uposlenik>();
        }
    }
}

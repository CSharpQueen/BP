using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GradFilmaModel
{   [DataContract]
   public class TipProjekcije
    {
        
      //  public int idTipProjekcije { get; set; }
        [DataMember]
        public Nullable<int> C2D { get; set; }
        public Nullable<int> C3D { get; set; }
        public Nullable<int> C4D { get; set; }

        //public virtual ICollection<Projekcija> Projekcijas { get; set; }

        public TipProjekcije()
        {
           // this.Projekcijas = new HashSet<Projekcija>();
        }
    }
}

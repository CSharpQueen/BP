using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GradFilmaModel
 {  [DataContract]
   public class SpecijalnePonude
    {
      

     //   public int idSpecPonude { get; set; }
          [DataMember]
        public string maxiComboPaket { get; set; }
       [DataMember]
        public string midiComboPaket { get; set; }
       [DataMember]
        public string miniComboPaket { get; set; }
       [DataMember]
        public string ladyPaket { get; set; }
       [DataMember]
        public string lovePaket { get; set; }
       [DataMember]
        public string studentDay { get; set; }
       [DataMember]
        public string familyDay { get; set; }
       [DataMember]
        public string workDay { get; set; }

      //  public virtual ICollection<Rezervacija> Rezervacijas { get; set; }

        public SpecijalnePonude()
        {
            //this.Rezervacijas = new HashSet<Rezervacija>();
        }
    }
}

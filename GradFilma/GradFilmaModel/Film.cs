using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace GradFilmaModel
{
    [DataContract]
   public class Film
    {
        
        [DataMember]
        public string naziv { get; set; }

        [DataMember]
        public string reziser { get; set; }

        [DataMember]
        public string glumci { get; set; }

        [DataMember]
        public string opis { get; set; }

     //   public virtual ICollection<Projekcija> Projekcijas { get; set; }
    }
}

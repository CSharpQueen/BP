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
        public int filmID { get; set; }

        [DataMember]
        public string naziv { get; set; }

        [DataMember]
        public string reziser { get; set; }

        [DataMember]
        public string glumci { get; set; }

        [DataMember]
        public string opis { get; set; }

        [DataMember]
        public string slika { get; set; }
       
        [DataMember]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public DateTime trajanje { get; set; }
    }
}

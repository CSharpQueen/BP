using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
namespace GradFilmaModel
{
    [DataContract]
   public class Sjediste
    {
        [DataMember]
        public int idSjedista { get; set; }
   
        [DataMember]
        public int brojReda { get; set; }
        
        [DataMember]
        public int brojKolone { get; set; }
        
        [DataMember]
        public int tip { get; set; }
        
        [DataMember]
        public int zauzeto { get; set; }
        
        [DataMember]
        public int SalaID { get; set; }
    }
}

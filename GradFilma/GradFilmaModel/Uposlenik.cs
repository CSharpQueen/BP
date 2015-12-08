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
    public class Uposlenik
    {
        [DataMember]
        public string Ime { get; set; }

        [DataMember]
        public string Prezime { get; set; }

        [DataMember]
        public string JMBG { get; set; }

        [DataMember]
        public string Adresa { get; set; }

        [DataMember]
        public string Telefon { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GradFilmaBEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpecijalnePonude
    {
        public SpecijalnePonude()
        {
            this.Rezervacija = new HashSet<Rezervacija>();
        }
    
        public int idSpecPonude { get; set; }
        public string maxiComboPaket { get; set; }
        public string midiComboPaket { get; set; }
        public string miniComboPaket { get; set; }
        public string ladyPaket { get; set; }
        public string lovePaket { get; set; }
        public string studentDay { get; set; }
        public string familyDay { get; set; }
        public string workDay { get; set; }
    
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GradFilmaEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sjediste
    {
        public int idSjedista { get; set; }
        public int brojReda { get; set; }
        public int brojKolone { get; set; }
        public int tip { get; set; }
        public int zauzeto { get; set; }
        public int SalaID { get; set; }
    
        public virtual KinoSala KinoSala { get; set; }
        public virtual TipMjesta TipMjesta { get; set; }
    }
}
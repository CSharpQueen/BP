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
    
    public partial class StavkePrivilegije
    {
        public int idStavkePrivilegije { get; set; }
        public int privilegijaId { get; set; }
        public Nullable<int> dodavanjeKorisnika { get; set; }
        public Nullable<int> brisanjeKorisnika { get; set; }
        public Nullable<int> rezervacija { get; set; }
        public Nullable<int> otkazivanjeRezervacije { get; set; }
        public Nullable<int> rezervacijaDodatnogSadrzaja { get; set; }
        public Nullable<int> dodavanjeUposlenika { get; set; }
        public Nullable<int> brisanjeUposlenika { get; set; }
        public Nullable<int> registracija { get; set; }
        public Nullable<int> dodavanjeSadrzaja { get; set; }
        public Nullable<int> brisanjeSadrzaja { get; set; }
    
        public virtual Privilegije Privilegije { get; set; }
    }
}

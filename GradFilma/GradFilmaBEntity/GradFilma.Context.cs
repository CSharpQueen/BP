﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GradFilmaEntities : DbContext
    {
        public GradFilmaEntities()
            : base("name=GradFilmaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Karta> Karta { get; set; }
        public virtual DbSet<KinoSala> KinoSala { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Privilegije> Privilegije { get; set; }
        public virtual DbSet<Projekcija> Projekcija { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<SpecijalnePonude> SpecijalnePonude { get; set; }
        public virtual DbSet<StavkePrivilegije> StavkePrivilegije { get; set; }
        public virtual DbSet<TipMjesta> TipMjesta { get; set; }
        public virtual DbSet<TipProjekcije> TipProjekcije { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBProjectEntities : DbContext
    {
        public DBProjectEntities()
            : base("name=DBProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Budynki> Budynki { get; set; }
        public virtual DbSet<Dozorcy> Dozorcy { get; set; }
        public virtual DbSet<FakturyNapraw> FakturyNapraw { get; set; }
        public virtual DbSet<FakturyWynajem> FakturyWynajem { get; set; }
        public virtual DbSet<Firmy> Firmy { get; set; }
        public virtual DbSet<Mieszkania> Mieszkania { get; set; }
        public virtual DbSet<Najemcy> Najemcy { get; set; }
        public virtual DbSet<Naprawy> Naprawy { get; set; }
        public virtual DbSet<Platnosci> Platnosci { get; set; }
        public virtual DbSet<StanyNapraw> StanyNapraw { get; set; }
        public virtual DbSet<StanyUsterek> StanyUsterek { get; set; }
        public virtual DbSet<Usterki> Usterki { get; set; }
        public virtual DbSet<Wynajmy> Wynajmy { get; set; }
        public virtual DbSet<RentalDataView> RentalDataView { get; set; }
        public virtual DbSet<FaultsDataView> FaultsDataView { get; set; }
    }
}

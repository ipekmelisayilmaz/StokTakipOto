﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakipOto.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class STOKTAKIPEntities : DbContext
    {
        public STOKTAKIPEntities()
            : base("name=STOKTAKIPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KATEGORI> KATEGORI { get; set; }
        public virtual DbSet<MUSTERI> MUSTERI { get; set; }
        public virtual DbSet<SATIM> SATIM { get; set; }
        public virtual DbSet<URUN> URUN { get; set; }
    }
}

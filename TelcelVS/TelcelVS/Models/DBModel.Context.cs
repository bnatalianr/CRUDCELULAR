﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelcelVS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TelcelDBEntities : DbContext
    {
        public TelcelDBEntities()
            : base("name=TelcelDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Telcel> Telcel { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}

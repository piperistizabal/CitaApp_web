﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CitAppEntities : DbContext
    {
        public CitAppEntities()
            : base("name=CitAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<disponibilidad> disponibilidad { get; set; }
        public virtual DbSet<disponibilidad_empresa> disponibilidad_empresa { get; set; }
        public virtual DbSet<disponibilidad_recursos> disponibilidad_recursos { get; set; }
        public virtual DbSet<empresas> empresas { get; set; }
        public virtual DbSet<espacios> espacios { get; set; }
        public virtual DbSet<pagos> pagos { get; set; }
        public virtual DbSet<parametros> parametros { get; set; }
        public virtual DbSet<planes> planes { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<profesionales> profesionales { get; set; }
        public virtual DbSet<suscripciones> suscripciones { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}
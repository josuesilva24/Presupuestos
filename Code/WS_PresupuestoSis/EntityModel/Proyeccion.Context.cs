﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProyeccionEntities : DbContext
    {
        public ProyeccionEntities()
            : base("name=ProyeccionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Centro_Costos> Centro_Costos { get; set; }
        public virtual DbSet<Cuenta_Contable> Cuenta_Contable { get; set; }
        public virtual DbSet<Inflacion> Inflacion { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<PROYECTO> PROYECTO { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tipo_Cambio> Tipo_Cambio { get; set; }
        public virtual DbSet<Tipo_CuentaContable> Tipo_CuentaContable { get; set; }
        public virtual DbSet<Proyecto_Centro_Costos> Proyecto_Centro_Costos { get; set; }
        public virtual DbSet<Tipo_Tipo_Cambio> Tipo_Tipo_Cambio { get; set; }
        public virtual DbSet<Cargas_Sociales> Cargas_Sociales { get; set; }
        public virtual DbSet<Anos> Anos { get; set; }
        public virtual DbSet<Ingresos> Ingresos { get; set; }
    }
}

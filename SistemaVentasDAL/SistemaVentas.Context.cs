﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVentasDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sistema_ventasEntities : DbContext
    {
        public Sistema_ventasEntities()
            : base("name=Sistema_ventasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Auditoria> Auditoria { get; set; }
        public DbSet<Categoria_Producto> Categoria_Producto { get; set; }
        public DbSet<Negocio> Negocio { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<PedidoProducto> PedidoProducto { get; set; }
    }
}

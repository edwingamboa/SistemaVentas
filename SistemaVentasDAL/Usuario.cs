//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Auditoria = new HashSet<Auditoria>();
            this.Pedido = new HashSet<Pedido>();
            this.Producto = new HashSet<Producto>();
        }
    
        public int cod_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasena_usuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string ruta_foto { get; set; }
        public int cod_perfil { get; set; }
    
        public virtual ICollection<Auditoria> Auditoria { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}

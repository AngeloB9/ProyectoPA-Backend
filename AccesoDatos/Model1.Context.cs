﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TicketPAEntities : DbContext
    {
        public TicketPAEntities()
            : base("name=TicketPAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }
        public virtual DbSet<TICKET> TICKET { get; set; }
    
        public virtual ObjectResult<seleccionarEmpleados_SP_Result> seleccionarEmpleados_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<seleccionarEmpleados_SP_Result>("seleccionarEmpleados_SP");
        }
    
        public virtual ObjectResult<seleccionarEmpleadobyApellidoSP_Result> seleccionarEmpleadobyApellidoSP(string apellido)
        {
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<seleccionarEmpleadobyApellidoSP_Result>("seleccionarEmpleadobyApellidoSP", apellidoParameter);
        }
    }
}

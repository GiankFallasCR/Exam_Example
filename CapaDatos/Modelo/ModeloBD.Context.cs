﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EXAMEN1Entities : DbContext
    {
        public EXAMEN1Entities()
            : base("name=EXAMEN1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<empleado> empleado { get; set; }
    
        public virtual int sp_insertaEmpleado(Nullable<int> codigo_empleado, string nombre, Nullable<decimal> horas_laboradas, Nullable<decimal> salario_Hora, Nullable<decimal> salario_Bruto)
        {
            var codigo_empleadoParameter = codigo_empleado.HasValue ?
                new ObjectParameter("codigo_empleado", codigo_empleado) :
                new ObjectParameter("codigo_empleado", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var horas_laboradasParameter = horas_laboradas.HasValue ?
                new ObjectParameter("Horas_laboradas", horas_laboradas) :
                new ObjectParameter("Horas_laboradas", typeof(decimal));
    
            var salario_HoraParameter = salario_Hora.HasValue ?
                new ObjectParameter("Salario_Hora", salario_Hora) :
                new ObjectParameter("Salario_Hora", typeof(decimal));
    
            var salario_BrutoParameter = salario_Bruto.HasValue ?
                new ObjectParameter("Salario_Bruto", salario_Bruto) :
                new ObjectParameter("Salario_Bruto", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertaEmpleado", codigo_empleadoParameter, nombreParameter, horas_laboradasParameter, salario_HoraParameter, salario_BrutoParameter);
        }
    }
}

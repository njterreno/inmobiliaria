//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alquiler
    {
        public Alquiler()
        {
            this.CuotaMensual = new HashSet<CuotaMensual>();
        }
    
        public long IDAlquiler { get; set; }
        public long IDPropiedad { get; set; }
        public long IDInquilino { get; set; }
        public int MontoAlquiler { get; set; }
        public long IDGarante1 { get; set; }
        public long IDGarante2 { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime FechaInicioContrato { get; set; }
        public System.DateTime FechaFinContrato { get; set; }
    
        public virtual ICollection<CuotaMensual> CuotaMensual { get; set; }
        public virtual Propiedad Propiedad { get; set; }
        public virtual Garante Garante { get; set; }
        public virtual Garante Garante1 { get; set; }
        public virtual Inquilino Inquilino { get; set; }
    }
}

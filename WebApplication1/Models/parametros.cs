//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class parametros
    {
        public int id { get; set; }
        public Nullable<bool> solicitarPago { get; set; }
        public Nullable<decimal> porcentajePago { get; set; }
        public Nullable<int> tiempoReagendamiento { get; set; }
        public Nullable<int> tiempoCancelancion { get; set; }
        public Nullable<bool> multaCancelacion { get; set; }
        public Nullable<decimal> porcentajeCancelacion { get; set; }
        public int cantidadAforo { get; set; }
        public int id_Empresa { get; set; }
        public Nullable<bool> estado { get; set; }
    
        public virtual empresas empresas { get; set; }
    }
}

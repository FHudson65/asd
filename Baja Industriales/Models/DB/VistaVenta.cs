//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baja_Industriales.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class VistaVenta
    {
        public int Cod_Venta { get; set; }
        public Nullable<int> Cod_Empleado { get; set; }
        public Nullable<int> Cod_Producto { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}

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
    
    public partial class Cotizacione
    {
        public int Folio { get; set; }
        public string Nombre_Cliente { get; set; }
        public Nullable<int> Cod_Venta { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<int> Total { get; set; }
    
        public virtual Venta Venta { get; set; }
    }
}

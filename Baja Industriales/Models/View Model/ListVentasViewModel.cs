using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Baja_Industriales.Models.View_Model
{
    public class ListVentasViewModel
    {
        public int Cod_Venta {get; set;}
        public int Cod_Empleado { get; set; }
        public int Cod_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha {get; set;}
}
}
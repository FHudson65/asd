using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baja_Industriales.Models.View_Model
{
    public class ListAlmacenViewModel
    {
        public int Cod_Producto { get; set; }
        public string Descirpcion { get; set; }
	    public decimal Precio { get; set; }
	    public int Stock { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Baja_Industriales.Models.View_Model
{
    public class ListClienteViewModel
    {
        public int Cod_Cliente { get; set; }
        public string Nombre { get; set; }
        [EmailAddress]
	    public string Correo { get; set; }
        public string Telefono { get; set; }
        public string RFC { get; set; }
    }
}
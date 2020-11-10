using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Baja_Industriales.Models.View_Model
{
    public class ListEmpleadosViewModel
    {
        public int Cod_Empleado { get; set; }
        //[Required(ErrorMessage = "Ingrese Tipo de Usuario")]
        public string Tipo_Usuario { get; set; }
        [Required(ErrorMessage = "Ingrese Contraseña")]
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "Ingrese Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese Apellido Paterno")]
        public string A_Paterno { get; set; }
        [Required(ErrorMessage = "Ingrese Apellido Materno")]
        public string A_Materno { get; set; }
        [Required(ErrorMessage = "Ingrese Teléfono")]
        public string Telefono { get; set; }
        //[Required(ErrorMessage = "Ingrese Sucursal")]
        public int Cod_Sucursal { get; set; }

    }
}
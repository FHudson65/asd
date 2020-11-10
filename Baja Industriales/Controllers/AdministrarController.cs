using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Baja_Industriales.Models;
using Baja_Industriales.Models.DB;
using Baja_Industriales.Models.View_Model;

namespace Baja_Industriales.Controllers
{
    public class AdministrarController : Controller
    {
        Conexión con = new Conexión();
        // GET: Administrar
        public ActionResult Administrar()
        {
            return View();
        }
        public ActionResult Empleados()
        {
            List<ListEmpleadosViewModel> lst;
            using (BajaIndustrialesEntities2 db = new BajaIndustrialesEntities2())
            {
                lst = (from d in db.Empleados
                       select new ListEmpleadosViewModel
                       {
                           Cod_Empleado = d.Cod_Empleado,
                           Tipo_Usuario = d.Tipo_Usuario,
                           Contraseña = d.Contraseña,
                           Nombre = d.Nombre,
                           A_Paterno = d.A_Paterno,
                           A_Materno = d.A_Materno,
                           Telefono = d.Telefono,
                           Cod_Sucursal = (int)d.Cod_Sucursal
                       }).ToList();
            }
            return View(lst);
        }
        public ActionResult Clientes()
        {
            List<ListClienteViewModel> lst;
            using (BajaIndustrialesEntities2 db = new BajaIndustrialesEntities2())
            {
                lst = (from d in db.Clientes
                       select new ListClienteViewModel
                       {
                           Cod_Cliente = d.Cod_Cliente,
                           Nombre = d.Nombre,
                           Correo = d.Correo,
                           Telefono = d.Telefono,
                           RFC = d.RFC
                       }).ToList();
            }
            return View(lst);
        }
        [HttpPost]
        public ActionResult altaClientes(ListClienteViewModel c)
        {
            //ListClienteViewModel C = new ListClienteViewModel();
            con.altaClientes(c);
            return Redirect("Clientes");
        }
    }
}
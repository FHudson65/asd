using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baja_Industriales.Models;
using Baja_Industriales.Models.DB;
using Baja_Industriales.Models.View_Model;

namespace Baja_Industriales.Controllers
{
    public class InformesController : Controller
    {
        // GET: Informes
        public ActionResult Informes()
        {
            return View();
        }
        public ActionResult VDia()
        {
            List<ListVentasViewModel> lst;
            using (BajaIndustrialesEntities2 db = new BajaIndustrialesEntities2())
            {
                lst = (from d in db.VistaVentas
                       select new ListVentasViewModel
                       {
                           Cod_Venta = (int)d.Cod_Venta,
                           Cod_Empleado = (int)d.Cod_Empleado,
                           Cod_Producto = (int)d.Cod_Producto,
                           Cantidad = (int)d.Cantidad,
                           Precio = (decimal)d.Precio,
                           IVA = (decimal)d.IVA,
                           Total = (decimal)d.Total,
                           Fecha = (DateTime)d.Fecha
                       }).ToList();
            }
            return View(lst);
        }
        public ActionResult VFecha()
        {
            List<ListVentasViewModel> lst;
            using (BajaIndustrialesEntities2 db = new BajaIndustrialesEntities2())
            {
                lst = (from d in db.VistaVentas
                       select new ListVentasViewModel
                       {
                           Cod_Venta = (int)d.Cod_Venta,
                           Cod_Empleado = (int)d.Cod_Empleado,
                           Cod_Producto = (int)d.Cod_Producto,
                           Cantidad = (int)d.Cantidad,
                           Precio = (decimal)d.Precio,
                           IVA = (decimal)d.IVA,
                           Total = (decimal)d.Total,
                           Fecha = (DateTime)d.Fecha
                       }).ToList();
            }
            return View(lst);
        }
        public ActionResult Cotizaciones()
        {
            return View();
        }
    }
}
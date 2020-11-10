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
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Productos()
        {
            return View();
        }
        public ActionResult Inventario()
        {
            List<ListAlmacenViewModel> lst;
            using (BajaIndustrialesEntities2 db = new BajaIndustrialesEntities2())
            {
                lst = (from d in db.VistaInventarios
                       select new ListAlmacenViewModel
                       {
                           Cod_Producto = d.Cod_Producto,
                           Descirpcion = d.Descripcion,
                           Precio = (decimal)d.Precio,
                           Stock = (int)d.Stock,
                       }).ToList();
            }
            return View(lst);
        }
        public ActionResult Ventas()
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
    }
}
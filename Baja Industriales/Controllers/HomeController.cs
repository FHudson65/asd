using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baja_Industriales.Models;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Baja_Industriales.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public ActionResult Index()
        {
            return View();
        }
    }
}
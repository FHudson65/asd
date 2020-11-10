using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
using Baja_Industriales.Models.View_Model;

namespace Baja_Industriales
{
    public class Conexión
    {
        SqlConnection con = new SqlConnection();
        string aEmp = "insert into Empleados(Tipo_Usuario, Contraseña, Nombre, A_Paterno, A_Materno, Telefono, Cod_Sucursal)values(@Tipo_Usuario, @Contraseña, @Nombre, @A_Paterno, @A_Materno, @Telefono, @Cod_Sucursal)";
        string aCli = "insert into Cliente(Nombre, Correo, Telefono, RFC)values(@Nombre, @Correo, @Telefono, @RFC)";
        public void conectar()
        {
            con.ConnectionString = @"data source = FHUDSON\MSSQLSERVER01; initial catalog = BajaIndustriales; integrated security = True";
        }

        public void altaEmpleados(ListEmpleadosViewModel emp)
        {
            con.Open();
            SqlCommand altaEmp = new SqlCommand(aEmp,con);
            altaEmp.Parameters.AddWithValue("Tipo_Usuario", emp.Tipo_Usuario);
            altaEmp.Parameters.AddWithValue("Contraseña", emp.Contraseña);
            altaEmp.Parameters.AddWithValue("Nombre", emp.Nombre);
            altaEmp.Parameters.AddWithValue("A_Paterno", emp.A_Paterno);
            altaEmp.Parameters.AddWithValue("A_Materno", emp.A_Materno);
            altaEmp.Parameters.AddWithValue("Telefono", emp.Telefono);
            altaEmp.Parameters.AddWithValue("Cod_Sucursal", emp.Cod_Sucursal);
            altaEmp.ExecuteNonQuery();
            con.Close();
        }
        public void altaClientes(ListClienteViewModel Cli)
        {
            con.Open();
            SqlCommand altaCli = new SqlCommand(aCli, con);
            altaCli.Parameters.AddWithValue("Nombre", Cli.Nombre);
            altaCli.Parameters.AddWithValue("Correo", Cli.Correo);
            altaCli.Parameters.AddWithValue("Telefono", Cli.Telefono);
            altaCli.Parameters.AddWithValue("RFC", Cli.RFC);
            altaCli.ExecuteNonQuery();
            con.Close();
        }
    }
}
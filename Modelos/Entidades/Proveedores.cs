using Modelos.Conexion_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Proveedores
    {



        public static DataTable ObtenerDatosProveedores()
        {


            SqlConnection conexion = Conexion.conectar();
            string consultaQuery = "select idProveedor,NombreProveedor from Proveedores";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable data = new DataTable();
            add.Fill(data);
            return data;


        }


    }
}

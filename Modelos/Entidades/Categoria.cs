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
   public class Categoria
    {



        public static DataTable ObtenerDatosCategoria()
        {


            SqlConnection conexion = Conexion.conectar();
            string consultaQuery = "select idCategoria,NombreCategoria from Categoria";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable data = new DataTable();
            add.Fill(data);
            return data;


        }


    }
}

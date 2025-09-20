using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Conexion_DB
{
    public class Conexion
    {

        private static string servidor = "DESKTOP-R09HVAC\\SQLEXPRESS";
        public static string database = "Sistema_de_Inventario";


        public static SqlConnection conectar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection($"Data Source = {servidor}; Initial Catalog = {database}; Integrated Security = true ;");
                return conexion;

            }
            catch( Exception ex ) 
            {
                MessageBox.Show("Hubo error con la conexion con la base de datos"+ex);
                return null;
            }

        }
    }
}

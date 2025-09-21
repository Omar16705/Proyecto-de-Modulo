using Modelos.Conexion_DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Roles_Usuario
    {

        public static Dictionary<string, DataTable> ObtenerDatosRoles()
        {
            try
            {
                Dictionary<string, DataTable> datos = new Dictionary<string, DataTable>();
            
                SqlConnection conexion = Conexion.conectar();
                {
                    conexion.Open();

                    ///// Roles usuarios en este xddd
                    SqlDataAdapter daRoles = new SqlDataAdapter("select idRol, NombreRol from ROL ", conexion);
                    DataTable dtRoles = new DataTable();
                    daRoles.Fill(dtRoles);
                    datos["ROL"] = dtRoles;
                }

                return datos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                return null;
            }

        }
    }
}

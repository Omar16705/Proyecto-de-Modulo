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
    public class TipoDocumento
    {

        private int idTipoDocumento;
        private string documento;

        public int IdTipoDocumento { get => idTipoDocumento; set => idTipoDocumento = value; }
        public string Documento { get => documento; set => documento = value; }


        public static DataTable mostrarTipoDocumento()
        {

            try
            {
                using (SqlConnection conn = Conexion.conectar())
                {
                    string query = "SELECT idTipoDocumentoVenta, nombreTipoDocumentoVenta FROM TipoDocumentoVenta";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception )
            {
                throw;
            }


        }





    }
}

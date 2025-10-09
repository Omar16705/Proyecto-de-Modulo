using Modelos.Conexion_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Proveedores
    {

        private int idProveedor;
        private string documentoProveedor;
        private string nombreProveedor;
        private string correoProveedor;
        private string telefonoProveedor;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string DocumentoProveedor { get => documentoProveedor; set => documentoProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string CorreoProveedor { get => correoProveedor; set => correoProveedor = value; }
        public string TelefonoProveedor { get => telefonoProveedor; set => telefonoProveedor = value; }



        public DataTable VerProveedores()
        {
            try
            {
                using (SqlConnection conn = Conexion.conectar())
                {
                    string query = "SELECT * FROM Proveedores";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                return null;
            }
            }
        public static DataTable ObtenerDatosProveedores()
        {

            try
            {
                SqlConnection conexion = Conexion.conectar();
                string consultaQuery = "select idProveedor,NombreProveedor from Proveedores";
                SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
                DataTable data = new DataTable();
                add.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex);
                return null;
            }

       }


        public bool InsertarProveedor()
        {
            try
            {
                using (SqlConnection conn = Conexion.conectar())
                {
                    string query = @"insert into Proveedores (DocumentoProveedor,NombreProveedor,CorreoProveedor,TelefonoProveedor) values 
 (@documento,@nombre, @correo, @telefono)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@documento", DocumentoProveedor);
                    cmd.Parameters.AddWithValue("@nombre", NombreProveedor);
                    cmd.Parameters.AddWithValue("correo", CorreoProveedor);
                    cmd.Parameters.AddWithValue("telefono", TelefonoProveedor);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarProveedor()
        {
            try {
                using (SqlConnection conn = Conexion.conectar())
                {
                    string query = @"UPDATE Proveedores 
                                 SET DocumentoProveedor =@documento , NombreProveedor=@nombre, CorreoProveedor=@correo, TelefonoProveedor=@telefono 
                                 WHERE idProveedor=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@documento", DocumentoProveedor);
                    cmd.Parameters.AddWithValue("@nombre", NombreProveedor);
                    cmd.Parameters.AddWithValue("correo", CorreoProveedor);
                    cmd.Parameters.AddWithValue("telefono", TelefonoProveedor);
                    cmd.Parameters.AddWithValue("@id", IdProveedor);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                return false;
            }
        }

        Productos Productos = new Productos();
        public bool EliminarProveedor(int id)
        {
            try
            {
                using (SqlConnection conn = Conexion.conectar())
                {
                    SqlCommand cmd = new SqlCommand("EliminarProveedorCompleto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

          
                    cmd.Parameters.AddWithValue("@idProveedor", id);
                    cmd.Parameters.AddWithValue("@idProducto", Productos.IdProducto);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
                return false;
            }
        }
    }
}

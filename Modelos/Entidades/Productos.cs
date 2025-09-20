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
    public class Productos
    {
        private int idProducto;
        private string codigoProducto;
        private string nombreProducto;
        private int categoria_id;
        private int proveedor_id;
        private int stock;
        private decimal precioCompra;
        private decimal precioVenta;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Categoria_id { get => categoria_id; set => categoria_id = value; }
        public int Proveedor_id { get => proveedor_id; set => proveedor_id = value; }
        public int Stock { get => stock; set => stock = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }

        public DataTable ObtenerProductos()
        {
            using (SqlConnection conn = Conexion.conectar())
            {
                string query = "SELECT * FROM Productos";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



        public bool InsertarProducto ()
        {
            try
            {
                using (SqlConnection conn = Conexion.conectar())
                {
                    string query = @"INSERT INTO Productos 
                        (CodigoProducto, NombreProducto, categoria_id, Proveedor_id, Stock, PrecioCompra, PrecioVenta) 
                        VALUES (@codigo, @nombre, @categoria, @proveedor, @stock, @precioCompra, @precioVenta)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@codigo", CodigoProducto);
                    cmd.Parameters.AddWithValue("@nombre", NombreProducto);
                    cmd.Parameters.AddWithValue("@categoria", Categoria_id);
                    cmd.Parameters.AddWithValue("@proveedor", Proveedor_id);
                    cmd.Parameters.AddWithValue("@stock", Stock);
                    cmd.Parameters.AddWithValue("@precioCompra", PrecioCompra);
                    cmd.Parameters.AddWithValue("@precioVenta", PrecioVenta);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error al insertar producto: " + ex.Message);
                return false;

            }


        }

        public bool ActualizarProducto()
        {
            using (SqlConnection conn = Conexion.conectar())
            {
                string query = @"UPDATE Productos SET 
                                    CodigoProducto=@codigo, 
                                    NombreProducto=@nombre, 
                                    categoria_id=@categoria, 
                                    Proveedor_id=@proveedor, 
                                    Stock=@stock, 
                                    PrecioCompra=@precioCompra, 
                                    PrecioVenta=@precioVenta 
                                WHERE idProducto=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
            
                cmd.Parameters.AddWithValue("@codigo",CodigoProducto);
                cmd.Parameters.AddWithValue("@nombre", NombreProducto);
                cmd.Parameters.AddWithValue("@categoria", Categoria_id);
                cmd.Parameters.AddWithValue("@proveedor", Proveedor_id);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@precioCompra", precioCompra);
                cmd.Parameters.AddWithValue("@precioVenta", precioVenta);
                cmd.Parameters.AddWithValue("@id", IdProducto);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            return true;
        }

        public void EliminarProducto(int id)
        {
            using (SqlConnection conn = Conexion.conectar())
            {
                string query = "DELETE FROM Productos WHERE idProducto=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}

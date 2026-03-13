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
   public class Ventas
    {

        private int idVenta;
        private int usuario_id;
        private int producto_id;
        private int tipoDocumento_id;
        private int cantidad;
        private decimal montoTotal;
        private decimal montoPago;
        private decimal montoCambio;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int Usuario_id { get => usuario_id; set => usuario_id = value; }
        public int Producto_id { get => producto_id; set => producto_id = value; }
        public int TipoDocumento_id { get => tipoDocumento_id; set => tipoDocumento_id = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        public decimal MontoPago { get => montoPago; set => montoPago = value; }
        public decimal MontoCambio { get => montoCambio; set => montoCambio = value; }
  
    
    public static DataTable MostrarVentas()
        {
            try
            {
              SqlConnection conexion = Conexion.conectar();
                string query = "select idVenta as 'ID Venta', usuario_id as 'ID Usuario', Usuarios.NombreCompletoUsuario as Usuario, producto_id as 'ID Producto', Productos.NombreProducto as 'Producto', tipoDocumentoVenta_id as 'ID Tipo Venta', TipoDocumentoVenta.nombreTipoDocumentoVenta as 'Tipo de documento', Cantidad, Montopago as 'Pago', MontoCambio as 'Cambio', MontoTotal as 'Total'  from Ventas\r\ninner join Usuarios on Ventas.usuario_id=Usuarios.idUsuario\r\ninner join TipoDocumentoVenta on TipoDocumentoVenta.idTipoDocumentoVenta = Ventas.tipoDocumentoVenta_id\r\ninner join Productos on Productos.idProducto=Ventas.producto_id";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las ventas: " + ex.Message);
                return null;
            }
        }

        public bool InsertarVenta(Ventas venta)
        {
            try
            {
                SqlConnection conexion = Conexion.conectar();
                string query = @"INSERT INTO Ventas 
                                (usuario_id, producto_id, tipoDocumentoVenta_id, Cantidad, MontoPago, MontoCambio, MontoTotal)
                                VALUES (@usuario, @producto, @tipoDoc, @cantidad, @pago, @cambio, @total)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", Usuario_id);
                cmd.Parameters.AddWithValue("@producto", Producto_id);
                cmd.Parameters.AddWithValue("@tipoDoc", TipoDocumento_id);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@pago", montoPago);
                cmd.Parameters.AddWithValue("@cambio", montoCambio);
                cmd.Parameters.AddWithValue("@total", montoTotal);

                conexion.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la venta: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarVenta(Ventas venta)
        {
            try
            {
                SqlConnection conexion = Conexion.conectar();
                string query = @"UPDATE Ventas SET 
                                usuario_id = @usuario, 
                                producto_id = @producto, 
                                tipoDocumentoVenta_id = @tipoDoc, 
                                Cantidad = @cantidad, 
                                MontoPago = @pago, 
                                MontoCambio = @cambio, 
                                MontoTotal = @total
                                WHERE idVenta = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", Usuario_id);
                cmd.Parameters.AddWithValue("@producto", Producto_id);
                cmd.Parameters.AddWithValue("@tipoDoc", TipoDocumento_id);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@pago", montoPago);
                cmd.Parameters.AddWithValue("@cambio", montoCambio);
                cmd.Parameters.AddWithValue("@total", montoTotal);
                cmd.Parameters.AddWithValue("@id", IdVenta);
                conexion.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la venta: " + ex.Message);
                return false;
            }
        }

        
        
        public void EliminarVenta(int idVenta)
        {
            using (SqlConnection conn = Conexion.conectar())
            {
                using (SqlCommand cmd = new SqlCommand("sp_EliminarVenta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades_Negocio
{
    public class Productos_Veriricar
    {

        Productos Productos = new Productos();

        public DataTable ListarProductos()
        {
            return Productos.ObtenerProductos();
        }


        public void AgregarProducto(string codigo, string nombre, int categoria, int proveedor, int stock, decimal precioCompra, decimal precioVenta)
        {
            if (string.IsNullOrWhiteSpace(codigo)) throw new Exception("El código es obligatorio.");
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es obligatorio.");
          

            Productos.InsertarProducto();
        }

        public void EditarProducto(int id, string codigo, string nombre, int categoria, int proveedor, int stock, decimal precioCompra, decimal precioVenta)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            Productos.ActualizarProducto();

        }


        public void BorrarProducto(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");

            Productos.EliminarProducto(id);
        }

    }
}

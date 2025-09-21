using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades_Negocio
{
   public class Proveedor_Verificar
    {
    
    Proveedores Proveedores = new Proveedores();

        public DataTable ListarProveedores()
        {
            return     Proveedores.ObtenerDatosProveedores();
        }

        public DataTable VerProveedores()
        {
            return Proveedores.VerProveedores();
        }

        public void AgregarProveedor(string nombre, string telefono, string direccion)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es obligatorio.");

            Proveedores.InsertarProveedor();
        }


        public void EditarProveedor(int id, string nombre, string telefono, string direccion)
        {
            if (id <= 0) throw new Exception("ID inválido.");

            Proveedores.ActualizarProveedor();
        }
    }
}

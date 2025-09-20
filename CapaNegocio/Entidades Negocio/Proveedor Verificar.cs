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

    }
}

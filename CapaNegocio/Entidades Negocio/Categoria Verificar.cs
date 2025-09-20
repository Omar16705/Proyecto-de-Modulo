using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades_Negocio
{
    public class Categoria_Verificar
    {

        Categoria Categoria = new Categoria();
        public DataTable ListarCategoria()
        {
            return Categoria.ObtenerDatosCategoria();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class VerificarUsuario
    {

        private static string nombre_usuario;
        private static string email;
        private static string rol;

        public static string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public static string Email { get => email; set => email = value; }
        public static string Rol { get => rol; set => rol = value; }

    }
}

using Modelos.Conexion_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
   public class Usuario
    {

        private int IdUsuario;
        private string NombreCompletoUsuario;
       
        private string CorrreoElectronico;
        private string Clave;
        private int IdRol;

        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public string NombreCompletoUsuario1 { get => NombreCompletoUsuario; set => NombreCompletoUsuario = value; }
      
        public string CorrreoElectronico1 { get => CorrreoElectronico; set => CorrreoElectronico = value; }
        public string Clave1 { get => Clave; set => Clave = value; }
        public int IdRol1 { get => IdRol; set => IdRol = value; }



        public static DataSet MostrarUsuarios()
        {
            try
            {
                SqlConnection conexion = Conexion.conectar();
                conexion.Open();
                string query = "select * from Usuarios";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds, "USUARIOS");
                conexion.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex);
                return null;
            }
        }

        public bool InsertarUsuario()
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    conexion.Open();
                    string query = @"INSERT INTO USUARIOS
                (NombreCompletoUsuario, correoUsuario, Clave, rol_id) 
                VALUES (@NombreCompletoUsuario, @CorreoElectronico, @Clave, @IdRol)";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@NombreCompletoUsuario", NombreCompletoUsuario1);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", CorrreoElectronico1);
                    cmd.Parameters.AddWithValue("@Clave", Clave1);
                    cmd.Parameters.AddWithValue("@IdRol", IdRol1);

                    cmd.ExecuteNonQuery();

                    //  Mensaje dinámico según el rol asignado
                    string mensaje;
                    switch (IdRol1)
                    {
                        case 1: // Administrador
                            mensaje = "Se ha insertado un ADMINISTRADOR con acceso completo al sistema.";
                            break;

                        case 2: // Vendedor
                            mensaje = "Se ha insertado un VENDEDOR con permiso de registrar ventas dentro del sistema.";
                            break;

                        case 3: // Almacenista
                            mensaje = "Se ha insertado un ALMACENISTA con permiso de gestionar el inventario.";
                            break;

                        default:
                            mensaje = "Se ha insertado un usuario con rol no definido en el sistema.";
                            break;
                    }


                    MessageBox.Show(mensaje, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                return false;
            }
        }




        public bool Ingresar()
        {
            try
            {
                SqlConnection connection = Conexion.conectar();

                connection.Open();


                string consulta = @"select Clave from vw_Login where NombreCompletoUsuario = @user";

                SqlCommand comando = new SqlCommand(consulta, connection);

                comando.Parameters.Add("@user", SqlDbType.VarChar, 100).Value = NombreCompletoUsuario;

                object resultado = comando.ExecuteScalar();

                ////////////Aqui verificamos i el usuario existe
                if (resultado == null || resultado == DBNull.Value)
                {
                    MessageBox.Show("El usuario no existe.");
                    return false;
                }

                string hashEnBaseDatos = resultado.ToString();

                ////////Aqui el programa verifica si la contraseña existe sino muestra el mensaje 
                if (!BCrypt.Net.BCrypt.Verify(Clave, hashEnBaseDatos))
                {
                    MessageBox.Show("Contraseña incorrecta.");
                    return false;
                }


                string consulta2 = @"select NombreCompletoUsuario, correoUsuario, NombreRol  FROM vw_Login  where NombreCompletoUsuario = @user";

                SqlCommand command = new SqlCommand(consulta2, connection);

                command.Parameters.Add("@user", SqlDbType.VarChar, 100).Value = NombreCompletoUsuario;
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        VerificarUsuario.Nombre_usuario = rd.GetString(0);
                        VerificarUsuario.Email = rd.GetString(1);
                        VerificarUsuario.Rol = rd.GetString(2);
                        return true; // Login correcto
                    }
                }


                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el inicio de sesión: " + ex.Message);
                return false;
            }
        }


        public bool EliminarUsuario()
        {
            try
            {
                SqlConnection conexion = Conexion.conectar();
                conexion.Open();
                string query = "delete from USUARIOS where idUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el Usuario");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex);
                return false;
            }
        }

        public bool ActualizarUsuario()
        {
            try
            {
                SqlConnection conexion = Conexion.conectar();
                conexion.Open();
                string query = "update USUARIOS set NombreCompletoUsuario = @NombreCompletoUsuario, correoUsuario = @CorreoElectronico, rol_id = @IdRol where idUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario1);
                cmd.Parameters.AddWithValue("@NombreCompletoUsuario", NombreCompletoUsuario1);
                cmd.Parameters.AddWithValue("@CorreoElectronico", CorrreoElectronico1);
 
                cmd.Parameters.AddWithValue("@IdRol", IdRol1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha actualizado el Usuario");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex);
                return false;
            }
        }
    }
}

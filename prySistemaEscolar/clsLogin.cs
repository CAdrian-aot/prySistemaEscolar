using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsLogin
    {
        
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        //Atributos estaticos
        private static string perfil;
        private static bool esAdmin;
        private static bool esDocente;

        //Propiedad estatica
        public static bool EsAdmin { get => esAdmin; }
        public static bool EsDocente { get => esDocente; }

        public void AsignarPermisos()
        {
            switch (perfil)
            {
                case "Administrador":
                    esAdmin = true;
                    esDocente = false;
                    break;
                case "Docente":
                    esAdmin = false;
                    esDocente = true;
                    break;
                default:
                    esAdmin = false;
                    esDocente=false;
                    break;
            }
        }

        public bool ValidarAcceso()
        {
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT vchperfil FROM tblusuarios " +
                                 "WHERE vchnombreUsuario = @usuario AND vchPASSWORD = @password;";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                AsignarPermisos();
                                if (!esAdmin && !esDocente)
                                {
                                    throw new Exception($"El perfil {perfil} no tiene permisos para acceder");
                                }

                                MessageBox.Show("Tu perfil es: " + perfil, "Sistema");
                                 return true;

                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos");
                            }
                        }//Liberar MySqlDataReader
                    }//Liberar MySqlCommand
                }//Liberar MySqlConnection a traves de tu clase
            }
            catch (Exception ex)
            {
                //Si ocurre un error, lo reelanzamos para que lo capture el formulario 
                throw new Exception(ex.Message, ex);
            }
        }//fin del metodo

    }
}

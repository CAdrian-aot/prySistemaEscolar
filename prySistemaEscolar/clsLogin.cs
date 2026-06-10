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

        public static string perfil;

        public bool ValidarAcceso()
        {
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.abrirConexion())
                {
                    string sql = "SELECT perfil FROM tblUsuarios " +
                                 "WHERE nombreUsuario = @usuario AND password = @password;";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("vchrol");
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

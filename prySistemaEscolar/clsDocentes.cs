using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsDocentes
    {
        //Datos docente
        private int clave;
        private string nombre;
        private string puesto;
        private int idUsuario;
        private string telefono;
        private string correo;
        //Datos usuario
        private string nombreUsuario;
        private string password;
        private string perfil;
        //Adaptador y tabla virtual de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;

        public int Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        //Método para cargar la tabla
        public DataTable CargarDatagrid()
        {
            tabla = new DataTable();

            try
            {
                ClsConexion conexionBD = new ClsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.idUsuario AS idUsuario, " +
                                 "D.nombreDocente AS Nombre, " +
                                 "D.puesto AS Puesto, " +
                                 "U.vchnombreUsuario AS NombreUsuario, " +
                                 "U.vchperfil AS Perfil, " +
                                 "U.vchpassword AS Password, " +
                                 "D.telefono AS Telefono, " +
                                 "D.correo AS Correo " +
                                 "FROM tbldocentes D " +
                                 "INNER JOIN tblusuarios U ON D.idUsuario = U.intidUsuario;";
                    using (var consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.SelectCommand.Parameters.AddWithValue("@claveDocente", "%" + clave + "%");
                        consulta.Fill(tabla);
                    }//Libera la adaptador
                }//Libera la cosulta
            }//Libera conexión
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión " + ex.Message);
            }

            return tabla;
        }



        //Método para buscar en la tabla
        public DataTable Consultar()
        {
            tabla = new DataTable();

            try
            {
                ClsConexion conexionBD = new ClsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.idUsuario AS idUsuario, " +
                                 "D.nombreDocente AS Nombre, " +
                                 "D.puesto AS Puesto, " +
                                 "U.vchnombreUsuario AS NombreUsuario, " +
                                 "U.vchperfil AS Perfil, " +
                                 "U.vchpassword AS Password, " +
                                 "D.telefono AS Telefono, " +
                                 "D.correo AS Correo " +
                                 "FROM tbldocentes D " +
                                 "INNER JOIN tblusuarios U ON D.idUsuario = U.intidUsuario " +
                                 "WHERE D.claveDocente LIKE @claveDocente;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@claveDocente", "%" + clave + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Libera adaptador
                    }//Libera consulta
                }//Libera conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión " + ex.Message);
            }

            return tabla;
        }

        //Método para insertar o actualizar un registro
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";

            ClsConexion conexionBD = new ClsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            switch (tipoOperacion)
                            {
                                case 0://Nuevo registro
                                    //Paso A: Insertar en la tabla de usuarios
                                    string sqlInUser = "INSERT INTO tblusuarios (vchnombreUsuario, vchpassword, vchperfil, vchestado) " +
                                                        "VALUES (@nomUser, MD5(@pass), @perfil, 'Activo'); SELECT LAST_INSERT_ID();";
                                    int nuevoUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                    }
                                    //Paso B: Insertar en la tabla de docentes
                                    string sqlInDocente = "INSERT INTO tbldocentes (claveDocente, nombreDocente, puesto, idUsuario, telefono, correo) " +
                                                        "VALUES (@claveD, @nombreD, @puesto, @idUsuario, @tel, @correo);";
                                    using (comando = new MySqlCommand(sqlInDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@claveD", clave);
                                        comando.Parameters.AddWithValue("@nombreD", nombre);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoUsuario);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "El docente y sus credenciales se guardaron correctamente";
                                    break;
                                case 1: //Actualizar registro
                                    //Paso A: Actualizar la tabla de usuarios
                                    string sqlUpUser = "UPDATE tblusuarios SET vchnombreUsuario = @nomUser, vchpassword = MD5(@pass), vchperfil = @perfil WHERE intidUsuario = @idUsuario";
                                    using (comando = new MySqlCommand(sqlUpUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                        comando.ExecuteNonQuery();
                                    }
                                    //Paso B: Actualizar la tabla de docentes
                                    string sqlUpDocente = "UPDATE tbldocentes SET nombreDocente = @nombreD, puesto = @puesto, telefono = @tel, correo = @correo WHERE claveDocente = @claveD";
                                    using (comando = new MySqlCommand(sqlUpDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nombreD", nombre);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@claveD", clave);
                                        comando.ExecuteNonQuery();
                                    }

                                    msg= "Los datos del docente y sus credenciales se actualizaron correctamente";
                                    break;
                            }
                            //Se hace la transacción si no hay errores
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            //Hacer rollback en caso de error
                            transaccion.Rollback();
                            throw new Exception("Error en la operación, se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión: " + ex.Message);
            }

            return msg;
        }

        
        //Método para eliminar un registro
        public string Eliminar()
        {
            string msg = "";
            ClsConexion conexionBD = new ClsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            //Eliminar el registro de docentes
                            string sqlDocente = "DELETE FROM tbldocentes WHERE claveDocente = @claveDocente;";
                            using (comando = new MySqlCommand(sqlDocente, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@claveDocente", clave);
                                comando.ExecuteNonQuery();
                            }
                            //Eliminar el registro de usuarios
                            string sqlUsuario = "DELETE FROM tblusuarios WHERE intidUsuario = @idUsuario;";
                            using (comando = new MySqlCommand(sqlUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                comando.ExecuteNonQuery();
                            }
                            //Confirmar la transacción
                            transaccion.Commit();
                            msg = "Registro eliminado correctamente del sistema.";
                        }
                        catch (Exception ex)
                        {
                            //Hacer rollback en caso de error
                            transaccion.Rollback();
                            throw new Exception("Error en la operación, se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "Error en la conexión al eliminar: " + ex.Message;
            }

            return msg;
        }

    }
}

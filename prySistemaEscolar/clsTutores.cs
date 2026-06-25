using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsTutores
    {
        //Se crean los atributos
        private string nombreTutor;
        private string parentesco;
        private string direccion;
        private string telefono;
        private string correo;

        private int idTutor; //Se crea para poder hacer referencia a la hora de actualizar o eliminar un registro
        private MySqlDataAdapter consulta; //Se crea un adaptador para poder hacer consultas a la base de datos
        private MySqlCommand comando; //Se crea un comando para poder insertar o actualizar registros en la base de datos
        private DataTable tabla; //Se crea una tabla temporal para poder almacenar los datos que se obtienen de la base de datos


        //Set y get para los atributos
        public string NombreTutor { get => nombreTutor; set => nombreTutor = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }

        //Metodo que se usa para cargar los datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Tutor, parentesco AS Parentesco, direccion AS Direccion, telefono AS Telefono, correo AS Correo FROM tbltutores";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los datos en la tabla" + ex.Message);
            }
            return tabla;
        }
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Tutor, parentesco AS Parentesco, direccion AS Direccion, telefono AS Telefono, correo AS Correo FROM tbltutores WHERE nombreTutor LIKE @tutor;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@tutor", "%" + nombreTutor + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Liberar el adaptador
                    }//Liberar la consulta
                }//Liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos " + ex.Message);
            }
            return tabla;
        }

        public string Eliminar()
        {
            string msg = "";
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tbltutores C WHERE C.idTutor = @idTutor;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    }//liberar las conexiones
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }
        public string GuardarActualizar(int TipoOperacion)
        {

            string msg = "";
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (TipoOperacion)
                    {
                        case 0://insertarNEW
                            string sqlN = "INSERT INTO tbltutores(nombreTutor, parentesco, direccion, telefono, correo) VALUES (@nombreTutor, @parentesco, @direccion, @telefono, @correo);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos";
                                }
                            }//Liberar la operacion de insercion
                            break;
                        case 1://ActualizarOLD
                            string sqlA = "UPDATE tbltutores C SET C.nombreTutor = @nombreTutor, C.parentesco = @parentesco, C.direccion = @direccion, C.telefono = @telefono, C.correo = @correo WHERE C.idTutor = @idTutor;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("idTutor", idTutor);
                                comando.Parameters.AddWithValue("nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);
                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se actualizo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se actualizaron los datos";
                                }
                            }//Liberar la operacion de actualizacion
                            break;
                    }
                }//Libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }

    }
}

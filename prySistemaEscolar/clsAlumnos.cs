using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsAlumnos
    {
        private int matricula;
        private string nombreAlumno;
        private string apellidoP;
        private string apellidoM;
        private string direccion;
        private string telefono;
        private string correo;
        private decimal promedioBachillerato; 
        private int idTutor; // Foraneo
        private int idCarrera; // Foraneo
        private int idusuario;
        //Nuevos
        private string nombreUsuario;
        private string password;
        private string perfil;
        // Adaptador y tabla virtuales de la clase 
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;

        // Propiedades
        public int Matricula { get => matricula; set => matricula = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public decimal PromedioBachillerato { get => promedioBachillerato; set => promedioBachillerato = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        //Metodo para cargar datos en el DataGrid//
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                ClsConexion conexionBD = new ClsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " + //Aqui se agrega el password
                                 "U.vchperfil, " + //Aqui se agrega el perfil
                                 "A.direccion, A.telefono, A.correo, A.promedioBachillerato, " +
                                 "A.idTutor, A.idCarrera, A.idUsuario " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario;";
                    using (var consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.SelectCommand.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberar conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión" + ex.Message);
            }
            return tabla;
        }

        //Para obtener carreras
        public DataTable ObtenerCarreras()
        {
            tabla = new DataTable();

            try
            {
                ClsConexion conexionBD = new ClsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera, nombreCarrera FROM tblcarreras";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberar conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener carreras: " + ex.Message);
            }
            return tabla;
        }

        //Para obtener tutores
        public DataTable ObtenerTutores() 
        {
            tabla = new DataTable();

            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor, nombreTutor FROM tbltutores";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener tutores: " + ex.Message);
            }
            return tabla;
        }

        //Meotodo para limpiar
        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0; 
                }
            }
        }

        //Metodo para buscar
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " + //Aqui se agrega el password
                                 "U.vchperfil, " + //Aqui se agrega el perfil
                                 "A.direccion, A.telefono, A.correo, A.promedioBachillerato, " +
                                 "A.idTutor, A.idCarrera, A.idUsuario " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario " +
                                 "WHERE A.Matricula LIKE @matricula;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Liberar el adaptador
                    }//Liberar la consulta
                }//Liberar conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión" + ex.Message);
            }
            return tabla;
        }

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
                            //eliminamos alumnos
                            string sqlDelAlumno = " DELETE FROM tblalumnos WHERE matricula = @matricula;";
                            using (comando = new MySqlCommand(sqlDelAlumno, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@matricula", matricula);
                                comando.ExecuteNonQuery();
                            }
                            //eliminamos el usuario
                            string sqlDelUsuario = " DELETE FROM tblusuarios WHERE intidUsuario = @idUsuario;";
                            using (comando  = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idusuario", idusuario);
                                comando.ExecuteNonQuery();
                            }
                            //si ambas se eliminan correctamente 
                            transaccion.Commit();
                            msg = "El alumno y sus credenciales de usuario han sido eliminados del sistema.";
                        }
                        catch (Exception ex)
                        {
                            //Si algo falla, deshacemos la operacion para no dejar datos huerfanos
                            transaccion.Rollback();
                            throw new Exception("No se pudo completar la eliminacion. Cambios revertidos: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion al eliminar: " + ex.Message);
            }

            return msg;
        }

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
                                case 0://Nuevo e insertar
                                       //Insertar en la tabla tblusuarios
                                    string sqlInUser = "INSERT INTO tblusuarios(vchnombreUsuario, vchpassword, vchperfil, vchestado) " +
                                        "VALUES(@nomUser, MD5(@pass), @perfil, 'Activo'); SELECT LAST_INSERT_ID();";
                                    int nuevoUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                    }
                                    //Paso B: Insertar el alumno en tblalumnos vinculado al ID del usuario obtenido
                                    string sqlInAlumno = "INSERT INTO tblalumnos(matricula, nombreAlumno, apellidoP, apellidoM, direccion, telefono, correo, promedioBachillerato, idTutor, idCarrera, idUsuario) " +
                                        "VALUES(@matricula, @nombre, @apP, @apM, @dir, @tel, @correo, @prom, @idTutor, @idCarrera, @idUsuario);";
                                    using (comando = new MySqlCommand(sqlInAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);                                        
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoUsuario);

                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "El alumno y sus credenciales se guardaron correctamente.";
                                    break;
                                case 1://Actualizar
                                       //Paso A: Actualizar la tabla tblusuarios usando el ID que recuperamos en el click
                                    string sqlUpUser = "UPDATE tblusuarios SET vchnombreUsuario = @nomUser, vchpassword = MD5(@pass), vchperfil = @perfil WHERE intidUsuario = @idUsuario;";
                                    using (comando = new MySqlCommand(sqlUpUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", idusuario);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }
                                    //Paso B: Actualizar el alumno en tblalumnos usando el ID que recuperamos en el click
                                    string sqlUpAlumno = "UPDATE tblalumnos SET nombreAlumno = @nombre, apellidoP = @apP, apellidoM = @apM, direccion = @dir, telefono = @tel, " +
                                        "correo = @correo, promedioBachillerato = @prom, idTutor = @idTutor, idCarrera = @idCarrera WHERE matricula = @matricula;";
                                    using (comando = new MySqlCommand(sqlUpAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);
                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "Los datos del alumno se actualizaron correctamente.";
                                    break;
                            }
                            //Si todo se ejecutó sin errores en el switch, confirmamos en la BD
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            //Si algo falló (en el usuario o en el alumno), dehacemos todo para evitar incosistencias
                            transaccion.Rollback();
                            throw new Exception("Error en la operación. Se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión: " + ex.Message);
            }

            return msg;
        }//Finaliza el método GuardarActualizar

    }
}
//Si se requiere un campo identificado, se crea un campo tipo indice
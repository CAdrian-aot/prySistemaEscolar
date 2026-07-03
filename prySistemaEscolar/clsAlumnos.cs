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



    }
}

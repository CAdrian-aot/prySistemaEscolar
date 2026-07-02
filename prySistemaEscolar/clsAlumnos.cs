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
                    string sql = "SELECT A.matricula AS Matricula," +
                                 "A.nombreAlumno AS Nombre," +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno'," +
                                 "C.nombreCarrera AS Carrera," +
                                 "T.nombreTutor AS Tutor," +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " + // <-- AQUI SE AGREGA EL PASSWORD
                                 "U.vchperfil, " +   // <-- AQUI SE AGREGA EL PERFIL
                                 "A.direccion, A.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario" +
                                 "FROM tblalumnos A" +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera" +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor" +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario WHERE A.matricula LIKE @matricula;";
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
    }
}

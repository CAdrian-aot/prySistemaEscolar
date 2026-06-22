using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clsCarreras
    {
        private string nombreCarrera;
        //Usamos un adaptador
        private MySqlDataAdapter consulta;
        //Usamos una tabla temporal
        private DataTable tabla;

        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }

        //Metodo para cargar datos en el DataGrid//
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                ClsConexion conexionBD = new ClsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descripcion FROM tblcarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
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

        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                ClsConexion conexionBD = new ClsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion FROM tblcarreras WHERE nombreCarrera LIKE @carrera;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@carrera", "%" + nombreCarrera + "%");
                        using (consulta = new MySqlDataAdapter (consultar))
		                {
                            consulta.Fill(tabla);
		                }///liberar el adaptador

                    }///liberar la consulta

                }///libera la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("error en la conexión" + ex.Message);
            }
            return tabla;
        }

    }
}


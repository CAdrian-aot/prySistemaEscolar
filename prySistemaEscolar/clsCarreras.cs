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
                    string sql = "select idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descripción from tblCarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberar conexión
            }
            catch (Exception ex)
            {
                throw new Exception("error en la conexión" + ex.Message);
            }
            return tabla;
        }
    }
    }
}

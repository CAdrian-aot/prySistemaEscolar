using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;

namespace prySistemaEscolar
{
    internal class ClsConexion
    {
        private string host = "189.240.192.140";
        private string bd = "bdescuela3d";
        private string usuario = "terceroD";
        private string password = "tercero@D";
        private string puerto = "3306";

        private string cadenaConexion => $"server={host}; database={bd}; user={usuario}; password={password}; port={puerto};";

        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            } 
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la Base de Datos" + ex.Message, ex);
            }
        }

        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar cerrar la conexión a la Base de Datos" + ex.Message, ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBD
{
    internal class ConexionBD
    {
     
        private string cadenaConexion = @"Server=Usuario-PC\SQLEXPRESS;Database=LibreriaDB;Trusted_Connection=True;";

        // EN CASA: @"Server=Usuario-PC\SQLEXPRESS;Database=LibreriaDB;Trusted_Connection=True;"
        // EN IES: @"Server=PC131;Database=LibreriaDB;Trusted_Connection=True;"
        private SqlConnection conexion;

        public ConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection AbrirConexion() {
            if (conexion.State == System.Data.ConnectionState.Closed) {
                conexion.Open();
            }

            return conexion;
        }

        public void CerrarConexion() {
            if (conexion.State == System.Data.ConnectionState.Open) {
                conexion.Close();
            }
        }
    }
}


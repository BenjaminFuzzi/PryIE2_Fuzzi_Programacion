using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBD
{
    // Clase encargada de administrar la conexión
    // con SQL Server.
    internal class ConexionBD
    {
        // Cadena de conexión:
        // Server     -> Nombre del servidor SQL
        // Database   -> Base de datos
        // Trusted_Connection=True -> Usa autenticación de Windows
        //string conexion =
        //"Server=localhost\\SQLEXPRESS;Database=NegocioDB;Trusted_Connection=True;";
        private string cadenaConexion = @"Server=Usuario-PC\SQLEXPRESS;Database=LibreriaDB;Trusted_Connection=True;";

        // Objeto SqlConnection:
        // representa la conexión física a SQL Server.
        private SqlConnection conexion;

        // Constructor
        public ConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        // Método para abrir la conexión
        public SqlConnection AbrirConexion() {
            if (conexion.State == System.Data.ConnectionState.Closed) {
                conexion.Open();
            }

            return conexion;
        }

        // Método para cerrar la conexión
        public void CerrarConexion() {
            // Si la conexión está abierta, la cierra
            if (conexion.State == System.Data.ConnectionState.Open) {
                conexion.Close();
            }
        }
    }
}


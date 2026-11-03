using PruebaBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryIE2_Fuzzi_Programacion {
    internal class ClienteDAO {
        private ConexionBD conexion = new ConexionBD();

        public void InsertarCliente(Cliente cliente) {
            String query = "INSERT INTO Clientes(Nombre, Apellido, Telefono, Email) " +
                "VALUES(@Nombre, @Apellido, @Telefono, @Email)";
            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public DataTable ObtenerClientes() {
            string query = "SELECT * FROM Clientes";

            SqlCommand comando =
                new SqlCommand(query, conexion.AbrirConexion());

            SqlDataReader lector = comando.ExecuteReader();
            DataTable tabla = new DataTable();

            tabla.Load(lector);

            conexion.CerrarConexion();

            return tabla;
        }
        public void EliminarCliente(int id) {
            string query = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";

            SqlCommand comando =
                new SqlCommand(query, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@IdCliente", id);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }
        public void ActualizarCliente(Cliente cliente) {
            String query = "UPDATE Clientes " +
                "SET Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono, Email=@Email " +
                "WHERE Id=@Id";
            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }
    }
}

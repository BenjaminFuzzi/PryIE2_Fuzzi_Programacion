using PruebaBD;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PryIE2_Fuzzi_Programacion
{
    internal class ProductoDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public void InsertarProducto(Producto producto)
        {
            String query = "INSERT INTO Productos(Descripcion, Precio, Stock) " +
                "VALUES(@Descripcion, @Precio, @Stock)";
            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public DataTable ObtenerProductos() {
            try {
                string query = "SELECT * FROM Productos";

                SqlCommand comando =
                    new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader lector = comando.ExecuteReader();
                DataTable tabla = new DataTable();

                tabla.Load(lector);

                conexion.CerrarConexion();

                return tabla;
            } catch (SqlException e) {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTable tabla = new DataTable();
                return tabla;
            }
        }
        public void EliminarProducto(int id)
        {
            try
            {
                string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                SqlCommand comando =
                    new SqlCommand(query, conexion.AbrirConexion());

                comando.Parameters.AddWithValue("@IdProducto", id);
                comando.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizarProducto(Producto producto, int id)
        {
            try
            {
                String query = "UPDATE Productos " +
                    "SET Descripcion=@Descripcion, Precio=@Precio, Stock=@Stock " +
                    "WHERE IdProducto=" + id;
                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Stock", producto.Stock);
                comando.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

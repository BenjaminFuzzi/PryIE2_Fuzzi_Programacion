using PruebaBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIE2_Fuzzi_Programacion
{
    internal class VentaDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public void InsertarVenta(Venta venta)
        {
            String query = "INSERT INTO Ventas(idCliente, IdProducto, Cantidad) " +
                "VALUES(@IdCliente, @IdProducto, @Cantidad)";
            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@IdCliente", venta.IdCliente);
            comando.Parameters.AddWithValue("@IdProducto", venta.IdProducto);
            comando.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public DataTable ObtenerProductos()
        {
            try
            {
                string query = "SELECT * FROM Ventas";

                SqlCommand comando =
                    new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader lector = comando.ExecuteReader();
                DataTable tabla = new DataTable();

                tabla.Load(lector);

                conexion.CerrarConexion();

                return tabla;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTable tabla = new DataTable();
                return tabla;
            }
        }
    }
}

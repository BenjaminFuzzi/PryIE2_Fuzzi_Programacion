using PruebaBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIE2_Fuzzi_Programacion {
    internal class ProveedorDAO {
        private ConexionBD conexion = new ConexionBD();

        public void InsertarProveedor(Proveedor proveedor)
        {
            String query = "INSERT INTO Proveedores(RazonSocial, Telefono, Email) " +
                "VALUES(@RazonSocial, @Telefono, @Email)";
            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
            comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
            comando.Parameters.AddWithValue("@Email", proveedor.Email);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }

        public DataTable ObtenerProveedores()
        {
            try
            {
                string query = "SELECT * FROM Proveedores";

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
        public void EliminarProveedor(int id)
        {
            try
            {
                string query = "DELETE FROM Proveedores WHERE IdProveedor =" + id;

                SqlCommand comando =
                    new SqlCommand(query, conexion.AbrirConexion());

                comando.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizarProveedor(Proveedor proveedor, int id)
        {
            try
            {
                String query = "UPDATE Proveedores " +
                    "SET RazonSocial=@RazonSocial, Telefono=@Telefono, Email=@Email " +
                    "WHERE IdProveedor=" + id;
                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                comando.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                comando.Parameters.AddWithValue("@Email", proveedor.Email);
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

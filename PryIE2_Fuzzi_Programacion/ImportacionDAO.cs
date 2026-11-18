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

    
    internal class ImportacionDAO
    {
        ConexionBD conexion = new ConexionBD();
        public void InsertarImportacion(Importacion importacion)
        {
            String query = "INSERT INTO Importaciones(Fecha, CantidadRegistros, Usuario) " +
                "VALUES(@Fecha, @CantidadRegistros, @Usuario)";
            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@Fecha", importacion.Fecha);
            comando.Parameters.AddWithValue("@CantidadRegistros", importacion.CantidadRegistros);
            comando.Parameters.AddWithValue("@Usuario", importacion.Usuario);
            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }
        public DataTable ObtenerImportaciones()
        {
            try
            {
                string query = "SELECT * FROM Importaciones";

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

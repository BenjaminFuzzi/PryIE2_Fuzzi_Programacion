using PruebaBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIE2_Fuzzi_Programacion
{
    public partial class frmBajoStock : Form
    {
        public frmBajoStock()
        {
            InitializeComponent();
        }
        ConexionBD conexion = new ConexionBD();

        public DataTable ObtenerProductosBajoStock() {
            try {
                string query = "SELECT * FROM Productos WHERE Stock < 10";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

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

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvBajoStock.DataSource = ObtenerProductosBajoStock();
        }
    }
}

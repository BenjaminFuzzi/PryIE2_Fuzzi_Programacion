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
    public partial class frmNuevaVenta : Form
    {
        public frmNuevaVenta()
        {
            InitializeComponent();
            cargarCombos();
        }
        ConexionBD conexion = new ConexionBD();
        VentaDAO vDAO = new VentaDAO();

        public void cargarCombos() {
            try {
                string query = "SELECT Descripcion FROM Productos";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read()) {
                    if (!lector.IsDBNull(0)) {
                        cbxProducto.Items.Add(lector.GetString(0));
                    }
                }

                conexion.CerrarConexion();

            } catch (SqlException e) {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try {
                string query = "SELECT Nombre FROM Clientes";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    if (!lector.IsDBNull(0))
                    {
                        cbxCliente.Items.Add(lector.GetString(0));
                    }
                }

                conexion.CerrarConexion();

            } catch (SqlException e) {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Int32 [] obtenerIDs() {
            Int32 [] IDs = new Int32[2];

            try {
                string query = "SELECT IdCliente FROM Clientes WHERE Nombre = " + "'" + cbxCliente.Text + "'";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    if (!lector.IsDBNull(0))
                    {
                        IDs[1] = lector.GetInt32(0);
                    }
                }

                conexion.CerrarConexion();

            } catch (SqlException X) {
                MessageBox.Show(X.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTable tabla = new DataTable();
            }

            try {
                string query = "SELECT IdProducto FROM Productos WHERE Descripcion = " + "'" + cbxProducto.Text + "'";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read()) {
                    if (!lector.IsDBNull(0))
                    {
                        IDs[0] = lector.GetInt32(0);
                    }
                }

                conexion.CerrarConexion();

            } catch (SqlException X) {
                MessageBox.Show(X.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTable tabla = new DataTable();
            }

            return IDs;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            Int32 MaxStock = 0;
            if (cbxCliente.Text != string.Empty &&
                cbxProducto.Text != string.Empty &&
                txtCantidad.Text != string.Empty &&
                Int32.TryParse(txtCantidad.Text,out Int32 y) ) {
                
                try {
                    string query = "SELECT Stock FROM Productos WHERE Descripcion = " + "'" + cbxProducto.Text + "'";

                    SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read()) {
                        if (!lector.IsDBNull(0)) {
                            MaxStock = lector.GetInt32(0);
                        }
                    }

                    conexion.CerrarConexion();

                    if (MaxStock >= Convert.ToInt32(txtCantidad.Text)) {
                        Venta venta = new Venta();

                        Int32[] DatosVenta = obtenerIDs();

                        venta.IdCliente = DatosVenta[0];
                        venta.IdProducto = DatosVenta[1];
                        venta.Cantidad = Convert.ToInt32(txtCantidad.Text);

                        vDAO.InsertarVenta(venta);
                        MessageBox.Show("Venta Realizada.", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        MessageBox.Show("No hay Suficiente Stock.", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } catch (SqlException X) {
                    MessageBox.Show(X.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Ingresar detalles válidos.", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void cbxProducto_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
    }
}

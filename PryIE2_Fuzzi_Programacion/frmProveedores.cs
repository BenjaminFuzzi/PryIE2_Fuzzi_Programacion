using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIE2_Fuzzi_Programacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        ProveedorDAO Dao = new ProveedorDAO();
        int idSeleccionado = 0;
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
        private void CargarProveedores() {
            dgvProveedores.DataSource = Dao.ObtenerProveedores();
        }
        private void limpiarCampos() {

            txtIdProveedor.Clear();
            txtRazonSocial.Clear();
            txtTelefono.Clear();   
            txtEmail.Clear();
            idSeleccionado = 0;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text != string.Empty &&
                txtTelefono.Text != string.Empty &&
                txtEmail.Text != string.Empty) {

                Proveedor proveedor = new Proveedor();

                proveedor.RazonSocial = txtRazonSocial.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Email = txtEmail.Text;

                Dao.InsertarProveedor(proveedor);

                CargarProveedores();

                MessageBox.Show("Proveedor guardado", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Ingresar datos válidos", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0) {
                Dao.EliminarProveedor(idSeleccionado);

                MessageBox.Show("Proveedor eliminado", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProveedores();
                limpiarCampos();
            } else {
                MessageBox.Show("Seleccione un proveedor", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text != string.Empty &&
               txtTelefono.Text != string.Empty &&
               txtEmail.Text != string.Empty &&
               idSeleccionado > 0)
            {

                Proveedor proveedor = new Proveedor();

                proveedor.RazonSocial = txtRazonSocial.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Email = txtEmail.Text;

                Dao.ActualizarProveedor(proveedor, idSeleccionado);

                CargarProveedores();

                MessageBox.Show("Proveedor actualizado", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Ingresar datos válidos", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(fila.Cells["IdProveedor"].Value);

            txtIdProveedor.Text = idSeleccionado.ToString();

            txtRazonSocial.Text = fila.Cells["RazonSocial"].Value.ToString();

            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();

            txtEmail.Text = fila.Cells["Email"].Value.ToString();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}

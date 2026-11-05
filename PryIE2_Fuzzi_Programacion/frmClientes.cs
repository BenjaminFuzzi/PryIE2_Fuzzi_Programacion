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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        ClienteDAO Dao = new ClienteDAO();
        int idSeleccionado = 0;

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
        private void CargarClientes()
        {
            dgvClientes.DataSource = Dao.ObtenerClientes();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && 
                txtApellido.Text != string.Empty && 
                txtTelefono.Text != string.Empty && 
                txtEmail.Text != string.Empty) {

                Cliente cliente = new Cliente();

                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Email = txtEmail.Text;

                Dao.InsertarCliente(cliente);

                MessageBox.Show("Cliente guardado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarClientes();

                LimpiarCampos();
            } else {
                MessageBox.Show("Ingresar datos válidos", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            idSeleccionado = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0) {
                Dao.EliminarCliente(idSeleccionado);

                MessageBox.Show("Cliente eliminado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarClientes();

                LimpiarCampos();
            } else {
                MessageBox.Show("Seleccione un Cliente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty &&
                txtApellido.Text != string.Empty &&
                txtTelefono.Text != string.Empty &&
                txtEmail.Text != string.Empty &&
                idSeleccionado > 0) {

                Cliente cliente = new Cliente();

                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Email = txtEmail.Text;

                Dao.ActualizarCliente(cliente, idSeleccionado);

                MessageBox.Show("Cliente actualizado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarClientes();

                LimpiarCampos();
            } else {
                MessageBox.Show("Ingresar datos válidos", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(fila.Cells["IdCliente"].Value);

            txtIdCliente.Text = idSeleccionado.ToString();

            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();

            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();

            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();

            txtEmail.Text = fila.Cells["Email"].Value.ToString();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}

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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        ProductoDAO Dao = new ProductoDAO();
        int idSeleccionado = 0;

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                Dao.EliminarProducto(idSeleccionado);

                MessageBox.Show("Producto eliminado", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != string.Empty &&
              txtPrecio.Text != string.Empty &&
              txtStock.Text != string.Empty &&
              Int32.TryParse(txtPrecio.Text, out Int32 y) &&
              Int32.TryParse(txtStock.Text, out Int32 x))
            {

                Producto producto = new Producto();

                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = Convert.ToInt32(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);


                Dao.InsertarProducto(producto);

                MessageBox.Show("Producto guardado", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingresar datos válidos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

            idSeleccionado = 0;
        }
        private void CargarProductos() {
            dgvProductos.DataSource = Dao.ObtenerProductos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);
            txtIdProducto.Text = idSeleccionado.ToString();

            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();

            txtPrecio.Text = fila.Cells["Precio"].Value.ToString();

            txtStock.Text = fila.Cells["Stock"].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != string.Empty &&
              txtPrecio.Text != string.Empty &&
              txtStock.Text != string.Empty &&
              Int32.TryParse(txtPrecio.Text, out Int32 y) &&
              Int32.TryParse(txtStock.Text, out Int32 x) &&
              idSeleccionado > 0)
            {

                Producto producto = new Producto();

                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = Convert.ToInt32(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);

                Dao.ActualizarProducto(producto, idSeleccionado);

                MessageBox.Show("Producto actualizado", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingresar datos válidos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores proveedores = new frmProveedores();
            proveedores.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void importarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportaciones importaciones = new frmImportaciones();
            importaciones.Show();
            this.Hide();
        }

        private void productosConBajoStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBajoStock bajoStock = new frmBajoStock();
            bajoStock.Show();
            this.Hide();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Nombre del Sistema: " + Environment.UserName +
"\n Alumno: Benjamín Fuzzi." +
"\n Comisión: Turno Noche." +
"\n Año: " + Convert.ToString(DateTime.Now.Year) + "."
,"Acerca de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaVenta nuevaVenta = new frmNuevaVenta();
            nuevaVenta.Show();
            this.Hide();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialVentas historialVentas = new frmHistorialVentas();
            historialVentas.Show();
            this.Hide();
        }
    }
}

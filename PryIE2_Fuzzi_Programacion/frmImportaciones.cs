using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PryIE2_Fuzzi_Programacion
{
    public partial class frmImportaciones : Form
    {
        public frmImportaciones()
        {
            InitializeComponent();
            cargarArchivosDeTexto();
        }
        ProductoDAO ProdDao = new ProductoDAO();
        ImportacionDAO ImpDao = new ImportacionDAO();

        public void cargarArchivosDeTexto() {
            string Debug = AppDomain.CurrentDomain.BaseDirectory;
            string[] Archivos = Directory.GetFiles(Debug, "*.txt");

            foreach (string Archivo in Archivos) {
                string name = Path.GetFileName(Archivo);
                cbxArchivo.Items.Add(name);
            }
        }

        public void actualizarTabla() {
            dgvImportaciones.DataSource = ImpDao.ObtenerImportaciones();
        }
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void frmImportaciones_Load(object sender, EventArgs e)
        {

        }

        private void cbxArchivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e) {
            Producto producto = new Producto();
            Int32 cantRegistros = 0;
            if (cbxArchivo.Text != string.Empty) {
                StreamReader leer = new StreamReader(cbxArchivo.Text);
                do {
                    string registro = leer.ReadLine();
                    if (registro != null) {
                        string[] campos = registro.Split(';');
                        producto.Descripcion = campos[0];
                        producto.Precio = Convert.ToInt32(campos[1]);
                        producto.Stock = Convert.ToInt32(campos[2]);

                        ProdDao.InsertarProducto(producto);
                        cantRegistros++;
                    }
                } while (!leer.EndOfStream);

                leer.Close();

                Importacion Importe = new Importacion();


                Importe.Fecha = Convert.ToString(DateTime.Today);
                Importe.CantidadRegistros = cantRegistros;
                Importe.Usuario = Environment.UserName;

                ImpDao.InsertarImportacion(Importe);

                actualizarTabla();

                MessageBox.Show("Archivo importado. Cantidad de registros: " + cantRegistros, "Importar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Seleccione un archivo.", "Importar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }
    }
}

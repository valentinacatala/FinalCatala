using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCatala
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        CsProductos productos;
        DataTable tabla;

        private void Productos_Load(object sender, EventArgs e)
        {
            productos = new CsProductos();
            tabla = productos.GetData();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = txtConsulta.Text;

            dgvProducto.Rows.Clear();

            foreach (DataRow datos in tabla.Rows)
            {
                if (nombre == datos["Nombre"].ToString())
                {
                    dgvProducto.Rows.Add(datos["ID"], datos["Nombre"], datos["FechaRegistro"]);
                }
                else
                {
                    MessageBox.Show("El producto ingresado no existe");
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            DateTime fecha = Convert.ToDateTime(dtpFecha.Text);

            productos.cargar(id, nombre, fecha);
        }
    }
}

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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
        CsVentas ventas;
        DataTable tabla;
        private void Ventas_Load(object sender, EventArgs e)
        {
            ventas = new CsVentas();
            tabla = ventas.GetData();
        }

        private void tbCargar_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int producto = int.Parse(txtProducto.Text);
            DateTime fecha = Convert.ToDateTime(dtpFecha.Text);
            int cant = int.Parse(txtCantidad.Text);

            ventas.cargar(id, fecha, producto, cant);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            dgvVentas.Rows.Clear();

            foreach (DataRow datos in tabla.Rows)
            {
                if (numero <= Convert.ToUInt32(datos["Cantidad"]))
                {
                    dgvVentas.Rows.Add(datos["Id"], datos["FechaVenta"], datos["Producto"], datos["Cantidad"]);
                }
                else
                {
                    MessageBox.Show("EL numero ingresado es incorrecto");
                }
            }
        }
    }
}

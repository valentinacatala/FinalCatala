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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        Productos productos;
        Ventas ventas;
        Consulta consulta;
        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            productos = new Productos();
            productos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventas = new Ventas();
            ventas.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            consulta = new Consulta();
            consulta.Show();
        }
    }
}

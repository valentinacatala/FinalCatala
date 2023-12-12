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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        CsProductos productos;
        CsVentas ventas;
        DataTable tablaprod;
        DataTable tablaven;
        private void Consulta_Load(object sender, EventArgs e)
        {
            productos = new CsProductos();
            ventas = new CsVentas();
            tablaprod = productos.GetData();
            tablaven = ventas.GetData();
        }

        private void btnConsular_Click(object sender, EventArgs e)
        {
            if (rbProductos.Checked)
            {
                dgvConsulta.DataSource = tablaprod;
            }

            if (rbVentas.Checked)
            {
                dgvConsulta.DataSource=tablaven;
            }
        }
    }
}

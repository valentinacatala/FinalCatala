using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace FinalCatala
{
    internal class CsProductos
    {
        OleDbCommand comando;
        OleDbConnection conector;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        public CsProductos()
        {

            conector = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Catala.accdb");
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Productos";

            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["Id"];
            tabla.PrimaryKey = vec;
        }
        public DataTable GetData()
        {
            return tabla;
        }
        public void cargar(int id, string nombre, DateTime fecha)
        {


            try
            {
                foreach (DataRow datos in tabla.Rows)
                {

                    try
                    {
                        if (id != int.Parse(datos["Id"].ToString()) && nombre != datos["Producto"].ToString())
                        {
                            tabla.Rows.Add(id, nombre, fecha);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Numero de id existente");
                        break;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El producto ya esta registrado");

            }

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
        }
    }
}

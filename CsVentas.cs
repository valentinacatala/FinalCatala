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
    internal class CsVentas
    {
        OleDbCommand comando;
        OleDbConnection conector;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        

        public CsVentas()
        {

            conector = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Catala.accdb");
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Ventas";

            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["Id"];
            tabla.PrimaryKey = vec;
        }
        public DataTable GetData()
        {
            return tabla;
        }

        public void cargar(int id, DateTime fecha, int producto, int cant)
        {
            
            
            try
            {
                foreach (DataRow datos in tabla.Rows)
                {
                    
                    try
                    {
                        if (id != int.Parse(datos["Id"].ToString()) && producto != int.Parse(datos["Producto"].ToString()))
                        {
                            tabla.Rows.Add(id, fecha, producto, cant);
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
                MessageBox.Show("Numero de producto exitente");

            }

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
        }
    
    }
}

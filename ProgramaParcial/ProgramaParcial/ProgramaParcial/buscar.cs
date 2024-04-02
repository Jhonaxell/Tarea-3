using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProgramaParcial
{
    public partial class buscar : Form
    {
      
        public buscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombVehiculo = textBox1.Text;

            using (SqlConnection dbConexion = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Logi;Integrated Security=True"))
            {
                try
                {
                    dbConexion.Open();

                    string consultaSQL = "SELECT * FROM autos WHERE nombreVehiculo = @nombreVehiculo";

                    using (SqlCommand comando = new SqlCommand(consultaSQL, dbConexion))
                    {
                        comando.Parameters.AddWithValue("@nombreVehiculo", nombVehiculo);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaResultados = new DataTable();
                        adaptador.Fill(tablaResultados);

                        if (tablaResultados.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = tablaResultados; 
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }



    }
}

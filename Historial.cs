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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCliente = nom.Text;
            int cedulaCliente = Convert.ToInt32(cedula.Text);

            using (SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Logi;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT nombreVehiculo, modelo, cantidad, precio, descripcion FROM DatosCompra WHERE NombreTitular = @NombreTitular AND cedula = @Cedula";

                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@NombreTitular", nombreCliente);
                        selectCommand.Parameters.AddWithValue("@Cedula", cedulaCliente);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron compras registradas para el cliente especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
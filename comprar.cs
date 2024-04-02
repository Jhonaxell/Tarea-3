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
    public partial class comprar : Form
    {

        public comprar()
        {
            InitializeComponent();
        }
        public string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Logi;Integrated Security=True";

        private void comprar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombreVehiculo = NomVehiculo.Text;
            string modeloVehiculo = ModeloVehiculo.Text;

            string NombreTitular = txtnomTitular.Text;
            int cedula = string.IsNullOrEmpty(txtcedula.Text) ? 0 : Convert.ToInt32(txtcedula.Text);
            string gmail = txtgmail.Text;
            int NumTarjeta = string.IsNullOrEmpty(txtNumTarjeta.Text) ? 0 : Convert.ToInt32(txtNumTarjeta.Text);
            DateTime fechaVencimiento = FechaVenci.Value;
            int cvv = string.IsNullOrEmpty(CVV.Text) ? 0 : Convert.ToInt32(CVV.Text);

            if (string.IsNullOrEmpty(NombreTitular) || cedula <= 0 || string.IsNullOrEmpty(gmail) || NumTarjeta <= 0 || cvv <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos de pago antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si existen datos en la tabla autos que coincidan con los datos que colocamos
                string selectAutosQuery = "SELECT * FROM autos WHERE nombreVehiculo = @NombreVehiculo AND modelo = @ModeloVehiculo";

                using (SqlCommand SeleccionAuto = new SqlCommand(selectAutosQuery, connection))
                {
                    SeleccionAuto.Parameters.AddWithValue("@NombreVehiculo", nombreVehiculo);
                    SeleccionAuto.Parameters.AddWithValue("@ModeloVehiculo", modeloVehiculo);

                    using (SqlDataReader reader = SeleccionAuto.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //pequeña ejecucion para verificar si hay autos disponibles 
                            int canti = Convert.ToInt32(reader["cantidad"]);
                            if (canti <= 0)
                            {
                                MessageBox.Show("No hay autos disponibles para la compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            // aqui se leen y se almacenan los valores
                            string nombre = reader["nombreVehiculo"].ToString();
                            string modelo = reader["modelo"].ToString();
                            int cantidad = Convert.ToInt32(reader["cantidad"]);
                            string precio = reader["precio"].ToString();
                            string descripcion = reader["descripcion"].ToString();

                            reader.Close();

                            // Mover los datos de la tabla autos a la tabla DatosCompra
                            string moveQuery = "INSERT INTO DatosCompra (nombreVehiculo, modelo, cantidad, precio, descripcion, NombreTitular, cedula, gmail, NumTarjeta, FechaVencimiento, CVV) VALUES (@NombreVehiculo, @ModeloVehiculo, @Cantidad, @Precio, @Descripcion, @NombreTitular, @Cedula, @Gmail, @NumTarjeta, @FechaVencimiento, @CVV)";

                                using (SqlCommand ComandoMover = new SqlCommand(moveQuery, connection))
                            {
                                ComandoMover.Parameters.AddWithValue("@NombreVehiculo", nombre);
                                ComandoMover.Parameters.AddWithValue("@ModeloVehiculo", modelo);
                                ComandoMover.Parameters.AddWithValue("@Cantidad", cantidad);
                                ComandoMover.Parameters.AddWithValue("@Precio", precio);
                                ComandoMover.Parameters.AddWithValue("@Descripcion", descripcion);
                                ComandoMover.Parameters.AddWithValue("@NombreTitular", NombreTitular);
                                ComandoMover.Parameters.AddWithValue("@Cedula", cedula);
                                ComandoMover.Parameters.AddWithValue("@Gmail", gmail);
                                ComandoMover.Parameters.AddWithValue("@NumTarjeta", NumTarjeta);
                                ComandoMover.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                                ComandoMover.Parameters.AddWithValue("@CVV", cvv);

                                ComandoMover.ExecuteNonQuery();
                            }

                            // Actualizar la cantidad en autos restando 1
                            string AcutalizarAutos = "UPDATE autos SET cantidad = cantidad - 1 WHERE nombreVehiculo = @NombreVehiculo AND modelo = @ModeloVehiculo AND cantidad > 0";

                            using (SqlCommand actualizarautos = new SqlCommand(AcutalizarAutos, connection))
                            {
                                actualizarautos.Parameters.AddWithValue("@NombreVehiculo", nombre);
                                actualizarautos.Parameters.AddWithValue("@ModeloVehiculo", modelo);

                                actualizarautos.ExecuteNonQuery();
                            }

                            MessageBox.Show("Gracias por su compra en TurboTraders.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos coincidentes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CVV_TextChanged(object sender, EventArgs e)
        {
            CVV.MaxLength = 3;
        }
    }
}
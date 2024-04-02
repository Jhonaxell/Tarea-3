using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProgramaParcial
{
    public partial class Dealer : Form
    {
        SqlConnection dbConexion = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Logi;Integrated Security=True");

        public Dealer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnmaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaxi.Visible = false;
            btncomp.Visible = true;
        }

 

        private void btncomp_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaxi.Visible = true;
            btncomp.Visible = false;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int waram, int IParam);

        private void Barra1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Dealer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConexion.Open();
            string nombVehiculo = textBox1.Text;
            string modelo = textBox2.Text;
            int cantidad = Convert.ToInt32(textBox3.Text);
            string precio = textBox4.Text;
            string descrip = textBox5.Text;


            SqlCommand query = new SqlCommand($"insert into autos values ('{nombVehiculo} ', '{modelo}', '{cantidad}', '{precio}', '{descrip}')",dbConexion);
            int r = query.ExecuteNonQuery();

            if (r > 0)
            {
                MessageBox.Show("Datos Guardados exitosamente");

            }
            else
            {
                MessageBox.Show("No se guardaron los dato );");

            }
            dbConexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreVehiculo = textBox1.Text;
            string modeloVehiculo = textBox2.Text;

            using (SqlConnection dbConexion = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Logi;Integrated Security=True"))
            {
                try
                {
                    dbConexion.Open();

                    string consultaSQL = "DELETE FROM autos WHERE nombreVehiculo = @nombreVehiculo AND modelo = @modeloVehiculo";

                    using (SqlCommand comando = new SqlCommand(consultaSQL, dbConexion))
                    {
                        comando.Parameters.AddWithValue("@nombreVehiculo", nombreVehiculo);
                        comando.Parameters.AddWithValue("@modeloVehiculo", modeloVehiculo);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Registros eliminados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Regreso = new Form1();
            Regreso.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombreVehiculo = textBox1.Text;
            string modeloVehiculo = textBox2.Text;
            int nuevaCantidad = Convert.ToInt32(textBox3.Text);
            string nuevoPrecio = textBox4.Text;
            string nuevaDescripcion = textBox5.Text;

            using (SqlConnection dbConexion = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Logi;Integrated Security=True"))
            {
                try
                {
                    dbConexion.Open();

                    string consultaSQL = "UPDATE autos SET cantidad = @nuevaCantidad, precio = @nuevoPrecio, descripcion = @nuevaDescripcion WHERE nombreVehiculo = @nombreVehiculo AND modelo = @modeloVehiculo";

                    using (SqlCommand comando = new SqlCommand(consultaSQL, dbConexion))
                    {
                        comando.Parameters.AddWithValue("@nombreVehiculo", nombreVehiculo);
                        comando.Parameters.AddWithValue("@modeloVehiculo", modeloVehiculo);
                        comando.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                        comando.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
                        comando.Parameters.AddWithValue("@nuevaDescripcion", nuevaDescripcion);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Registros actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

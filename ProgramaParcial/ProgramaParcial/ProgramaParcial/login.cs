using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProgramaParcial
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
 
        }

        private void btnmaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaxi.Visible = false;
            btncomp.Visible = true;
        }

        private void btncomp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaxi.Visible = true;
            btncomp.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int waram, int IParam);
        private void Barra1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage( this.Handle, 0x112, 0xf012, 0);
        }

        private void Barra1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection dbConexion = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Logi;Integrated Security=True");
            string consulta, usuario, pass;
            usuario = textBox1.Text;
            pass = textBox2.Text;

            dbConexion.Open();
            consulta = "SELECT * FROM admins WHERE usuario='" + usuario + "' AND password='" + pass + "'";


            SqlCommand comando = new SqlCommand(consulta, dbConexion);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            if(usuario =="" || pass == "")
            {
                MessageBox.Show("Digite el Usuario y la Contraseña por favor");
                textBox1.Focus();
            }
            if(leer.HasRows == true)
            {
                MessageBox.Show("Bienvenido al sistema");
                Dealer dealer = new Dealer();
                dealer.Show();
                this.Close();
                dbConexion.Close();
            }

            if(usuario == "Jhon1204" || pass == "AdminJhon")
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Regreso = new Form1();
            Regreso.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

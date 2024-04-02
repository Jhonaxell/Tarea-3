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


namespace ProgramaParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login Loggin = new login();
            Loggin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }


        private void btnmin_Click(object sender, EventArgs e)
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int waram, int IParam);

 

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Barra1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Barra1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

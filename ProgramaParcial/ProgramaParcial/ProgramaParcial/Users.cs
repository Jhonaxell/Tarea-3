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
    public partial class Users : Form
    {

        public Users()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Users_Load(object sender, EventArgs e)
        {

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand )
            {
                sidebar.Width -= 5;
                if(sidebar.Width <= 48)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                    if(sidebar.Width >= 190)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new buscar());
            
            userss.Visible = false;
            buscc.Visible = true;
            compra.Visible = false;

        }

        public void AbrirFormHija(object formhija)
        {
            if (contenedor != null)
            {
                if (this.contenedor.Controls.Count > 0)
                {
                    this.contenedor.Controls.RemoveAt(0);
                }

                Form fh = formhija as Form;
                if (fh != null) 
                {
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.contenedor.Controls.Add(fh);
                    this.contenedor.Tag = fh;
                    fh.Show();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new comprar());
            userss.Visible = false;
            buscc.Visible = false;
            compra.Visible = true;
            historia.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userss_Click(object sender, EventArgs e)
        {

        }


        public void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Regreso = new Form1();
            Regreso.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Historial());
            userss.Visible = false;
            buscc.Visible = false;
            historia.Visible = true;
            compra.Visible = false;
            

        }
    }
}


namespace ProgramaParcial
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.btnmaxi = new System.Windows.Forms.PictureBox();
            this.btncomp = new System.Windows.Forms.PictureBox();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.Barra1 = new System.Windows.Forms.Panel();
            this.userss = new System.Windows.Forms.Label();
            this.buscc = new System.Windows.Forms.Label();
            this.historia = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.compra = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.contenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncomp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.Barra1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmaxi
            // 
            this.btnmaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnmaxi.Image")));
            this.btnmaxi.Location = new System.Drawing.Point(1104, 8);
            this.btnmaxi.Name = "btnmaxi";
            this.btnmaxi.Size = new System.Drawing.Size(25, 25);
            this.btnmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaxi.TabIndex = 8;
            this.btnmaxi.TabStop = false;
            this.btnmaxi.Click += new System.EventHandler(this.btnmaxi_Click);
            // 
            // btncomp
            // 
            this.btncomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncomp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncomp.Image = ((System.Drawing.Image)(resources.GetObject("btncomp.Image")));
            this.btncomp.Location = new System.Drawing.Point(1104, 8);
            this.btncomp.Name = "btncomp";
            this.btncomp.Size = new System.Drawing.Size(25, 25);
            this.btncomp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncomp.TabIndex = 6;
            this.btncomp.TabStop = false;
            this.btncomp.Click += new System.EventHandler(this.btncomp_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1066, 8);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(25, 25);
            this.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmin.TabIndex = 7;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1141, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Barra1
            // 
            this.Barra1.BackColor = System.Drawing.Color.Silver;
            this.Barra1.Controls.Add(this.userss);
            this.Barra1.Controls.Add(this.buscc);
            this.Barra1.Controls.Add(this.historia);
            this.Barra1.Controls.Add(this.btnHam);
            this.Barra1.Controls.Add(this.compra);
            this.Barra1.Controls.Add(this.btnmaxi);
            this.Barra1.Controls.Add(this.btncomp);
            this.Barra1.Controls.Add(this.btnmin);
            this.Barra1.Controls.Add(this.btnClose);
            this.Barra1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Barra1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra1.Location = new System.Drawing.Point(0, 0);
            this.Barra1.Name = "Barra1";
            this.Barra1.Size = new System.Drawing.Size(1178, 39);
            this.Barra1.TabIndex = 7;
            this.Barra1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barra1_MouseMove);
            // 
            // userss
            // 
            this.userss.AutoSize = true;
            this.userss.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userss.Location = new System.Drawing.Point(84, 8);
            this.userss.Name = "userss";
            this.userss.Size = new System.Drawing.Size(211, 25);
            this.userss.TabIndex = 9;
            this.userss.Text = "TurboTraders | Usuarios";
            this.userss.Click += new System.EventHandler(this.userss_Click);
            // 
            // buscc
            // 
            this.buscc.AutoSize = true;
            this.buscc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscc.Location = new System.Drawing.Point(80, 8);
            this.buscc.Name = "buscc";
            this.buscc.Size = new System.Drawing.Size(209, 25);
            this.buscc.TabIndex = 10;
            this.buscc.Text = "TurboTraders |    Buscar";
            this.buscc.Click += new System.EventHandler(this.label2_Click);
            // 
            // historia
            // 
            this.historia.AutoSize = true;
            this.historia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historia.Location = new System.Drawing.Point(84, 8);
            this.historia.Name = "historia";
            this.historia.Size = new System.Drawing.Size(208, 25);
            this.historia.TabIndex = 11;
            this.historia.Text = "TurboTraders | Historial";
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.Silver;
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(62, 38);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 8;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // compra
            // 
            this.compra.AutoSize = true;
            this.compra.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.Location = new System.Drawing.Point(80, 8);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(212, 25);
            this.compra.TabIndex = 10;
            this.compra.Text = "TurboTraders | Comprar";
            this.compra.Click += new System.EventHandler(this.label1_Click);
            // 
            // sidebar
            // 
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebar.BackColor = System.Drawing.Color.Navy;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 39);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(241, 648);
            this.sidebar.TabIndex = 8;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 81);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 1);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(225, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "        Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(3, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 81);
            this.panel2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 1);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(225, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "        Compras";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(3, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 81);
            this.panel3.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 1);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(225, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "      Historial de compra";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 364);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 161);
            this.panel4.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 531);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(225, 53);
            this.button4.TabIndex = 9;
            this.button4.Text = "          Salir";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.MenuTransition_Tick);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(241, 39);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(937, 648);
            this.contenedor.TabIndex = 9;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 687);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.Barra1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncomp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.Barra1.ResumeLayout(false);
            this.Barra1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnmaxi;
        private System.Windows.Forms.PictureBox btncomp;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel Barra1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label userss;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label buscc;
        private System.Windows.Forms.Label compra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label historia;
        private System.Windows.Forms.Button button3;
    }
}
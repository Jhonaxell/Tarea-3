
namespace ProgramaParcial
{
    partial class comprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comprar));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ModeloVehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NomVehiculo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tarjeta = new System.Windows.Forms.GroupBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaVenci = new System.Windows.Forms.DateTimePicker();
            this.CVV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.txtnomTitular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Tarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(955, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bienvenido a compras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Nombre vehiculo ";
            // 
            // ModeloVehiculo
            // 
            this.ModeloVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloVehiculo.Location = new System.Drawing.Point(314, 259);
            this.ModeloVehiculo.Name = "ModeloVehiculo";
            this.ModeloVehiculo.Size = new System.Drawing.Size(219, 30);
            this.ModeloVehiculo.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Modelo";
            // 
            // NomVehiculo
            // 
            this.NomVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomVehiculo.Location = new System.Drawing.Point(314, 209);
            this.NomVehiculo.Name = "NomVehiculo";
            this.NomVehiculo.Size = new System.Drawing.Size(219, 30);
            this.NomVehiculo.TabIndex = 64;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 65;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tarjeta
            // 
            this.Tarjeta.Controls.Add(this.txtcedula);
            this.Tarjeta.Controls.Add(this.label3);
            this.Tarjeta.Controls.Add(this.txtgmail);
            this.Tarjeta.Controls.Add(this.label2);
            this.Tarjeta.Controls.Add(this.FechaVenci);
            this.Tarjeta.Controls.Add(this.CVV);
            this.Tarjeta.Controls.Add(this.label9);
            this.Tarjeta.Controls.Add(this.label8);
            this.Tarjeta.Controls.Add(this.txtNumTarjeta);
            this.Tarjeta.Controls.Add(this.txtnomTitular);
            this.Tarjeta.Controls.Add(this.label6);
            this.Tarjeta.Controls.Add(this.label7);
            this.Tarjeta.Location = new System.Drawing.Point(143, 319);
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.Size = new System.Drawing.Size(645, 322);
            this.Tarjeta.TabIndex = 68;
            this.Tarjeta.TabStop = false;
            this.Tarjeta.Text = "Datos Tarjeta";
            // 
            // txtcedula
            // 
            this.txtcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula.Location = new System.Drawing.Point(222, 97);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(212, 30);
            this.txtcedula.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Numero de tarjeta";
            // 
            // txtgmail
            // 
            this.txtgmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgmail.Location = new System.Drawing.Point(222, 143);
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(212, 30);
            this.txtgmail.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Gmail";
            // 
            // FechaVenci
            // 
            this.FechaVenci.Location = new System.Drawing.Point(250, 268);
            this.FechaVenci.Name = "FechaVenci";
            this.FechaVenci.Size = new System.Drawing.Size(184, 22);
            this.FechaVenci.TabIndex = 51;
            // 
            // CVV
            // 
            this.CVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVV.Location = new System.Drawing.Point(482, 230);
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(105, 30);
            this.CVV.TabIndex = 60;
            this.CVV.TextChanged += new System.EventHandler(this.CVV_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(504, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "CVV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fecha de vencimiento";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTarjeta.Location = new System.Drawing.Point(222, 192);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(212, 30);
            this.txtNumTarjeta.TabIndex = 56;
            // 
            // txtnomTitular
            // 
            this.txtnomTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomTitular.Location = new System.Drawing.Point(222, 49);
            this.txtnomTitular.Name = "txtnomTitular";
            this.txtnomTitular.Size = new System.Drawing.Size(327, 30);
            this.txtnomTitular.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Cedula";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nombre Titular";
            // 
            // comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 795);
            this.Controls.Add(this.Tarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ModeloVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomVehiculo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "comprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "comprar";
            this.Load += new System.EventHandler(this.comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Tarjeta.ResumeLayout(false);
            this.Tarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModeloVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomVehiculo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Tarjeta;
        private System.Windows.Forms.DateTimePicker FechaVenci;
        private System.Windows.Forms.TextBox CVV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.TextBox txtnomTitular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.Label label2;
    }
}
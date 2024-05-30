namespace Vista
{
    partial class VsPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActividad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTituloGym = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnMembresia = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActividad
            // 
            this.btnActividad.BackColor = System.Drawing.Color.Gainsboro;
            this.btnActividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividad.Location = new System.Drawing.Point(0, 333);
            this.btnActividad.Name = "btnActividad";
            this.btnActividad.Size = new System.Drawing.Size(122, 23);
            this.btnActividad.TabIndex = 1;
            this.btnActividad.Text = "Actividad";
            this.btnActividad.UseVisualStyleBackColor = false;
            this.btnActividad.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Vista.Properties.Resources.fondoprueba;
            this.pictureBox1.Location = new System.Drawing.Point(146, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 749);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTituloGym
            // 
            this.labelTituloGym.AutoSize = true;
            this.labelTituloGym.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloGym.Location = new System.Drawing.Point(0, 0);
            this.labelTituloGym.Name = "labelTituloGym";
            this.labelTituloGym.Size = new System.Drawing.Size(0, 55);
            this.labelTituloGym.TabIndex = 3;
            this.labelTituloGym.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(9, 210);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 43);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar miembro";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMembresia
            // 
            this.btnMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembresia.Location = new System.Drawing.Point(0, 282);
            this.btnMembresia.Name = "btnMembresia";
            this.btnMembresia.Size = new System.Drawing.Size(122, 23);
            this.btnMembresia.TabIndex = 5;
            this.btnMembresia.Text = "Membresia";
            this.btnMembresia.UseVisualStyleBackColor = true;
            this.btnMembresia.Click += new System.EventHandler(this.btnMembresia_Click);
            // 
            // btnPago
            // 
            this.btnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.Location = new System.Drawing.Point(0, 386);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(122, 23);
            this.btnPago.TabIndex = 7;
            this.btnPago.Text = "Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMembresia);
            this.panel1.Controls.Add(this.btnPago);
            this.panel1.Controls.Add(this.btnActividad);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(709, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 749);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 749);
            this.panel2.TabIndex = 9;
            // 
            // VsPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(852, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTituloGym);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VsPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.VsPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActividad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTituloGym;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnMembresia;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}


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
            this.labelTituloGym = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnMembresia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGM = new System.Windows.Forms.Button();
            this.buttonGestionActividad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerRegistroFact = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloGym
            // 
            this.labelTituloGym.AutoSize = true;
            this.labelTituloGym.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloGym.Location = new System.Drawing.Point(0, 0);
            this.labelTituloGym.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloGym.Name = "labelTituloGym";
            this.labelTituloGym.Size = new System.Drawing.Size(0, 69);
            this.labelTituloGym.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(39, 61);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(163, 63);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar nuevo cliente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMembresia
            // 
            this.btnMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembresia.Location = new System.Drawing.Point(39, 193);
            this.btnMembresia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMembresia.Name = "btnMembresia";
            this.btnMembresia.Size = new System.Drawing.Size(163, 65);
            this.btnMembresia.TabIndex = 5;
            this.btnMembresia.Text = "Gestionar cliente";
            this.btnMembresia.UseVisualStyleBackColor = true;
            this.btnMembresia.Click += new System.EventHandler(this.btnMembresia_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVerRegistroFact);
            this.panel1.Controls.Add(this.btnGM);
            this.panel1.Controls.Add(this.buttonGestionActividad);
            this.panel1.Controls.Add(this.btnMembresia);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(891, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 602);
            this.panel1.TabIndex = 8;
            // 
            // btnGM
            // 
            this.btnGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGM.Location = new System.Drawing.Point(39, 308);
            this.btnGM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGM.Name = "btnGM";
            this.btnGM.Size = new System.Drawing.Size(163, 65);
            this.btnGM.TabIndex = 8;
            this.btnGM.Text = "Gestion de Membresia";
            this.btnGM.UseVisualStyleBackColor = true;
            this.btnGM.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonGestionActividad
            // 
            this.buttonGestionActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionActividad.Location = new System.Drawing.Point(39, 410);
            this.buttonGestionActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGestionActividad.Name = "buttonGestionActividad";
            this.buttonGestionActividad.Size = new System.Drawing.Size(163, 65);
            this.buttonGestionActividad.TabIndex = 7;
            this.buttonGestionActividad.Text = "Gestion de Actividad";
            this.buttonGestionActividad.UseVisualStyleBackColor = true;
            this.buttonGestionActividad.Click += new System.EventHandler(this.buttonGestionActividad_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 602);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Vista.Properties.Resources.Img_vtnPrincipal;
            this.pictureBox1.Location = new System.Drawing.Point(268, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnVerRegistroFact
            // 
            this.btnVerRegistroFact.Location = new System.Drawing.Point(39, 516);
            this.btnVerRegistroFact.Name = "btnVerRegistroFact";
            this.btnVerRegistroFact.Size = new System.Drawing.Size(163, 65);
            this.btnVerRegistroFact.TabIndex = 64;
            this.btnVerRegistroFact.Text = "VER REGISTRO DE FACTURAS";
            this.btnVerRegistroFact.UseVisualStyleBackColor = true;
            this.btnVerRegistroFact.Click += new System.EventHandler(this.btnVerRegistroFact_Click);
            // 
            // VsPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1136, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTituloGym);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VsPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.VsPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTituloGym;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnMembresia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGestionActividad;
        private System.Windows.Forms.Button btnGM;
        private System.Windows.Forms.Button btnVerRegistroFact;
    }
}


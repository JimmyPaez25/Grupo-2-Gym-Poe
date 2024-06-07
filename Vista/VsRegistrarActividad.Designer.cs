namespace Vista
{
    partial class VsRegistrarActividad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR COMBO ACTIVIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Combo de Actividades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion de Actividades:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora Inicio:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(331, 91);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(288, 22);
            this.textNombre.TabIndex = 6;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(331, 144);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescripcion.Size = new System.Drawing.Size(288, 136);
            this.textDescripcion.TabIndex = 7;
            this.textDescripcion.TextChanged += new System.EventHandler(this.textDescripcion_TextChanged);
            this.textDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDescripcion_KeyPress);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(331, 404);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(100, 28);
            this.buttonRegistrar.TabIndex = 11;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(520, 404);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(175, 346);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaFin.TabIndex = 0;
            this.dtpFechaFin.Value = new System.DateTime(2024, 5, 27, 23, 37, 25, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(175, 305);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaInicio.TabIndex = 13;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 5, 27, 23, 37, 25, 0);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(552, 305);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(67, 22);
            this.dtpHoraInicio.TabIndex = 14;
            this.dtpHoraInicio.Value = new System.DateTime(2024, 5, 27, 1, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hora Fin:";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(552, 346);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(67, 22);
            this.dtpHoraFin.TabIndex = 16;
            this.dtpHoraFin.Value = new System.DateTime(2024, 5, 27, 23, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.Img_Gym2;
            this.pictureBox1.Location = new System.Drawing.Point(655, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // VsRegistrarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VsRegistrarActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
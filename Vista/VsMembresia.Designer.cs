namespace Vista
{
    partial class VsMembresia
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.lblNombreMT = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelFI = new System.Windows.Forms.Label();
            this.labelFF = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelDP = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtBoxM = new System.Windows.Forms.TextBox();
            this.dateTPFI = new System.Windows.Forms.DateTimePicker();
            this.dateTPFF = new System.Windows.Forms.DateTimePicker();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.txtBoxDP = new System.Windows.Forms.TextBox();
            this.txtBoxD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCedulaMT = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblCedulaM = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblApllidoMT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(287, 21);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(211, 42);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Membresía";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombreMT
            // 
            this.lblNombreMT.AutoSize = true;
            this.lblNombreMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMT.Location = new System.Drawing.Point(142, 109);
            this.lblNombreMT.Name = "lblNombreMT";
            this.lblNombreMT.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMT.TabIndex = 1;
            this.lblNombreMT.Text = "Nombre:";
            this.lblNombreMT.Click += new System.EventHandler(this.labelC_Click);
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.Location = new System.Drawing.Point(143, 166);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(61, 13);
            this.labelM.TabIndex = 2;
            this.labelM.Text = "Membresia:";
            // 
            // labelFI
            // 
            this.labelFI.AutoSize = true;
            this.labelFI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFI.Location = new System.Drawing.Point(142, 192);
            this.labelFI.Name = "labelFI";
            this.labelFI.Size = new System.Drawing.Size(67, 13);
            this.labelFI.TabIndex = 3;
            this.labelFI.Text = "Fecha inicio:";
            // 
            // labelFF
            // 
            this.labelFF.AutoSize = true;
            this.labelFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFF.Location = new System.Drawing.Point(142, 218);
            this.labelFF.Name = "labelFF";
            this.labelFF.Size = new System.Drawing.Size(54, 13);
            this.labelFF.TabIndex = 4;
            this.labelFF.Text = "Fecha fin:";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.Location = new System.Drawing.Point(142, 245);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(60, 13);
            this.labelP.TabIndex = 5;
            this.labelP.Text = "Promoción:";
            // 
            // labelDP
            // 
            this.labelDP.AutoSize = true;
            this.labelDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDP.Location = new System.Drawing.Point(142, 267);
            this.labelDP.Name = "labelDP";
            this.labelDP.Size = new System.Drawing.Size(101, 13);
            this.labelDP.TabIndex = 6;
            this.labelDP.Text = "Detalles Promoción:";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(142, 335);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(62, 13);
            this.labelD.TabIndex = 7;
            this.labelD.Text = "Descuento:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(294, 364);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar ";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(418, 364);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 9;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtBoxM
            // 
            this.txtBoxM.Location = new System.Drawing.Point(293, 159);
            this.txtBoxM.Name = "txtBoxM";
            this.txtBoxM.Size = new System.Drawing.Size(199, 20);
            this.txtBoxM.TabIndex = 11;
            this.txtBoxM.TextChanged += new System.EventHandler(this.txtBoxM_TextChanged);
            this.txtBoxM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxM_KeyPress);
            // 
            // dateTPFI
            // 
            this.dateTPFI.Location = new System.Drawing.Point(293, 185);
            this.dateTPFI.Name = "dateTPFI";
            this.dateTPFI.Size = new System.Drawing.Size(200, 20);
            this.dateTPFI.TabIndex = 12;
            // 
            // dateTPFF
            // 
            this.dateTPFF.Location = new System.Drawing.Point(293, 211);
            this.dateTPFF.Name = "dateTPFF";
            this.dateTPFF.Size = new System.Drawing.Size(200, 20);
            this.dateTPFF.TabIndex = 13;
            // 
            // comboBoxP
            // 
            this.comboBoxP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboBoxP.Location = new System.Drawing.Point(294, 237);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(47, 21);
            this.comboBoxP.TabIndex = 14;
            this.comboBoxP.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBoxDP
            // 
            this.txtBoxDP.Location = new System.Drawing.Point(293, 264);
            this.txtBoxDP.Multiline = true;
            this.txtBoxDP.Name = "txtBoxDP";
            this.txtBoxDP.Size = new System.Drawing.Size(200, 58);
            this.txtBoxDP.TabIndex = 15;
            this.txtBoxDP.TextChanged += new System.EventHandler(this.txtBoxDP_TextChanged);
            this.txtBoxDP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDP_KeyPress);
            // 
            // txtBoxD
            // 
            this.txtBoxD.Location = new System.Drawing.Point(293, 328);
            this.txtBoxD.Name = "txtBoxD";
            this.txtBoxD.Size = new System.Drawing.Size(199, 20);
            this.txtBoxD.TabIndex = 16;
            this.txtBoxD.TextChanged += new System.EventHandler(this.txtBoxD_TextChanged);
            this.txtBoxD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxD_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.Img_Gym2;
            this.pictureBox1.Location = new System.Drawing.Point(555, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblCedulaMT
            // 
            this.lblCedulaMT.AutoSize = true;
            this.lblCedulaMT.Location = new System.Drawing.Point(142, 86);
            this.lblCedulaMT.Name = "lblCedulaMT";
            this.lblCedulaMT.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaMT.TabIndex = 18;
            this.lblCedulaMT.Text = "Cédula:";
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(290, 109);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(31, 13);
            this.lblNombreM.TabIndex = 19;
            this.lblNombreM.Text = "____";
            // 
            // lblCedulaM
            // 
            this.lblCedulaM.AutoSize = true;
            this.lblCedulaM.Location = new System.Drawing.Point(290, 86);
            this.lblCedulaM.Name = "lblCedulaM";
            this.lblCedulaM.Size = new System.Drawing.Size(31, 13);
            this.lblCedulaM.TabIndex = 20;
            this.lblCedulaM.Text = "____";
            this.lblCedulaM.Click += new System.EventHandler(this.lblCedulaM_Click);
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(290, 131);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(31, 13);
            this.lblApellidoM.TabIndex = 21;
            this.lblApellidoM.Text = "____";
            // 
            // lblApllidoMT
            // 
            this.lblApllidoMT.AutoSize = true;
            this.lblApllidoMT.Location = new System.Drawing.Point(142, 131);
            this.lblApllidoMT.Name = "lblApllidoMT";
            this.lblApllidoMT.Size = new System.Drawing.Size(47, 13);
            this.lblApllidoMT.TabIndex = 22;
            this.lblApllidoMT.Text = "Apellido:";
            // 
            // VsMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.lblApllidoMT);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblCedulaM);
            this.Controls.Add(this.lblNombreM);
            this.Controls.Add(this.lblCedulaMT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxD);
            this.Controls.Add(this.txtBoxDP);
            this.Controls.Add(this.comboBoxP);
            this.Controls.Add(this.dateTPFF);
            this.Controls.Add(this.dateTPFI);
            this.Controls.Add(this.txtBoxM);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelDP);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelFF);
            this.Controls.Add(this.labelFI);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.lblNombreMT);
            this.Controls.Add(this.labelTitulo);
            this.Name = "VsMembresia";
            this.Text = "Modulo Membresia";
            this.Load += new System.EventHandler(this.VsMembresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lblNombreMT;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelFI;
        private System.Windows.Forms.Label labelFF;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelDP;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.TextBox txtBoxM;
        private System.Windows.Forms.DateTimePicker dateTPFI;
        private System.Windows.Forms.DateTimePicker dateTPFF;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.TextBox txtBoxDP;
        private System.Windows.Forms.TextBox txtBoxD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCedulaMT;
        public System.Windows.Forms.Label lblNombreM;
        public System.Windows.Forms.Label lblCedulaM;
        private System.Windows.Forms.Label lblApllidoMT;
        public System.Windows.Forms.Label lblApellidoM;
    }
}
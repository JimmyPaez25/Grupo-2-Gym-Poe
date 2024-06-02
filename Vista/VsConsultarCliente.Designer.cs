namespace Vista
{
    partial class VsConsultarCliente
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
            this.lblConsultarCliente = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnAsignarMembresía = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarCliente
            // 
            this.lblConsultarCliente.AutoSize = true;
            this.lblConsultarCliente.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblConsultarCliente.Location = new System.Drawing.Point(352, 29);
            this.lblConsultarCliente.Name = "lblConsultarCliente";
            this.lblConsultarCliente.Size = new System.Drawing.Size(249, 36);
            this.lblConsultarCliente.TabIndex = 1;
            this.lblConsultarCliente.Text = "Consultar Cliente";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCedula,
            this.clmNombre,
            this.clmApellido,
            this.clmTelefono,
            this.clmDireccion,
            this.clmEstudiante});
            this.dgvClientes.Location = new System.Drawing.Point(174, 178);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(643, 279);
            this.dgvClientes.TabIndex = 2;
            // 
            // clmCedula
            // 
            this.clmCedula.HeaderText = "CEDULA";
            this.clmCedula.Name = "clmCedula";
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "NOMBRE";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "APELLIDO";
            this.clmApellido.Name = "clmApellido";
            // 
            // clmTelefono
            // 
            this.clmTelefono.HeaderText = "TELEFONO";
            this.clmTelefono.Name = "clmTelefono";
            // 
            // clmDireccion
            // 
            this.clmDireccion.HeaderText = "DIRECCION";
            this.clmDireccion.Name = "clmDireccion";
            // 
            // clmEstudiante
            // 
            this.clmEstudiante.HeaderText = "ESTUDIANTE";
            this.clmEstudiante.Name = "clmEstudiante";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.lblCedula.Location = new System.Drawing.Point(91, 98);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(63, 20);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Cedula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(191, 98);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(197, 20);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.btnBuscar.Location = new System.Drawing.Point(417, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 41);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.btnActualizar.Location = new System.Drawing.Point(662, 91);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 41);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.btnDarBaja.Location = new System.Drawing.Point(755, 89);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(101, 43);
            this.btnDarBaja.TabIndex = 7;
            this.btnDarBaja.Text = "Dar de Baja";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            // 
            // btnAsignarMembresía
            // 
            this.btnAsignarMembresía.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.btnAsignarMembresía.Location = new System.Drawing.Point(581, 90);
            this.btnAsignarMembresía.Name = "btnAsignarMembresía";
            this.btnAsignarMembresía.Size = new System.Drawing.Size(75, 41);
            this.btnAsignarMembresía.TabIndex = 8;
            this.btnAsignarMembresía.Text = "Asignar Membresía";
            this.btnAsignarMembresía.UseVisualStyleBackColor = true;
            // 
            // VsConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 501);
            this.Controls.Add(this.btnAsignarMembresía);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblConsultarCliente);
            this.Name = "VsConsultarCliente";
            this.Text = "Consultar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConsultarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnAsignarMembresía;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstudiante;
    }
}
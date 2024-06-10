namespace Vista
{
    partial class VsConsultarActividad
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.radioButtonDescripcion = new System.Windows.Forms.RadioButton();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dgvActividad = new System.Windows.Forms.DataGridView();
            this.ClmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTAR ACTIVIDAD";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(48, 391);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(48, 107);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(227, 22);
            this.textBuscar.TabIndex = 14;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            this.textBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBuscar_KeyPress);
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Checked = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(48, 79);
            this.radioButtonNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(77, 20);
            this.radioButtonNombre.TabIndex = 15;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonDescripcion
            // 
            this.radioButtonDescripcion.AutoSize = true;
            this.radioButtonDescripcion.Location = new System.Drawing.Point(179, 79);
            this.radioButtonDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonDescripcion.Name = "radioButtonDescripcion";
            this.radioButtonDescripcion.Size = new System.Drawing.Size(100, 20);
            this.radioButtonDescripcion.TabIndex = 16;
            this.radioButtonDescripcion.TabStop = true;
            this.radioButtonDescripcion.Text = "Descripcion";
            this.radioButtonDescripcion.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(299, 103);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 28);
            this.buttonBuscar.TabIndex = 17;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dgvActividad
            // 
            this.dgvActividad.AllowUserToAddRows = false;
            this.dgvActividad.AllowUserToDeleteRows = false;
            this.dgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNumero,
            this.ClmEstado,
            this.ClmNombre,
            this.ClmDescripcion,
            this.ClmFechaInicio,
            this.ClmFechaFin,
            this.ClmHoraInicio,
            this.ClmHoraFin});
            this.dgvActividad.Location = new System.Drawing.Point(48, 164);
            this.dgvActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvActividad.Name = "dgvActividad";
            this.dgvActividad.ReadOnly = true;
            this.dgvActividad.RowHeadersWidth = 51;
            this.dgvActividad.Size = new System.Drawing.Size(992, 199);
            this.dgvActividad.TabIndex = 18;
            this.dgvActividad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActividad_CellContentClick);
            // 
            // ClmNumero
            // 
            this.ClmNumero.HeaderText = "NRO";
            this.ClmNumero.MinimumWidth = 6;
            this.ClmNumero.Name = "ClmNumero";
            this.ClmNumero.ReadOnly = true;
            this.ClmNumero.Width = 125;
            // 
            // ClmEstado
            // 
            this.ClmEstado.HeaderText = "ESTADO";
            this.ClmEstado.MinimumWidth = 6;
            this.ClmEstado.Name = "ClmEstado";
            this.ClmEstado.ReadOnly = true;
            this.ClmEstado.Visible = false;
            this.ClmEstado.Width = 125;
            // 
            // ClmNombre
            // 
            this.ClmNombre.HeaderText = "NOMBRE";
            this.ClmNombre.MinimumWidth = 6;
            this.ClmNombre.Name = "ClmNombre";
            this.ClmNombre.ReadOnly = true;
            this.ClmNombre.Width = 125;
            // 
            // ClmDescripcion
            // 
            this.ClmDescripcion.HeaderText = "DESCRIPCION";
            this.ClmDescripcion.MinimumWidth = 6;
            this.ClmDescripcion.Name = "ClmDescripcion";
            this.ClmDescripcion.ReadOnly = true;
            this.ClmDescripcion.Width = 125;
            // 
            // ClmFechaInicio
            // 
            this.ClmFechaInicio.HeaderText = "FECHA INICIO";
            this.ClmFechaInicio.MinimumWidth = 6;
            this.ClmFechaInicio.Name = "ClmFechaInicio";
            this.ClmFechaInicio.ReadOnly = true;
            this.ClmFechaInicio.Width = 125;
            // 
            // ClmFechaFin
            // 
            this.ClmFechaFin.HeaderText = "FECHA FIN";
            this.ClmFechaFin.MinimumWidth = 6;
            this.ClmFechaFin.Name = "ClmFechaFin";
            this.ClmFechaFin.ReadOnly = true;
            this.ClmFechaFin.Width = 125;
            // 
            // ClmHoraInicio
            // 
            this.ClmHoraInicio.HeaderText = "HORA INICIO";
            this.ClmHoraInicio.MinimumWidth = 6;
            this.ClmHoraInicio.Name = "ClmHoraInicio";
            this.ClmHoraInicio.ReadOnly = true;
            this.ClmHoraInicio.Width = 125;
            // 
            // ClmHoraFin
            // 
            this.ClmHoraFin.HeaderText = "HORA FIN";
            this.ClmHoraFin.MinimumWidth = 6;
            this.ClmHoraFin.Name = "ClmHoraFin";
            this.ClmHoraFin.ReadOnly = true;
            this.ClmHoraFin.Width = 125;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(812, 107);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 28);
            this.buttonEditar.TabIndex = 19;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(940, 107);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 28);
            this.buttonEliminar.TabIndex = 20;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(176, 391);
            this.buttonSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(100, 28);
            this.buttonSeleccionar.TabIndex = 21;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Visible = false;
            // 
            // VsConsultarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 460);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dgvActividad);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.radioButtonDescripcion);
            this.Controls.Add(this.radioButtonNombre);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VsConsultarActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.RadioButton radioButtonDescripcion;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dgvActividad;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmHoraFin;
    }
}
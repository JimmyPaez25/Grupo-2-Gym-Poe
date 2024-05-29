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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ClmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTAR ACTIVIDAD";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 14;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(134, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Descripcion";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmId,
            this.ClmEstado,
            this.ClmNombre,
            this.ClmDescripcion,
            this.ClmFechaInicio,
            this.ClmFechaFin,
            this.ClmHoraInicio,
            this.ClmHoraFin});
            this.dataGridView1.Location = new System.Drawing.Point(36, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 162);
            this.dataGridView1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(605, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ClmId
            // 
            this.ClmId.HeaderText = "ID";
            this.ClmId.Name = "ClmId";
            this.ClmId.Visible = false;
            // 
            // ClmEstado
            // 
            this.ClmEstado.HeaderText = "ESTADO";
            this.ClmEstado.Name = "ClmEstado";
            this.ClmEstado.Visible = false;
            // 
            // ClmNombre
            // 
            this.ClmNombre.HeaderText = "NOMBRE";
            this.ClmNombre.Name = "ClmNombre";
            // 
            // ClmDescripcion
            // 
            this.ClmDescripcion.HeaderText = "DESCRIPCION";
            this.ClmDescripcion.Name = "ClmDescripcion";
            // 
            // ClmFechaInicio
            // 
            this.ClmFechaInicio.HeaderText = "FECHA INICIO";
            this.ClmFechaInicio.Name = "ClmFechaInicio";
            // 
            // ClmFechaFin
            // 
            this.ClmFechaFin.HeaderText = "FECHA FIN";
            this.ClmFechaFin.Name = "ClmFechaFin";
            // 
            // ClmHoraInicio
            // 
            this.ClmHoraInicio.HeaderText = "HORA INICIO";
            this.ClmHoraInicio.Name = "ClmHoraInicio";
            // 
            // ClmHoraFin
            // 
            this.ClmHoraFin.HeaderText = "HORA FIN";
            this.ClmHoraFin.Name = "ClmHoraFin";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Seleccionar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // VsConsultarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 374);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "VsConsultarActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmHoraFin;
        private System.Windows.Forms.Button button5;
    }
}
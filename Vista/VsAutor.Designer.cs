namespace Vista
{
    partial class VsAutor
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
            this.labelNombreSistema = new System.Windows.Forms.Label();
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.ClmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombreAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFechaCreacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Sistema:";
            // 
            // labelNombreSistema
            // 
            this.labelNombreSistema.AutoSize = true;
            this.labelNombreSistema.Location = new System.Drawing.Point(165, 30);
            this.labelNombreSistema.Name = "labelNombreSistema";
            this.labelNombreSistema.Size = new System.Drawing.Size(10, 13);
            this.labelNombreSistema.TabIndex = 1;
            this.labelNombreSistema.Text = ".";
            // 
            // dgvAutor
            // 
            this.dgvAutor.AllowUserToAddRows = false;
            this.dgvAutor.AllowUserToDeleteRows = false;
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNumero,
            this.ClmNombreAutor,
            this.ClmEmail,
            this.ClmTelefono,
            this.ClmFoto});
            this.dgvAutor.Location = new System.Drawing.Point(58, 111);
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.ReadOnly = true;
            this.dgvAutor.Size = new System.Drawing.Size(759, 428);
            this.dgvAutor.TabIndex = 2;
            // 
            // ClmNumero
            // 
            this.ClmNumero.HeaderText = "NUM";
            this.ClmNumero.Name = "ClmNumero";
            this.ClmNumero.ReadOnly = true;
            // 
            // ClmNombreAutor
            // 
            this.ClmNombreAutor.HeaderText = "AUTOR";
            this.ClmNombreAutor.Name = "ClmNombreAutor";
            this.ClmNombreAutor.ReadOnly = true;
            // 
            // ClmEmail
            // 
            this.ClmEmail.HeaderText = "EMAIL";
            this.ClmEmail.Name = "ClmEmail";
            this.ClmEmail.ReadOnly = true;
            // 
            // ClmTelefono
            // 
            this.ClmTelefono.HeaderText = "TELEFONO";
            this.ClmTelefono.Name = "ClmTelefono";
            this.ClmTelefono.ReadOnly = true;
            // 
            // ClmFoto
            // 
            this.ClmFoto.HeaderText = "FOTO";
            this.ClmFoto.Name = "ClmFoto";
            this.ClmFoto.ReadOnly = true;
            this.ClmFoto.Width = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Creacion:";
            // 
            // labelFechaCreacion
            // 
            this.labelFechaCreacion.AutoSize = true;
            this.labelFechaCreacion.Location = new System.Drawing.Point(165, 62);
            this.labelFechaCreacion.Name = "labelFechaCreacion";
            this.labelFechaCreacion.Size = new System.Drawing.Size(10, 13);
            this.labelFechaCreacion.TabIndex = 4;
            this.labelFechaCreacion.Text = ".";
            // 
            // VsAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 597);
            this.Controls.Add(this.labelFechaCreacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAutor);
            this.Controls.Add(this.labelNombreSistema);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "VsAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreSistema;
        private System.Windows.Forms.DataGridView dgvAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombreAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTelefono;
        private System.Windows.Forms.DataGridViewImageColumn ClmFoto;
    }
}
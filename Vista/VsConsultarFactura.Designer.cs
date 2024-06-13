namespace Vista
{
    partial class VsConsultarFactura
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
            this.dgvRegistroFact = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.FacturaRegistroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRegistroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoRegistroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaRegistroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimRegistroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoRegistroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionRegistroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroFact)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroFact
            // 
            this.dgvRegistroFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacturaRegistroFact,
            this.NombreRegistroFact,
            this.ApellidoRegistroFact,
            this.CedulaRegistroFact,
            this.FechaNacimRegistroFact,
            this.TelefonoRegistroFact,
            this.DireccionRegistroFact,
            this.A,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgvRegistroFact.Location = new System.Drawing.Point(12, 59);
            this.dgvRegistroFact.Name = "dgvRegistroFact";
            this.dgvRegistroFact.RowHeadersWidth = 51;
            this.dgvRegistroFact.RowTemplate.Height = 24;
            this.dgvRegistroFact.Size = new System.Drawing.Size(1732, 246);
            this.dgvRegistroFact.TabIndex = 0;
            this.dgvRegistroFact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroFact_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motivo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Borrar Factura Seleccionada";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FacturaRegistroFact
            // 
            this.FacturaRegistroFact.HeaderText = "Factura";
            this.FacturaRegistroFact.MinimumWidth = 6;
            this.FacturaRegistroFact.Name = "FacturaRegistroFact";
            this.FacturaRegistroFact.Width = 125;
            // 
            // NombreRegistroFact
            // 
            this.NombreRegistroFact.HeaderText = "Nombre";
            this.NombreRegistroFact.MinimumWidth = 6;
            this.NombreRegistroFact.Name = "NombreRegistroFact";
            this.NombreRegistroFact.Width = 125;
            // 
            // ApellidoRegistroFact
            // 
            this.ApellidoRegistroFact.HeaderText = "Apellido";
            this.ApellidoRegistroFact.MinimumWidth = 6;
            this.ApellidoRegistroFact.Name = "ApellidoRegistroFact";
            this.ApellidoRegistroFact.Width = 125;
            // 
            // CedulaRegistroFact
            // 
            this.CedulaRegistroFact.HeaderText = "Cedula";
            this.CedulaRegistroFact.MinimumWidth = 6;
            this.CedulaRegistroFact.Name = "CedulaRegistroFact";
            this.CedulaRegistroFact.Width = 125;
            // 
            // FechaNacimRegistroFact
            // 
            this.FechaNacimRegistroFact.HeaderText = "Fecha Nacimiento";
            this.FechaNacimRegistroFact.MinimumWidth = 6;
            this.FechaNacimRegistroFact.Name = "FechaNacimRegistroFact";
            this.FechaNacimRegistroFact.Width = 125;
            // 
            // TelefonoRegistroFact
            // 
            this.TelefonoRegistroFact.HeaderText = "Teléfono";
            this.TelefonoRegistroFact.MinimumWidth = 6;
            this.TelefonoRegistroFact.Name = "TelefonoRegistroFact";
            this.TelefonoRegistroFact.Width = 125;
            // 
            // DireccionRegistroFact
            // 
            this.DireccionRegistroFact.HeaderText = "Direccion";
            this.DireccionRegistroFact.MinimumWidth = 6;
            this.DireccionRegistroFact.Name = "DireccionRegistroFact";
            this.DireccionRegistroFact.Width = 125;
            // 
            // A
            // 
            this.A.HeaderText = "Actividades";
            this.A.MinimumWidth = 6;
            this.A.Name = "A";
            this.A.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Descuento";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IVA";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // VsConsultarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 597);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRegistroFact);
            this.Name = "VsConsultarFactura";
            this.Text = "VsConsultarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroFact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvRegistroFact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridViewTextBoxColumn FacturaRegistroFact;
        public System.Windows.Forms.DataGridViewTextBoxColumn NombreRegistroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoRegistroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaRegistroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimRegistroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoRegistroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionRegistroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
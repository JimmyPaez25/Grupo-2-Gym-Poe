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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dgvRegistroFact.Location = new System.Drawing.Point(9, 48);
            this.dgvRegistroFact.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegistroFact.Name = "dgvRegistroFact";
            this.dgvRegistroFact.RowHeadersWidth = 51;
            this.dgvRegistroFact.RowTemplate.Height = 24;
            this.dgvRegistroFact.Size = new System.Drawing.Size(1299, 200);
            this.dgvRegistroFact.TabIndex = 0;
            this.dgvRegistroFact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroFact_CellContentClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(76, 79);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(392, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motivo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 451);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 19);
            this.button2.TabIndex = 7;
            this.button2.Text = "Borrar Factura Seleccionada";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VsConsultarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRegistroFact);
            this.Margin = new System.Windows.Forms.Padding(2);
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
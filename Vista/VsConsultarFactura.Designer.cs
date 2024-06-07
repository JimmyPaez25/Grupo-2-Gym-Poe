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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FacturaMostrarFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombredefacturamostrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMostrarFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaMostrarFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiMostrarFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacturaMostrarFact,
            this.Nombredefacturamostrar,
            this.ApellidoMostrarFactura,
            this.CedulaMostrarFact,
            this.FechaNacimiMostrarFact,
            this.Column1,
            this.Direccion,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1732, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "BORRAR FACTURA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(608, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Factura a Eliminar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(608, 399);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(618, 133);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
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
            // FacturaMostrarFact
            // 
            this.FacturaMostrarFact.HeaderText = "Factura";
            this.FacturaMostrarFact.MinimumWidth = 6;
            this.FacturaMostrarFact.Name = "FacturaMostrarFact";
            this.FacturaMostrarFact.Width = 125;
            // 
            // Nombredefacturamostrar
            // 
            this.Nombredefacturamostrar.HeaderText = "Nombre";
            this.Nombredefacturamostrar.MinimumWidth = 6;
            this.Nombredefacturamostrar.Name = "Nombredefacturamostrar";
            this.Nombredefacturamostrar.Width = 125;
            // 
            // ApellidoMostrarFactura
            // 
            this.ApellidoMostrarFactura.HeaderText = "Apellido";
            this.ApellidoMostrarFactura.MinimumWidth = 6;
            this.ApellidoMostrarFactura.Name = "ApellidoMostrarFactura";
            this.ApellidoMostrarFactura.Width = 125;
            // 
            // CedulaMostrarFact
            // 
            this.CedulaMostrarFact.HeaderText = "Cedula";
            this.CedulaMostrarFact.MinimumWidth = 6;
            this.CedulaMostrarFact.Name = "CedulaMostrarFact";
            this.CedulaMostrarFact.Width = 125;
            // 
            // FechaNacimiMostrarFact
            // 
            this.FechaNacimiMostrarFact.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiMostrarFact.MinimumWidth = 6;
            this.FechaNacimiMostrarFact.Name = "FechaNacimiMostrarFact";
            this.FechaNacimiMostrarFact.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Teléfono";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Column2";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Actividades";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Borrar Factura Seleccionada";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "VsConsultarFactura";
            this.Text = "VsConsultarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaMostrarFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombredefacturamostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMostrarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaMostrarFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiMostrarFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
    }
}
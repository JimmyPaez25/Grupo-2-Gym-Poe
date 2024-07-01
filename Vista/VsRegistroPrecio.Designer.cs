namespace Vista
{
    partial class VsRegistroPrecio
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
            this.dgvRegistroPrecio = new System.Windows.Forms.DataGridView();
            this.clmNroFactRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioFactRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRegistroPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroPrecio
            // 
            this.dgvRegistroPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNroFactRegistro,
            this.clmPrecioFactRegistro});
            this.dgvRegistroPrecio.Location = new System.Drawing.Point(170, 142);
            this.dgvRegistroPrecio.Name = "dgvRegistroPrecio";
            this.dgvRegistroPrecio.RowHeadersWidth = 51;
            this.dgvRegistroPrecio.RowTemplate.Height = 24;
            this.dgvRegistroPrecio.Size = new System.Drawing.Size(714, 201);
            this.dgvRegistroPrecio.TabIndex = 0;
            // 
            // clmNroFactRegistro
            // 
            this.clmNroFactRegistro.HeaderText = "Número de factura";
            this.clmNroFactRegistro.MinimumWidth = 6;
            this.clmNroFactRegistro.Name = "clmNroFactRegistro";
            this.clmNroFactRegistro.ReadOnly = true;
            this.clmNroFactRegistro.Width = 125;
            // 
            // clmPrecioFactRegistro
            // 
            this.clmPrecioFactRegistro.HeaderText = "Precio";
            this.clmPrecioFactRegistro.MinimumWidth = 6;
            this.clmPrecioFactRegistro.Name = "clmPrecioFactRegistro";
            this.clmPrecioFactRegistro.ReadOnly = true;
            this.clmPrecioFactRegistro.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(597, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL:";
            // 
            // lblTotalRegistroPrecio
            // 
            this.lblTotalRegistroPrecio.AutoSize = true;
            this.lblTotalRegistroPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalRegistroPrecio.Location = new System.Drawing.Point(718, 399);
            this.lblTotalRegistroPrecio.Name = "lblTotalRegistroPrecio";
            this.lblTotalRegistroPrecio.Size = new System.Drawing.Size(63, 20);
            this.lblTotalRegistroPrecio.TabIndex = 2;
            this.lblTotalRegistroPrecio.Text = "______";
            this.lblTotalRegistroPrecio.Click += new System.EventHandler(this.lblTotalRegistroPrecio_Click);
            // 
            // VsRegistroPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 529);
            this.Controls.Add(this.lblTotalRegistroPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistroPrecio);
            this.Name = "VsRegistroPrecio";
            this.Text = "VsRegistroPrecio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroFactRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioFactRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRegistroPrecio;
    }
}
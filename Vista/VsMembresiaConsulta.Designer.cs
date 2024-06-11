namespace Vista
{
    partial class VsMembresiaConsulta
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
            this.dgvMembresia = new System.Windows.Forms.DataGridView();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFFM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPREM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembresia
            // 
            this.dgvMembresia.AllowUserToAddRows = false;
            this.dgvMembresia.AllowUserToDeleteRows = false;
            this.dgvMembresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembresia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCedula,
            this.clmNombre,
            this.clmApellido,
            this.clmPM,
            this.clmFIM,
            this.clmFFM,
            this.clmP,
            this.clmDM,
            this.clmPREM});
            this.dgvMembresia.Location = new System.Drawing.Point(12, 191);
            this.dgvMembresia.Name = "dgvMembresia";
            this.dgvMembresia.ReadOnly = true;
            this.dgvMembresia.Size = new System.Drawing.Size(945, 279);
            this.dgvMembresia.TabIndex = 3;
            this.dgvMembresia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembresia_CellContentClick);
            // 
            // clmCedula
            // 
            this.clmCedula.HeaderText = "CEDULA";
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "NOMBRE";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "APELLIDO";
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            // 
            // clmPM
            // 
            this.clmPM.HeaderText = "PLAN DE MEMBRESIA";
            this.clmPM.Name = "clmPM";
            this.clmPM.ReadOnly = true;
            // 
            // clmFIM
            // 
            this.clmFIM.HeaderText = "FECHA DE INICIO";
            this.clmFIM.Name = "clmFIM";
            this.clmFIM.ReadOnly = true;
            // 
            // clmFFM
            // 
            this.clmFFM.HeaderText = "FECHA DE FIN ";
            this.clmFFM.Name = "clmFFM";
            this.clmFFM.ReadOnly = true;
            // 
            // clmP
            // 
            this.clmP.HeaderText = "PROMOCIÓN";
            this.clmP.Name = "clmP";
            this.clmP.ReadOnly = true;
            // 
            // clmDM
            // 
            this.clmDM.HeaderText = "DESCUENTO";
            this.clmDM.Name = "clmDM";
            this.clmDM.ReadOnly = true;
            // 
            // clmPREM
            // 
            this.clmPREM.HeaderText = "PRECIO";
            this.clmPREM.Name = "clmPREM";
            this.clmPREM.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONSULTAR MEMBRESIA";
            // 
            // VsMembresiaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMembresia);
            this.Name = "VsMembresiaConsulta";
            this.Text = "VsMembresiaConsulta";
            this.Load += new System.EventHandler(this.VsMembresiaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembresia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFFM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPREM;
    }
}
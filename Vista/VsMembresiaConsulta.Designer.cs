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
            this.clmPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFFM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPREM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBDP = new System.Windows.Forms.RadioButton();
            this.txtBoxBM = new System.Windows.Forms.TextBox();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnEM = new System.Windows.Forms.Button();
            this.radioBCM = new System.Windows.Forms.RadioButton();
            this.btnBM = new System.Windows.Forms.Button();
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
            this.clmPM,
            this.clmFIM,
            this.clmFFM,
            this.clmP,
            this.clmDPM,
            this.clmDM,
            this.clmPREM});
            this.dgvMembresia.Location = new System.Drawing.Point(67, 209);
            this.dgvMembresia.Name = "dgvMembresia";
            this.dgvMembresia.ReadOnly = true;
            this.dgvMembresia.Size = new System.Drawing.Size(844, 279);
            this.dgvMembresia.TabIndex = 3;
            this.dgvMembresia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembresia_CellContentClick);
            // 
            // clmCedula
            // 
            this.clmCedula.HeaderText = "CEDULA";
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.ReadOnly = true;
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
            // clmDPM
            // 
            this.clmDPM.HeaderText = "DETALLE PROMOCION";
            this.clmDPM.Name = "clmDPM";
            this.clmDPM.ReadOnly = true;
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
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(365, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONSULTAR MEMBRESIA";
            // 
            // radioBDP
            // 
            this.radioBDP.AutoSize = true;
            this.radioBDP.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBDP.ForeColor = System.Drawing.Color.White;
            this.radioBDP.Location = new System.Drawing.Point(158, 122);
            this.radioBDP.Name = "radioBDP";
            this.radioBDP.Size = new System.Drawing.Size(102, 17);
            this.radioBDP.TabIndex = 6;
            this.radioBDP.TabStop = true;
            this.radioBDP.Text = "Detalle promoción";
            this.radioBDP.UseVisualStyleBackColor = true;
            // 
            // txtBoxBM
            // 
            this.txtBoxBM.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBM.Location = new System.Drawing.Point(67, 158);
            this.txtBoxBM.Name = "txtBoxBM";
            this.txtBoxBM.Size = new System.Drawing.Size(201, 21);
            this.txtBoxBM.TabIndex = 7;
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarM.FlatAppearance.BorderSize = 2;
            this.btnEliminarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarM.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.ForeColor = System.Drawing.Color.White;
            this.btnEliminarM.Location = new System.Drawing.Point(844, 147);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(67, 31);
            this.btnEliminarM.TabIndex = 8;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = false;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // btnEM
            // 
            this.btnEM.BackColor = System.Drawing.Color.Transparent;
            this.btnEM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEM.FlatAppearance.BorderSize = 2;
            this.btnEM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEM.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEM.ForeColor = System.Drawing.Color.White;
            this.btnEM.Location = new System.Drawing.Point(743, 148);
            this.btnEM.Name = "btnEM";
            this.btnEM.Size = new System.Drawing.Size(67, 31);
            this.btnEM.TabIndex = 9;
            this.btnEM.Text = "Editar";
            this.btnEM.UseVisualStyleBackColor = false;
            this.btnEM.Click += new System.EventHandler(this.btnEM_Click);
            // 
            // radioBCM
            // 
            this.radioBCM.AutoSize = true;
            this.radioBCM.Checked = true;
            this.radioBCM.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBCM.ForeColor = System.Drawing.Color.White;
            this.radioBCM.Location = new System.Drawing.Point(67, 122);
            this.radioBCM.Name = "radioBCM";
            this.radioBCM.Size = new System.Drawing.Size(52, 17);
            this.radioBCM.TabIndex = 16;
            this.radioBCM.TabStop = true;
            this.radioBCM.Text = "Cedula";
            this.radioBCM.UseVisualStyleBackColor = true;
            // 
            // btnBM
            // 
            this.btnBM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBM.FlatAppearance.BorderSize = 2;
            this.btnBM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnBM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBM.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBM.ForeColor = System.Drawing.Color.White;
            this.btnBM.Location = new System.Drawing.Point(285, 147);
            this.btnBM.Name = "btnBM";
            this.btnBM.Size = new System.Drawing.Size(75, 31);
            this.btnBM.TabIndex = 17;
            this.btnBM.Text = "Buscar";
            this.btnBM.UseVisualStyleBackColor = true;
            this.btnBM.Click += new System.EventHandler(this.btnBM_Click);
            // 
            // VsMembresiaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(980, 542);
            this.Controls.Add(this.btnBM);
            this.Controls.Add(this.radioBCM);
            this.Controls.Add(this.btnEM);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.txtBoxBM);
            this.Controls.Add(this.radioBDP);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFFM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPREM;
        private System.Windows.Forms.RadioButton radioBDP;
        private System.Windows.Forms.TextBox txtBoxBM;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnEM;
        private System.Windows.Forms.RadioButton radioBCM;
        private System.Windows.Forms.Button btnBM;
    }
}
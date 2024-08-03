using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class VsAutor : Form
    {
        CtrAutor ctrAutor = new CtrAutor();

        private DataGridView dgvAutores;
        private Label lblTitulo1;
        private Label lblTitulo2;
        private Label lblNameSystem;
        private Label lblDateCreate;

        public VsAutor()
        {
            //InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(903, 636);
            this.MaximizeBox = false;
            this.Text = "Autores";
            MisComponentes();
            ctrAutor.TablaConsultarAutor(dgvAutores, lblNameSystem, lblDateCreate);
        }

        private void MisComponentes()
        {
            // AGG LABEL TITULO 1
            lblTitulo1 = new Label();
            lblTitulo1.Text = "Nombre del Sistema: ";
            lblTitulo1.Location = new System.Drawing.Point(55, 30); // (HORIZONTAL, VERTICAL) (X, Y) 
            lblTitulo1.AutoSize = true;

            // AGG LABEL TITULO 2
            lblTitulo2 = new Label();
            lblTitulo2.Text = "Fecha de Creacion: ";
            lblTitulo2.Location = new System.Drawing.Point(55, 62); // (HORIZONTAL, VERTICAL) (X, Y) 
            lblTitulo2.AutoSize = true;

            // AGG LABEL NAME SYSTEM
            lblNameSystem = new Label();
            lblNameSystem.Text = ".";
            lblNameSystem.Location = new System.Drawing.Point(165, 30); // (HORIZONTAL, VERTICAL) (X, Y) 
            lblNameSystem.AutoSize = true;

            // AGG LABEL DATE CREATE
            lblDateCreate = new Label();
            lblDateCreate.Text = ".";
            lblDateCreate.Location = new System.Drawing.Point(165, 62); // (HORIZONTAL, VERTICAL) (X, Y) 
            lblDateCreate.AutoSize = true;

            // AGG TABLA AUTORES
            dgvAutores = new DataGridView();
            dgvAutores.Location = new System.Drawing.Point(58, 111); // (HORIZONTAL, VERTICAL) (X, Y) 
            dgvAutores.Size = new System.Drawing.Size(759, 428);
            dgvAutores.AllowUserToAddRows = false;

            // AGG COLUMNAS A TABLA AUTORES
            int numColAutores = 4;
            DataGridViewTextBoxColumn[] clmAutores = new DataGridViewTextBoxColumn[numColAutores];
            string[] nombreClmAutores = { "NUM", "AUTOR", "EMAIL", "TELEFONO" };
            for (int i = 0; i < nombreClmAutores.Length; i++)
            {
                clmAutores[i] = new DataGridViewTextBoxColumn();
                clmAutores[i].HeaderText = nombreClmAutores[i];
                dgvAutores.Columns.Add(clmAutores[i]);
            }

            // AGG COLUMNA DE IMAGEN A TABLA AUTORES
            DataGridViewImageColumn colFoto = new DataGridViewImageColumn();
            colFoto.HeaderText = "FOTO";
            colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom; // AJUSTA IMAGEN A DIMENSION DE LA CELDA
            dgvAutores.Columns.Add(colFoto);

            dgvAutores.ReadOnly = true;

            //
            // AGG COMPONENTES AL FORM
            //
            Controls.Add(lblTitulo1);
            Controls.Add(lblTitulo2);
            Controls.Add(lblNameSystem);
            Controls.Add(lblDateCreate);
            Controls.Add(dgvAutores);
        }

    }
}

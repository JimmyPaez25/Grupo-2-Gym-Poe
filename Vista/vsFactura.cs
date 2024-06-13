using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vista
{
    public partial class VsFactura : Form
    {
        CtrFactura ctrfact;



        public VsFactura()
        {
            InitializeComponent();
            ctrfact = new CtrFactura();
            lblNumFactura.Text = ctrfact.GenerarFactura();

        }


        /// <summary>
        /// 
        /// </summary>
    
        private void btnRegistrarDatosFact_Click(object sender, EventArgs e)
        {

            int rnumfact = lblNumFactura.Text.Trim();   
            string rid = lblDireccionFact.Text.Trim();




            


            // Mostrar mensaje con los datos de la factura
            string mensaje = "\nDATOS DE SU FACTURA REGISTRADOS\n";
            mensaje += "NÚNERO DE FACTURA: " + lblNumFactura.Text + "\n";
            mensaje += "NÚNMERO DE CÉDULA: " + lblCedulaFact.Text + "\n";
            mensaje += "NOMBRE: " + lblNombreFact.Text + "\n";
            mensaje += "APELLIDO: " + lblApellidoFact.Text + "\n";
            mensaje += "FECHA DE NACIMIENTO: " + lblFechaNacimientoFact.Text + "\n";
            mensaje += "TELÉFONO: " + lblTelefonoFact.Text + "\n";
            mensaje += "DIRECCIÓN: " + lblDireccionFact.Text + "\n";
            mensaje += "ESTUDIANTE: " + lblEstudianteFact.Text + "\n";
            mensaje += "COMPROBANTE: " + lblComprobanteFact.Text + "\n";
            mensaje += "PLAN: " + lblPlanFact.Text + "\n";
            mensaje += "PROMOCIÓN: " + lblPromocionFact.Text + "\n";
            mensaje += "FECHA INICIO: " + lblFechaInicioFact.Text + "\n";
            mensaje += "FECHA FIN: " + lblFechaFinFact.Text + "\n";
            MessageBox.Show(mensaje, "REGISTRO DE FACTURA", MessageBoxButtons.OK);
            
            this.Close();

  
            mensaje = ctrfact.IngresarFact(rnumfact, rid);
            if (mensaje.Contains("\nDATOS DE SU FACTURA REGISTRADOS\n"))
            {
                lblNumFactura.Text = "";
                
                
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreFact_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidoFact_Click(object sender, EventArgs e)
        {

        }

        private void dtFechaNacimientoFact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefonoFact_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccionFact_Click(object sender, EventArgs e)
        {

        }

        private void lblEstudianteFact_Click(object sender, EventArgs e)
        {

        }

        private void lblComprobanteFact_Click(object sender, EventArgs e)
        {

        }

        private void lblPlanFact_Click(object sender, EventArgs e)
        {

        }

        private void lblPromocionFact_Click(object sender, EventArgs e)
        {

        }

        private void dtFechaFactura_ValueChanged_1(object sender, EventArgs e)
        {

        }

    

        private void lblFechaNacimientoFact_Click(object sender, EventArgs e)
        {

        }

        private void VsFactura_Load(object sender, EventArgs e)
        {

        }

        private void lblNumFactura_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaInicioFact_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaFinFact_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }


    }
}

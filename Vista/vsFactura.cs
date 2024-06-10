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
        CtrFactura factura;



        public VsFactura()
        {
            InitializeComponent();
            factura = new CtrFactura();
            lblNumFactura.Text = factura.GenerarFactura();

        }


        /// <summary>
        /// 
        /// </summary>
    
        private void btnRegistrarDatosFact_Click(object sender, EventArgs e)
        {
           
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

        private void txtNumFactura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

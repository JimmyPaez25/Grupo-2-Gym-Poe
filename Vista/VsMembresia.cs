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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Vista;

namespace Vista
{
    public partial class VsMembresia : Form
    {
        private CtrMembresia ctrMen = new CtrMembresia();
        private Validacion v = new Validacion();
        private VsRegistrarCliente vscliente = new VsRegistrarCliente();
        string celular, direccion, comprobante;


        public VsMembresia()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tienePromocion = (String)comboBoxP.SelectedItem;
            if (tienePromocion.Equals("SI"))
            {
                labelDP.Visible = true;
                txtBoxDP.Visible = true;
                labelD.Visible = true;
                txtBoxD.Visible = true;
            }
            else
            {
                labelDP.Visible = false;
                txtBoxDP.Visible = false;
                labelD.Visible = false;
                txtBoxD.Visible = false;
            }
        }

        private void txtBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxD_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarCantidad(sender, e);
        }

        private void txtBoxM_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarLetra(sender, e);

        }

        private void txtBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarLetra(sender, e);
        }

        private void txtBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string msj = "";
            string sPlan = txtBoxM.Text.Trim();
            string sFechaInicio = dateTPFI.Text.Trim();
            string sFechaFin = dateTPFF.Text.Trim();
            string promocion = comboBoxP.Text.Trim();
            string sDescuento = txtBoxD.Text.Trim();
            string detallePromocion = txtBoxDP.Text.Trim();
            string cedula = lblCedulaM.Text.Trim();


            msj = ctrMen.IngresarMembresia(sPlan, sFechaInicio, sFechaFin, promocion, sDescuento, detallePromocion , cedula);
            MessageBox.Show(msj);
            VsFactura vFactura = new VsFactura();
            vFactura.lblCedulaFact.Text = this.lblCedulaM.Text;
            vFactura.lblNombreFact.Text = this.lblNombreM.Text;
            vFactura.lblApellidoFact.Text = this.lblApellidoM.Text;
            vFactura.lblEstudianteFact.Text = this.lblEstudianteM.Text;
            vFactura.lblPlanFact.Text = this.txtBoxM.Text;
            vFactura.lblPromocionFact.Text = this.comboBoxP.Text;
            vFactura.Show();
            this.Close();



   

            if (msj.Contains("MEMBRESIA REGISTRADA CORRECTAMENTE"))
            {
                DateTime fechaInicio = ctrMen.FechaActual.Date; 
                DateTime fechaFin = ctrMen.FechaActual.Date;
                txtBoxM.Text = "";
                dateTPFI.Value = ctrMen.FechaActual;
                dateTPFF.Value = ctrMen.FechaActual;
                comboBoxP.Text = "";
                txtBoxD.Text = "";
                txtBoxDP.Text = "";
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }

        private void labelC_Click(object sender, EventArgs e)
        {

        }

        private void lblCedulaM_Click(object sender, EventArgs e)
        {

        }

        private void VsMembresia_Load(object sender, EventArgs e)
        {

        }
    }
}

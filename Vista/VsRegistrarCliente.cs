using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    public partial class VsRegistrarCliente : Form
    {
        private CtrCliente ctrCli = new Control.CtrCliente();
        private Validacion v = new Validacion();
        private bool edicion = false;
        public VsRegistrarCliente()
        {
            InitializeComponent();
            lblEstado.Visible = false;
            cmbEstado.Visible = false;
            lblComprobante.Visible = false;
            txtComprobante.Visible = false;
        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comprobante = (string)cmbEstudiante.SelectedItem;
            if (comprobante.Equals("SI"))
            {
                lblComprobante.Visible=true;
                txtComprobante.Visible = true;
            }
            else
            {
                lblComprobante.Visible = false;
                txtComprobante.Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string rCedula = txtCedula.Text.Trim(), rTelefono = txtTelefono.Text.Trim();
            string rNombre = txtNombre.Text.Trim(), rDireccion = txtDireccion.Text.Trim();
            string rFechaNacimiento = dtpDate.Text.Trim(), esEstudiante = (string)cmbEstudiante.SelectedItem;
            string rApellido = txtApellido.Text.Trim(), rEstado = "ACTIVO";
            string rComprobante = txtComprobante.Text.Trim();
            string msg = "";
            if (string.IsNullOrEmpty(rCedula) || rCedula.Equals("") &&
                string.IsNullOrEmpty(rNombre) || rNombre.Equals("") &&
                 string.IsNullOrEmpty(rTelefono) || rTelefono.Equals("") &&
                  string.IsNullOrEmpty(rDireccion) || rDireccion.Equals("") &&
                  string.IsNullOrEmpty(rApellido) || rApellido.Equals("")
                   || esEstudiante.Equals("") )
            {
                MessageBox.Show("ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS");
            }
            else
            {
                if (esEstudiante.Equals("SI"))
                {
                    msg = ctrCli.IngresarCliEst(rCedula, rNombre, rApellido, rFechaNacimiento, rTelefono, rEstado, rDireccion, rComprobante);
                }
                else
                {
                    msg = ctrCli.IngresarCli(rCedula, rNombre, rApellido, rFechaNacimiento, rTelefono, rEstado, rDireccion);
                }
            }

            
            VsMembresia vMembresia = new VsMembresia(); 
            vMembresia.lblCedulaM.Text = this.txtCedula.Text;
            vMembresia.lblNombreM.Text = this.txtNombre.Text;
            vMembresia.lblApellidoM.Text = this.txtApellido.Text;
            vMembresia.Show();
        }

        private void btnConsultarMembresia_Click(object sender, EventArgs e)
        {
            VsConsultarCliente cltCliente = new VsConsultarCliente();
            cltCliente.Visible = true;
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
            v.maximoDigitosNumericos(sender, e, 10, txtCedula);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
            v.maximoDigitosNumericos(sender, e, 10, txtTelefono);
        }
    }
}

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

            MessageBox.Show(msg);
            VsMembresia vMembresia = new VsMembresia(); 
            vMembresia.lblCedulaM.Text = this.txtCedula.Text;
            vMembresia.lblNombreM.Text = this.txtNombre.Text;
            vMembresia.lblApellidoM.Text = this.txtApellido.Text;
            vMembresia.lblEstudianteM.Text = this.cmbEstudiante.Text;
            vMembresia.CelularInvisible.Text = this.txtTelefono.Text;
            vMembresia.ComprobanteInvisible.Text = this.txtComprobante.Text;
            vMembresia.FechaNacInvisible.Text = this.dtpDate.Text;
            vMembresia.DireccionInvisible.Text = this.txtDireccion.Text;

            vMembresia.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
            v.ValidarMaximoDeDigito(sender, e, 10, 0, txtCedula);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
            v.ValidarMaximoDeDigito(sender, e, 10, 0, txtTelefono);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ConvertirMayuscula(txtNombre);
            v.ValidarMaximoDeDigito(sender, e, 0, 20, txtNombre);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            v.ConvertirMayuscula(textBox);
            v.ValidarMaximoDeDigito(sender, e, 0, 20, txtApellido);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            v.ConvertirMayuscula(textBox);
            v.ValidarMaximoDeDigito(sender, e, 5, 20, txtDireccion);
        }

        private void txtComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            v.ConvertirMayuscula(textBox);
            v.ValidarMaximoDeDigito(sender, e, 15, 5, txtComprobante);
        }
    }
}

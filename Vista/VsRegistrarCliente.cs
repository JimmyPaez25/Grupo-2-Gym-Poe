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
            DateTime fechaActual = DateTime.Now;
            bool camposValidos = false;
            do
            {
                string rCedula = txtCedula.Text.Trim(), rTelefono = txtTelefono.Text.Trim();
                string rNombre = txtNombre.Text.Trim(), rDireccion = txtDireccion.Text.Trim();
                DateTime rFechaNacimiento = dtpDate.Value;  
                string esEstudiante = (string)cmbEstudiante.SelectedItem;
                string rApellido = txtApellido.Text.Trim(), rEstado = "ACTIVO";
                string rComprobante = txtComprobante.Text.Trim();
                string msg = "";
                
                if (string.IsNullOrEmpty(rCedula) || string.IsNullOrEmpty(rNombre) || string.IsNullOrEmpty(rTelefono) ||
                    string.IsNullOrEmpty(rDireccion) || string.IsNullOrEmpty(rApellido) || string.IsNullOrEmpty(esEstudiante))
                {
                    MessageBox.Show("ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (rFechaNacimiento.Year == fechaActual.Year && rFechaNacimiento.Month == fechaActual.Month)
                {
                    MessageBox.Show("ERROR: EL AÑO Y EL MES DE LA FECHA DE NACIMIENTO NO PUEDEN SER LOS MISMOS QUE EL AÑO Y MES ACTUALES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (ctrCli.ClienteExistente(rCedula))
                {
                    MessageBox.Show("ERROR: ESTA CEDULA YA ESTÁ ASIGNADA CON UN CLIENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                

                // Ingresar datos del cliente
                if (esEstudiante.Equals("SI"))
                {
                    msg = ctrCli.IngresarCliEst(rCedula, rNombre, rApellido, rFechaNacimiento.ToString("yyyy-MM-dd"), rTelefono, rEstado, rDireccion, rComprobante);
                }
                else
                {
                    msg = ctrCli.IngresarCli(rCedula, rNombre, rApellido, rFechaNacimiento.ToString("yyyy-MM-dd"), rTelefono, rEstado, rDireccion);
                }

                MessageBox.Show(msg);

                // Mostrar el formulario VsMembresia
                VsMembresia vMembresia = new VsMembresia();
                vMembresia.lblCedulaM.Text = rCedula;
                vMembresia.lblNombreM.Text = rNombre;
                vMembresia.lblApellidoM.Text = rApellido;
                vMembresia.lblEstudianteM.Text = esEstudiante;
                vMembresia.CelularInvisible.Text = rTelefono;
                vMembresia.ComprobanteInvisible.Text = rComprobante;
                vMembresia.FechaNacInvisible.Text = rFechaNacimiento.ToString("yyyy-MM-dd");
                vMembresia.DireccionInvisible.Text = rDireccion;

                vMembresia.Show();
                this.Close();

                camposValidos = true;

            } while (!camposValidos);
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

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
    public partial class VsEditarCliente : Form
    {
        private CtrCliente ctrCli = new CtrCliente();
        private Validacion v = new Validacion();
        private bool cambios;
        public bool Cambios { get => cambios; set => cambios = value; }

        public VsEditarCliente(string cedulaCliente)
        {
            InitializeComponent();
            ctrCli.MostrarDatosCliente(cedulaCliente, txtCedula, txtNombre, txtApellido, dtpDate, txtTelefono, txtDireccion, txtComprobante, cmbEstado, cmbEstudiante);
            txtCedulaOriginal.Text = txtCedula.Text;

            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string aCedulaOrg = txtCedulaOriginal.Text.Trim();
            string aCedula = txtCedula.Text.Trim();
            string aNombre = txtNombre.Text.Trim();
            string aApellido = txtApellido.Text.Trim();
            string aDireccion = txtDireccion.Text.Trim();
            string aFechaNacimiento = dtpDate.Text.Trim();
            string aComprobante = txtComprobante.Text.Trim();
            string aTelefono = txtTelefono.Text.Trim();
            string esEstudiante = (string)cmbEstudiante.SelectedItem;
            string aEstado = (string)cmbEstado.SelectedItem;
            string msg = "";
            if (aEstado.Equals("ACTIVO"))
            {
                if (esEstudiante.Equals("SI", StringComparison.OrdinalIgnoreCase))
                {
                    msg = ctrCli.EditarCliEst(aCedulaOrg, aCedula, aNombre, aApellido, aFechaNacimiento, aTelefono, aDireccion, aEstado , aComprobante, esEstudiante);
                }
                else
                {
                    msg = ctrCli.EditarCli(aCedulaOrg, aCedula, aNombre, aApellido, aFechaNacimiento, aTelefono, aDireccion, aEstado );
                }
            }
            else
            {
                if (esEstudiante.Equals("SI", StringComparison.OrdinalIgnoreCase))
                {
                    msg = ctrCli.EditarCliEst(aCedulaOrg, aCedula, aNombre, aApellido, aFechaNacimiento, aTelefono, aDireccion, aEstado , aComprobante, esEstudiante);
                }
                else
                {
                    msg = ctrCli.EditarCli(aCedulaOrg, aCedula, aNombre, aApellido, aFechaNacimiento, aTelefono, aDireccion, aEstado);
                }
            }
            

            MessageBox.Show(msg, "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (msg.Contains("CLIENTE EDITADO CORRECTAMENTE"))
            {
                Cambios = true;
                this.Close();
            }

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
            v.ValidarMaximoDeDigito(sender, e,10, 0, txtCedula);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
            v.ValidarMaximoDeDigito(sender, e,10, 0, txtTelefono);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            v.ConvertirMayuscula(textBox);
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

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
        public VsRegistrarCliente()
        {
            InitializeComponent();
        }

        private void lblCedula_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string rCedula = txtCedula.Text.Trim(), rTelefono = txtTelefono.Text.Trim();
            string rNombre = txtNombre.Text.Trim(), rDireccion = txtDireccion.Text.Trim();
            string rFechaNacimiento = txtDate.Text.Trim(), esEstudiante = (string)cmbEstudiante.SelectedItem;
            string rApellido = txtApellido.Text.Trim();
            string msg = "";

            if (esEstudiante.Equals("SI"))
            {
                msg = ctrCli.IngresarCliEst(rCedula, rNombre, rApellido, rFechaNacimiento, rTelefono, rDireccion, esEstudiante);
            }else
            {
                msg = ctrCli.IngresarCli(rCedula, rNombre, rApellido, rFechaNacimiento, rTelefono, rDireccion);
            }
            MessageBox.Show(msg);
        }

        private void btnConsultarMembresia_Click(object sender, EventArgs e)
        {
            VsConsultarCliente cltCliente = new VsConsultarCliente();
            cltCliente.Visible = true;
        }



        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
        }
    }
}

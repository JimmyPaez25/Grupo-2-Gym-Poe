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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VsConsultarCliente cltCliente = new VsConsultarCliente();
            cltCliente.Visible = true;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            //char letra = e.KeyChar;
            //if (!char.IsDigit(letra) && letra != (char)Keys.Back)
            //{
            //    e.Handled = true;
            //    return;
            //}
        }
    }
}

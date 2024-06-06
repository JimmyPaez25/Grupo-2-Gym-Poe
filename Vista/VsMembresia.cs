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
    public partial class VsMembresia : Form
    {

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

        }

        private void txtBoxM_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

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

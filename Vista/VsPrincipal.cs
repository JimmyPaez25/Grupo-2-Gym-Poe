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
    public partial class VsPrincipal : Form
    {
        public VsPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VsActividad act = new VsActividad(); act.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VsRegistrarCliente rgCliente = new VsRegistrarCliente();
            rgCliente.ShowDialog();
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
           VsConsultarCliente conCli = new VsConsultarCliente();
            conCli.ShowDialog();
        }

        private void VsPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VsFactura facto = new VsFactura();
            facto.ShowDialog();
        }

        private void buttonGestionActividad_Click(object sender, EventArgs e)
        {
            VsActividad vActividad = new VsActividad(); vActividad.ShowDialog();
        }

        // FIN
    }
}

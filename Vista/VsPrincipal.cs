using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class VsPrincipal : Form
    {
        private CtrMembresia ctrMembresia = new CtrMembresia();
        private VsConexion VsConn;

        public VsPrincipal(VsConexion VsConn)
        {
            InitializeComponent();
            this.VsConn = VsConn;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            VsMembresiaConsulta vConsMembresia = null;
            if (ctrMembresia.GetTotal() > 0)
            {
                vConsMembresia = new VsMembresiaConsulta(); vConsMembresia.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR: NO EXISTEN MEMBRESIA REGISTRADAS.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //VsMembresiaConsulta consultaMembresia = new VsMembresiaConsulta();
            //consultaMembresia.ShowDialog();
        }

        private void btnVerRegistroFact_Click(object sender, EventArgs e)
        {
                VsConsultarFactura vRegistroFact = new VsConsultarFactura();
                vRegistroFact.ShowDialog();
            
        }

        private void VsPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            VsConn.Close();
        }


        // FIN
    }
}

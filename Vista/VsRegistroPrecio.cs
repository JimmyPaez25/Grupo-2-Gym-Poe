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
    public partial class VsRegistroPrecio : Form
    {

        CtrFactura ctrfacto = new CtrFactura();

        public VsRegistroPrecio()
        {
            InitializeComponent();
            ctrfacto.LlenarRegistroPrecio(dgvRegistroPrecio);
            lblTotalRegistroPrecio.Text = ctrfacto.CalcularSumaPrecios().ToString();
        }

        private void lblTotalRegistroPrecio_Click(object sender, EventArgs e)
        {

            
        }
    }
}

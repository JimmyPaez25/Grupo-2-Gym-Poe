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
    public partial class VsConsultarCliente : Form
    {
        private CtrCliente ctrCli = new CtrCliente();
        private Validacion v = new Validacion();
        private VsRegistrarCliente vRC = new VsRegistrarCliente();

        public VsConsultarCliente()
        {
            InitializeComponent();
            ctrCli.LlenarGrid(dgvClientes);

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}

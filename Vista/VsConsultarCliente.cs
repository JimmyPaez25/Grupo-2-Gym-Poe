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
        private int poc;


        public VsConsultarCliente()
        {
            InitializeComponent();
            ctrCli.LlenarGrid(dgvClientes);

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro =txtCedula.Text.Trim();
            ctrCli.ConsultarClientePorCedula(dgvClientes,filtro);
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            VsEditarCliente vsEditarClint = new VsEditarCliente();
            vsEditarClint.Visible = true;
            poc = dgvClientes.CurrentRow.Index;

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

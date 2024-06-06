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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class VsConsultarCliente : Form
    {
        private CtrMembresia ctrMen = new CtrMembresia();
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
            string cedula, nombre, apellido, telefono;
            string direccion, comprobante;
            string estado;
            DateTime fechaNacimiento;

            ctrCli.ConseguirDatosGrid(dgvClientes, out cedula, out nombre, out apellido, out fechaNacimiento, out telefono, out direccion, out comprobante, out estado);
            VsEditarCliente vsEditarClint = new VsEditarCliente(cedula, nombre, apellido, fechaNacimiento, telefono, direccion, estado, comprobante);
            
            vsEditarClint.Visible = true;
            poc = dgvClientes.CurrentRow.Index;

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarM_Click(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count > 0)
            {
                string cedula;
                ctrMen.ExtraerDatosTablaMembresia(dgvClientes, out cedula);
                VsMembresiaLista vListaM = new VsMembresiaLista(cedula);
                vListaM.Show();
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA DE CLIENTE.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

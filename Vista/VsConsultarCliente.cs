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
            ctrCli.BuscarClientePorCedula(dgvClientes,filtro);
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarNumero(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
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
            else
            {
                MessageBox.Show("ERROR: DEBE SELECCIONAR UNA FILA PARA EDITAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            ctrCli.LlenarGrid(dgvClientes);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0) 
            { 
                var filaSeleccionada = dgvClientes.SelectedRows[0];
                var cedula = (string)filaSeleccionada.Cells["clmCedula"].Value;
                ctrCli.InvalidarCliente(cedula, dgvClientes);
                ctrCli.LlenarGrid(dgvClientes);
            }
            else
            {
                MessageBox.Show("ERROR: Selecciona una fila antes de dar de baja a un cliente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
    public partial class VsEditarCliente : Form
    {
        private CtrCliente ctrCli = new CtrCliente();
        private Validacion v = new Validacion();

        private String cedula;
        private String nombre;
        private String apellido;
        private DateTime fechaNacimiento;
        private String telefono;
        private String direccion;
        private String estado;
        private String comprobante;
        private bool cambios;

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Comprobante { get => comprobante; set => comprobante = value; }
        public bool Cambios { get => cambios; set => cambios = value; }

        public VsEditarCliente(string cedula, string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string estado, string comprobante)
        {
            InitializeComponent();
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Direccion = direccion;
            Estado = estado;
            Comprobante = comprobante;
            ctrCli.MostrarDatosCliente(Cedula, Nombre, Apellido, FechaNacimiento, Telefono, Direccion, Estado, Comprobante, txtCedula, txtNombre, txtApellido, dtpDate, txtTelefono, txtDireccion, txtComprobante, cmbEstado);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

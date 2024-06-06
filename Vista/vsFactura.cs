using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vista
{
    public partial class VsFactura : Form
    {
        CtrFactura factura;



        public VsFactura()
        {
            InitializeComponent();
            factura = new CtrFactura();
            txtNumFactura.Text = factura.GenerarFactura();


        }

        private void VsFactura_Load(object sender, EventArgs e)
        {
            CtrCliente ctrCliente = new CtrCliente();
            List<string> cedulas = ctrCliente.ObtenerCedulasClientes();
            foreach (string cedula in cedulas)
            {
                cbNumeroCedula.Items.Add(cedula);
            }

        }


        private void dtFechaFactura_ValueChanged(object sender, EventArgs e)
        {

        }

        private CtrCliente CtClient = new CtrCliente();

        //private void cbNumeroCedula_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string seleccion = cbNumeroCedula.Text;
        //    ClienteDatos cliDatos = CtClient.ObtenerDatosClientePorCedula(seleccion);
        //    if (cliDatos != null)
        //    {
        //        txtNombreUsuario.Text = cliDatos.Nombre;
        //        txtApellidoUsuario.Text = cliDatos.Apellido;
        //        dateTPFNF.Text = cliDatos.FechaNacimiento.ToString("yyyy-MM-dd");
        //        txtTefefono.Text = cliDatos.Telefono;
        //        txtDireccion.Text = cliDatos.Direccion;
        //        txtEstado.Text = cliDatos.Estado;
        //    }
        //    else
        //    {
        //        // Mostrar mensaje de error si no se encuentra el cliente
        //    }
        //}

        private void txtApellidoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTefefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComprobante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumFactura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

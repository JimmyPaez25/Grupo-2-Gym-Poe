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


        CtClient cliente;
        CtrFactura factura;
        List<CtrFactura> listCliente;
        string seleccion;
        string nombre;


        CtrFactura ctrfact = new CtrFactura();





        public VsFactura()
        {
            InitializeComponent();
            cliente = new CtrCliente();
            factura = new CtrFactura();
            listCliente = CtrFactura.GetCliente();
            cbNumeroCedula.DisplayMember = "cedula"; // Propiedad que se mostrará en el ComboBox
            cbNumeroCedula.ValueMember = "cedula"; // Propiedad que se seleccionará al seleccionar un elemento del ComboBox
            cbNumeroCedula.DataSource = listCliente;
            txtNumFactura.Text = factura.GenerarFactura();

        }

        private void VsFactura_Load(object sender, EventArgs e)
        {

        }

        private void txtNumFactura_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaFactura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbNumeroCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (true)
            {
                seleccion = cbNumeroCedula.Text;
                nombre = CtClient.obtenerNombre(seleccion);

            }
            txtNombreUsuario.Text = nombre;

        }
    }
}

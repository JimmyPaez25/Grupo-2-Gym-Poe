using Control;
using iTextSharp.text.pdf.codec.wmf;
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
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRegistroPrecio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbiNFORME_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = cmbiNFORME.SelectedItem.ToString();
            ctrfacto.LlenarRegistroPrecio(dgvRegistroPrecio, estadoSeleccionado);
            ctrfacto.MostrarTotalFacturas(estadoSeleccionado, txtTotalFacturas);
            ctrfacto.MostrarTotalFacturasConDescuento(estadoSeleccionado, txtTotalConDescuento, txtTotalSinDescuento);
            ctrfacto.MostrarMontoTotalInforme(estadoSeleccionado, txtMontoTotal);
            //ctrfacto.MostrarTotalFacturasSinDescuento(estadoSeleccionado, txtTotalSinDescuento);
        }



        private void txtTotalFacturas_TextChanged(object sender, EventArgs e)
        {
            //ctrfacto.MostrarTotalFacturas();
        }

        private void txtTotalConDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalSinDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInformePDF_Click(object sender, EventArgs e)
        {
          
                if (cmbiNFORME.SelectedItem == null)
                {
                    MessageBox.Show("SELECCIONA EL ESTADO DE LAS FACTURAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string estadoSeleccionado = cmbiNFORME.SelectedItem.ToString();
                DialogResult resultado = MessageBox.Show("DESEA GENERAR REPORTE PDF DE FACTURAS?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ctrfacto.GenerarInformePDF(estadoSeleccionado);
                    ctrfacto.AbrirInformePDF();
                }          
        }
    }
}

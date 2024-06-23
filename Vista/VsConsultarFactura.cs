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
    public partial class VsConsultarFactura : Form
    {
        // El original
        CtrFactura ctrfacto = new CtrFactura();
        private Validacion val = new Validacion();


        public VsConsultarFactura()
        {
            InitializeComponent();
            ctrfacto.LlenarDataFact(dgvRegistroFact);
            
            //facturaListi = CtrFactura.GetTotal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRegistroFact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            richTextBox1.KeyPress += val.ValidarLetra;
            
        }

       

        private void txtingresarbuscar_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            string filtro = txtingresarbuscar.Text.Trim();
            ctrfacto.TablaConsultarNombreDescripcion(dgvRegistroFact, filtro);
        }

        private void btnInactivarFact_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("POR FAVOR, ESCRIBA EL MOTIVO POR EL CUAL DESEA ELIMINAR ESTA FACTURA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var filaSeleccionada = dgvRegistroFact.SelectedRows[0];
                var serie = (string)filaSeleccionada.Cells["FacturaRegistroFact"].Value;

                ctrfacto.InactivarFactura(serie, dgvRegistroFact);
                ctrfacto.LlenarDataFact(dgvRegistroFact);
                richTextBox1.Clear(); // Borrar el contenido del richTextBox1
            }
            
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            richTextBox1.KeyPress += val.ValidarLetra;

        }

        private void btnBuscarFact_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtingresarbuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnVolverFact_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VsConsultarFactura_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    public partial class VsPapeleraActividad : Form
    {
        private CtrActividad ctrActividad = new CtrActividad();
        private Validacion val = new Validacion();

        public VsPapeleraActividad()
        {
            InitializeComponent();
            ctrActividad.TablaConsultarActividadPapelera(dgvActividad);
        }

        private void buttonEliminarPermanente_Click(object sender, EventArgs e)
        {
            ctrActividad.RemoverActividad(dgvActividad);
        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            ctrActividad.RestaurarActividad(dgvActividad);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string filtro = textBuscar.Text.Trim();
            bool buscarPorNombre = radioButtonNombre.Checked;
            ctrActividad.TablaConsultarActividadNombreDescripcionPapelera(dgvActividad, filtro, buscarPorNombre);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCaracterEspecial(sender, e);
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int cursorPosicion = textBox.SelectionStart;
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = cursorPosicion;
        }

        // FIN
    }
}

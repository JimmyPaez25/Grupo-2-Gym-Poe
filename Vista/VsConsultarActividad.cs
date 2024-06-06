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
    public partial class VsConsultarActividad : Form
    {
        private CtrActividad ctrActividad = new CtrActividad();
        private Validacion val = new Validacion();

        public VsConsultarActividad()
        {
            InitializeComponent();
            ctrActividad.TablaConsultarActividad(dgvActividad);
        }

        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCaracterEspecial(sender, e);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ctrActividad.InactivarActividad(dgvActividad);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string filtro = textBuscar.Text.Trim();
            bool buscarPorNombre = radioButtonNombre.Checked;
            ctrActividad.TablaConsultarActividadNombreDescripcion(dgvActividad, filtro, buscarPorNombre);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dgvActividad.SelectedRows.Count > 0)
            {
                string sNombre, sDescripcion;
                DateTime sFechaInicio, sFechaFin;
                TimeSpan sHoraInicio, sHoraFin;
                ctrActividad.ExtraerDatosTablaActividad(dgvActividad, out sNombre, out sDescripcion, out sFechaInicio, out sFechaFin, out sHoraInicio, out sHoraFin);
                VsEditarActividad editarActividad = new VsEditarActividad(sNombre, sDescripcion, sFechaInicio, sFechaFin, sHoraInicio, sHoraFin); editarActividad.ShowDialog();
                if (editarActividad.CambiosGuardados)
                {
                    ctrActividad.TablaConsultarActividad(dgvActividad);
                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR UNA ACTIVIDAD.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        // FIN
    }
}

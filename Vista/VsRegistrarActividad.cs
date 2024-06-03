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
    public partial class VsRegistrarActividad : Form
    {
        private Validacion val = new Validacion();
        private CtrActividad ctrActividad = new CtrActividad();
        DateTime fechaActual = DateTime.Now;
        DateTime horaActual = DateTime.Now;

        public VsRegistrarActividad()
        {
            InitializeComponent();
            dtpFechaInicio.Value = fechaActual;
            dtpFechaFin.Value = fechaActual;
        }       

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCaracterEspecial(sender, e);
        }

        private void textDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCaracterEspecial(sender, e);
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string msj = "";
            string sNombre = textNombre.Text.Trim();
            string sDescripcion = textDescripcion.Text.Trim();
            string sFechaInicio = dtpFechaInicio.Text.Trim();
            string sFechaFin = dtpFechaFin.Text.Trim();
            string sHoraInicio = dtpHoraInicio.Text.Trim();
            string sHoraFin = dtpHoraFin.Text.Trim();

            msj = ctrActividad.IngresarActividad(sNombre, sDescripcion, sFechaInicio, sFechaFin, sHoraInicio, sHoraFin);
            MessageBox.Show(msj);

            if (msj.Contains("ACTIVIDAD REGISTRADA CORRECTAMENTE"))
            {
                textNombre.Text = "";
                textDescripcion.Text = "";
                dtpFechaInicio.Value = fechaActual;
                dtpFechaFin.Value = fechaActual;
                dtpHoraInicio.Value = horaActual;
                dtpHoraFin.Value = horaActual;
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        // FIN    
    }
}

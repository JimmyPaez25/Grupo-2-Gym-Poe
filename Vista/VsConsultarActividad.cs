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
    }
}

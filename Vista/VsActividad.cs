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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Vista
{
    public partial class VsActividad : Form
    {
        private CtrActividad ctrActividad = new CtrActividad();

        public VsActividad()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            VsRegistrarActividad vRegActividad = new VsRegistrarActividad(); vRegActividad.ShowDialog();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            VsConsultarActividad vConsActividad = null;
            if (ctrActividad.GetTotal() > 0)
            {
                vConsActividad = new VsConsultarActividad(); vConsActividad.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR: NO EXISTEN ACTIVIDADES REGISTRADAS.");
            }
        }

    // FIN
    }
}

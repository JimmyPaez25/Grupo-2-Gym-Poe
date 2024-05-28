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
    public partial class VsActividad : Form
    {
        public VsActividad()
        {
            InitializeComponent();
        }

        private void VsActividad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VsRegistrarActividad ra = new VsRegistrarActividad();
            ra.Visible = true;
        }
    }
}

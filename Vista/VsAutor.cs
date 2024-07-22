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
    public partial class VsAutor : Form
    {
        CtrAutor ctrAutor = new CtrAutor();

        public VsAutor()
        {
            InitializeComponent();
            ctrAutor.TablaConsultarAutor(dgvAutor, labelNombreSistema, labelFechaCreacion);
        }
    }
}

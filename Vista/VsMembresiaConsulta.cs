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
    public partial class VsMembresiaConsulta : Form
    {
        private CtrMembresia ctrMem = new CtrMembresia();
        public VsMembresiaConsulta()
        {
            InitializeComponent();
            ctrMem.LlenarGrid(dgvMembresia);
        }

        private void dgvMembresia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VsMembresiaConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnBM_Click(object sender, EventArgs e)
        {
            string filtro = txtBoxBM.Text.Trim();
            bool buscarPorCedula = radioBCM.Checked;
            ctrMem.TablaConsultarMebresiaFiltro(dgvMembresia, filtro, buscarPorCedula);
        }
    }
}

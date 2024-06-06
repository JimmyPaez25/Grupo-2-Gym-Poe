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
    public partial class VsEditarActividad : Form
    {
        private Validacion val = new Validacion();
        private CtrActividad ctrActividad = new CtrActividad();

        private string nombre;
        private string descripcion;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }

        public VsEditarActividad(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, TimeSpan horaInicio, TimeSpan horaFin)
        {
            InitializeComponent();
            Nombre = nombre;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            ctrActividad.PresentarDatosActividad(Nombre, Descripcion, FechaInicio, FechaFin, HoraInicio, HoraFin, textNombre, textDescripcion, dtpFechaInicio, dtpFechaFin, dtpHoraInicio, dtpHoraFin);
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCaracterEspecial(sender, e);
        }

        private void textDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCaracterEspecial(sender, e);
        }


        // FIN
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Control
{
    public class CtrActividad
    {
        private static List<Actividad> listaActividad = new List<Actividad>();

        public int GetTotal()
        {
            return listaActividad.Count;
        }

        public string IngresarActividad(string sNombre, string sDescripcion, string sFechaInicio, string sFechaFin, string sHoraInicio, string sHoraFin)
        {
            String msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            Actividad act = null;
            DateTime fechaInicio = val.ConvertirDateTime(sFechaInicio);
            DateTime fechaFin = val.ConvertirDateTime(sFechaFin);
            TimeSpan horaInicio = val.ConvertirTimeSpan(sHoraInicio);
            TimeSpan horaFin = val.ConvertirTimeSpan(sHoraFin);

            if (fechaInicio.Date == fechaFin.Date)
            {
                return "ERROR: FECHA INICIO NO PUEDE SER IGUAL A FECHA FIN.";
            }
            else if (horaInicio == horaFin)
            {
                return "ERROR: HORA INICIO NO PUEDE SER IGUAL A HORA FIN.";
            }
            else if (fechaFin < fechaInicio)
            {
                return "ERROR: FECHA FIN NO PUEDE SER ANTERIOR A FECHA INICIO.";
            }
            else if (ActividadExistente(sNombre))
            {
                return "ERROR: ACTIVIDAD YA REGISTRADA CON ESE NOMBRE.";
            }
            else if (string.IsNullOrEmpty(sNombre) || sNombre.Equals("") && string.IsNullOrEmpty(sDescripcion) || sDescripcion.Equals(""))
            {
                return "ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS.";
            }
            else
            {               
            act = new Actividad(sNombre, sDescripcion, fechaInicio, fechaFin, horaInicio, horaFin);
                listaActividad.Add(act);
                msj = act.ToString() + Environment.NewLine + "---ACTIVIDAD REGISTRADA CORRECTAMENTE---" + Environment.NewLine;
            }
            return msj;
        }

        public bool ActividadExistente(string nombre)
        {
            foreach (Actividad act in listaActividad)
            {
                if (act.Nombre == nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public void TablaConsultarActividad(DataGridView dgvActividad)
        {
            int i = 0;
            dgvActividad.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Actividad x in listaActividad)
            {
                if (x.Estado == 1)
                {
                    i = dgvActividad.Rows.Add();
                    dgvActividad.Rows[i].Cells["ClmNumero"].Value = i + 1;
                    dgvActividad.Rows[i].Cells["ClmEstado"].Value = x.Estado;
                    dgvActividad.Rows[i].Cells["ClmNombre"].Value = x.Nombre;
                    dgvActividad.Rows[i].Cells["ClmDescripcion"].Value = x.Descripcion;
                    dgvActividad.Rows[i].Cells["ClmFechaInicio"].Value = x.FechaInicio.ToString("d");
                    dgvActividad.Rows[i].Cells["ClmFechaFin"].Value = x.FechaFin.ToString("d");
                    dgvActividad.Rows[i].Cells["ClmHoraInicio"].Value = x.HoraInicio;
                    dgvActividad.Rows[i].Cells["ClmHoraFin"].Value = x.HoraFin;
                }
            }
        }

        public void Inactivar(DataGridView dgvActividad)
        {
            if (dgvActividad.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvActividad.SelectedRows[0].Index; // OBTIENE INDICE DE FILA SELECCIONADA
                if (filaSeleccionada >= 0)
                {
                    int clmId = (int)dgvActividad.Rows[filaSeleccionada].Cells["ClmNumero"].Value - 1; // OBTIENE NUMERO DE LA ACTIVIDAD
                    DialogResult resultado = MessageBox.Show("ESTAS SEGURO DE BORRAR ESTA ACTIVIDAD?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        listaActividad[clmId].Estado = 2; // ESTADO 2 = INACTIVO
                        TablaConsultarActividad(dgvActividad);
                        MessageBox.Show("BORRADO DE ACTIVIDAD EXITOSO.");
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR UNA ACTIVIDAD.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    // FIN
    }
}

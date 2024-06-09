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
        private DateTime fechaActual = DateTime.Now;
        private static List<Actividad> listaActividad = new List<Actividad>();

        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }
        public static List<Actividad> ListaActividad { get => listaActividad; set => listaActividad = value; }

        public CtrActividad()
        {
            if (ListaActividad.Count == 0)
            {
                ListaActividad.Add(new Actividad("ACTIVIDAD 1", "PESAS", DateTime.Now, DateTime.Now.AddDays(1), new TimeSpan(9, 0, 0), new TimeSpan(12, 0, 0)));
                ListaActividad.Add(new Actividad("ACTIVIDAD 2", "MANCUERNAS", DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), new TimeSpan(10, 0, 0), new TimeSpan(13, 0, 0)));
                ListaActividad.Add(new Actividad("ACTIVIDAD 3", "FLEXIONES", DateTime.Now.AddDays(4), DateTime.Now.AddDays(5), new TimeSpan(11, 0, 0), new TimeSpan(14, 0, 0)));
            }
        }

        public int GetTotal()
        {
            return ListaActividad.Count;
        }

        public string IngresarActividad(string sNombre, string sDescripcion, string sFechaInicio, string sFechaFin, string sHoraInicio, string sHoraFin)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
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
                ListaActividad.Add(act);
                msj = act.ToString() + Environment.NewLine + "---ACTIVIDAD REGISTRADA CORRECTAMENTE---" + Environment.NewLine;
            }
            return msj;
        }

        public bool ActividadExistente(string nombre)
        {
            foreach (Actividad act in ListaActividad)
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
            foreach (Actividad x in ListaActividad)
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
                    dgvActividad.Rows[i].Cells["ClmHoraInicio"].Value = x.HoraInicio.ToString(@"hh\:mm");
                    dgvActividad.Rows[i].Cells["ClmHoraFin"].Value = x.HoraFin.ToString(@"hh\:mm");
                }
            }
        }

        public void InactivarActividad(DataGridView dgvActividad)
        {
            if (dgvActividad.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvActividad.SelectedRows[0].Index; // OBTIENE INDICE DE FILA SELECCIONADA
                if (filaSeleccionada >= 0)
                {
                    int clmId = (int)dgvActividad.Rows[filaSeleccionada].Cells["ClmNumero"].Value - 1; // OBTIENE NUMERO DE LA ACTIVIDAD
                    DialogResult resultado = MessageBox.Show("ESTAS SEGURO DE BORRAR ESTA ACTIVIDAD?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (resultado == DialogResult.Yes)
                    {
                        ListaActividad[clmId].Estado = 2; // ESTADO 2 = INACTIVO
                        TablaConsultarActividad(dgvActividad);
                        MessageBox.Show("BORRADO DE ACTIVIDAD EXITOSO.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR UNA ACTIVIDAD.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TablaConsultarActividadNombreDescripcion(DataGridView dgvActividad, string filtro = "", bool buscarPorNombre = true)
        {
            int i = 0;
            dgvActividad.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Actividad x in ListaActividad)
            {
                if (x.Estado == 1 &&
                    (string.IsNullOrEmpty(filtro) ||
                    (buscarPorNombre && x.Nombre.Contains(filtro)) ||
                    (!buscarPorNombre && x.Descripcion.Contains(filtro))))
                {
                    i = dgvActividad.Rows.Add();
                    dgvActividad.Rows[i].Cells["ClmNumero"].Value = i + 1;
                    dgvActividad.Rows[i].Cells["ClmEstado"].Value = x.Estado;
                    dgvActividad.Rows[i].Cells["ClmNombre"].Value = x.Nombre;
                    dgvActividad.Rows[i].Cells["ClmDescripcion"].Value = x.Descripcion;
                    dgvActividad.Rows[i].Cells["ClmFechaInicio"].Value = x.FechaInicio.ToString("d");
                    dgvActividad.Rows[i].Cells["ClmFechaFin"].Value = x.FechaFin.ToString("d");
                    dgvActividad.Rows[i].Cells["ClmHoraInicio"].Value = x.HoraInicio.ToString(@"hh\:mm");
                    dgvActividad.Rows[i].Cells["ClmHoraFin"].Value = x.HoraFin.ToString(@"hh\:mm");
                }
            }
        }

        public string EditarActividad(string sNombreOriginal, string sNombre, string sDescripcion, string sFechaInicio, string sFechaFin, string sHoraInicio, string sHoraFin)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            DateTime fechaInicio = val.ConvertirDateTime(sFechaInicio);
            DateTime fechaFin = val.ConvertirDateTime(sFechaFin);
            TimeSpan horaInicio = val.ConvertirTimeSpan(sHoraInicio);
            TimeSpan horaFin = val.ConvertirTimeSpan(sHoraFin);

            if (string.IsNullOrEmpty(sNombre) || string.IsNullOrEmpty(sDescripcion))
            {
                return "ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS.";
            }
            else if (fechaInicio.Date == fechaFin.Date)
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
            else
            {
                Actividad actividadExistente = ListaActividad.Find(atv => atv.Nombre == sNombreOriginal); // BUSCAR NOMBRE ORIGINAL EN LISTA
                if (actividadExistente != null)
                {
                    if (actividadExistente.Nombre != sNombre) // SI NOMBRE ORIGINAL Y NUEVO SON DIFERENTES
                    {
                        if (ListaActividad.Any(atv => atv.Nombre == sNombre)) // BUSCAR SI NOMBRE NUEVO YA EXISTE
                        {
                            return "ERROR: YA EXISTE UNA ACTIVIDAD CON EL NUEVO NOMBRE.";
                        }
                        actividadExistente.Nombre = sNombre; // ASIGNAR NOMBRE NUEVO
                    }

                    // ACTUALIZA DATOS ACTIVIDAD
                    actividadExistente.Descripcion = sDescripcion;
                    actividadExistente.FechaInicio = fechaInicio;
                    actividadExistente.FechaFin = fechaFin;
                    actividadExistente.HoraInicio = horaInicio;
                    actividadExistente.HoraFin = horaFin;

                    msj = "ACTIVIDAD EDITADA CORRECTAMENTE";
                }
                else
                {
                    msj = "ERROR: NO SE PUDO ENCONTRAR LA ACTIVIDAD A EDITAR.";
                }
            }
            return msj;
        }

        public void TablaConsultarActividadPapelera(DataGridView dgvActividad)
        {
            int i = 0;
            dgvActividad.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Actividad x in ListaActividad)
            {
                if (x.Estado == 2)
                {
                    i = dgvActividad.Rows.Add();
                    dgvActividad.Rows[i].Cells["ClmNumero"].Value = i + 1;
                    dgvActividad.Rows[i].Cells["ClmEstado"].Value = x.Estado;
                    dgvActividad.Rows[i].Cells["ClmNombre"].Value = x.Nombre;
                    dgvActividad.Rows[i].Cells["ClmDescripcion"].Value = x.Descripcion;
                    dgvActividad.Rows[i].Cells["ClmFechaInicio"].Value = x.FechaInicio.ToString("d");
                    dgvActividad.Rows[i].Cells["ClmFechaFin"].Value = x.FechaFin.ToString("d");
                    dgvActividad.Rows[i].Cells["ClmHoraInicio"].Value = x.HoraInicio.ToString(@"hh\:mm");
                    dgvActividad.Rows[i].Cells["ClmHoraFin"].Value = x.HoraFin.ToString(@"hh\:mm");
                }
            }
        }

        public void RestaurarActividad(DataGridView dgvActividad)
        {
            if (dgvActividad.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvActividad.SelectedRows[0].Index; // OBTIENE EL ÍNDICE DE LA FILA SELECCIONADA
                if (filaSeleccionada >= 0)
                {
                    string nombreActividad = dgvActividad.Rows[filaSeleccionada].Cells["ClmNombre"].Value.ToString(); // OBTIENE EL NOMBRE DE LA ACTIVIDAD DE LA FILA SELECCIONADA
                    Actividad actividad = ListaActividad.FirstOrDefault(a => a.Nombre == nombreActividad);// BUSCA ACTIVIDAD EN LISTA POR NOMBRE

                    if (actividad != null)
                    {
                        DialogResult resultado = MessageBox.Show("ESTAS SEGURO DE RESTAURAR ESTA ACTIVIDAD?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            actividad.Estado = 1; // CAMBIA EL ESTADO A ACTIVO
                            TablaConsultarActividadPapelera(dgvActividad);
                            MessageBox.Show("ACTIVIDAD RESTAURADA EXITOSAMENTE.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE RESTAURAR UNA ACTIVIDAD.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RemoverActividad(DataGridView dgvActividad)
        {
            if (dgvActividad.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvActividad.SelectedRows[0].Index; // OBTIENE EL ÍNDICE DE LA FILA SELECCIONADA
                if (filaSeleccionada >= 0)
                {
                    string nombreActividad = dgvActividad.Rows[filaSeleccionada].Cells["ClmNombre"].Value.ToString(); // OBTIENE EL NOMBRE DE LA ACTIVIDAD DE LA FILA SELECCIONADA
                    Actividad actividad = ListaActividad.FirstOrDefault(a => a.Nombre == nombreActividad); // BUSCA ACTIVIDAD EN LISTA POR NOMBRE

                    if (actividad != null)
                    {
                        DialogResult resultado = MessageBox.Show("ESTAS SEGURO DE ELIMINAR PERMANENTEMENTE ESTA ACTIVIDAD?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (resultado == DialogResult.Yes)
                        {
                            ListaActividad.Remove(actividad);
                            dgvActividad.Rows.RemoveAt(filaSeleccionada);
                            for (int i = filaSeleccionada; i < dgvActividad.Rows.Count; i++)
                            {
                                dgvActividad.Rows[i].Cells["ClmNumero"].Value = i + 1;
                            }
                            MessageBox.Show("ACTIVIDAD ELIMINADA CORRECTAMENTE.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR DE FORMA PERMANENTE UNA ACTIVIDAD.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TablaConsultarActividadNombreDescripcionPapelera(DataGridView dgvActividad, string filtro = "", bool buscarPorNombre = true)
        {
            int i = 0;
            dgvActividad.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Actividad x in ListaActividad)
            {
                if (x.Estado == 2 &&
                    (string.IsNullOrEmpty(filtro) ||
                    (buscarPorNombre && x.Nombre.Contains(filtro)) ||
                    (!buscarPorNombre && x.Descripcion.Contains(filtro))))
                {
                    i = dgvActividad.Rows.Add();
                    dgvActividad.Rows[i].Cells["ClmNumero"].Value = i + 1;
                    dgvActividad.Rows[i].Cells["ClmEstado"].Value = x.Estado;
                    dgvActividad.Rows[i].Cells["ClmNombre"].Value = x.Nombre;
                    dgvActividad.Rows[i].Cells["ClmDescripcion"].Value = x.Descripcion;
                    dgvActividad.Rows[i].Cells["ClmFechaInicio"].Value = x.FechaInicio.ToString("d");
                    dgvActividad.Rows[i].Cells["ClmFechaFin"].Value = x.FechaFin.ToString("d");
                    dgvActividad.Rows[i].Cells["ClmHoraInicio"].Value = x.HoraInicio.ToString(@"hh\:mm");
                    dgvActividad.Rows[i].Cells["ClmHoraFin"].Value = x.HoraFin.ToString(@"hh\:mm");
                }
            }
        }

        public int GetTotalInactivas()
        {
            return ListaActividad.Count(act => act.Estado == 2);
        }

        public void PresentarDatosActividad(TextBox textNombre, TextBox textDescripcion, DateTimePicker dtpFechaInicio, DateTimePicker dtpFechaFin, DateTimePicker dtpHoraInicio, DateTimePicker dtpHoraFin, string nombreActividad)
        {
            //Actividad actividadSeleccionada = ExtraerNombreActividad(nombreActividad);
            Actividad actividadSeleccionada = listaActividad.Find(a => a.Nombre == nombreActividad);
            if (actividadSeleccionada != null)
            {
                textNombre.Text = actividadSeleccionada.Nombre;
                textDescripcion.Text = actividadSeleccionada.Descripcion;
                dtpFechaInicio.Value = actividadSeleccionada.FechaInicio;
                dtpFechaFin.Value = actividadSeleccionada.FechaFin;
                dtpHoraInicio.Value = DateTime.Today + actividadSeleccionada.HoraInicio;
                dtpHoraFin.Value = DateTime.Today + actividadSeleccionada.HoraFin;
            }
        }

        public Actividad ExtraerNombreActividad(string nombreActividad)
        {
            return listaActividad.Find(a => a.Nombre == nombreActividad);
        }
        // FIN
    }
}

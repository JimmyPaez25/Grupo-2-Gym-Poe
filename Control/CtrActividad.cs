using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    // FIN
    }
}

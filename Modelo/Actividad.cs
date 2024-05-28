using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Actividad
    {
        int id;
        int estado;
        string nombre;
        string descripcion;
        TimeSpan horaInicio;
        TimeSpan horaFin;
        DateTime fechaInicio;
        DateTime fechaFin;

        public Actividad(int id, int estado, string nombre, string descripcion, TimeSpan horaInicio, TimeSpan horaFin, DateTime fechaInicio, DateTime fechaFin)
        {
            this.id = id;
            this.estado = estado;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public int Id { get => id; set => id = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

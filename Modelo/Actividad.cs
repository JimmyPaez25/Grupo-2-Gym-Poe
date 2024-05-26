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
        int duracion;
        string ubicacion;
        DateTime horario;

        public Actividad(int id, int estado, string nombre, string descripcion, int duracion, string ubicacion, DateTime horario)
        {
            this.id = id;
            this.estado = estado;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.duracion = duracion;
            this.ubicacion = ubicacion;
            this.horario = horario;
        }

        public int Id { get => id; set => id = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public DateTime Horario { get => horario; set => horario = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

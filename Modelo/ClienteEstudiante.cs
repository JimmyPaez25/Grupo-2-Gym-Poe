using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClienteEstudiante : Cliente
    {
        string estudiante;
        public string Estudiante { get => estudiante; set => estudiante = value; }

        public ClienteEstudiante(string cedula, string nombre, string apellido, string fechaNacimiento, string telefono, string direccion, string estudiante) : 
                                 base (cedula, nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            Estudiante = estudiante;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Estudiante: " + Estudiante;
        }
    }
}

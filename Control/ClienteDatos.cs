using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
   
        public class ClienteDatos
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string FechaNacimiento { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public string Estado { get; set; }

            public ClienteDatos(string nombre, string apellido, string fechaNacimiento, string telefono, string direccion, string estado)
            {
                Nombre = nombre;
                Apellido = apellido;
                FechaNacimiento = fechaNacimiento;
                Telefono = telefono;
                Direccion = direccion;
                Estado = estado;
            }
        }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        String cedula;
        String nombre;
        String apellido;
        String fechaNacimiento;
        String telefono;
        String direccion;

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Cliente(string cedula, string nombre, string apellido, string fechaNacimiento, string telefono, string direccion)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return "> CEDULA: " + cedula + "\n> NOMBRE: " + nombre + "\n> APELLIDO: " + apellido + "\n> FECHA DE NACIMIENTO: " + fechaNacimiento +
                   "\n> TELEFONO: " + telefono + "\n> DIRECCION: " + direccion;
        }
        
    }
}

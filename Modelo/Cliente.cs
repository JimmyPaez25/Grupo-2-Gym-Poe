using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Cliente
    {
        int cedula;
        String nombre;
        String apellido;
        DateTime fechaNacimiento;
        int telefono;
        String direccion;
        char estudiante;

        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public char Estudiante { get => estudiante; set => estudiante = value; }

        public Cliente(int cedula, string nombre, string apellido, DateTime fechaNacimiento, int telefono, string direccion, char estudiante)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Direccion = direccion;
            Estudiante = estudiante;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        
    }
}

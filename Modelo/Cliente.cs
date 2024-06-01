using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        int cedula;
        String nombre;
        String apellido;
        string fechaNacimiento;
        int telefono;
        String direccion;
        String estudiante;

        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Estudiante { get => estudiante; set => estudiante = value; }

        public Cliente(int cedula, string nombre, string apellido, string fechaNacimiento, int telefono, string direccion, string estudiante)
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
            return "> CEDULA: " + cedula + "\n> NOMBRE: " + nombre + "\n> APELLIDO: " + apellido + "\n> FECHA DE NACIMIENTO: " + fechaNacimiento +
                   "\n> TELEFONO: " + telefono + "\n> DIRECCION: " + telefono + "\n> ESTUDIANTE: " + estudiante;
        }
        
    }
}

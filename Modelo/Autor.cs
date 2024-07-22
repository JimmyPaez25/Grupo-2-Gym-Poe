using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Autor
    {
        protected string nombreSistema;
        protected string nombreAutor;
        protected string email;
        protected int telefono;
        protected DateTime fechaCreacion;
        protected byte[] foto;

        public Autor(string nombreSistema, string nombreAutor, string email, int telefono, DateTime fechaCreacion, byte[] foto)
        {
            NombreSistema = nombreSistema;
            NombreAutor = nombreAutor;
            Email = email;
            Telefono = telefono;
            FechaCreacion = fechaCreacion;
            Foto = foto;
        }

        public Autor() { }

        public string NombreSistema { get => nombreSistema; set => nombreSistema = value; }
        public string NombreAutor { get => nombreAutor; set => nombreAutor = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public override string ToString()
        {
            return "-> NOMBRE SISTEMA: " + nombreSistema + Environment.NewLine +
                   "-> NOMBRE AUTOR: " + nombreAutor + Environment.NewLine +
                   "-> EMAIL: " + email + Environment.NewLine +
                   "-> TELEFONO: " + telefono + Environment.NewLine;
        }


    }
}

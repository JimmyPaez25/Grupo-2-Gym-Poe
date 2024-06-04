using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Control
{
    public class CtrMembresia
    {
        private static List<Membresia> listaMembresia = new List<Membresia>();

        public static List<Membresia> ListaMembresia { get => listaMembresia; set => listaMembresia = value; }

        public int GetTotal()
        {
            return ListaMembresia.Count;
        }

    }
}

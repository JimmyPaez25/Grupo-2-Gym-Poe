using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Control
{
    internal class CtrCliente
    {
        private static List<Cliente> listaCliente = new List<Cliente>();

        public static List<Cliente> ListaCliente { get => listaCliente; set => listaCliente = value; }

        public int GetTotal()
        {
            return listaCliente.Count;
        }
    }
}

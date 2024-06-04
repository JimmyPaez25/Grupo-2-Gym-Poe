using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Control
{
    public class CtrFactura
    {

        public List<Cliente> listaCli = new List<Cliente>();



        public string GenerarFactura()
        {
            return generarCodigoUnico();
        }

        private string generarCodigoUnico()
        {
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var Serie = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                int indice = random.Next(caracteresPermitidos.Length);
                Serie.Append(caracteresPermitidos[indice]);
            }

            return Serie.ToString();
        }





        public List<Cliente> GetClientes()
        {
            listaCli.Add(new Cliente("0928961044", "Pepe", " ", " ", " ", " ", " "));
            listaCli.Add(new Cliente("0928961066", "Arepa", " ", " ", " ", " ", " "));
            listaCli.Add(new Cliente("0928961055", "Juan", " ", " ", " ", " ", " "));

            return listaCli;
        }

        public string obtenerNombre(string numeroCedula)
        {
            foreach (Cliente cliente in listaCli)
            {
                if (cliente.Cedula.ToString() == numeroCedula)
                {
                    return cliente.Nombre;
                }
            }
            return "No se encontró un cliente con ese número de cédula.";
        }





    }


}


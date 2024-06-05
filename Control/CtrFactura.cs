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


        //Esto es para factura
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


    }



    public class CtClient
    {
        //Esto es para clientes

        public List<Cliente> lstccliente = new List<Cliente>();

        public List<Cliente> GetCliente()
        {
            lstccliente.Add(new Cliente("0928961044", "Pepe", " ", " ", " ", " ", " "));
            lstccliente.Add(new Cliente("0928961066", "Arepa", " ", " ", " ", " ", " "));
            lstccliente.Add(new Cliente("0928961055", "Juan", " ", " ", " ", " ", " "));

            return lstccliente;
        }

        public string obtenerNombre(string numeroCedula)
        {
            foreach (Cliente cliente in lstccliente)
            {
                if (cliente.Cedula.ToString() == numeroCedula)
                {
                    return cliente.Nombre;
                    return cliente.Apellido;
                    return cliente.FechaNacimiento;
                    return cliente.Telefono;
                    return cliente.Direccion;
                    return cliente.Estado;
                }
            }
            return "No se encontró un cliente con ese número de cédula.";
        }
    }


}


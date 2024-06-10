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
            for (int i = 0; i < 10; i++)
            {
                int indice = random.Next(caracteresPermitidos.Length);
                Serie.Append(caracteresPermitidos[indice]);
            }

            return Serie.ToString();
        }










    }



}


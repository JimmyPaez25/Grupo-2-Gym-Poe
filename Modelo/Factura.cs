using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Factura
    {

        int numfactura;
        string serie;


        public Factura()
        {
            Numfactura = 0;
            Serie = string.Empty;
        }

        public Factura(int numfactura, string serie)
        {
            this.Numfactura = numfactura;
            this.Serie = serie;
        }

        public int Numfactura { get => numfactura; set => numfactura = value; }
        public string Serie { get => serie; set => serie = value; }


    }
}

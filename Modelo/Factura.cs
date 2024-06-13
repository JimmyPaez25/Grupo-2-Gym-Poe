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
        int estadofact;


        public Factura()
        {
            Numfactura = 0;
            Serie = string.Empty;
        }

        public Factura(int numfactura, string serie)
        {
            this.estadofact = 1;
            Numfactura = numfactura;
            Serie = serie;
        }

        public int Estadofact { get => estadofact; set => estadofact = value; }
        public int Numfactura { get => numfactura; set => numfactura = value; }
        public string Serie { get => serie; set => serie = value; }

    }
}

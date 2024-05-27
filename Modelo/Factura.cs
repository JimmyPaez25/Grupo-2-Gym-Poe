using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Factura
    {
        int numfactura;
        int serie;

        public Factura(int numfactura, int serie)
        {
            this.Numfactura = numfactura;
            this.Serie = serie;
        }

        public int Numfactura { get => numfactura; set => numfactura = value; }
        public int Serie { get => serie; set => serie = value; }


        public override string ToString()
        {
            return base.ToString();
        }


    }
}

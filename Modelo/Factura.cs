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
        string preciofact;
        string descuentofact;
        string iva;
        string total;
        int estadofact;


        public Factura()
        {
            Numfactura = 0;
            Serie = string.Empty;
            Preciofact = string.Empty;
            Descuentofact = string.Empty;
            iva = string.Empty;
            total = string.Empty;

        }

        public Factura(int numfactura, string serie, string preciofact, string descuentofact, string iva, string total)
        {
            this.estadofact = 1;
            Numfactura = numfactura;
            Serie = serie;
            Preciofact = preciofact;
            Descuentofact = descuentofact;
            Iva = iva;
            Total = total;
        }

        public int Estadofact { get => estadofact; set => estadofact = value; }

        public int Numfactura { get => numfactura; set => numfactura = value; }
        public string Preciofact { get => preciofact; set => preciofact = value; }
        public string Descuentofact { get => descuentofact; set => descuentofact = value; }
        public string Iva { get => iva; set => iva = value; }
        public string Total { get => total; set => total = value; }
        public string Serie { get => serie; set => serie = value; }
    }
}

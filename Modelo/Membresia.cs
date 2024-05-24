using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Membresia
    {
        int plan;
        string promocion;
        double descuento;

        public Membresia(int plan, string promocion, double descuento)
        {
            this.Plan = plan;
            this.Promocion = promocion;
            this.Descuento = descuento;
        }

        public int Plan { get => plan; set => plan = value; }
        public string Promocion { get => promocion; set => promocion = value; }
        public double Descuento { get => descuento; set => descuento = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

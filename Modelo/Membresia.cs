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
        string fechaInicio;
        string fechaFin;
        string promocion;
        double descuento;

        public Membresia(int plan, string fechaInicio, string fechaFinstring, string promocion, double descuento)
        {
            this.Plan = plan;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Descuento = descuento;
            this.Promocion = promocion;
            
        }

        public int Plan { get => plan; set => plan = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Promocion { get => promocion; set => promocion = value; }
        public double Descuento { get => descuento; set => descuento = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

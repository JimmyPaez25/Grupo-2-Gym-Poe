using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Membresia
    {
        string plan;
        DateTime fechaInicio;
        DateTime fechaFin;
        string promocion;
        double descuento;
        string detallePromocion;
        string cedulaCliente;
 


        public Membresia(string plan, DateTime fechaInicio, DateTime fechaFin, string promocion, double descuento, string detallePromocion, string cedulaCliente) 
        {
            this.Plan = plan;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Descuento = descuento;
            this.Promocion = promocion;
            this.detallePromocion = detallePromocion;
            this.CedulaCliente = cedulaCliente;
    
        }

        public string Plan { get => plan; set => plan = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Promocion { get => promocion; set => promocion = value; }
        public string DetallePromocion { get => detallePromocion; set => detallePromocion = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public string CedulaCliente { get => cedulaCliente; set => cedulaCliente = value; }

        public override string ToString()
        {
            return "-> PlAN: " + plan + Environment.NewLine +
                   "-> FECHA INICIO: " + fechaInicio.ToString("d") + Environment.NewLine +
                   "-> FECHA FIN: " + fechaFin.ToString("d") + Environment.NewLine +
                   "-> PROMOCION: " + promocion + Environment.NewLine +
                   "-> DETALLES PROMOCION: " + Environment.NewLine + detallePromocion + Environment.NewLine +
                   "-> DESCUENTO: " + descuento + Environment.NewLine;


        }
    }
}

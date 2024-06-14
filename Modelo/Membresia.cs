
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
        string descuento;
        string detallePromocion;
        string cedulaCliente;
        double precio;

 


        public Membresia(string plan, DateTime fechaInicio, DateTime fechaFin, string promocion, string descuento, string detallePromocion, string cedulaCliente, double precio) 
        {
            this.Plan = plan;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.Promocion = promocion;
            this.Descuento = descuento;
            this.detallePromocion = detallePromocion;
            this.CedulaCliente = cedulaCliente;
            this.precio = precio;

 
    
        }

        public string Plan { get => plan; set => plan = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Promocion { get => promocion; set => promocion = value; }
        public string DetallePromocion { get => detallePromocion; set => detallePromocion = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string CedulaCliente { get => cedulaCliente; set => cedulaCliente = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return ">PLAN DE MEMBRESIA: " + plan + Environment.NewLine +
                   ">FECHA INICIO: " + fechaInicio.ToString("d") + Environment.NewLine +
                   ">FECHA FIN: " + fechaFin.ToString("d") + Environment.NewLine +
                   ">PROMOCION: " + promocion + Environment.NewLine +
                   ">DETALLES PROMOCION: " + detallePromocion + Environment.NewLine +
                   ">DESCUENTO: " + descuento + Environment.NewLine +
                   ">PRECIO: " + precio + Environment.NewLine +
                   ">CEDULA CLIENTE: " + cedulaCliente + Environment.NewLine;
        }
    }
}

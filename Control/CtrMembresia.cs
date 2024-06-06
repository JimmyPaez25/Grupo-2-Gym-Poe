using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Control
{
    public class CtrMembresia
    {
        private DateTime fechaActual = DateTime.Now;
        private static List<Membresia> listaMembresia = new List<Membresia>();

        public static List<Membresia> ListaMembresia { get => listaMembresia; set => listaMembresia = value; }
        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }

        //private List<Cliente> listaCli;
        //private CtrCliente ctrCliente;

        //public CtrMembresia(List<Cliente> listaClientes)
        //{
        //    listaCli = listaClientes;
        //}
        public int GetTotal()
        {
            return ListaMembresia.Count;
        }
        public string IngresarMembresia(string plan, string sFechaInicio, string sFechaFin, string promocion, string sDescuento, string detallePromocion/*, string cedula*/)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            Membresia mem = null;
            //CtrMembresia controlMembresia = new CtrMembresia(CtrCliente.ListaCli);
            DateTime fechaInicio = val.ConvertirDateTime(sFechaInicio);
            DateTime fechaFin = val.ConvertirDateTime(sFechaFin);
            double descuento = val.ConvertirDouble(sDescuento);



            if (fechaInicio.Date == fechaFin.Date)
            {
                return "ERROR: FECHA INICIO NO PUEDE SER IGUAL A FECHA FIN.";
            }
            else if (fechaFin < fechaInicio)
            {
                return "ERROR: FECHA FIN NO PUEDE SER ANTERIOR A FECHA INICIO.";
            }
            //else if (MembresiaExistente(cedula))
            //{
            //    return "ERROR: MEMBRESIA YA REGISTRADA.";
            //}
            else if (string.IsNullOrEmpty(plan) || plan.Equals("") && string.IsNullOrEmpty(promocion) || promocion.Equals("") && string.IsNullOrEmpty(detallePromocion) || detallePromocion.Equals("") && (descuento == 0))
            {
                return "ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS.";
            }
            else
            {
                mem = new Membresia(plan, fechaInicio, fechaFin, promocion, descuento, detallePromocion);
                ListaMembresia.Add(mem);
                msj = mem.ToString() + Environment.NewLine + "MEMBRESIA REGISTRADA CORRECTAMENTE" + Environment.NewLine;
            }
            return msj;
        }
        //public bool MembresiaExistente(string cedula)
        //{
        //    foreach (Cliente men in listaCli)
        //    {
        //        if (men.Cedula == cedula)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

    }
}

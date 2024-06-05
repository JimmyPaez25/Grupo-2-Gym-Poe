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
        private static List<Membresia> listaMembresia = new List<Membresia>();

        public static List<Membresia> ListaMembresia { get => listaMembresia; set => listaMembresia = value; }

        public int GetTotal()
        {
            return ListaMembresia.Count;
        }
        public string IngresarMembresia(string sPlan, string sFechaInicio, string sFechaFin, string promocion, string sDescuento, string detallePromocion)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            Membresia mem = null;
            DateTime fechaInicio = val.ConvertirDateTime(sFechaInicio);
            DateTime fechaFin = val.ConvertirDateTime(sFechaFin);
            double descuento = val.ConvertirDouble(sDescuento);
            int plan = val.ConvertirEntero(sPlan);


            if (fechaInicio.Date == fechaFin.Date)
            {
                return "ERROR: FECHA INICIO NO PUEDE SER IGUAL A FECHA FIN.";
            }
            else if (fechaFin < fechaInicio)
            {
                return "ERROR: FECHA FIN NO PUEDE SER ANTERIOR A FECHA INICIO.";
            }
            //else if (MembresiaExistente(sCedula))
            //{
            //    return "ERROR: MEMBRESIA YA REGISTRADA CON ESE NOMBRE.";
            //}
            //else if (string.IsNullOrEmpty(sCedula) || sNombre.Equals("") && string.IsNullOrEmpty(sDescripcion) || sDescripcion.Equals(""))
            //{
            //    return "ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS.";
            //}
            else
            {
                mem = new Membresia(plan, fechaInicio, fechaFin, promocion, descuento, detallePromocion);
                ListaMembresia.Add(mem);
                msj = mem.ToString() + Environment.NewLine + "---MEMBRESIA REGISTRADA CORRECTAMENTE---" + Environment.NewLine;
            }
            return msj;
        }
        //public bool MembresiaExistente(string cedula)
        //{
        //    foreach (Cliente men in listacli)
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

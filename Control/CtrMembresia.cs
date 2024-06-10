using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;

namespace Control
{
    public class CtrMembresia
    {
        private DateTime fechaActual = DateTime.Now;
        private static List<Membresia> listaMembresia = new List<Membresia>();
        private static List<Cliente> listaCli = new List<Cliente>();

        public static List<Membresia> ListaMembresia { get => listaMembresia; set => listaMembresia = value; }
        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }
        public static List<Cliente> ListaCli { get => listaCli; set => listaCli = value; }


   

        //public CtrMembresia(List<Cliente> listaClientes)
        //{
        //    listaCli = listaClientes;
        //}
        public int GetTotal()
        {
            return ListaMembresia.Count;
        }
        public string IngresarMembresia(string plan, string sFechaInicio, string sFechaFin, string promocion, string descuento, string detallePromocion, string cedulaCliente, string Sprecio)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            Membresia mem = null;
            //CtrMembresia controlMembresia = new CtrMembresia(CtrCliente.ListaCli);
            double precio = val.ConvertirDouble(Sprecio);
            DateTime fechaInicio = val.ConvertirDateTime(sFechaInicio);
            DateTime fechaFin = val.ConvertirDateTime(sFechaFin);

            



            if (fechaInicio.Date == fechaFin.Date)
            {
                return "ERROR: FECHA INICIO NO PUEDE SER IGUAL A FECHA FIN.";
            }
            else if (fechaFin < fechaInicio)
            {
                return "ERROR: FECHA FIN NO PUEDE SER ANTERIOR A FECHA INICIO.";
            }
            else if (MembresiaExistente(cedulaCliente))
            {
                return "ERROR: MEMBRESIA YA REGISTRADA.";
            }
            else if (string.IsNullOrEmpty(plan) || plan.Equals("") && string.IsNullOrEmpty(promocion) || promocion.Equals("") && string.IsNullOrEmpty(detallePromocion) || detallePromocion.Equals("") && string.IsNullOrEmpty(descuento) || descuento.Equals(""))
            {
                return "ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS.";
            }
            else
            {
                mem = new Membresia(plan, fechaInicio, fechaFin, promocion, descuento, detallePromocion,cedulaCliente, precio);
                ListaMembresia.Add(mem);
                msj = mem.ToString() + Environment.NewLine + "MEMBRESIA REGISTRADA CORRECTAMENTE" + Environment.NewLine;
            }
            return msj;
        }
        public bool MembresiaExistente(string cedula)
        {
            foreach (Cliente men in ListaCli)
            {
                if (men.Cedula == cedula)
                {
                    return true;
                }
            }
            return false;
        }
        public void Llenar(TextBox txtBoxLMA, string cedula)
        {
            txtBoxLMA.Text = "";
            List<Membresia> membresiaEncontrados = ListaMembresia.Where(abc => abc.CedulaCliente.Contains(cedula)).ToList();

            if (membresiaEncontrados.Count > 0)
            {
                foreach (var Membresia in membresiaEncontrados)
                {
                    txtBoxLMA.Text += Membresia.ToString() + Environment.NewLine;
                }
            }
            else
            {
                txtBoxLMA.Text = "No se encontraron clientes con la cédula especificada.";
            }
        }
        public void ExtraerDatosTablaMembresia(DataGridView dgvClientes, out string cedula)
        {
            DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0]; 
            cedula = filaSeleccionada.Cells["ClmCedula"].Value.ToString();
        }
    }
}

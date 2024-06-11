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
        CtrCliente CtrCliente = new CtrCliente();
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

        public string IngresarMembresia(string plan, string SFInicio, string SFFin, string promocion, string descuento, string detallePromocion, string cedulaCliente,string Sprecio)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            Membresia mem = null;
            //CtrMembresia controlMembresia = new CtrMembresia(CtrCliente.ListaCli);
            double precio = val.ConvertirDouble(Sprecio);
            DateTime fechaInicio = val.ConvertirDateTime(SFInicio);
            DateTime fechaFin = val.ConvertirDateTime(SFFin);

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

        public void LlenarGrid(DataGridView dgvMembresia)
        {
            // Limpiar filas si las hay 
            dgvMembresia.Rows.Clear();

            // Iterar sobre la lista de membresías
            foreach (Membresia x in ListaMembresia)
            {
                int i = dgvMembresia.Rows.Add();
                dgvMembresia.Rows[i].Cells["clmPREM"].Value = x.Precio;
                dgvMembresia.Rows[i].Cells["clmCedula"].Value = x.CedulaCliente;
                dgvMembresia.Rows[i].Cells["clmPM"].Value = x.Plan;
                dgvMembresia.Rows[i].Cells["clmFIM"].Value = x.FechaInicio.ToString("d");
                dgvMembresia.Rows[i].Cells["clmFFM"].Value = x.FechaFin.ToString("d");
                dgvMembresia.Rows[i].Cells["clmP"].Value = x.Promocion;
                dgvMembresia.Rows[i].Cells["clmDPM"].Value = x.DetallePromocion;
                dgvMembresia.Rows[i].Cells["clmDM"].Value = x.Descuento;

            }
        }
        public void TablaConsultarMebresiaFiltro(DataGridView dgvMembresia, string filtro = "", bool buscarPorCedula = true)
        {
            int i = 0;
            dgvMembresia.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Membresia x in ListaMembresia)
            {
                if  (string.IsNullOrEmpty(filtro) ||
                    (buscarPorCedula && x.CedulaCliente.Contains(filtro)) ||
                    (!buscarPorCedula && x.DetallePromocion.Contains(filtro)))
                {
                    i = dgvMembresia.Rows.Add();
                    dgvMembresia.Rows[i].Cells["clmPREM"].Value = x.Precio;
                    dgvMembresia.Rows[i].Cells["clmCedula"].Value = x.CedulaCliente;
                    dgvMembresia.Rows[i].Cells["clmPM"].Value = x.Plan;
                    dgvMembresia.Rows[i].Cells["clmFIM"].Value = x.FechaInicio.ToString("d");
                    dgvMembresia.Rows[i].Cells["clmFFM"].Value = x.FechaFin.ToString("d");
                    dgvMembresia.Rows[i].Cells["clmP"].Value = x.Promocion;
                    dgvMembresia.Rows[i].Cells["clmDPM"].Value = x.DetallePromocion;
                    dgvMembresia.Rows[i].Cells["clmDM"].Value = x.Descuento;
                }
            }
        }
    }
}

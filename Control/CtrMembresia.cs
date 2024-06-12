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

            if (string.IsNullOrEmpty(plan) || plan.Equals(""))
            {
                return "ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS.";
            }
            else if (fechaInicio.Date == fechaFin.Date)
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
            else if (promocion != "SI" && promocion != "NO")
            {
                return "ERROR: DEBE SELECCIONAR UNA OPCIÓN VÁLIDA PARA PROMOCIÓN (SI O NO).";
            }
            else if (string.IsNullOrEmpty(Sprecio) || precio <= 0)
            {
                return "ERROR: EL PRECIO NO PUEDE ESTAR VACÍO O SER CERO.";
            }
            else if (string.IsNullOrEmpty(plan) || plan.Equals(""))
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
                dgvMembresia.Rows[i].Cells["clmPREM"].Value = x.Precio.ToString() + "$";
                dgvMembresia.Rows[i].Cells["clmCedula"].Value = x.CedulaCliente;
                dgvMembresia.Rows[i].Cells["clmPM"].Value = x.Plan;
                dgvMembresia.Rows[i].Cells["clmFIM"].Value = x.FechaInicio.ToString("d");
                dgvMembresia.Rows[i].Cells["clmFFM"].Value = x.FechaFin.ToString("d");
                dgvMembresia.Rows[i].Cells["clmP"].Value = x.Promocion;
                dgvMembresia.Rows[i].Cells["clmDPM"].Value = x.DetallePromocion;
                dgvMembresia.Rows[i].Cells["clmDM"].Value = x.Descuento.ToString() + "%";

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
                    dgvMembresia.Rows[i].Cells["clmPREM"].Value = x.Precio.ToString() + "$";
                    dgvMembresia.Rows[i].Cells["clmCedula"].Value = x.CedulaCliente;
                    dgvMembresia.Rows[i].Cells["clmPM"].Value = x.Plan;
                    dgvMembresia.Rows[i].Cells["clmFIM"].Value = x.FechaInicio.ToString("d");
                    dgvMembresia.Rows[i].Cells["clmFFM"].Value = x.FechaFin.ToString("d");
                    dgvMembresia.Rows[i].Cells["clmP"].Value = x.Promocion;
                    dgvMembresia.Rows[i].Cells["clmDPM"].Value = x.DetallePromocion;
                    dgvMembresia.Rows[i].Cells["clmDM"].Value = x.Descuento.ToString()+ "%";
                }
            }
        }
        public string editarMembresia(string nombrePlan, string planE, string SFInicioE, string SFFinE, string promocionE, string descuentoE, string detallePromocionE, string cedulaCliente, string SprecioE)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            Membresia mem = null;
            double precio = val.ConvertirDouble(SprecioE);
            DateTime fechaInicio = val.ConvertirDateTime(SFInicioE);
            DateTime fechaFin = val.ConvertirDateTime(SFFinE);

            if (string.IsNullOrEmpty(planE) || planE.Equals(""))
            {
                return "ERROR: NO PUEDEN EXISTIR CAMPOS VACIOS.";
            }
            else if (fechaInicio.Date == fechaFin.Date)
            {
                return "ERROR: FECHA INICIO NO PUEDE SER IGUAL A FECHA FIN.";
            }
            else if (fechaFin < fechaInicio)
            {
                return "ERROR: FECHA FIN NO PUEDE SER ANTERIOR A FECHA INICIO.";
            }
            else if (promocionE != "SI" && promocionE != "NO")
            {
                return "ERROR: DEBE SELECCIONAR UNA OPCIÓN VÁLIDA PARA PROMOCIÓN (SI O NO).";
            }
            else if (string.IsNullOrEmpty(SprecioE) || precio <= 0)
            {
                return "ERROR: EL PRECIO NO PUEDE ESTAR VACÍO O SER CERO.";
            }
            else
            {
                Membresia membresiaExistente = ListaMembresia.Find(atv => atv.Plan == nombrePlan); // BUSCAR NOMBRE ORIGINAL EN LISTA
                if (membresiaExistente != null)
                {
                    if (membresiaExistente.Plan != planE) // SI NOMBRE ORIGINAL Y NUEVO SON DIFERENTES
                    {
                        if (ListaMembresia.Any(atv => atv.Plan == planE)) // BUSCAR SI NOMBRE NUEVO YA EXISTE
                        {
                            return "ERROR: YA EXISTE UNA MEMBRESIA CON EL NUEVO NOMBRE.";
                        }
                        membresiaExistente.Plan = planE; // ASIGNAR NOMBRE NUEVO
                    }

                    // ACTUALIZA DATOS 
                    membresiaExistente.FechaInicio = fechaInicio;
                    membresiaExistente.FechaFin = fechaFin;
                    membresiaExistente.Promocion = promocionE;
                    membresiaExistente.DetallePromocion = detallePromocionE;
                    membresiaExistente.Descuento = descuentoE;
                    membresiaExistente.CedulaCliente = cedulaCliente;
                    membresiaExistente.Precio = precio;

                    msj = "MEMBRESIA EDITADA CORRECTAMENTE";
                }
                else
                {
                    msj = "ERROR: NO SE PUDO ENCONTRAR LA MEMBRESIA A EDITAR.";
                }
            }
            return msj;
        }
        public void PresentarDatosMembresia(TextBox txtBoxME, DateTimePicker dateTPFIE, DateTimePicker dateTPFFE, ComboBox comboBoxPE, TextBox txtBoxDPE, TextBox txtBoxDE, TextBox txtBoxPEM, string nombrePlan)
        {
            Membresia membresiaSeleccionada = ListaMembresia.Find(a => a.Plan == nombrePlan);
            if (membresiaSeleccionada != null)
            {
                txtBoxME.Text = membresiaSeleccionada.Plan;
                dateTPFIE.Value = membresiaSeleccionada.FechaInicio;
                dateTPFIE.Value = membresiaSeleccionada.FechaFin;
                comboBoxPE.Text = membresiaSeleccionada.Promocion;
                txtBoxDPE.Text = membresiaSeleccionada.DetallePromocion;
                txtBoxDE.Text = membresiaSeleccionada.Descuento;
                txtBoxPEM.Text = membresiaSeleccionada.Precio.ToString();
            }
        }
        public void eliminarMembresia(DataGridView dgvMembresia)
        {
            if (dgvMembresia.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvMembresia.SelectedRows[0].Index; // OBTIENE EL ÍNDICE DE LA FILA SELECCIONADA
                if (filaSeleccionada >= 0)
                {
                    string nombrePlan = dgvMembresia.Rows[filaSeleccionada].Cells["clmPM"].Value.ToString(); 
                    Membresia membresia = ListaMembresia.FirstOrDefault(a => a.Plan == nombrePlan); 

                    if (membresia != null)
                    {
                        DialogResult resultado = MessageBox.Show("ESTAS SEGURO DE ELIMINAR PERMANENTEMENTE ESTA MEMBRESIA?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (resultado == DialogResult.Yes)
                        {
                            ListaMembresia.Remove(membresia);
                            dgvMembresia.Rows.RemoveAt(filaSeleccionada);
                            MessageBox.Show("MEMBRESIA ELIMINADA CORRECTAMENTE.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR DE FORMA PERMANENTE UNA MEMBRESIA.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

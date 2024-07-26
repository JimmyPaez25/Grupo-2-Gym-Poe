using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;
using Dato;

namespace Control
{
    public class CtrMembresia
    {
        Conexion conn = new Conexion();
        DatoMembresia dtMembresia = new DatoMembresia();

        CtrCliente ctrCliente = new CtrCliente();
        private DateTime fechaActual = DateTime.Now;
        private static List<Membresia> listaMembresia = new List<Membresia>();
        private static List<Cliente> listaCli = new List<Cliente>();

        public static List<Membresia> ListaMembresia { get => listaMembresia; set => listaMembresia = value; }
        public DateTime FechaActual { get => fechaActual; set => fechaActual = value; }
        public static List<Cliente> ListaCli { get => listaCli; set => listaCli = value; }


        //public int GetTotal()
        //{
        //    return ListaMembresia.Count;
        //}

        //public CtrMembresia()
        //{
        //    if (ListaMembresia.Count == 0)
        //    {
        //        ListaMembresia.Add(new Membresia("Plan Basico", new DateTime(2021, 1, 1), new DateTime(2021, 12, 31), "NO", 0, "No aplica", "123456789", 100));
        //        ListaMembresia.Add(new Membresia("Plan Premium", new DateTime(2021, 1, 1), new DateTime(2021, 12, 31), "SI", 10, "Promoción estudiante", "987654321", 200));
        //        ListaMembresia.Add(new Membresia("Plan Premium #1", new DateTime(2021, 1, 1), new DateTime(2021, 12, 31), "SI", 20, "Promocion Gym Bro", "123456789", 300));
        //        ListaMembresia.Add(new Membresia("Plan Basico #2", new DateTime(2021, 1, 1), new DateTime(2021, 12, 31), "NO", 0, "No aplica", "987654321", 100));

        //    }
        //}
        public string IngresarMembresia(string plan, string SFInicio, string SFFin, string promocion, string Sdescuento, string detallePromocion, string cedulaCliente,string Sprecio)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            Membresia mem = null;
            //CtrMembresia controlMembresia = new CtrMembresia(CtrCliente.ListaCli);
            double precio = val.ConvertirDouble(Sprecio);
            int descuento = val.ConvertirEntero(Sdescuento);

            DateTime fechaInicio = val.ConvertirDateTime(SFInicio);
            DateTime fechaFin = val.ConvertirDateTime(SFFin);

            string idCliente = SelectClienteBD(cedulaCliente);
            Console.WriteLine(idCliente);
            int idCli = val.ConvertirEntero(idCliente);
            Console.WriteLine(idCli);

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
                mem = new Membresia(plan, fechaInicio, fechaFin, promocion, detallePromocion, descuento, precio, idCli);
                //ListaMembresia.Add(mem);
                IngresarMembresiaBD(mem);
                msj = mem.ToString() + Environment.NewLine + "MEMBRESIA REGISTRADA CORRECTAMENTE" + Environment.NewLine;
            }
            return msj;
        }
        public void IngresarMembresiaBD(Membresia mem)
        {
            string msj = string.Empty;
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                msj = dtMembresia.InsertMembresia(mem, conn.Connect);
                if (msj[0] == '0')
                {
                    MessageBox.Show("ERROR INESPERADO: " + msj);
                }
            }
            else if (msjBD[0] == '0')
            {
                MessageBox.Show("ERROR: " + msjBD);
            }
            conn.CerrarConexion();
        }

        //
        // CONSULTAR LIST - BD
        //
        public int GetTotal()
        {
            ListaMembresia = TablaConsultarMembresiaBD(); // BASE DE DATOS
            return ListaMembresia.Count;
        }

        public List<Membresia> TablaConsultarMembresiaBD()
        {
            List<Membresia> membresias = new List<Membresia>();
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                membresias = dtMembresia.SelectMembresias(conn.Connect);
            }
            else if (msjBD[0] == '0')
            {
                MessageBox.Show("ERROR: " + msjBD);
            }
            conn.CerrarConexion();
            return membresias;
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


        public string SelectClienteBD(string cedulaCliente)
        {
            string msj = string.Empty;
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                try
                {
                    string idCliente = dtMembresia.SelectCliente(conn.Connect, cedulaCliente);
                    if (!string.IsNullOrEmpty(idCliente))
                    {
                        msj = idCliente;
                    }
                    else
                    {
                        msj = "Cliente no encontrado.";
                        Console.WriteLine(msj);
                    }
                }
                catch (Exception ex)
                {
                    msj = "ERROR INESPERADO: " + ex.Message;
                    MessageBox.Show(msj);
                }
                finally
                {
                    conn.CerrarConexion();
                }
            }
            else if (msjBD[0] == '0')
            {
                msj = "ERROR: " + msjBD;
                MessageBox.Show(msj);
            }

            return msj;
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
                //dgvMembresia.Rows[i].Cells["clmCedula"].Value = x.CedulaCliente;
                dgvMembresia.Rows[i].Cells["clmPM"].Value = x.Plan;
                dgvMembresia.Rows[i].Cells["clmFIM"].Value = x.FechaInicio.ToString("d");
                dgvMembresia.Rows[i].Cells["clmFFM"].Value = x.FechaFin.ToString("d");
                dgvMembresia.Rows[i].Cells["clmP"].Value = x.Promocion;
                dgvMembresia.Rows[i].Cells["clmDPM"].Value = x.DetallePromocion;
                dgvMembresia.Rows[i].Cells["clmDM"].Value = x.Descuento.ToString() + "%";

                dgvMembresia.Rows[i].Cells["clmCedulaCliente"].Value = x.Cliente?.Cedula ?? "N/A"; // Cedula del cliente
                dgvMembresia.Rows[i].Cells["clmNombreCliente"].Value = x.Cliente?.Nombre ?? "N/A"; // Nombre del cliente
                dgvMembresia.Rows[i].Cells["clmApellidoCliente"].Value = x.Cliente?.Apellido ?? "N/A"; // Apellido del cliente
            }
        }

        public void TablaConsultarMebresiaFiltro(DataGridView dgvMembresia, string filtro = "", bool buscarPorCedula = true)
        {
            int i = 0;
            dgvMembresia.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Membresia x in ListaMembresia)
            {
                if  (string.IsNullOrEmpty(filtro) ||
                    (buscarPorCedula && x.Cliente?.Cedula.Contains(filtro) == true) ||
                    (!buscarPorCedula && x.DetallePromocion.Contains(filtro)))
                {
                    i = dgvMembresia.Rows.Add();
                    dgvMembresia.Rows[i].Cells["clmPREM"].Value = x.Precio.ToString() + "$";
                    dgvMembresia.Rows[i].Cells["clmCedulaCliente"].Value = x.Cliente?.Cedula ?? "N/A";
                    dgvMembresia.Rows[i].Cells["clmPM"].Value = x.Plan;
                    dgvMembresia.Rows[i].Cells["clmFIM"].Value = x.FechaInicio.ToString("d");
                    dgvMembresia.Rows[i].Cells["clmFFM"].Value = x.FechaFin.ToString("d");
                    dgvMembresia.Rows[i].Cells["clmP"].Value = x.Promocion;
                    dgvMembresia.Rows[i].Cells["clmDPM"].Value = x.DetallePromocion;
                    dgvMembresia.Rows[i].Cells["clmDM"].Value = x.Descuento.ToString()+ "%";
                    dgvMembresia.Rows[i].Cells["clmNombreCliente"].Value = x.Cliente?.Nombre ?? "N/A"; // Nombre del cliente
                    dgvMembresia.Rows[i].Cells["clmApellidoCliente"].Value = x.Cliente?.Apellido ?? "N/A"; // Apellido del cliente
                }
            }
        }
        public string editarMembresia(string nombrePlan, string planE, string SFInicioE, string SFFinE, string promocionE, string SdescuentoE, string detallePromocionE, string SprecioE)
        {
            string msj = "ERROR: SE ESPERABA DATOS CORRECTOS.";
            Validacion val = new Validacion();
            //Membresia mem = null;
            double precio = val.ConvertirDouble(SprecioE);
            int descuento = val.ConvertirEntero(SdescuentoE);
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
                    membresiaExistente.Descuento = descuento;
                    membresiaExistente.Precio = precio;

                    EditarMembresiaBD(membresiaExistente, nombrePlan); // BASE DE DATOS
                    msj = "MEMBRESIA EDITADA CORRECTAMENTE" + Environment.NewLine + membresiaExistente.ToString();
                }
                else
                {
                    msj = "ERROR: NO SE PUDO ENCONTRAR LA MEMBRESIA A EDITAR.";
                }
            }
            return msj;
        }

        public void EditarMembresiaBD(Membresia mem, string nombrePlan)
        {
            string msj = string.Empty;
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                msj = dtMembresia.UpdateCamposMembresia(mem, conn.Connect, nombrePlan);
                if (msj[0] == '0')
                {
                    MessageBox.Show("ERROR INESPERADO: " + msj);
                }
            }
            else if (msjBD[0] == '0')
            {
                MessageBox.Show("ERROR: " + msjBD);
            }
            conn.CerrarConexion();
        }
        public void PresentarDatosMembresia(TextBox txtBoxME, DateTimePicker dateTPFIE, DateTimePicker dateTPFFE, ComboBox comboBoxPE, TextBox txtBoxDPE, TextBox txtBoxDE, TextBox txtBoxPEM, Label lblCedulaM, string nombrePlan)
        {
            Membresia membresiaSeleccionada = ListaMembresia.Find(a => a.Plan == nombrePlan);
            if (membresiaSeleccionada != null)
            {
                txtBoxME.Text = membresiaSeleccionada.Plan;
                dateTPFIE.Value = membresiaSeleccionada.FechaInicio;
                dateTPFIE.Value = membresiaSeleccionada.FechaFin;
                comboBoxPE.Text = membresiaSeleccionada.Promocion;
                txtBoxDPE.Text = membresiaSeleccionada.DetallePromocion;
                txtBoxDE.Text = membresiaSeleccionada.Descuento.ToString();
                txtBoxPEM.Text = membresiaSeleccionada.Precio.ToString();
                lblCedulaM.Text = membresiaSeleccionada.Cliente?.Cedula ?? "N/A";
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
                            //ListaMembresia.Remove(membresia);
                            RemoverMembresiaBD(membresia);
                            dgvMembresia.Rows.RemoveAt(filaSeleccionada);
                            LlenarGrid(dgvMembresia);
                            MessageBox.Show("MEMBRESIA ELIMINADA CORRECTAMENTE." + Environment.NewLine + membresia.ToString(), "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR DE FORMA PERMANENTE UNA MEMBRESIA.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void RemoverMembresiaBD(Membresia mem)
        {
            string msj = string.Empty;
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                msj = dtMembresia.DeleteMembresia(mem, conn.Connect);
                if (msj[0] == '0')
                {
                    MessageBox.Show("ERROR INESPERADO: " + msj);
                }
            }
            else if (msjBD[0] == '0')
            {
                MessageBox.Show("ERROR: " + msjBD);
            }
            conn.CerrarConexion();
        }

        public void MostrarDatosClienteMem(string cedulaCliente, Label lblCedulaM, Label lblNombreM, Label lblApellidoM, Label lblEstudianteM, Label celularInvisible, Label comprobanteInvisible, Label fechaNacInvisible, Label direccionInvisible)
        {
            Cliente clienteSeleccionado = ctrCliente.ConseguirDatosGrid(cedulaCliente);
            if (clienteSeleccionado != null)
            {
                lblCedulaM.Text = clienteSeleccionado.Cedula;
                lblNombreM.Text = clienteSeleccionado.Nombre;
                lblApellidoM.Text = clienteSeleccionado.Apellido;
                celularInvisible.Text = clienteSeleccionado.Telefono;
                fechaNacInvisible.Text = clienteSeleccionado.FechaNacimiento.ToString("yyyy-MM-dd");
                direccionInvisible.Text = clienteSeleccionado.Direccion;

                if (clienteSeleccionado is ClienteEstudiante cliEst)
                {
                    lblEstudianteM.Text = "SI";
                    comprobanteInvisible.Text = cliEst.Comprobante;
                }
                else
                {

                    lblEstudianteM.Text = "NO";
                    comprobanteInvisible.Text = ctrCliente.ObtenerComprobanteActualizado(clienteSeleccionado.Cedula);
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
namespace Control
{
    public class CtrCliente
    {
        private static List<Cliente> listaCli = new List<Cliente>();

        private int poc;

        public static List<Cliente> ListaCli { get => listaCli; set => listaCli = value; }
        

        public int GetTotal()
        {
            return listaCli.Count;
        }

        public CtrCliente()
        {
            if (ListaCli.Count == 0) { 
                ListaCli.Add(new ClienteEstudiante("0987654321", "TULIO JOSE ", "TRIVIÑO FERNANDEZ", DateTime.ParseExact("01/01/1980", "dd/MM/yyyy", CultureInfo.InvariantCulture), "0874563219", "COOP. 31 MINUTOS","ACTIVO", "E09876543211"));
                ListaCli.Add(new Cliente("9512368749", "JUAN CARLOS", "BODOQUE AVENDAÑO", DateTime.ParseExact("24/05/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture), "2031659847", "GUASMO SUR", "ACTIVO"));
                ListaCli.Add(new Cliente("9865231470", "JUANIN JUAN", "JARRY SANCHEZ", DateTime.ParseExact("30/07/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture),"0995263417", "VIA DAULE", "INACTIVO"));
                ListaCli.Add(new ClienteEstudiante("0963254178", "PATRICIA ANA", "TUFILLO TRIVIÑO", DateTime.ParseExact("24/05/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture), "0963251478", "PASCUALES", "ACTIVO", "E10987263541"));
            }
        }

        public string IngresarCli(string rCedula, string rNombre, string rApellido,string rFechaNacimiento, string rTelefono, string rEstado, string rDireccion)
        {
            
            String msg = "ERROR: SE ESPERABA DATOS CORRECTOS!!";
            Validacion v = new Validacion();
            DateTime hoy = DateTime.Now;
            Cliente cli = null;
            DateTime fechaNac = v.ConvertirDateTime(rFechaNacimiento);

                cli = new Cliente(rCedula, rNombre, rApellido, fechaNac, rTelefono, rDireccion, rEstado);
                ListaCli.Add(cli); // Agregando datos del cliente
                msg = cli.ToString() + "\n CLIENTE REGISTRADO EXITOSAMENTE!!";

            return msg;
        }

        public string IngresarCliEst( string rCedula, string rNombre, string rApellido, string rFechaNacimiento, string rTelefono,string rEstado, string rDireccion, string comprobante)
        {
            String msg = "ERROR: SE ESPERABA DATOS CORRECTOS11";
            Validacion v = new Validacion();
            DateTime hoy = DateTime.Now;
            DateTime fechaNac = v.ConvertirDateTime(rFechaNacimiento);
            Cliente cli = null;

                cli = new ClienteEstudiante(rCedula, rNombre, rApellido, fechaNac, rTelefono, rDireccion, rEstado, comprobante);
                listaCli.Add(cli); // Agregando datos del cliente
                msg = cli.ToString() + "\n CLIENTE ESTUDIANTE REGISTRADO EXITOSAMENTE11";

            return msg;
        }

        public bool ClienteExistente(string cedula)
        {
            foreach(Cliente cli in ListaCli)
            {
                if(cli.Cedula == cedula)
                {
                    return true;
                }
            }
            return false;

        }

        public void LlenarGrid(DataGridView dgvClientes)
        {
            int i = 0;
            dgvClientes.Rows.Clear(); // Limpiar filas si las hay 
            foreach (Cliente x in ListaCli )
            {
                    i = dgvClientes.Rows.Add();
                    dgvClientes.Rows[i].Cells["clmEstado"].Value = x.Estado;
                    dgvClientes.Rows[i].Cells["clmCedula"].Value = x.Cedula;
                    dgvClientes.Rows[i].Cells["clmNombre"].Value = x.Nombre;
                    dgvClientes.Rows[i].Cells["clmApellido"].Value = x.Apellido;
                    dgvClientes.Rows[i].Cells["clmTelefono"].Value = x.Telefono;
                    dgvClientes.Rows[i].Cells["clmDireccion"].Value = x.Direccion;
                    dgvClientes.Rows[i].Cells["clmDate"].Value = x.FechaNacimiento.ToString("d");
                if (x is ClienteEstudiante clienteEstudiante)
                    {

                        dgvClientes.Rows[i].Cells["clmComprobanteEst"].Value = clienteEstudiante.Comprobante;
                    }
                    else
                    {
                    dgvClientes.Rows[i].Cells["clmComprobanteEst"].Value = ObtenerComprobanteActualizado(x.Cedula);
                    }
            }

        }

        private string ObtenerComprobanteActualizado(string cedula)
        {
            foreach (Cliente cliente in ListaCli)
            {
                if (cliente.Cedula == cedula)
                {
                    if (cliente is ClienteEstudiante clienteEstudiante)
                    {
                        return string.IsNullOrEmpty(clienteEstudiante.Comprobante) ? "SIN COMPROBANTE" : clienteEstudiante.Comprobante;
                    }
                }
            }
            return "SIN COMPROBANTE";
        }

        public string EditarCliEst(string aCedulaOrg, string aCedula, string aNombre, string aApellido, string aFechaNacimiento, string aTelefono, string aDireccion,string aEstado, string aComprobante, bool esEstudiante)
        {
            string msg = "ERROR: SE ESPERABA DATOS CORRECTOS!!";
            Validacion v = new Validacion();
            DateTime fechaNac = v.ConvertirDateTime(aFechaNacimiento);

            foreach (Cliente clienteExistente in ListaCli)
            {
                if (clienteExistente.Cedula == aCedulaOrg)
                {
                    if (clienteExistente.Cedula != aCedula)
                    {
                        if (ListaCli.Any(cli => cli.Cedula == aCedula))
                        {
                            return "ERROR: YA EXISTE UN CLIENTE CON ESA CEDULA.";
                        }
                        clienteExistente.Cedula = aCedula;
                    }
                    clienteExistente.Nombre = aNombre;
                    clienteExistente.Apellido = aApellido;
                    clienteExistente.FechaNacimiento = fechaNac;
                    clienteExistente.Telefono = aTelefono;
                    clienteExistente.Direccion = aDireccion;
                    clienteExistente.Estado = aEstado;


                    // Verificar si debe convertirse en ClienteEstudiante
                    if (esEstudiante)
                    {
                        if (clienteExistente is ClienteEstudiante)
                        {
                            ((ClienteEstudiante)clienteExistente).Comprobante = aComprobante;
                        }
                        else
                        {
                            ClienteEstudiante clienteEstudiante = new ClienteEstudiante(aCedula, aNombre, aApellido, fechaNac, aTelefono, aDireccion, aEstado, aComprobante);
                            ListaCli.Remove(clienteExistente);
                            ListaCli.Add(clienteEstudiante);
                        }
                    }
                    else
                    {
                        if (clienteExistente is ClienteEstudiante)
                        {
                            // Convertir ClienteEstudiante a Cliente normal
                            Cliente cliente = new Cliente(aCedula, aNombre, aApellido, fechaNac, aTelefono, aDireccion, aEstado);
                            ListaCli.Remove(clienteExistente);
                            ListaCli.Add(cliente);
                        }
                    }


                    msg = "CLIENTE EDITADO CORRECTAMENTE";
                    break;
                }
            }

            if (msg == "ERROR: SE ESPERABA DATOS CORRECTOS!!")
            {
                msg = "ERROR: NO SE ENCONTRO EL CLIENTE";
            }

            return msg;

        }

        public string EditarCli(string aCedulaOrg, string aCedula, string aNombre, string aApellido, string aFechaNacimiento, string aTelefono, string aDireccion, string aEstado)
        {
            string msg = "ERROR: SE ESPERABA DATOS CORRECTOS!!";
            Validacion v = new Validacion();
            DateTime fechaNac = v.ConvertirDateTime(aFechaNacimiento);

            foreach (Cliente clienteExistente in ListaCli)
            {
                if (clienteExistente.Cedula == aCedulaOrg)
                {
                    if (clienteExistente.Cedula != aCedula)
                    {
                        if (ListaCli.Any(cli => cli.Cedula == aCedula))
                        {
                            return "ERROR: YA EXISTE UN CLIENTE CON ESA CEDULA.";
                        }
                        clienteExistente.Cedula = aCedula;
                    }
                    clienteExistente.Nombre = aNombre;
                    clienteExistente.Apellido = aApellido;
                    clienteExistente.FechaNacimiento = fechaNac;
                    clienteExistente.Telefono = aTelefono;
                    clienteExistente.Direccion = aDireccion;
                    clienteExistente.Estado = aEstado;

                    msg = "CLIENTE EDITADO CORRECTAMENTE";
                    break;
                }
            }

            if (msg == "ERROR: SE ESPERABA DATOS CORRECTOS!!")
            {
                msg = "ERROR: NO SE ENCONTRO EL CLIENTE";
            }

            return msg;
        }


        public void BuscarCliente(DataGridView dgvClientes, string filtroPorCedula = "", string filtroPorNombre = "")
        {

            if (string.IsNullOrEmpty(filtroPorCedula) && string.IsNullOrEmpty(filtroPorNombre))
            {
                MessageBox.Show("ERROR: DEBE INGRESAR AL MENOS UN CAMPO PARA LA BÚSQUEDA (CÉDULA O NOMBRE).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = 0;
            dgvClientes.Rows.Clear(); // Limpiar filas si las hay 
            foreach (Cliente x in ListaCli)
            {
                bool coincideCedula = string.IsNullOrEmpty(filtroPorCedula) || x.Cedula.IndexOf(filtroPorCedula, StringComparison.OrdinalIgnoreCase) >= 0;
                bool coincideNombre = string.IsNullOrEmpty(filtroPorNombre) || x.Nombre.IndexOf(filtroPorNombre, StringComparison.OrdinalIgnoreCase) >= 0;

                if (coincideCedula && coincideNombre)
                {
                    i = dgvClientes.Rows.Add();
                    dgvClientes.Rows[i].Cells["clmEstado"].Value = x.Estado;
                    dgvClientes.Rows[i].Cells["clmCedula"].Value = x.Cedula;
                    dgvClientes.Rows[i].Cells["clmNombre"].Value = x.Nombre;
                    dgvClientes.Rows[i].Cells["clmApellido"].Value = x.Apellido;
                    dgvClientes.Rows[i].Cells["clmTelefono"].Value = x.Telefono;
                    dgvClientes.Rows[i].Cells["clmDireccion"].Value = x.Direccion;
                    dgvClientes.Rows[i].Cells["clmDate"].Value = x.FechaNacimiento.ToString("d");

                    if (x is ClienteEstudiante clienteEstudiante)
                    {
                        dgvClientes.Rows[i].Cells["clmComprobanteEst"].Value = clienteEstudiante.Comprobante;
                    }
                    else
                    {
                        dgvClientes.Rows[i].Cells["clmComprobanteEst"].Value = ObtenerComprobanteActualizado(x.Cedula); ;
                    }
                }
            }

            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("ERROR: NO SE ENCONTRARON RESULTADOS CON LOS FILTROS PROPORCIONADOS.", "SIN RESULTADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void InactivarCliente(string cedula, DataGridView dgvCliente)
        {
                DialogResult resultado = MessageBox.Show("¿DESEA INACTIVAR A ESTE CLIENTE?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(resultado == DialogResult.Yes)
                {
                    var cliente = ListaCli.FirstOrDefault(cli => cli.Cedula == cedula);
                    if (cliente != null)
                    {
                        cliente.Estado = "INACTIVO";
                    }
                }
        }

        public void MostrarDatosCliente(string cedulaCliente, TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, DateTimePicker dtpDate, TextBox txtTelefono, TextBox txtDireccion, TextBox txtComprobante, ComboBox cmbEstado, ComboBox cmbEstudiante)
        {
            Cliente clienteSeleccionado = ConseguirDatosGrid(cedulaCliente);
            if(clienteSeleccionado != null) 
            {
                txtCedula.Text = clienteSeleccionado.Cedula;
                txtNombre.Text = clienteSeleccionado.Nombre;
                txtApellido.Text = clienteSeleccionado.Apellido;
                dtpDate.Value = clienteSeleccionado.FechaNacimiento;
                txtTelefono.Text = clienteSeleccionado.Telefono;
                txtDireccion.Text = clienteSeleccionado.Direccion;
                cmbEstado.SelectedItem = clienteSeleccionado.Estado;


                if (clienteSeleccionado is ClienteEstudiante clienteEstudiante)
                {
                    txtComprobante.Text = clienteEstudiante.Comprobante;
                    cmbEstudiante.SelectedItem = "SI";
                    
                }
                else
                {
                    txtComprobante.Text = ObtenerComprobanteActualizado(clienteSeleccionado.Cedula);
                    cmbEstudiante.SelectedItem = "NO";
                }

            }

        }
        
        public Cliente ConseguirDatosGrid(string cedulaCliente)
        {
            return ListaCli.Find(cli => cli.Cedula == cedulaCliente);
        }




    }   
}

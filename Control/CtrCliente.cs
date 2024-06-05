using System;
using System.Collections.Generic;
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

        public string IngresarCli(string rCedula, string rNombre, string rApellido, string rFechaNacimiento, string rTelefono, string rEstado, string rDireccion)
        {
            String msg = "ERROR: SE ESPERABA DATOS CORRECTOS!!";
            Validacion v = new Validacion();
            Cliente cli = null;
            if (rCedula != "" && rNombre != "" && rApellido!= "" && rFechaNacimiento !="" && rTelefono != "" && rDireccion != "")
            {
                cli = new Cliente(rCedula, rNombre, rApellido, rFechaNacimiento, rTelefono, rDireccion, rEstado);
                listaCli.Add(cli); // Agregando datos del cliente
                msg = cli.ToString() + "\n CLIENTE ESTUDIANTE REGISTRADO EXITOSAMENTE!!";
            } 
            return msg;
        }

        public string IngresarCliEst(string rCedula, string rNombre, string rApellido, string rFechaNacimiento, string rTelefono,string rEstado, string rDireccion, string comprobante)
        {
            String msg = "ERROR: SE ESPERABA DATOS CORRECTOS11";
            Validacion v = new Validacion();
 //           DateTime fechaNac = v.ConvertirDateTime(rFechaNacimiento);
            

            Cliente cli = null;
            if (rCedula != "" && rNombre != "" && rApellido != "" && rFechaNacimiento != "" && rTelefono != "" && rDireccion != "" && comprobante != "")
            {
                cli = new ClienteEstudiante(rCedula, rNombre, rApellido, rFechaNacimiento, rTelefono, rDireccion, rEstado, comprobante);
                listaCli.Add(cli); // Agregando datos del cliente
                msg = cli.ToString() + "\n CLIENTE REGISTRADO EXITOSAMENTE11";
            }
            return msg;
        }

        //public string IngresarPolimorfismo()

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

                    if (x is ClienteEstudiante clienteEstudiante)
                    {

                        dgvClientes.Rows[i].Cells["clmComprobanteEst"].Value = clienteEstudiante.Comprobante;
                    }
                    else
                    {
                        dgvClientes.Rows[i].Cells["clmComprobanteEst"].Value = "SIN COMPROBANTE";
                    }
            }

        }

        public void ConsultarClientePorCedula(DataGridView dgvClientes, string filtro = "")
        {
            int i = 0;
            dgvClientes.Rows.Clear(); // Limpiar filas si las hay 
            foreach (Cliente x in ListaCli)
            {
                if ((string.IsNullOrEmpty(filtro)) || x.Cedula.Contains(filtro))
                {
                    i = dgvClientes.Rows.Add();
                    dgvClientes.Rows[i].Cells["clmEstado"].Value = x.Estado;
                    dgvClientes.Rows[i].Cells["clmCedula"].Value = x.Cedula;
                    dgvClientes.Rows[i].Cells["clmNombre"].Value = x.Nombre;
                    dgvClientes.Rows[i].Cells["clmApellido"].Value = x.Apellido;
                    dgvClientes.Rows[i].Cells["clmTelefono"].Value = x.Telefono;
                    dgvClientes.Rows[i].Cells["clmDireccion"].Value = x.Direccion;

                    if (x is ClienteEstudiante clienteEstudiante)
                    {
                        dgvClientes.Rows[i].Cells["clmComprobanteEst"].Value = clienteEstudiante.Comprobante;
                    }
                    else
                    {
                        dgvClientes.Rows[i].Cells["clmComprobanteEst"].Value = "SIN COMPROBANTE";
                    }

                }
            }
        }










        //Omar Arroba
        /// AQUI EMPIEZA
        /// 
        /// 
        /// 
        /// 


        public Cliente ObtenerClientePorCedula(string cedula)
        {
            foreach (Cliente cli in listaCli)
            {
                if (cli.Cedula == cedula)
                {
                    return cli;
                }
            }
            return null;
        }



        public List<string> ObtenerCedulasClientes()
        {
            List<string> cedulas = new List<string>();
            foreach (Cliente cli in listaCli)
            {
                cedulas.Add(cli.Cedula);
            }
            return cedulas;
        }



        public ClienteDatos ObtenerDatosClientePorCedula(string cedula)
        {
            Cliente cli = ObtenerClientePorCedula(cedula);
            if (cli != null)
            {
                return new ClienteDatos(cli.Nombre, cli.Apellido, cli.FechaNacimiento, cli.Telefono, cli.Direccion, cli.Estado);
            }
            else
            {
                return null;
            }
        }


        ///
        ///
        ///
        ///AQUI TERMINA


    }
}

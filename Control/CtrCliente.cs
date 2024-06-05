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

        public static List<Cliente> ListaCliente { get => listaCli; set => listaCli = value; }

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

        public string IngresarCliEst(string rCedula, string rNombre, string rApellido, string rFechaNacimiento, string rTelefono,string rEstado, string rDireccion, string esEstudiante)
        {
            String msg = "ERROR: SE ESPERABA DATOS CORRECTOS11";
            Validacion v = new Validacion();
 //           DateTime fechaNac = v.ConvertirDateTime(rFechaNacimiento);
            

            Cliente cli = null;
            if (rCedula != "" && rNombre != "" && rApellido != "" && rFechaNacimiento != "" && rTelefono != "" && rDireccion != "")
            {
                cli = new ClienteEstudiante(rCedula, rNombre, rApellido, rFechaNacimiento, rTelefono, rDireccion, rEstado, esEstudiante);
                listaCli.Add(cli); // Agregando datos del cliente
                msg = cli.ToString() + "\n CLIENTE REGISTRADO EXITOSAMENTE11";
            }
            return msg;
        }
        public void ActualizarCli(TextBox txtCedula, TextBox txtNombre, TextBox txtApellido, TextBox txtDate, TextBox txtTelefono, TextBox txtDireccion, ComboBox cmbEstudiante, ComboBox cmbEstado)
        {
            //txtNombre.Text = dgvClientes
        }

        //public string BuscarCli(TextBox txtCedula)
        //{
        //    string msg = "NO EXISTE CLIENTE CON ESA CEDULA";
        //    if (txtCedula.Text != "")
        //    {
                
        //    }

        //    return msg;
        //}
        public void LlenarGrid(DataGridView dgvClientes)
        {
            int i = 0;
            dgvClientes.Rows.Clear(); // Limpiar filas si las hay 
            foreach (Cliente x in ListaCliente)
            {
                i = dgvClientes.Rows.Add();
                dgvClientes.Rows[i].Cells["clmEstado"].Value = x.Estado;
                dgvClientes.Rows[i].Cells["clmCedula"].Value = x.Cedula;
                dgvClientes.Rows[i].Cells["clmNombre"].Value = x.Nombre;
                dgvClientes.Rows[i].Cells["clmApellido"].Value = x.Apellido;
                dgvClientes.Rows[i].Cells["clmTelefono"].Value = x.Telefono;
                dgvClientes.Rows[i].Cells["clmDireccion"].Value = x.Direccion;

                if(x is ClienteEstudiante)
                {
                    dgvClientes.Rows[i].Cells["clmEstudiante"].Value  = "SI";
                }
                else
                {
                    dgvClientes.Rows[i].Cells["clmEstudiante"].Value = "NO";
                }
                
            }

        }

        
    }
}

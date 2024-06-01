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

        public static List<Cliente> ListaCliente { get => listaCli; set => listaCli = value; }

        public int GetTotal()
        {
            return listaCli.Count;
        }

        public string IngresarCli(string rCedula, string rNombre, string rApellido, string rFechaNacimiento, string rTelefono, string rDireccion, string esEstudiante)
        {
            String msg = "ERROR: SE ESPERABA DATOS CORRECTOS!!";
            Validacion v = new Validacion();
            int cedula = v.aEntero(rCedula);
            int fono = v.aEntero(rTelefono);
            Cliente cli = null;
            if (cedula > 0 && rNombre != "" && rApellido!= "" && rFechaNacimiento !="" && fono > 0 && rDireccion != "")
            {
                cli = new Cliente(cedula, rNombre, rApellido, rFechaNacimiento, fono, rDireccion, esEstudiante);
                listaCli.Add(cli); // Agregando datos del cliente
                msg = cli.ToString() + "\n CLIENTE ESTUDIANTE REGISTRADO EXITOSAMENTE!!";
            } 
            return msg;
        }

        public string IngresarCliEst(string rCedula, string rNombre, string rApellido, string rFechaNacimiento, string rTelefono, string rDireccion, string esEstudiante)
        {
            String msg = "ERROR: SE ESPERABA DATOS CORRECTOS11";
            Validacion v = new Validacion();
            int cedula = v.aEntero(rCedula);
            int fono = v.aEntero(rTelefono);
            Cliente cli = null;
            if (cedula > 0 && rNombre != "" && rApellido != "" && rFechaNacimiento != "" && fono > 0 && rDireccion != "")
            {
                cli = new Cliente(cedula, rNombre, rApellido, rFechaNacimiento, fono, rDireccion, esEstudiante);
                listaCli.Add(cli); // Agregando datos del cliente
                msg = cli.ToString() + "\n CLIENTE REGISTRADO EXITOSAMENTE11";
            }
            return msg;
        }


        public void LlenarGrid(DataGridView dgvClientes)
        {
            int i = 0;
            dgvClientes.Rows.Clear(); // Limpiar filas si las hay 
            foreach (Cliente x in ListaCliente)
            {
                i = dgvClientes.Rows.Add();
                dgvClientes.Rows[i].Cells["clmCedula"].Value = i + 1;
                dgvClientes.Rows[i].Cells["clmNombre"].Value = x.Nombre;
                dgvClientes.Rows[i].Cells["clmApellido"].Value = x.Apellido;
                dgvClientes.Rows[i].Cells["clmTelefono"].Value = x.Telefono;
                dgvClientes.Rows[i].Cells["clmDireccion"].Value = x.Direccion;
                
            }

        }
    }
}

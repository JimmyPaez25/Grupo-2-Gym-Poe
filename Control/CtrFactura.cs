using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;


namespace Control
{
    public class CtrFactura
    {

        Factura fac = new Factura();

        public static List<Factura> listaFact = new List<Factura>();
        public static List<Factura> ListaFact { get => listaFact; set => listaFact = value; }

        //Lista quemada
        public CtrFactura()
        {
            if (ListaFact.Count == 0)
            {
                ListaFact.Add(new Factura(1, "3434"/*, "200","0.12","2"*/));
                ListaFact.Add(new Factura(2, "2222"));
                ListaFact.Add(new Factura(3, "Super"));
            }
        }

        public int GetFacto()
        {
            return listaFact.Count;
        }



        //Generar código de la factura
        public string GenerarFactura()
        {
            return generarCodigoUnico();
        }

        private string generarCodigoUnico()
        {
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var Serie = new StringBuilder();
            for (int i = 0; i < 12; i++)
            {
                int indice = random.Next(caracteresPermitidos.Length);
                Serie.Append(caracteresPermitidos[indice]);
            }

            return Serie.ToString();
        }




        //Guardar datos
        public string IngresarFact(int numfactura, string serie)
        {
            string msg = "ERROR";
            Factura fact = null;

            fact = new Factura(numfactura, serie);
            listaFact.Add(fact);
            msg = fact.ToString() + Environment.NewLine + "---REGISTRO EXITOSO---" + Environment.NewLine;

            return msg;

        }








        //LLenar la tabla
        public void LlenarDataFact(DataGridView dgvRegistroFact)
        {
            int i = 0;
            dgvRegistroFact.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Factura f in ListaFact)
            {
                if (f.Estadofact == 1)
                {

                    i = dgvRegistroFact.Rows.Add();
                    dgvRegistroFact.Rows[i].Cells["FacturaRegistroFact"].Value = f.Numfactura;
                    dgvRegistroFact.Rows[i].Cells["PrecioDataFact"].Value = f.Serie;
                    //dgvRegistroFact
                    //dgvRegistroFact
                }

            }

        }



        //Eliminar factura seleccionando fila
        public void EliminarFactura(DataGridView dgvRegistroFact)
        {
            if (dgvRegistroFact.SelectedRows.Count > 0)
            {
                int filaSelecc = dgvRegistroFact.SelectedRows[0].Index; // OBTIENE INDICE DE FILA SELECCIONADA
                if (filaSelecc >= 0)
                {
                    int cl = (int)dgvRegistroFact.Rows[filaSelecc].Cells["FacturaRegistroFact"].Value - 1; // OBTIENE NUMERO DE LA ACTIVIDAD
                    DialogResult result = MessageBox.Show("ESTA SEGURO DE BORRAR LA FACTURA SELECCIONADA?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        ListaFact[cl].Estadofact = 2; // ESTADO 2 = INACTIVO
                        LlenarDataFact(dgvRegistroFact);
                        MessageBox.Show("BORRADO EXITOSO.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        public void TablaConsultarNombreDescripcion(DataGridView dgvRegistroFact, string filtro = "", bool buscarPorNombrefact = true)
        {
            int i = 0;
            dgvRegistroFact.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Factura x in ListaFact)
            {
                if (string.IsNullOrEmpty(filtro) ||
                    (buscarPorNombrefact && x.Numfactura.ToString().Contains(filtro)) ||
                    (!buscarPorNombrefact && x.Serie.Contains(filtro)))
                {
                    i = dgvRegistroFact.Rows.Add();
                    //dgvRegistroFact.Rows[i].Cells["clmPREM"].Value = x.Precio.ToString() + "$";
                    dgvRegistroFact.Rows[i].Cells["FacturaRegistroFact"].Value = x.Numfactura;
                    dgvRegistroFact.Rows[i].Cells["PrecioDataFact"].Value = x.Serie;
                    //dgvMembresia.Rows[i].Cells["clmFIM"].Value = x.FechaInicio.ToString("d");
                    //dgvMembresia.Rows[i].Cells["clmFFM"].Value = x.FechaFin.ToString("d");
                    //dgvMembresia.Rows[i].Cells["clmP"].Value = x.Promocion;
                    //dgvMembresia.Rows[i].Cells["clmDPM"].Value = x.DetallePromocion;
                    //dgvMembresia.Rows[i].Cells["clmDM"].Value = x.Descuento.ToString() + "%";
                }
            }
        }


       
           
           
    }
}





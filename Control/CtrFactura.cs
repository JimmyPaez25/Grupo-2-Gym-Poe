using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Modelo;


namespace Control
{
    public class CtrFactura
    {

        Factura fac = new Factura();

        public static List<Factura> listaFact = new List<Factura>();
        private static List<Membresia> listaMembresia = new List<Membresia>();
        public static List<Factura> ListaFact { get => listaFact; set => listaFact = value; }
        public static List<Membresia> ListaMembresia { get => listaMembresia; set => listaMembresia = value; }






        //Lista quemada
        public CtrFactura()
        {
            if (ListaFact.Count == 0)
            {
                ListaFact.Add(new Factura(1, "JKSD23FJ32K9 ","144","20%", "0.15","136.80"));
                ListaFact.Add(new Factura(2, "JKDI43JYW3FG", "556", "24%", "0.15", "505.06"));
                ListaFact.Add(new Factura(3, "34TEOI0D0GG7", "700", "13%", "0.15", "714"));
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





        //Guardar datos y realizar cálculo
        public string IngresarFact(int numfactura, string serie, string preciofact, string descuentofact, string iva, string total)
        {
            string msg = "ERROR";
            Factura fact = null;

            fact = new Factura(numfactura, serie, preciofact, descuentofact, iva, total);

            double precioFact;
            double descuentoFact = 0; // Inicializo descuentoFact a 0 por defecto

            if (double.TryParse(preciofact, out precioFact))
            {
                if (!string.IsNullOrEmpty(descuentofact) && double.TryParse(descuentofact, out descuentoFact) && descuentoFact > 0)
                {
                    // Si hay descuento y es mayor a 0, lo aplico
                    double totalFact = precioFact - (precioFact * (descuentoFact / 100)) + (precioFact * 0.15);
                    fact.Total = totalFact.ToString();
                }
                else
                {
                    // Si no hay descuento o es 0, solo calculo el IVA
                    double totalFact = precioFact + (precioFact * 0.15);
                    fact.Total = totalFact.ToString();
                }
            }
            else
            {
                msg = "Error: Valor de precio no válido";
                return msg;
            }

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
            
                    i = dgvRegistroFact.Rows.Add();
                    dgvRegistroFact.Rows[i].Cells["FacturaRegistroFact"].Value = f.Serie;
                    dgvRegistroFact.Rows[i].Cells["PrecioDataFact"].Value = f.Preciofact;
                    dgvRegistroFact.Rows[i].Cells["DescuentoDataFact"].Value = f.Descuentofact;
                    dgvRegistroFact.Rows[i].Cells["IvaDataFact"].Value = f.Iva;
                    dgvRegistroFact.Rows[i].Cells["TotalDataFact"].Value = f.Total;
                    //dgvRegistroFact
                    //dgvRegistroFact
                

            }

        }


        //Buscar
        public void TablaConsultarNombreDescripcion(DataGridView dgvRegistroFact, string filtro = "", bool buscarPorNombrefact = true)
        {
            int i = 0;
            dgvRegistroFact.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Factura x in ListaFact)
            {
                if (string.IsNullOrEmpty(filtro) ||
                    (buscarPorNombrefact && x.Serie.ToString().Contains(filtro)) ||
                    (!buscarPorNombrefact && x.Preciofact.ToString().Contains(filtro)))
                {
                    i = dgvRegistroFact.Rows.Add();
                    dgvRegistroFact.Rows[i].Cells["FacturaRegistroFact"].Value = x.Serie;
                    dgvRegistroFact.Rows[i].Cells["PrecioDataFact"].Value = x.Preciofact;
                    dgvRegistroFact.Rows[i].Cells["DescuentoDataFact"].Value = x.Descuentofact;
                    dgvRegistroFact.Rows[i].Cells["IvaDataFact"].Value = x.Iva;
                    dgvRegistroFact.Rows[i].Cells["TotalDataFact"].Value = x.Total;
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
                    string cl = dgvRegistroFact.Rows[filaSelecc].Cells["FacturaRegistroFact"].Value.ToString(); // OBTIENE NUMERO DE LA ACTIVIDAD
                    Factura factura = ListaFact.FirstOrDefault(f => f.Serie == cl);

                    if (factura != null)
                    {
                        DialogResult result = MessageBox.Show("ESTA SEGURO DE BORRAR LA FACTURA SELECCIONADA?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            ListaFact.Remove(factura); // <--- Actualiza la yabla y ya no muestra lo borrado
                            dgvRegistroFact.Rows.RemoveAt(filaSelecc);
                            MessageBox.Show("BORRADO EXITOSO.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Modelo;
using System.Numerics;


namespace Control
{
    public class CtrFactura
    {
        public static List<Factura> listaFact = new List<Factura>();
        private static List<Membresia> listaMembresia = new List<Membresia>();
        public static List<Factura> ListaFact { get => listaFact; set => listaFact = value; }
        public static List<Membresia> ListaMembresia { get => listaMembresia; set => listaMembresia = value; }




        //Lista quemada
        public CtrFactura()
        {
            if (ListaFact.Count == 0)
            {
                ListaFact.Add(new Factura(1, "JKSD23FJ3D52K9 ", "144", "20%", "0.15", "136.80"));
                ListaFact.Add(new Factura(2, "JKDI43JYWHG3FG", "556", "24%", "0.15", "505.06"));
                ListaFact.Add(new Factura(3, "34TEOI0D07KGG7", "700", "13%", "0.15", "714"));
            }
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













        //Método para caluclar datos ingresados
        public string CalcularTotal(double precioFact, double descuentoFact)
        {
            double totalFact;
            if (descuentoFact > 0)
            {
                // Si hay descuento y es mayor a 0, lo aplico
                totalFact = precioFact - (precioFact * (descuentoFact / 100)) + (precioFact * 0.15);
            }
            else
            {
                // Si no hay descuento o es 0, solo calculo el IVA
                totalFact = precioFact + (precioFact * 0.15);
            }
            return totalFact.ToString();
        }




        //Guardar datos
        public string IngresarFact(int numfactura, string serie, string preciofact, string descuentofact, string iva, string total)
        {
            string msg;
            Factura fact;

            fact = new Factura(numfactura, serie, preciofact, descuentofact, iva, total);
            fact.Estadofact = "ACTIVO";
            double precioFact;
            double descuentoFact;

            if (double.TryParse(preciofact, out precioFact))
            {
                if (!string.IsNullOrEmpty(descuentofact) && double.TryParse(descuentofact, out descuentoFact) && descuentoFact > 0)
                {
                    fact.Total = CalcularTotal(precioFact, descuentoFact);
                }
                else
                {
                    fact.Total = CalcularTotal(precioFact, 0);
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



        //Guardar datos y realizar cálculo
        //public string IngresarFact(int numfactura, string serie, string preciofact, string descuentofact, string iva, string total)
        //{
        //    string msg;
        //    Factura fact;

        //    fact = new Factura(numfactura, serie, preciofact, descuentofact, iva, total);
        //    fact.Estadofact = "ACTIVO";
        //    double precioFact;
        //    double descuentoFact;

        //    if (double.TryParse(preciofact, out precioFact))
        //    {
        //        if (!string.IsNullOrEmpty(descuentofact) && double.TryParse(descuentofact, out descuentoFact) && descuentoFact > 0)
        //        {
        //            // Si hay descuento y es mayor a 0, lo aplico
        //            double totalFact = precioFact - (precioFact * (descuentoFact / 100)) + (precioFact * 0.15);
        //            fact.Total = totalFact.ToString();
        //        }
        //        else
        //        {
        //            // Si no hay descuento o es 0, solo calculo el IVA
        //            double totalFact = precioFact + (precioFact * 0.15);
        //            fact.Total = totalFact.ToString();
        //        }
        //    }
        //    else
        //    {
        //        msg = "Error: Valor de precio no válido";
        //        return msg;
        //    }

        //    listaFact.Add(fact);
        //    msg = fact.ToString() + Environment.NewLine + "---REGISTRO EXITOSO---" + Environment.NewLine;

        //    return msg;
        //}


        //LLenar la tabla
        public void LlenarDataFact(DataGridView dgvRegistroFact)
        {
            int i;
            dgvRegistroFact.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Factura f in ListaFact)
            {

                i = dgvRegistroFact.Rows.Add();
                dgvRegistroFact.Rows[i].Cells["FacturaRegistroFact"].Value = f.Serie;
                dgvRegistroFact.Rows[i].Cells["PrecioDataFact"].Value = f.Preciofact;
                dgvRegistroFact.Rows[i].Cells["DescuentoDataFact"].Value = f.Descuentofact;
                dgvRegistroFact.Rows[i].Cells["IvaDataFact"].Value = f.Iva;
                dgvRegistroFact.Rows[i].Cells["TotalDataFact"].Value = f.Total;
                dgvRegistroFact.Rows[i].Cells["EstadoDataFact"].Value = f.Estadofact;
                dgvRegistroFact.Rows[i].Cells["MotivoDataFact"].Value = f.Motivoinactivacion;
                //dgvRegistroFact
                //dgvRegistroFact
            }
        }


        //Buscar
        public void TablaConsultarNombreDescripcion(DataGridView dgvRegistroFact, string filtro = "", bool buscarPorNombrefact = true)
        {
            int i;
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
                    dgvRegistroFact.Rows[i].Cells["EstadoDataFact"].Value = x.Estadofact;
                    dgvRegistroFact.Rows[i].Cells["MotivoDataFact"].Value = x.Motivoinactivacion;
                }
            }
        }





        //Eliminar factura seleccionando fila
        //public void EliminarFactura(DataGridView dgvRegistroFact)
        //{
        //    if (dgvRegistroFact.SelectedRows.Count > 0)
        //    {
        //        int filaSelecc = dgvRegistroFact.SelectedRows[0].Index; // OBTIENE INDICE DE FILA SELECCIONADA
        //        if (filaSelecc >= 0)
        //        {
        //            string cl = dgvRegistroFact.Rows[filaSelecc].Cells["FacturaRegistroFact"].Value.ToString(); // OBTIENE NUMERO DE LA ACTIVIDAD
        //            Factura factura = ListaFact.FirstOrDefault(f => f.Serie == cl);

        //            if (factura != null)
        //            {
        //                DialogResult result = MessageBox.Show("ESTA SEGURO DE BORRAR LA FACTURA SELECCIONADA?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        //                if (result == DialogResult.Yes)
        //                {
        //                    ListaFact.Remove(factura); // <--- Actualiza la tabla y ya no muestra lo borrado
        //                    dgvRegistroFact.Rows.RemoveAt(filaSelecc);
        //                    MessageBox.Show("BORRADO EXITOSO.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }

        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE ELIMINAR.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}




        //INACTIVAR FACTURA
        public void InactivarFactura(string serie, DataGridViewRow filaSeleccionada)
        {

            DialogResult resultado = MessageBox.Show("¿DESEA INACTIVAR LA FACTURA SELECCIONADA?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                var factura = listaFact.FirstOrDefault(facto => facto.Serie == serie);
                if (factura != null)
                {
                    factura.estadofact = "INACTIVO"; //Pone el estado Inactivo a la factura
                    factura.motivoinactivacion = filaSeleccionada.Cells["MotivoDataFact"].Value.ToString();
                }
            }
        }


        //RE-ACTIVAR FACTURA
        public void ActivarFactura(string serie, DataGridViewRow filaSeleccionada)
        {
            var factura = listaFact.FirstOrDefault(facto => facto.Serie == serie);
            if (factura != null)
            {
                if (factura.estadofact == "ACTIVO")
                {
                    MessageBox.Show("LA FACTURA YA ESTÁ ACTIVA.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (factura.estadofact == "INACTIVO")
                {
                    factura.estadofact = "ACTIVO"; //Pone el estado Activo a la factura
                    factura.motivoinactivacion = string.Empty; //Borra el rich de motivo
                    MessageBox.Show("LA FACTURA AHORA ESTÁ ACTIVA.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        //LLENAR EL REGISTRO DE PRECIO
        public void LlenarRegistroPrecio(DataGridView dgvRegistroPrecio)
        {
            int i;
            dgvRegistroPrecio.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Factura f in ListaFact)
            {
                if (f.Estadofact == "ACTIVO")
                {
                    i = dgvRegistroPrecio.Rows.Add();
                    dgvRegistroPrecio.Rows[i].Cells["clmNroFactRegistro"].Value = f.Serie;
                    dgvRegistroPrecio.Rows[i].Cells["clmPrecioFactRegistro"].Value = f.Total;
                    //dgvRegistroPrecio.Rows[i].Cells["DescuentoDataFact"].Value = f.Descuentofact;
                    //dgvRegistroPrecio.Rows[i].Cells["IvaDataFact"].Value = f.Iva;
                    //dgvRegistroPrecio.Rows[i].Cells["TotalDataFact"].Value = f.Total;
                    //dgvRegistroPrecio.Rows[i].Cells["EstadoDataFact"].Value = f.Estadofact;
                    //dgvRegistroPrecio.Rows[i].Cells["MotivoDataFact"].Value = f.Motivoinactivacion;
                }
            }
        }

        //Calcular el total de los precios
        public decimal CalcularSumaPrecios()
        {
            decimal sumaPrecios = 0;
            foreach (Factura f in ListaFact)
            {
                if (f.Estadofact == "ACTIVO")
                {
                    sumaPrecios += decimal.Parse(f.Total);
                }
            }
            return sumaPrecios;
        }


    }
}





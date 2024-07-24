using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Modelo;
using System.Numerics;
using Dato;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;


namespace Control
{
    public class CtrFactura
    {
        Conexion conn = new Conexion();
        DatoFactura dtFactura = new DatoFactura();


        public static List<Factura> listaFact = new List<Factura>();
        private static List<Membresia> listaMembresia = new List<Membresia>();
        public static List<Factura> ListaFact { get => listaFact; set => listaFact = value; }
        public static List<Membresia> ListaMembresia { get => listaMembresia; set => listaMembresia = value; }


        //Lista quemada
        //public CtrFactura()
        //{
        //    if (ListaFact.Count == 0)
        //    {
        //        ListaFact.Add(new Factura(1, "JKSD23FJ3D52K9 ", "144", "20%", "0.15", "136.80"));
        //        ListaFact.Add(new Factura(2, "JKDI43JYWHG3FG", "556", "24%", "0.15", "505.06"));
        //        ListaFact.Add(new Factura(3, "34TEOI0D07KGG7", "700", "13%", "0.15", "714"));
        //    }
        //}


        //Mostrar tabla BD
        public int GetTotal()
        {
            ListaFact = TablaConsultarFacturaBD(); // BASE DE DATOS
            return ListaFact.Count;
        }


        public List<Factura> TablaConsultarFacturaBD()
        {
            List<Factura> facturas = new List<Factura>();
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                facturas = dtFactura.SelectFact(conn.Connect);
            }
            else if (msjBD[0] == '0')
            {
                MessageBox.Show("ERROR: " + msjBD);
            }
            conn.CerrarConexion();
            return facturas;
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


        //Método para calcular datos ingresados
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




        //Guardar datos temporal
        public string IngresarFact(int numfactura, string preciofact, string descuentofact, string iva, string total, string serie, string cedula, string planMembresia)
        {
            string msg;
            Factura fact;
            Validacion val = new Validacion();

            string idCliente = SelectClienteBD(cedula);
            Console.WriteLine(idCliente);
            int idCli = val.ConvertirEntero(idCliente);
            Console.WriteLine(idCli);


            string idMembresia = SelectMembresiaBD(planMembresia);
            Console.WriteLine(idMembresia);
            int idMem = val.ConvertirEntero(idMembresia);
            Console.WriteLine(idMem);


            string motivoinactivacion = "";

            fact = new Factura(numfactura, serie, preciofact, descuentofact, iva, total, motivoinactivacion, idCli, idMem);
            fact.Estadofact = "ACTIVO";
            //double precioFact;
            //double descuentoFact;

            //if (double.TryParse(preciofact, out precioFact))
            //{
            //if (!string.IsNullOrEmpty(descuentofact) && double.TryParse(descuentofact, out descuentoFact) && descuentoFact > 0)
            //{
            //    fact.Total = CalcularTotal(precioFact, descuentoFact);
            //}
            //else
            //{
            //    fact.Total = CalcularTotal(precioFact, 0);
            //}
            //}
            //else
            //{
            //    msg = "Error: Valor de precio no válido";
            //    return msg;
            //}

            //listaFact.Add(fact);            
            IngresarFacturaBD(fact);
            msg = fact.ToString() + Environment.NewLine + "---REGISTRO EXITOSO---" + Environment.NewLine;

            return msg;
        }

        //PARA CLIENTE
        public string SelectClienteBD(string cedulaCliente)
        {
            string msj = string.Empty;
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                try
                {
                    string idCliente = dtFactura.SelectCliente(conn.Connect, cedulaCliente);
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



        //PARA MEMBRESIA
        public string SelectMembresiaBD(string planMembresia)
        {
            string msj = string.Empty;
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                try
                {
                    string idMembresia = dtFactura.SelectMembresia(conn.Connect, planMembresia);
                    if (!string.IsNullOrEmpty(idMembresia))
                    {
                        msj = idMembresia;
                    }
                    else
                    {
                        msj = "Membresia no encontrado.";
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








        //Ingresar-Guardar en el BD
        public void IngresarFacturaBD(Factura fact)
        {
            string msj = string.Empty;
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                msj = dtFactura.InsertFactura(fact, conn.Connect);
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




        //Consultar list BD
        //public int GetTotalFacturacion()
        //{
        //    ListaFact = TablaConsultarFacturaBD(); // BASE DE DATOS
        //    return ListaFact.Count;
        //}


        //public List<Factura> TablaConsultarFacturaBD(string estadofact)
        //{
        //    List<Factura> facturas = new List<Factura>();
        //    string msjBD = conn.AbrirConexion();

        //    if (msjBD[0] == '1')
        //    {
        //        facturas = dtFactura.SelectFact(conn.Connect, estadofact);
        //    }
        //    else if (msjBD[0] == '0')
        //    {
        //        MessageBox.Show("ERROR: " + msjBD);
        //    }
        //    conn.CerrarConexion();
        //    return facturas;
        //}


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
                //dgvRegistroFact.Rows[i].Cells["PrecioDataFact"].Value = f.Preciofact;
                //dgvRegistroFact.Rows[i].Cells["DescuentoDataFact"].Value = f.Descuentofact;
                dgvRegistroFact.Rows[i].Cells["IvaDataFact"].Value = f.Iva;
                dgvRegistroFact.Rows[i].Cells["TotalDataFact"].Value = f.Total;
                dgvRegistroFact.Rows[i].Cells["EstadoDataFact"].Value = f.Estadofact;
                dgvRegistroFact.Rows[i].Cells["MotivoDataFact"].Value = f.Motivoinactivacion;

                dgvRegistroFact.Rows[i].Cells["ClmCedulaCliente"].Value = f.Cliente?.Cedula ?? "N/A"; // Cedula del cliente
                dgvRegistroFact.Rows[i].Cells["ClmNombreCliente"].Value = f.Cliente?.Nombre ?? "N/A"; // Nombre del cliente
                dgvRegistroFact.Rows[i].Cells["ClmApellidoCliente"].Value = f.Cliente?.Apellido ?? "N/A"; // Apellido del cliente
                dgvRegistroFact.Rows[i].Cells["ClmTelefonoCliente"].Value = f.Cliente?.Telefono ?? "N/A";

                dgvRegistroFact.Rows[i].Cells["ClmPlanMembresia"].Value = f.Membresia?.Plan ?? "N/A";
                dgvRegistroFact.Rows[i].Cells["ClmPromocionMembresia"].Value = f.Membresia?.Promocion ?? "N/A";
                dgvRegistroFact.Rows[i].Cells["ClmDescuentoMembresia"].Value = f.Membresia != null ? f.Membresia.Descuento.ToString("F2") : "N/A"; // Formato con 2 decimales
                dgvRegistroFact.Rows[i].Cells["ClmPrecioMembresia"].Value = f.Membresia != null ? f.Membresia.Precio.ToString() : "N/A"; // Conversión a string

                //dgvRegistroFact
                //dgvRegistroFact
            }
        }


        //Buscar
        public void TablaConsultarNombreDescripcion(DataGridView dgvRegistroFact, string filtro = "", bool buscarPorNombrefact = true)
        {
            int i;
            dgvRegistroFact.Rows.Clear(); // LIMPIA FILAS SI LAS HAY
            foreach (Factura f in ListaFact)
            {
                if (string.IsNullOrEmpty(filtro) ||
                    (buscarPorNombrefact && f.Serie.ToString().Contains(filtro)) ||
                    (!buscarPorNombrefact && f.Preciofact.ToString().Contains(filtro)))
                {
                    i = dgvRegistroFact.Rows.Add();
                    dgvRegistroFact.Rows[i].Cells["FacturaRegistroFact"].Value = f.Serie;
                    //dgvRegistroFact.Rows[i].Cells["PrecioDataFact"].Value = f.Preciofact;
                    dgvRegistroFact.Rows[i].Cells["DescuentoDataFact"].Value = f.Descuentofact;
                    dgvRegistroFact.Rows[i].Cells["IvaDataFact"].Value = f.Iva;
                    dgvRegistroFact.Rows[i].Cells["TotalDataFact"].Value = f.Total;
                    dgvRegistroFact.Rows[i].Cells["EstadoDataFact"].Value = f.Estadofact;
                    dgvRegistroFact.Rows[i].Cells["MotivoDataFact"].Value = f.Motivoinactivacion;

                    dgvRegistroFact.Rows[i].Cells["ClmCedulaCliente"].Value = f.Cliente?.Cedula ?? "N/A"; // Cedula del cliente
                    dgvRegistroFact.Rows[i].Cells["ClmNombreCliente"].Value = f.Cliente?.Nombre ?? "N/A"; // Nombre del cliente
                    dgvRegistroFact.Rows[i].Cells["ClmApellidoCliente"].Value = f.Cliente?.Apellido ?? "N/A"; // Apellido del cliente
                    dgvRegistroFact.Rows[i].Cells["ClmTelefonoCliente"].Value = f.Cliente?.Telefono ?? "N/A";

                    dgvRegistroFact.Rows[i].Cells["ClmPlanMembresia"].Value = f.Membresia?.Plan ?? "N/A";
                    dgvRegistroFact.Rows[i].Cells["ClmPromocionMembresia"].Value = f.Membresia?.Promocion ?? "N/A";
                    dgvRegistroFact.Rows[i].Cells["ClmDescuentoMembresia"].Value = f.Membresia != null ? f.Membresia.Descuento.ToString("F2") : "N/A"; // Formato con 2 decimales
                    dgvRegistroFact.Rows[i].Cells["ClmPrecioMembresia"].Value = f.Membresia != null ? f.Membresia.Precio.ToString() : "N/A"; // Conversión a string
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


     
        public void EstadoFacturaBD(Factura fact)
        {
            string msj = string.Empty;
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                msj = dtFactura.UpdateEstadoFactura(fact, conn.Connect);
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




        //INACTIVAR FACTURA
        public void InactivarFactura(string serie, DataGridViewRow filaSeleccionada, DataGridView dgvRegistroFact)
        {

            DialogResult resultado = MessageBox.Show("¿DESEA INACTIVAR LA FACTURA SELECCIONADA?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                var factura = listaFact.FirstOrDefault(facto => facto.Serie == serie);
                if (factura != null)
                {
                    factura.estadofact = "INACTIVO"; //Pone el estado Inactivo a la factura
                    EstadoFacturaBD(factura);
                    LlenarDataFact(dgvRegistroFact);

                    //factura.motivoinactivacion = filaSeleccionada.Cells["MotivoDataFact"].Value.ToString();
                }
            }
        }




        //public void InactivarFactura(DataGridView dgvRegistroFact)
        //{
        //    if (dgvRegistroFact.SelectedRows.Count > 0)
        //    {
        //        int filaSeleccionada = dgvRegistroFact.SelectedRows[0].Index; // OBTIENE INDICE DE FILA SELECCIONADA

        //        if (filaSeleccionada >= 0)
        //        {
        //            string motivo = dgvRegistroFact.Rows[filaSeleccionada].Cells["FacturaRegistroFact"].Value.ToString(); // OBTENER NOMBRE DE FACTURA
        //            Factura factura = ListaFact.FirstOrDefault(a => a.Motivoinactivacion == motivo); // BUSCA FACTURA EN LISTA POR NOMBRE

        //            if (factura != null)
        //            {
        //                DialogResult resultado = MessageBox.Show("ESTAS SEGURO DE INACTIVAR ESTA FACTURA?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //                if (resultado == DialogResult.Yes)
        //                {
        //                    factura.Estadofact = "INACTIVO"; // ESTADO = INACTIVO
        //                    EstadoFacturaBD(factura); // BASE DE DATOS
        //                    LlenarDataFact(dgvRegistroFact);
        //                    MessageBox.Show("FACTURA INACTIVADA EXITOSAMENTE." + Environment.NewLine + factura.ToString(), "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("ERROR: SELECCIONA UNA FILA ANTES DE INACTIVAR UNA FACTURA.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}













        //RE-ACTIVAR FACTURA
        public void ActivarFactura(string serie, DataGridViewRow filaSeleccionada, DataGridView dgvRegistroFact)
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
                    EstadoFacturaBD(factura);
                    LlenarDataFact(dgvRegistroFact);
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
        public float CalcularSumaPrecios()
        {
            float sumaPrecios = 0;
            foreach (Factura f in ListaFact)
            {
                if (f.Estadofact == "ACTIVO")
                {
                    sumaPrecios += float.Parse(f.Preciofact);
                }
            }
            return sumaPrecios;
        }







        public List<Factura> GetListaFactura()
        {
            return TablaConsultarFacturaBD();
        }


        public void AbrirPDF()
        {
            if (File.Exists("REPORTE-PDF-FACTURAS.pdf")) // Verificar si el archivo PDF existe antes de intentar abrirlo
            {
                System.Diagnostics.Process.Start("REPORTE-PDF-FACTURAS.pdf"); // Abrir el archivo PDF con el visor de PDF predeterminado del sistema
            }
            else
            {
                MessageBox.Show("ARCHIVO PDF NO ENCONTRADO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarPDF()
        {
            FileStream stream = null;
            Document document = null;
            string[] etiquetas = { "NUMERO FACTURA", "PRECIO", "DESCUENTO" };
            int numCol = 3;
            List<Factura> facturas = GetListaFactura();

            try
            {
                // Crear documento PDF
                stream = new FileStream("REPORTE-PDF-FACTURAS.pdf", FileMode.Create);
                document = new Document(PageSize.A4, 5, 5, 7, 7);
                PdfWriter pdf = PdfWriter.GetInstance(document, stream);
                document.Open();

                // Crear fuentes
                iTextSharp.text.Font Miletra = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.NORMAL, BaseColor.RED);
                iTextSharp.text.Font letra = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.NORMAL, BaseColor.BLUE);

                // Agregar contenido al documento PDF
                document.Add(new Paragraph("CONSULTA DE FACTURAS ACTIVAS DEL GIMNASIO GYMRAT."));
                document.Add(Chunk.NEWLINE);

                PdfPTable table = new PdfPTable(numCol);
                table.WidthPercentage = 100;

                PdfPCell[] columnaT = new PdfPCell[etiquetas.Length];
                for (int i = 0; i < etiquetas.Length; i++)
                {
                    columnaT[i] = new PdfPCell(new Phrase(etiquetas[i], Miletra));
                    columnaT[i].BorderWidth = 0;
                    columnaT[i].BorderWidthBottom = 0.25f;
                    table.AddCell(columnaT[i]);
                }

                foreach (Factura fact in facturas)
                {
                    columnaT[0] = new PdfPCell(new Phrase(fact.Serie, letra));
                    columnaT[0].BorderWidth = 0;

                    columnaT[1] = new PdfPCell(new Phrase(fact.Preciofact, letra));
                    columnaT[1].BorderWidth = 0;

                    columnaT[2] = new PdfPCell(new Phrase(fact.Descuentofact, letra));
                    columnaT[2].BorderWidth = 0;

                    //columnaT[3] = new PdfPCell(new Phrase(fact.FechaFin.ToString("d"), letra));
                    //columnaT[3].BorderWidth = 0;

                    //columnaT[4] = new PdfPCell(new Phrase(fact.HoraInicio.ToString(@"hh\:mm"), letra));
                    //columnaT[4].BorderWidth = 0;

                    //columnaT[5] = new PdfPCell(new Phrase(fact.HoraFin.ToString(@"hh\:mm"), letra));
                    //columnaT[5].BorderWidth = 0;

                    table.AddCell(columnaT[0]);
                    table.AddCell(columnaT[1]);
                    table.AddCell(columnaT[2]);
                    //table.AddCell(columnaT[3]);
                    //table.AddCell(columnaT[4]);
                    //table.AddCell(columnaT[5]);
                }
                document.Add(table);
                document.Close();
                pdf.Close();

                MessageBox.Show("PDF GENERADO EXITOSAMENTE.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL GENERAR PDF: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                stream?.Close(); // Asegurarse de cerrar el FileStream incluso si ocurre una excepción
            }
        }


    }
}

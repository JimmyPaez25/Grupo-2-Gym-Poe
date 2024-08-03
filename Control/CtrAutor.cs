using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Dato;
using Modelo;

namespace Control
{
    public class CtrAutor
    {
        Conexion conn = new Conexion();
        DatoAutor dtAutor = new DatoAutor();

        private static List<Autor> listaAutor = new List<Autor>();
        public static List<Autor> ListaAutor { get => listaAutor; set => listaAutor = value; }

        public int GetTotal()
        {
            ListaAutor = TablaConsultarAutorBD(); // BASE DE DATOS
            return ListaAutor.Count;
        }

        public List<Autor> TablaConsultarAutorBD()
        {
            List<Autor> autor = new List<Autor>();
            string msjBD = conn.AbrirConexion();

            if (msjBD[0] == '1')
            {
                autor = dtAutor.SelectAutores(conn.Connect);
            }
            else if (msjBD[0] == '0')
            {
                MessageBox.Show("ERROR: " + msjBD);
            }
            conn.CerrarConexion();
            return autor;
        }

        // PRESENTAR REGISTROS TABLA AUTOR
        public void TablaConsultarAutor(DataGridView dgvAutor, Label labelNombreSistema, Label labelFechaCreacion)
        {
            int i = 0;
            dgvAutor.Rows.Clear(); // LIMPIA FILAS SI LAS HAY          
            dgvAutor.RowTemplate.Height = 200; // AJUSTAR ALTURA DE CELDAS DE TABLA

            foreach (Autor x in ListaAutor)
            {
                i = dgvAutor.Rows.Add();
                dgvAutor.Rows[i].Cells[0].Value = i + 1;
                dgvAutor.Rows[i].Cells[1].Value = x.NombreAutor;
                dgvAutor.Rows[i].Cells[2].Value = x.Email;
                dgvAutor.Rows[i].Cells[3].Value = x.Telefono;

                try
                {
                    if (x.Foto != null && x.Foto.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(x.Foto))
                        {
                            Image img = Image.FromStream(ms);
                            dgvAutor.Rows[i].Cells[4].Value = img;
                        }
                    }
                    else
                    {
                        dgvAutor.Rows[i].Cells[4].Value = null; // NO HAY IMAGEN DE AUTOR
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL CARGAR IMAGEN: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvAutor.Rows[i].Cells[4].Value = null; // NO MOSTRAR IMAGEN CORRUPTA
                }
                labelFechaCreacion.Text = x.FechaCreacion.ToString("d");
                labelNombreSistema.Text = x.NombreSistema;

            }
            // AJUSTAR ANCHO DE COLUMNAS
            dgvAutor.Columns[0].Width = 50;
            dgvAutor.Columns[1].Width = 200;
            dgvAutor.Columns[2].Width = 200;
            dgvAutor.Columns[3].Width = 100;

            // CONFIGURA ANCHO Y DESIGN DE COLUMNA DE IMAGEN
            DataGridViewImageColumn colFoto = (DataGridViewImageColumn)dgvAutor.Columns[4];
            colFoto.Width = 150; // AJUSTA ANCHO DE COLUMNA DE IMAGEN
            colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom; // AJUSTA DISENIO DE IMAGEN
        }


    // FIN
    }
}

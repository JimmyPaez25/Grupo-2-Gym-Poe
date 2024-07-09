using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DatoFactura
    {
        SqlCommand cmd = new SqlCommand();


        public void ImprimirSQL(string sentencia)
        {
            string sqlWithValues = sentencia;
            foreach (SqlParameter param in cmd.Parameters)
            {
                if (param.Value != null)
                {
                    sqlWithValues = sqlWithValues.Replace(param.ParameterName, param.Value.ToString());
                }
                else
                {
                    sqlWithValues = sqlWithValues.Replace(param.ParameterName, "NULL");
                }
            }
            Console.WriteLine("COMANDO SQL: " + sqlWithValues);
        }




        public string InsertFactura(Factura fact, SqlConnection conn)
        {
            Console.WriteLine("-----INSERT FACTURA-----");
            string x = "";
            string comando = "INSERT INTO Factura (numFactura, serie, precioFact, descuentoFact, iva, total, estadoFact) \n" +
                             "VALUES (@numfactura, @serie, @preciofact, @descuentofact, @iva, @total, @estadofact); \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@numfactura", fact.Numfactura);
                cmd.Parameters.AddWithValue("@serie", fact.Serie);
                cmd.Parameters.AddWithValue("@preciofact", fact.Preciofact);
                cmd.Parameters.AddWithValue("@descuentofact", fact.Descuentofact);
                cmd.Parameters.AddWithValue("@iva", fact.Iva);
                cmd.Parameters.AddWithValue("@total", fact.Total);
                cmd.Parameters.AddWithValue("@estadofact", fact.Estadofact);
                //cmd.Parameters.AddWithValue("@motivoinactivacion", DBNull.Value);


                //if (fact.motivoinactivacion != null)
                //{                    
                //    cmd.Parameters.AddWithValue("@motivoinactivacion", fact.motivoinactivacion);
                //}
                //else
                //{
                //    string motivoblanco = "NO ASIGNADO";
                //    cmd.Parameters.AddWithValue("@motivoinactivacion", DBNull.Value);
                //}

                ImprimirSQL(comando);
                cmd.ExecuteNonQuery();
                x = "1";
            }
            catch (SqlException ex)
            {
                x = "0" + ex.Message; Console.WriteLine(x);
            }
            return x;
        }




        //
        // SELECTS
        //
        public List<Factura> SelectFact(SqlConnection conn, string estadofact)
        {
            Console.WriteLine("-----SELECT Factura-----");
            List<Factura> facturas = new List<Factura>();
            SqlDataReader reader = null; // TABLA VIRTUAL
            Factura factdat;
            string comando = "SELECT numFactura, serie, precioFact, descuentoFact, iva, total, estadoFact FROM Factura WHERE estadoFact = @estadoFact; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@estadoFact", estadofact);

                ImprimirSQL(comando);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    factdat = new Factura();
                    factdat.Numfactura = Convert.ToInt32(reader["numFactura"]);
                    factdat.Serie = reader["serie"].ToString();
                    factdat.Preciofact = reader["precioFact"].ToString();
                    factdat.Descuentofact = reader["descuentoFact"].ToString();
                    factdat.Iva = reader["iva"].ToString();
                    factdat.Total = reader["total"].ToString();
                    factdat.estadofact = reader["estadoFact"].ToString();
                    factdat.motivoinactivacion = reader["motivoInactivacion"].ToString();

                    facturas.Add(factdat);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return facturas;
        }



        //aqui poner el motivo inac
        public string UpdateEstadoFactura(Factura fact, SqlConnection conn)
        {
            Console.WriteLine("-----UPDATE ESTADO Factura-----");
            string x = "";
            string comando = "UPDATE Factura SET \n" +
                             "numfactura = @numFactura \n" +
                             "serie = @serie \n" +
                             "preciofact = @precioFact \n " +
                             "descuentofact = @descuentoFact \n " +
                             "iva = @iva \n " +
                             "total = @total \n " +
                             "estadofact = @estadoFact \n" +
                             "motivoinactivacion = @motivoInactivacion \n " +
                             "WHERE serie = @serie; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@numFactura", fact.Numfactura);
                cmd.Parameters.AddWithValue("@serie", fact.Serie);
                cmd.Parameters.AddWithValue("@precioFact", fact.Preciofact);
                cmd.Parameters.AddWithValue("@descuentoFact", fact.Descuentofact);
                cmd.Parameters.AddWithValue("@iva", fact.Iva);
                cmd.Parameters.AddWithValue("@total", fact.Total);
                cmd.Parameters.AddWithValue("@estadoFact", fact.estadofact);
                cmd.Parameters.AddWithValue("@motivoInactivacion", fact.motivoinactivacion);

                ImprimirSQL(comando);
                cmd.ExecuteNonQuery();
                x = "1";
            }
            catch (SqlException ex)
            {
                x = "0" + ex.Message; Console.WriteLine(x);
            }
            return x;
        }
    }
}





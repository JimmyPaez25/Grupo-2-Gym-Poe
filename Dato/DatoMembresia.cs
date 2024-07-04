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
    public class DatoMembresia
    {
        SqlCommand cmd = new SqlCommand();

        //
        // INSERTS
        //
        public string InsertMembresia(Membresia mem, SqlConnection conn)
        {
            Console.WriteLine("-----INSERT MEMBRESIA-----");
            string x = "";
            string precio = mem.Precio.ToString().Replace(",", ".");
            string comando = "INSERT INTO Membresia (planMembresia, fechaInicio, fechaFin, promocion, descuento, detallePromocion, cedulaCliente, precio) \n" +
                             //"VALUES (@plan, @fechaInicio, @fechaFin, @fechaInicio, @promocion, @descuento, @detallePromocion, @cedulaCliente, @precio); \n";
                             "VALUES ('"+ mem.Plan + "', '"+ mem.FechaInicio + "', '"+ mem.FechaFin + "', '"+mem.Promocion+"', "+mem.Descuento+", '"+mem.DetallePromocion+"','"+mem.CedulaCliente+"', "+precio +"); \n";  
            Console.WriteLine(comando);
                           
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                //cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                //cmd.Parameters.AddWithValue("@plan", mem.Plan);
                //cmd.Parameters.AddWithValue("@fechaInicio", mem.FechaInicio.ToString("yyyy-MM-dd"));
                //cmd.Parameters.AddWithValue("@fechaFin", mem.FechaFin.ToString("yyyy-MM-dd"));
                //cmd.Parameters.AddWithValue("@promocion", mem.Promocion);
                //cmd.Parameters.AddWithValue("@descuento", mem.Descuento);
                //cmd.Parameters.AddWithValue("@detallePromocion", mem.DetallePromocion);
                //cmd.Parameters.AddWithValue("@precio", mem.Precio);
                //cmd.Parameters.AddWithValue("@cedulaCliente", mem.CedulaCliente);



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
        //        public List<Membresia> SelectMembresia(SqlConnection conn, int estado)
        //        {
        //            Console.WriteLine("-----SELECT Membresia-----");
        //            List<Membresia> membresias = new List<Membresia>();
        //            SqlDataReader reader = null; // TABLA VIRTUAL
        //            Membresia membresia = null;
        //            string comando = "SELECT plan, fechaInicio, fechaFin, promocion, descuento, detallePromocion, precio; \n";

        //            try
        //            {
        //                cmd.Connection = conn;
        //                cmd.CommandText = comando;

        //                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
        //                cmd.Parameters.AddWithValue("@estado", estado);

        //                reader = cmd.ExecuteReader();

        //                while (reader.Read())
        //                {
        //                    membresia = new Membresia();
        //                    membresia.Plan = Convert.ToInt32(reader["plan"]);


        //                    membresias.Add(membresia);
        //                }
        //            }
        //            catch (SqlException ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //            return membresia;
        //        }
    }
}

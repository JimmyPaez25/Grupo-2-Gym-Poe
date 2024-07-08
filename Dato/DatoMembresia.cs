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

        public void ImprimirSQL(string sentencia)
        {
            string sqlWithValues = sentencia;
            foreach (SqlParameter param in cmd.Parameters)
            {
                sqlWithValues = sqlWithValues.Replace(param.ParameterName, param.Value.ToString());
            }
            Console.WriteLine("COMANDO SQL: " + sqlWithValues);
        }
        //
        // INSERTS
        //
        public string InsertMembresia(Membresia mem, SqlConnection conn)
        {
            Console.WriteLine("-----INSERT MEMBRESIA-----");
            string x = "";
            string precio = mem.Precio.ToString().Replace(",", ".");
            string comando = "INSERT INTO Membresia (planMembresia, fechaInicio, fechaFin, promocion, descuento, detallePromocion, cedulaCliente, precio) \n" +
                             "VALUES (@plan, @fechaInicio, @fechaFin, @promocion, @descuento, @detallePromocion, @cedulaCliente, @precio); \n";
            //"VALUES ('"+ mem.Plan + "', '"+ mem.FechaInicio + "', '"+ mem.FechaFin + "', '"+mem.Promocion+"', "+mem.Descuento+", '"+mem.DetallePromocion+"','"+mem.CedulaCliente+"', "+precio +"); \n";  
            Console.WriteLine(comando);
                           
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@plan", mem.Plan);
                cmd.Parameters.AddWithValue("@fechaInicio", mem.FechaInicio.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@fechaFin", mem.FechaFin.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@promocion", mem.Promocion);
                cmd.Parameters.AddWithValue("@descuento", mem.Descuento);
                cmd.Parameters.AddWithValue("@detallePromocion", mem.DetallePromocion);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@cedulaCliente", mem.CedulaCliente);


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

        public List<Membresia> SelectMembresias(SqlConnection conn)
        {
            Console.WriteLine("-----SELECT MEMBRESIA-----");
            List<Membresia> membresias = new List<Membresia>();
            SqlDataReader reader = null; // TABLA VIRTUAL
            Membresia membresia = null;
            string comando = "SELECT  planMembresia, fechaInicio, fechaFin, promocion, descuento, detallePromocion, cedulaCliente, precio FROM Membresia ; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                ImprimirSQL(comando);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    membresia = new Membresia();
                    membresia.Plan = reader["planMembresia"].ToString();
                    membresia.FechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
                    membresia.FechaFin = Convert.ToDateTime(reader["fechaFin"]);
                    membresia.Promocion = reader["promocion"].ToString();
                    membresia.Descuento = Convert.ToInt32(reader["descuento"]);
                    membresia.DetallePromocion = reader["detallePromocion"].ToString();
                    membresia.CedulaCliente = reader["cedulaCliente"].ToString();
                    membresia.Precio = Convert.ToDouble(reader["precio"]);

                    membresias.Add(membresia);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return membresias;
        }

        public string UpdateCamposMembresia(Membresia mem, SqlConnection conn, string SNombrePlan)
        {
            Console.WriteLine("-----UPDATE CAMPOS MEMBRESIA-----");
            string x = "";
            string comando = "UPDATE Membresia SET \n" +
                             "planMembresia = @plan, \n" +
                             "fechaInicio = @fechaInicio, \n" +
                             "fechaFin = @fechaFin, \n" +
                             "promocion = @promocion, \n" +
                             "descuento = @descuento, \n" +
                             "detallePromocion = @detallePromocion, \n" +
                             "cedulaCliente = @cedulaCliente, \n" +
                             "precio = @precio \n" +
                             "WHERE planMembresia = @nombrePlan; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@plan", mem.Plan);
                cmd.Parameters.AddWithValue("@fechaInicio", mem.FechaInicio.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@fechaFin", mem.FechaFin.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@promocion", mem.Promocion);
                cmd.Parameters.AddWithValue("@descuento", mem.Descuento);
                cmd.Parameters.AddWithValue("@detallePromocion", mem.DetallePromocion);
                cmd.Parameters.AddWithValue("@cedulaCliente", mem.CedulaCliente);
                cmd.Parameters.AddWithValue("@precio", mem.Precio);
                cmd.Parameters.AddWithValue("@nombrePlan", SNombrePlan);
;

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
        public string DeleteMembresia(Membresia mem, SqlConnection conn)
        {
            Console.WriteLine("-----DELETE MEMBRESIA-----");
            string x = "";
            string comando = "DELETE FROM Membresia WHERE planMembresia = @plan; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@plan", mem.Plan);

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
        // FIN
    }
}

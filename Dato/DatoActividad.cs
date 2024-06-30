using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Dato
{
    // GONZALEZ ASTUDILLO ADRIAN
    public class DatoActividad
    {
        SqlCommand cmd = new SqlCommand();

        //
        // INSERTS
        //
        public string InsertActividad(Actividad act, SqlConnection conn)
        {
            Console.WriteLine("-----INSERT ACTIVIDAD-----");
            string x = "";
            string comando = "INSERT INTO Actividad(Estado, Nombre, Descripcion, FechaInicio, FechaFin, HoraInicio, HoraFin) \n" +
                             "VALUES (@Estado, @Nombre, @Descripcion, @FechaInicio, @FechaFin, @HoraInicio, @HoraFin); \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@Estado", act.Estado);
                cmd.Parameters.AddWithValue("@Nombre", act.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", act.Descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", act.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", act.FechaFin);
                cmd.Parameters.AddWithValue("@HoraInicio", act.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", act.HoraFin);

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
        public List<Actividad> SelectActividades(SqlConnection conn, int estado)
        {
            Console.WriteLine("-----SELECT ACTIVIDAD-----");
            List<Actividad> actividades = new List<Actividad>();
            SqlDataReader reader = null; // TABLA VIRTUAL
            Actividad actividad = null;
            string comando = "SELECT Estado, Nombre, Descripcion, FechaInicio, FechaFin, HoraInicio, HoraFin FROM Actividad WHERE Estado = @Estado; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@Estado", estado);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    actividad = new Actividad();
                    actividad.Estado = Convert.ToInt32(reader["Estado"]);
                    actividad.Nombre = reader["Nombre"].ToString();
                    actividad.Descripcion = reader["Descripcion"].ToString();
                    actividad.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
                    actividad.FechaFin = Convert.ToDateTime(reader["FechaFin"]);
                    actividad.HoraInicio = TimeSpan.Parse(reader["HoraInicio"].ToString());
                    actividad.HoraFin = TimeSpan.Parse(reader["HoraFin"].ToString());

                    actividades.Add(actividad);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return actividades;
        }

        //public List<Actividad> SelectActividades(SqlConnection conn)
        //{
        //    List<Actividad> actividades = new List<Actividad>();
        //    SqlDataReader reader = null; // TABLA VIRTUAL
        //    Actividad actividad = null;
        //    string comando = "SELECT Estado, Nombre, Descripcion, FechaInicio, FechaFin, HoraInicio, HoraFin FROM Actividad; \n";

        //    try
        //    {
        //        cmd.Connection = conn;
        //        cmd.CommandText = comando;
        //        reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            actividad = new Actividad();
        //            actividad.Estado = Convert.ToInt32(reader["Estado"]);
        //            actividad.Nombre = reader["Nombre"].ToString();
        //            actividad.Descripcion = reader["Descripcion"].ToString();
        //            actividad.FechaInicio = Convert.ToDateTime(reader["FechaInicio"]);
        //            actividad.FechaFin = Convert.ToDateTime(reader["FechaFin"]);
        //            actividad.HoraInicio = TimeSpan.Parse(reader["HoraInicio"].ToString());
        //            actividad.HoraFin = TimeSpan.Parse(reader["HoraFin"].ToString());

        //            actividades.Add(actividad);
        //        }
        //    }
        //    catch(SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return actividades;
        //}

        //
        // UPDATES
        //
        public string UpdateCamposActividad(Actividad act, SqlConnection conn, string sNombreOriginal)
        {
            Console.WriteLine("-----UPDATE ACTIVIDAD-----");
            string x = "";
            string comando = "UPDATE Actividad SET \n" +
                             "Nombre = @Nombre, \n" +
                             "Descripcion = @Descripcion, \n" +
                             "FechaInicio = @FechaInicio, \n" +
                             "FechaFin = @FechaFin, \n" +
                             "HoraInicio = @HoraInicio, \n" +
                             "HoraFin = @HoraFin \n" +
                             "WHERE Nombre = @NombreOriginal; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@Nombre", act.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", act.Descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", act.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", act.FechaFin);
                cmd.Parameters.AddWithValue("@HoraInicio", act.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", act.HoraFin);
                cmd.Parameters.AddWithValue("@NombreOriginal", sNombreOriginal);

                cmd.ExecuteNonQuery();
                x = "1";
            }
            catch (SqlException ex)
            {
                x = "0" + ex.Message; Console.WriteLine(x);
            }
            return x;
        }

        public string UpdateEstadoActividad(Actividad act, SqlConnection conn)
        {
            Console.WriteLine("-----UPDATE ACTIVIDAD-----");
            string x = "";
            string comando = "UPDATE Actividad SET \n" +
                             "Estado = @Estado \n" +
                             "WHERE Nombre = @Nombre; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear(); // LIMPIA PARAMETROS UTILIZADOS
                cmd.Parameters.AddWithValue("@Estado", act.Estado);
                cmd.Parameters.AddWithValue("@Nombre", act.Nombre);

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
        // DELETES
        //
        public string DeleteActividad(Actividad act, SqlConnection conn)
        {
            Console.WriteLine("-----DELETE ACTIVIDAD-----");
            string x = "";
            string comando = "DELETE FROM Actividad WHERE Nombre = @Nombre; \n";

            try
            {
                cmd.Connection= conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", act.Nombre);

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

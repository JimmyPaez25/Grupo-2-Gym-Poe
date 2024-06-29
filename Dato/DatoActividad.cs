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

        public string IngresarActividad(Actividad act, SqlConnection conn)
        {
            Console.WriteLine("-----INSERT ACTIVIDAD-----");
            string resultado;
            string comando = "INSERT INTO Actividad(Estado, Nombre, Descripcion, FechaInicio, FechaFin, HoraInicio, HoraFin) \n" +
                             "VALUES (@Estado, @Nombre, @Descripcion, @FechaInicio, @FechaFin, @HoraInicio, @HoraFin); \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.AddWithValue("@Estado", act.Estado);
                cmd.Parameters.AddWithValue("@Nombre", act.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", act.Descripcion);
                cmd.Parameters.AddWithValue("@FechaInicio", act.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", act.FechaFin);
                cmd.Parameters.AddWithValue("@HoraInicio", act.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", act.HoraFin);

                cmd.ExecuteNonQuery();
                resultado = "1";
            }
            catch (Exception ex)
            {
                resultado = "0" + ex.Message;
                Console.WriteLine(resultado);
            }
            return resultado;
        }



    }
}

using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DatoAutor
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
        // SELECTS
        //
        public List<Autor> SelectAutores(SqlConnection conn)
        {
            Console.WriteLine("-----SELECT AUTOR-----");
            List<Autor> autores = new List<Autor>();
            SqlDataReader reader = null; // TABLA VIRTUAL
            Autor autor = null;
            string comando = "SELECT nombreSistema, nombreAutor, email, telefono, fechaCreacion,foto FROM Autor; \n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;
                ImprimirSQL(comando);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    autor = new Autor();
                    autor.NombreSistema = reader["nombreSistema"].ToString();
                    autor.NombreAutor = reader["nombreAutor"].ToString();
                    autor.Email = reader["email"].ToString();
                    autor.Telefono = Convert.ToInt32(reader["telefono"]);
                    autor.FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]);

                    // LEER IMAGEN COMO BYTE
                    if (reader["foto"] != DBNull.Value)
                    {
                        autor.Foto = (byte[])reader["foto"];
                    }
                    else
                    {
                        autor.Foto = null; // NO HAY FOTO
                    }

                    autores.Add(autor);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return autores;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;

namespace Dato
{
    public class DatoCliente
    {
        DateTime fecha = DateTime.Now;
        SqlCommand cmd = new SqlCommand();
        //
        //INSERT
        //
        public string InsertarCliente(Cliente cli, SqlConnection conn)
        {
            Console.WriteLine("-----INSERT CLIENTE-----");
            string x = "";
            string comando = "INSERT INTO Cliente(cedula, nombre, apellido, fechaNacimiento, telefono, direccion, estado)\n" +
                "VALUES (@cedula, @nombre, @apellido, @fechaNacimiento, @telefono, @direccion, @estado);\n";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cedula", cli.Cedula);
                cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cli.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", cli.FechaNacimiento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                cmd.Parameters.AddWithValue("@direccion", cli.Direccion);
                cmd.Parameters.AddWithValue("@estado", cli.Estado);

                cmd.ExecuteNonQuery();

                x = "1";
            }catch (SqlException ex)
            { 
                x = "0" + ex.Message;
                Console.WriteLine(x);
            }
            return x;
        }

        //
        //SELECT
        //
        public List<Cliente> ConsultarCliente(SqlConnection cn) 
        { 
            List<Cliente> clientes = new List<Cliente>();
            SqlDataReader dr = null;
            Cliente cli = null;

            string comando = "SELECT cedula, nombre, apellido, fechaNacimiento, telefono, direccion, estado FROM Cliente";
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cli = new Cliente("", "","",fecha,"","",""); ;
                    cli.Cedula = dr["cedula"].ToString();
                    cli.Nombre = dr["nombre"].ToString();
                    cli.Apellido = dr["apellido"].ToString();
                    cli.FechaNacimiento = DateTime.Parse(dr["fechaNacimiento"].ToString());
                    cli.Telefono = dr["telefono"].ToString();
                    cli.Direccion = dr["direccion"].ToString();
                    cli.Estado = dr["estado"].ToString();

                    clientes.Add(cli);
                }
            }catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return clientes;
        }
    }
}

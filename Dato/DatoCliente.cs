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
        //INSERT
        //
        public string InsertarCliente(Cliente cli, SqlConnection conn)
        {
            Console.WriteLine("-----INSERT CLIENTE-----");
            string x = "";
            string comando = "INSERT INTO Cliente(cedula, nombre, apellido, fechaNacimiento, telefono, direccion, estado, tipo, comprobante)\n" +
                "VALUES (@cedula, @nombre, @apellido, @fechaNacimiento, @telefono, @direccion, @estado, @tipo, @comprobante);\n";

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

                if (cli is ClienteEstudiante cliEst)
                {
                    cmd.Parameters.AddWithValue("@tipo", "ESTUDIANTE");
                    cmd.Parameters.AddWithValue("@comprobante", cliEst.Comprobante);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@tipo", "ESTANDAR");
                    cmd.Parameters.AddWithValue("@comprobante", DBNull.Value);
                }
                ImprimirSQL(comando);
                cmd.ExecuteNonQuery();

                x = "1";
            }
            catch (SqlException ex)
            {
                x = "0" + ex.Message;
                Console.WriteLine(x);
            }
            return x;
        }

        //
        //SELECT
        //
        public List<Cliente> SeleccionarCliente(SqlConnection cn)
        {
            Console.WriteLine("-----SELECT CLIENTE-----");
            List<Cliente> clientes = new List<Cliente>();
            SqlDataReader dr = null;
            Cliente cli = null;

            string comando = "SELECT cedula, nombre, apellido, fechaNacimiento, telefono, direccion, estado, tipo, comprobante FROM Cliente";
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;

                ImprimirSQL(comando);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string tipo = dr["tipo"]?.ToString();

                    if (tipo == "ESTUDIANTE")
                    {
                        cli = new ClienteEstudiante(
                            dr["cedula"].ToString(),
                            dr["nombre"].ToString(),
                            dr["apellido"].ToString(),
                            DateTime.Parse(dr["fechaNacimiento"].ToString()),
                            dr["telefono"].ToString(),
                            dr["direccion"].ToString(),
                            dr["estado"].ToString(),
                            dr["comprobante"].ToString()
                        );
                    }
                    else
                    {
                        cli = new Cliente(
                            dr["cedula"].ToString(),
                            dr["nombre"].ToString(),
                            dr["apellido"].ToString(),
                            DateTime.Parse(dr["fechaNacimiento"].ToString()),
                            dr["telefono"].ToString(),
                            dr["direccion"].ToString(),
                            dr["estado"].ToString()
                        );


                    }

                    clientes.Add(cli);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return clientes;
        }
        //
        // UPDATE
        //
        public string UpdateCliente(Cliente cli, SqlConnection cn, string uCedulaOrg)
        {
            Console.WriteLine("-----UPDATE CLIENTES-----");
            string x = "";
            string comando = "UPDATE Cliente SET \n" +
                             "cedula = @cedula, \n" +
                             "nombre = @nombre, \n" +
                             "apellido = @apellido, \n" +
                             "fechaNacimiento = @fechaNacimiento, \n" +
                             "telefono = @telefono, \n" +
                             "direccion = @direccion, \n" +
                             "estado = @estado, \n" +
                             "tipo = @tipo, \n" +
                             "comprobante = @comprobante \n" +
                             "WHERE cedula = @cedulaOrg; \n";
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = comando;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cedula", cli.Cedula);
                cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cli.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", cli.FechaNacimiento.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                cmd.Parameters.AddWithValue("@direccion", cli.Direccion);
                cmd.Parameters.AddWithValue("@estado", cli.Estado);
                cmd.Parameters.AddWithValue("@cedulaOrg", uCedulaOrg);

                if (cli is ClienteEstudiante cliEst)
                {
                    cmd.Parameters.AddWithValue("@tipo", "ESTUDIANTE");
                    cmd.Parameters.AddWithValue("@comprobante", cliEst.Comprobante);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@tipo", "ESTANDAR");
                    cmd.Parameters.AddWithValue("@comprobante", DBNull.Value);
                }
                ImprimirSQL(comando);
                cmd.ExecuteNonQuery();
                x = "1";
            }
            catch (SqlException ex)
            {
                x = "0" + ex.Message;
                Console.WriteLine(x);
            }

            return x;
        }

    }
}

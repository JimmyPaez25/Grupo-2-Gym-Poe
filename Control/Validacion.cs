using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Control
{
    public class Validacion
    {
        public int ConvertirEntero(String dato)
        {
            int valor = -1;
            try
            {
                if (dato.Equals("") && string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("ERROR: DATO VACIO.\n");
                }
                else
                {
                    valor = Convert.ToInt32(dato);
                }

                if (valor == -1)
                {
                    Console.WriteLine("ERROR: DATO DEBE SER NUMERO ENTERO.\n");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: DATO INVALIDO.\n");
                //Console.WriteLine("ERROR namespace:Control/ class:Validacion/ aEntero: {0}\n", ex);
            }
            return valor;
        }

        public double ConvertirDouble(string dato)
        {
            double valor = -1;
            try
            {
                if (dato.Equals("") && string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("ERROR: DATO VACIO.\n");
                }
                else
                {
                    valor = Convert.ToDouble(dato, CultureInfo.InvariantCulture);
                }

                if (valor <= 0)
                {
                    Console.WriteLine("ERROR: DATO DEBE SER MAYOR A CERO.\n");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: DATO INVALIDO.\n");
                //Console.WriteLine("ERROR namespace:Control/ class:Validacion/ aDouble: {0}\n", ex);
            }
            return valor;
        }

        public double ConvertirReal(string dato)
        {
            double valor = -1;
            try
            {
                if (dato.Equals("") && string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("ERROR: DATO VACIO.\n");
                }
                else
                {
                    valor = Convert.ToDouble(dato);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: SE ESPERABA UN NUMERO REAL.");
            }
            return valor;
        }

        public char ConvertirChar(string dato)
        {
            char valor = ' ';
            try
            {
                if (dato.Equals("") && string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("ERROR: DATO VACIO.\n");
                }
                else
                {
                    valor = Convert.ToChar(dato[0]);
                }

                if (dato.Length > 1)
                {
                    Console.WriteLine("ERROR: SOLO PUEDE INGRESAR 1 LETRA.\n");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: DATO INVALIDO.\n");
                //Console.WriteLine("ERROR namespace:Control/ class:Validacion/ aChar: {0}\n", ex);
            }
            return valor;
        }

        public void ValidarLetra(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetter(letra) && letra != ' ' && letra != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        public void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) && letra != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        public void ValidarCantidad(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) && letra != (char)Keys.Back && letra != ',')
            {
                e.Handled = true;
                return;
            }
        }

        public void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetterOrDigit(letra) && letra != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

    }
}

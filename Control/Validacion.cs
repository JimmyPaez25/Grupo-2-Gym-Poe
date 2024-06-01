using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Control
{
    public class Validacion
    {
        public int aEntero(String dato)
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

        public double aDouble(string dato)
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

        public char AChar(String dato)
        {
            char valueC = ' ';
            try
            {
                valueC = Convert.ToChar(dato[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Dato Invalido");
            }


            return valueC;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversor
{
    class DecimalBinario
    {
        public static string InverterString(string str)
        {

            int tamanho = str.Length;

            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {

                caracteres[i] = str[tamanho - 1 - i];

            }

            return new string(caracteres);

        }

        public string DecimalParaBinario(string numero)
        {

            string valor = "";

            int dividendo = Convert.ToInt32(numero);

            if (dividendo == 0 || dividendo == 1)
            {

                return Convert.ToString(dividendo);

            }

            else
            {

                while (dividendo > 0)
                {

                    valor += Convert.ToString(dividendo % 2);

                    dividendo = dividendo / 2;

                }
              
                return InverterString(valor);
            }

        }

    }
}

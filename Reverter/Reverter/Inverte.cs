using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverter
{
    class Inverte
    {
        public string Inverter(string Texto)
        {
            char[] revertido = Texto.ToCharArray();
            char[] texto2 = Texto.ToCharArray();

            for (int x = (Texto.Length) - 1, j = 0; x >= 0; x--, j++)
                revertido[j] = texto2[x];

            return new string(revertido);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversor
{
    class BinarioDecimal
    {
        public int BinarioParaDecimal(string numero)
        {
            char[] verificar = numero.ToCharArray();
            bool passar = false;
            for (int i = 0; i < numero.Length; i++)
            {
                if (verificar[i].Equals('0') || verificar[i].Equals('1'))
                {
                    passar = true;
                }
                else
                {
                    passar = false;
                    break;
                }
            }
            if (passar)
            {
                return Convert.ToInt32(numero, 2);
            }
            else return 2;
        }
    }
}

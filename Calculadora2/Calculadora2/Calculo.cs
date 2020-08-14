using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora2
{
    class Calculo
    {
        public double fibo(double n)
        {
            if (n == 0)
                return (0);
            else if (n == 1)
                return (1);
            else
                return (fibo(n - 1) + fibo(n - 2));
        }

        public double fat(double n)
        {
            double i, fat;

            fat = 1;

            for (i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            return fat;
        }
    }
}

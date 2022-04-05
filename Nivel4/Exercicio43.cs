using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio43
    {
        static void Main43(string[] args)
        {
            double result;
            double i = 2;
            double j = 0;

            while (j <= 64)
            {
                result = Math.Pow(i, j);
                j++;
                Console.WriteLine("Resultado -> " + result);
            }
        }
    }
}

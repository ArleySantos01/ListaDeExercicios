using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio35
    {
        static void Main35(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i%10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10 -> " + i);
                }
            }
        }
    }
}

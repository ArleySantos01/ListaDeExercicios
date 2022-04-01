using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio30
    {
        static void Main30(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int total = 0;
                    total = i * j;
                    Console.WriteLine("" + i + "X" + j + "" + " = " + "" + total);
                }
            }
        }
    }
}

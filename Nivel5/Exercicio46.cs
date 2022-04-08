using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio46
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite o número limite da array");
            n = Convert.ToInt32(Console.ReadLine());
            double[] x = new double[n];
            double[] y = new double[n];
            double total = 0.0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Números x");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Números y");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                total += (x[i] * y[i]);
            }
            Console.WriteLine("total -> " + total);
        }
    }
}

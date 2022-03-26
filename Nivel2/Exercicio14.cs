using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio14
    {
        static void Main14(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double[] total1 = new double[2];
            double[] total2 = new double[2];

            Console.WriteLine("Digite o valor de A: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("Valor B -> " + num2);
                Console.WriteLine("Valor A -> " + num1);
                for (int i = 0; i < total1.Length; i++)
                {                
                    total1[i] = num1 / num2;
                }
                Array.Sort(total1);

                Console.WriteLine("Resultados: ");
                foreach (var resultado1 in total1)
                {
                    Console.WriteLine(resultado1 + "");
                }
            }

            if (num2 < num1)
            {
                Console.WriteLine("Valor de A -> " + num1);
                Console.WriteLine("Valor de B -> " + num2);
                for (int i = 0; i < total2.Length; i++)
                {
                    total2[i] = num2 / num1;
                }
                Array.Sort(total2);

                Console.WriteLine("Resultados: ");
                foreach (var resultado2 in total2)
                {
                    Console.WriteLine(resultado2 + "");
                }
            }
        }
    }
}

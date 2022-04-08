using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio49
    {
        static void Main(string[] args)
        {
            int n;
            int conte = 0;
            Console.WriteLine("Digite o limite dos vetores");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 50)
            {
                int[] vetor1 = new int[n];
                int[] vetor2 = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Vetor 1 -> ");
                    vetor1[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Vetor 2 -> ");
                    vetor2[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    if (vetor1[i] == vetor2[i])
                    {
                        conte++;
                        Console.WriteLine("Vetor 1 -> " + vetor1[i] + "\tVetor 2 -> " + vetor2[i]);
                    }
                }
                Console.WriteLine("Repetições acontecem " + conte + " vezes");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio54
    {
        static void Main54(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[8];  

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite os numeros do vetor 1");
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite os numeros do vetor 2");
                vetor2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= 8; i++)
            {
                if (vetor1[i] == vetor2[i])
                {
                    Console.WriteLine("Vetor 1 -> " + vetor1[i] + "\tVetor 2 -> " + vetor2[i]);
                }
            }
        }
    }
}

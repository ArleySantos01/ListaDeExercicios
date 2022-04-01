using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio27
    {
        static void Main27(string[] args)
        {
            int processeNumeros = 0;
            int entreNumeros = 0;
            int fatorial = 0;
            Console.WriteLine("Digite o a quantidade de números a serem processados");
            processeNumeros = Convert.ToInt32(Console.ReadLine());

            for (int i = processeNumeros; i >= 1; i--)
            {
                Console.WriteLine("Digite um número");
                entreNumeros = Convert.ToInt32(Console.ReadLine());
                fatorial = entreNumeros;

                for (int j = i; j > 0; j--)
                {
                    fatorial *= j;
                    Console.WriteLine("fatorial -> " + fatorial);
                }
            }

        }
    }
}

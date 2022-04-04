using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio32
    {
        static void Main32(string[] args)
        {
            int numero = 0;
            int totalQuadrado = 0;
            int totalSoma = 0;
            int i = 0;
            do
            {
                Console.WriteLine("Digite um número ímpar entre 0 e 10: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero%2 == 1 && numero > 0  && numero < 10)
                {
                    totalQuadrado = numero * numero;
                    totalSoma += totalQuadrado;
                }

                i++;
            } while(numero > 0 && numero < 10 && i < 20);

            Console.WriteLine("Soma dos quadrados dos numeros ímpares -> " + totalSoma);
        }
    }
}

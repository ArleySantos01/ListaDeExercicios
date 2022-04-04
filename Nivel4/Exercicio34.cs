using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio34
    {
        static void Main34(string[] args)
        {
            int[] conjuntoNumero = new int[50];
            int i = 0;
            int numero = 0;

            do
            {
                Console.WriteLine("Digite um número positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Deseja continuar [S/N]?");

                if (numero < 0)
                {
                    i++;
                    break;
                }
                conjuntoNumero[i] = numero;
                i++;
            } while (numero > 0);

            int minInt = conjuntoNumero[0];
            int maxInt = conjuntoNumero[0];

            foreach (int var in conjuntoNumero)
            {
                if (var < minInt)
                {
                    minInt = var;
                    Console.WriteLine("Menor número -> " + minInt);
                }

                if (var > minInt)
                {
                    maxInt = var;
                    Console.WriteLine("Maior número -> " + maxInt);
                }
            }
        }
    }
}

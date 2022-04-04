using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio31
    {
        static void Main31(string[] args)
        {
            int numero = 0;           
            int total1 = 0; 
            int total2 = 0;
            int i = 0;

            do
            {
                Console.WriteLine("Digite os números: ");

                if ((numero = Convert.ToInt32(Console.ReadLine())) % 2 == 0)
                {
                    Console.WriteLine("Número par");
                    total1 += numero;
                }

                else if (numero % 2 == 1)
                {
                    Console.WriteLine("Número ímpar");
                    total2 += numero;
                }

                Console.WriteLine("Se deseja encerrar digite um número negativo");
                if (numero < 0)
                {
                    break;
                }

                i++;
            } while (numero > 0);

            Console.WriteLine("Total de iterações -> " + i);
            Console.WriteLine("Soma dos números pares -> " + total1);
            Console.WriteLine("Soma dos números ímpares -> " + total2);
        }
    }
}

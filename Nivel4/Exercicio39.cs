using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio39
    {
        static void Main39(string[] args)
        {
            int numero = 0;
            char cancelar = 'n';

            do
            {
                Console.WriteLine("Digite um número:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Número negativo");
                }

                if (numero > 0)
                {
                    Console.WriteLine("Número positivo");
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Número par");
                }

                if (numero % 2 == 1)
                {
                    Console.WriteLine("Número ímpar");
                }

                if (cancelar == 's' || cancelar == 'S')
                {
                    break;
                }

                Console.WriteLine("\nDeseja finalizar [S/N]?");
                cancelar = Console.ReadKey().KeyChar;

                if (cancelar == 's' || cancelar == 'S')
                {
                    break;
                }
            } while (cancelar != 's' || cancelar != 'S');
        }
    }
}

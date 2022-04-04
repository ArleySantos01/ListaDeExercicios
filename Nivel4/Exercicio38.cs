using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio38
    {
        static void Main38(string[] args)
        {
            char cancelar = 's';
            string codigo = "";
            int numeroHoras = 0;
            int excessoHoras = 0;
            int total = 0;

            do
            {
                Console.WriteLine("Digite o código do operário:");
                codigo = Console.ReadLine();
                Console.WriteLine("Digite o número de horas");
                numeroHoras = Convert.ToInt32(Console.ReadLine());
                total = 10 * numeroHoras;

                if (numeroHoras > 50)
                {
                    excessoHoras = 20 * numeroHoras;
                    Console.WriteLine("Valor excedente -> " + excessoHoras);
                }

                else
                {
                    excessoHoras = 0;
                }

                Console.WriteLine("Deseja finalizar [S/N]?");
                cancelar = Console.ReadKey().KeyChar;
                if (cancelar == 's' || cancelar == 'S')
                {
                    Console.WriteLine("\nFinalizado");
                    break;
                }
            } while (cancelar != 's' || cancelar != 'S');
            Console.WriteLine("Salário total -> " + total);
            Console.WriteLine("Valor excedente -> " + excessoHoras);
        }
    }
}

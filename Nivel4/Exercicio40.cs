using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio40
    {
        static void Main(string[] args)
        {
            double controlePoluicao = 0.0;
            char cancelar = 'n';

            do
            {
                Console.WriteLine("Digite o índice de poluição:");
                controlePoluicao = Convert.ToDouble(Console.ReadLine());

                if (controlePoluicao <= 0.05 || controlePoluicao <= 0.25)
                {
                    Console.WriteLine("Poluição aceitável");
                }

                if (controlePoluicao == 0.3)
                {
                    Console.WriteLine("Indústrias do 1° grupo intimadas");
                }

                if (controlePoluicao == 0.4)
                {
                    Console.WriteLine("Indústrias do 1° e 2° grupo intimadas");
                }

                if (controlePoluicao >= 0.5)
                {
                    Console.WriteLine("Todos os grupos, paralisem as operações");
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

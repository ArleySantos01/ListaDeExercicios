using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio33
    {
        static void Main33(string[] args)
        {
            string numMatricula = "";
            double notas = 0.0;
            double totalNotas = 0.0;
            double totalMedia = 0.0;
            int i = 0;
            char cancelar = 's';

            do
            {
                Console.WriteLine("\nNúmero de matrícula: ");
                numMatricula = Console.ReadLine();
                Console.WriteLine("Nota: ");
                notas = Convert.ToDouble(Console.ReadLine());
                totalNotas += notas;

                Console.WriteLine("Deseja continuar [S/N]?");
                cancelar = Console.ReadKey().KeyChar;
                if (cancelar == 'n' || cancelar == 'N')
                {
                    i++;
                    break;
                }
                i++;

            } while (cancelar != 'n' || cancelar != 'N');

            totalMedia = totalNotas / i;
            Console.WriteLine("\nMédia dos alunos " + Math.Round(totalMedia, 2));
        }
    }
}

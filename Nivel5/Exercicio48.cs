using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio48
    {
        static void Main(string[] args)
        {
            String[] nomeCandidata = new String[20];
            int[] idadeCandidata = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Nome: ");
                nomeCandidata[i] = Console.ReadLine();
                Console.WriteLine("Idade: ");
                idadeCandidata[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 20; i++)
            {
                if (idadeCandidata[i] >= 18 && idadeCandidata[i] <= 20)
                {
                    Console.WriteLine("Nome:\tIdade:\n" + nomeCandidata[i] + "\t" + idadeCandidata[i]);
                }
            }
        }
    }
}

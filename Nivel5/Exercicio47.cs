using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio47
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];
            int identifica = 0;
            int contaMaior = 0;
            int contaMenor = 0;
            int contaIgual = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número para o vetor");
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digie um número para a busca");
            identifica = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (numero[i] > identifica)
                {
                    contaMaior++;
                }

                if (numero[i] < identifica)
                {
                    contaMenor++;
                }

                if (numero[i] == identifica)
                {
                    contaIgual++;
                }
            }

            Console.WriteLine("Numeros maiores -> " + contaMaior);
            Console.WriteLine("Numeros menores -> " + contaMenor);
            Console.WriteLine("Numeros iguais -> " + contaIgual);
        }
    }
}

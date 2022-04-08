using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio50
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int tentativas = 5;
            int numEntrada = 0;
            int numAleatorio = random.Next(0, 100);
            Console.WriteLine("Um número aleatório foi sorteado");

            while (tentativas > 0)
            {
                Console.WriteLine("Digite um número entre 0 e 100");
                numEntrada = Convert.ToInt32(Console.ReadLine());

                if (numEntrada < numAleatorio)
                {
                    Console.WriteLine("Número informado menor do que o sorteado");
                }

                if (numEntrada > numAleatorio)
                {
                    Console.WriteLine("Número informado maior do que o sorteado");
                }

                if (numEntrada == numAleatorio)
                {
                    Console.WriteLine("Você encontrou o número");
                }
                tentativas--;
                Console.WriteLine("Você tem mais " + tentativas + " tentativas");
            }
            Console.WriteLine("O número sorteado era: " + numAleatorio);
        }
    }
}

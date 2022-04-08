using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio52
    {
        static void Main(string[] args)
        {
            int[] VetorInteiro = new int[100];
            int conteUm = 0;
            int conteTres = 0;
            int conteQuatro = 0;
            int numero = 0;

            do
            {
                Console.WriteLine("Digite um número");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 1)
                {
                    conteUm++;
                    Console.WriteLine("Número 1 foi repetido " + conteUm + " vezes");
                }

                if (numero == 3)
                {
                    conteTres++;
                    Console.WriteLine("Número 3 foi repetido " + conteTres + " vezes");
                }

                if (numero == 4)
                {
                    conteQuatro++;
                    Console.WriteLine("Número 4 foi repetido " + conteQuatro + " vezes");
                }

                if (numero < 0)
                {
                    break;
                }
            } while (numero >= 0);
            Console.WriteLine("Repetições do número 1 -> " + conteUm);
            Console.WriteLine("Repetições do número 3 -> " + conteTres);
            Console.WriteLine("Repetições do número 4 -> " + conteQuatro);
        }
    }
}

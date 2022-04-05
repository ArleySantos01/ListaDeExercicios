using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio42
    {
        static void Main42(string[] args)
        {
            int numero;
            int[] contemNumero = new int[50];
            int[] maiorNumero = new int[50];
            int[] menorNumero = new int[50];
            int minNumero = 0;
            int maxNumero = 0;
            int i = 0;

            do
            {

                Console.WriteLine("Digite um número(digite zero para encerrar):");
                if((numero = Convert.ToInt32(Console.ReadLine())) == 0)
                {
                    break;
                }
                contemNumero[i] = numero;
                minNumero = contemNumero[0];

                if (contemNumero[i] < minNumero)
                {
                    minNumero = contemNumero[i];
                }

                i++;
            } while (numero != 0);
            maxNumero = contemNumero.Max();
            Console.WriteLine("Maior número -> " + maxNumero + "\t" + "Menor número -> " + minNumero + "\t");
            foreach (int var in contemNumero)
            {
                Console.WriteLine("Números -> " + var);
            }
        }
    }
}

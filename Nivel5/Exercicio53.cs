using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio53
    {
        static void Main53(string[] args)
        {
            int voltas = 0;
            int mantemVoltas = 0;
            double somaDeVolta = 0.0;
            double mediaVolta = 0.0;
            double tempoDeVolta = 0.0;
            Console.WriteLine("Quantas voltas o piloto irá percorrer: ");
            voltas = Convert.ToInt32(Console.ReadLine());
            double[] MantemTempoDeVoltas = new double[voltas];
            mantemVoltas = voltas;

            do
            {
                Console.WriteLine("Tempo da volta:");
                tempoDeVolta = Convert.ToDouble(Console.ReadLine());
                somaDeVolta += tempoDeVolta;
                voltas--;
                MantemTempoDeVoltas[voltas] = tempoDeVolta;
            } while (voltas > 0);

            double melhorVolta = MantemTempoDeVoltas[0];
            mediaVolta = somaDeVolta / mantemVoltas;
            Console.WriteLine("Média das voltas -> " + Math.Round(mediaVolta, 2));

            for (int i = 0; i < mantemVoltas; i++)
            {
                if (melhorVolta <= MantemTempoDeVoltas[i])
                {
                    Console.WriteLine("Melhor volta " + melhorVolta);
                }
            }
        }
    }
}

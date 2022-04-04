using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio36
    {
        static void Main36(string[] args)
        {
            int[] numero = new int[10];
            int totalNum = 0;
            int totalMedia = 0;
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Digite um número:");
                numero[i] = Convert.ToInt32(Console.ReadLine());
                totalNum += numero[i];
                i++;
            }
            int numeroMin = numero.Min();
            int numeroMax = numero.Max();
            Console.WriteLine("Menor valor -> " + numeroMin);
            Console.WriteLine("Maior valor -> " + numeroMax);
            totalMedia = totalNum / i;
            Console.WriteLine("Media -> " + totalMedia);

            /*
            foreach (int var in numero)
            {

            }
            */           
        }
    }
}

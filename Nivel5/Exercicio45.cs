using System;

namespace Nivel5
{
    class Exercicio45
    {
        static void Main45(string[] args)
        {
            int[] numero = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número:");
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = numero.Length-1; i >= 0; i--)
            {
                Console.WriteLine("Numero -> " + numero[i]);
            }
        }
    }
}

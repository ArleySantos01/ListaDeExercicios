using System;

namespace Nivel2
{
    class Exercicio11
    {
        static void Main11(string[] args)
        {
            int A, B;
            int total = 0;

            Console.WriteLine("Digite o valor de A > ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B > ");
            B = Convert.ToInt32(Console.ReadLine());
            
            total = A;
            A = B;
            B = total;
        }
    }
}

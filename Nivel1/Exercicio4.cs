using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio4
    {
        static void Main4(string[] args)
        {
            int A, B, C, D;
            int total1, total2;

            Console.WriteLine("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            D = Convert.ToInt32(Console.ReadLine());

            total1 = ((A + B) + (A + C) + (A + D));
            total2 = ((A * B) * (A * C) * (A * D));

            Console.WriteLine("Primeira soma -> " + total1);
            Console.WriteLine("Primeira multiplicação ->" + total2);
            
            total1 = ((B + C) + (B + D));
            total2 = ((B * C) * (B * D));

            Console.WriteLine("Segunda soma -> " + total1);
            Console.WriteLine("Segunda multiplicação ->" + total2);

            total1 = (C + D);
            total2 = (C * D);

            Console.WriteLine("Terceira soma -> " + total1);
            Console.WriteLine("Terceira multiplicação ->" + total2);
        }
    }
}

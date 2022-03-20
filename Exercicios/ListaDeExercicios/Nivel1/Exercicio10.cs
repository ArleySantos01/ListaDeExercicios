using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os dois números são iguais");
            }

            if (num1 > num2)
            {
                Console.WriteLine("O primeiro número é maior que o segundo");
            }

            if (num1 < num2)
            {
                Console.WriteLine("O segundo número é maior que o primeiro");
            }

            if (num1 >= num2)
            {
                Console.WriteLine("O primeiro número é maior ou igual ao segundo");
            }

            if (num1 <= num2)
            {
                Console.WriteLine("O segundo número é maior ou igual ao primeiro");
            }
        }
    }
}

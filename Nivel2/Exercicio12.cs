using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio12
    {
        static void Main(string[] args)
        {
            int num = 0;
            int mod = 0;
            int total = 0;
            Console.WriteLine("Digite um valor ->");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor para o módulo -> ");
            mod = Convert.ToInt32(Console.ReadLine());
            total = mod%num;
            
            if (num > 0)
            {
                Console.WriteLine("Valor digitado -> " + num);
                Console.WriteLine("Valor do cálculo modular -> " + total);
            }

            if (num < 0)
            {
                mod = num * (-1);
                Console.WriteLine("Valor modular -> " + mod);
            }
        }
    }
}

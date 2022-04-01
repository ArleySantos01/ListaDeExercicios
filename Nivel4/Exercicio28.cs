using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio28
    {
        static void Main28(string[] args)
        {
            int entreNumero = 0;
            Console.WriteLine("Digite um número");
            entreNumero = Convert.ToInt32(Console.ReadLine());

            while (entreNumero >= 100 && entreNumero <= 200)
            {
                Console.WriteLine("" + entreNumero);
                entreNumero += 2;
            }
        }
    }
}

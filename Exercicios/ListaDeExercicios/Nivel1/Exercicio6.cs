using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio6
    {
        static void Main6(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Converta graus celsius em fahrenheit: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);
        }
    }
}
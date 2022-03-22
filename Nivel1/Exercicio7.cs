using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio7
    {
        static void Main7(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Converta graus fahrenheit em celsius : ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperatura em Celsius: " + celsius);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio55
    {
        static void Main55(string[] args)
        {
            String entrada = "";
            Console.WriteLine("Digite algo:");
            entrada = Console.ReadLine();
            entrada = entrada.Replace(" ", String.Empty);
            Console.WriteLine("" + entrada);
        }
    }
}

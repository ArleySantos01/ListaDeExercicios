using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio8
    {
        static void Main8(string[] args)
        {
            double V, R, A;
            Console.WriteLine("Digite o valor de raio: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor para a altura");
            A = Convert.ToDouble(Console.ReadLine());
            V = 3.14159 * R * R * A;
            Console.WriteLine("Volume de óleo: " + V);
        }
    }
}

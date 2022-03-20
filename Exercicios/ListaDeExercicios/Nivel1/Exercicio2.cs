using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio2
    {
        static void Main2(string[] args)
        {
            double cotacaoDolar, valorDolar, valorReal;
            Console.WriteLine("Digite a cotação do dólar -> ");
            cotacaoDolar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do dólar -> ");
            valorDolar = Convert.ToDouble(Console.ReadLine());
            valorReal = cotacaoDolar * valorDolar;
            Console.WriteLine("Valor em Real -> " + string.Format("{0:C2}", valorReal));
            //String.format("{0:c2}");
        }
    }
}

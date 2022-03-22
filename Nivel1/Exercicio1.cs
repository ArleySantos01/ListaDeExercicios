using System;

namespace Nivel1
{
    class Exercicio1
    {
        static void Main1(string[] args)
        {
            double estoqueMedio;
            int quantidadeMin, quantidadeMax;
            Console.WriteLine("Cálculo de média: ");
            Console.WriteLine("Digite a quantidade mínima: ");
            quantidadeMin = Convert.ToInt32(Console.ReadLine());
            quantidadeMax = Convert.ToInt32(Console.ReadLine());
            estoqueMedio = Convert.ToDouble(((quantidadeMax + quantidadeMin) / 2));
            Console.WriteLine("Estoque médio -> " + estoqueMedio);
            //Console.WriteLine("Quantidade mínima -> " + quantidadeMin);
        }
    }
}

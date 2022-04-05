using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio41
    {
        static void Main41(string[] args)
        {
            int idade = 0;
            Console.WriteLine("Leitura de idade para nadadores\n");
            Console.WriteLine("Idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }

            if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("Infantil B");
            }

            if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Juvenil A");
            }

            if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Juvenil B");
            }

            if (idade >= 18)
            {
                Console.WriteLine("Adulto");
            }
        }
    }
}

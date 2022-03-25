using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio14
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int[] total1 = new int[2];
            int[] total2 = new int[2];

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= total1.Length; i++)
            {                
                total1[i] = num1 / num2;
                total2[i] = num2 / num1;
            }

            if (num1 < num2)
            {
                Console.WriteLine("Valor B -> " + num1);
                Console.WriteLine("Valor A -> " + num2);
                Array.Sort(total1);

                foreach (int var in total1)
                {
                    
                }

            }

            if (num2 < num1)
            {

            }
        }
    }
}

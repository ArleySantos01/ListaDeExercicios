using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio13
    {
        static void Main13(string[] args)
        {
            int [] arr = new int[3];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Digite um valor positivo: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            foreach(int var in arr)
            {
                Console.WriteLine(var + "");
            }
        }
    }
}

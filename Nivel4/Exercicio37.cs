using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio37
    {
        public string decimalParaBinario(int num)
        {
            string restante = string.Empty;
            for (int i = 0; num > 0; i++)
            {
                restante = num % 2 + restante;
                num /= 2;
            }

            return restante;
        }

        static void Main37(string[] args)
        {
            int num1;
            int num2;
            int total = 0;
            int selecao = 0;
            int i = 1;
            Exercicio37 Ex = new Exercicio37();
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");

            while (i > 0)
            {
                selecao = Convert.ToInt32(Console.ReadLine());

                if (selecao == 1)
                {
                    Console.WriteLine("Número 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Número 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("" + num1 + "\t" + Ex.decimalParaBinario(num1));
                    Console.WriteLine("+");
                    Console.WriteLine("" + num2 + "\t" + Ex.decimalParaBinario(num2));
                    Console.WriteLine("=================================================");
                    total = num1 + num2;
                    Console.WriteLine("" + total + "\t" + Ex.decimalParaBinario(total));
                }

                if (selecao == 2)
                {
                    Console.WriteLine("Número 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Número 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("" + num1 + "\t" + Ex.decimalParaBinario(num1));
                    Console.WriteLine("-");
                    Console.WriteLine("" + num2 + "\t" + Ex.decimalParaBinario(num2));
                    Console.WriteLine("=================================================");
                    total = num1 - num2;
                    Console.WriteLine("" + total + "\t" + Ex.decimalParaBinario(total));
                }

                if (selecao == 3)
                {
                    Console.WriteLine("Número 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Número 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("" + num1 + "\t" + Ex.decimalParaBinario(num1));
                    Console.WriteLine("*");
                    Console.WriteLine("" + num2 + "\t" + Ex.decimalParaBinario(num2));
                    Console.WriteLine("=================================================");
                    total = num1 * num2;
                    Console.WriteLine("" + total + "\t" + Ex.decimalParaBinario(total));
                }

                if (selecao == 4)
                {
                    Console.WriteLine("Número 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Número 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("" + num1 + "\t" + Ex.decimalParaBinario(num1));
                    Console.WriteLine("/");
                    Console.WriteLine("" + num2 + "\t" + Ex.decimalParaBinario(num2));
                    Console.WriteLine("=================================================");
                    total = num1 / num2;
                    Console.WriteLine("" + total + "\t" + Ex.decimalParaBinario(total));
                }

                else if (selecao <= 0 || selecao > 4)
                {
                    Console.WriteLine("Seleção inválida");

                }
                Console.WriteLine("Digite um numero negativo para encerrar o programa");
                i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Opções: ");
                Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            }
        }
    }
}

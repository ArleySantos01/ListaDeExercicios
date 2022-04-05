using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio44
    {
        static void Main(string[] args)
        {
            char cancelar = 'n';
            int selecao = 0;

            do
            {
                Console.WriteLine("Digite uma das opções");
                Console.WriteLine("1 - Converta graus Celsius em Fahrenheit\n2 - Converta graus Fahrenheit em graus Celsius\n" +
                                  "3 - Peso ideal do homem\n4 - Peso ideal da mulher");
                selecao = Convert.ToInt32(Console.ReadLine());
                if (selecao == 1)
                {
                    double celsius = 0.0;
                    double fahrenheit = 0.0;
                    Console.WriteLine("Digite a temperartura em Celsius");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fahrenheit = (9 * celsius + 160) / 5;
                    fahrenheit = Math.Round(fahrenheit, 2);
                    Console.WriteLine("Temperatura em Fahrenheit -> " + fahrenheit);
                }

                if (selecao == 2)
                {
                    double celsius = 0.0;
                    double fahrenheit = 0.0;
                    Console.WriteLine("Digite a temperartura em Fahrenheit");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    celsius = Math.Round(celsius, 2);
                    Console.WriteLine("Temperatura em Celsius -> " + celsius);
                }

                if (selecao == 3)
                {
                    double total = 0.0;
                    double altura = 0.0;
                    Console.WriteLine("Digite a sua altura:");
                    altura = Convert.ToDouble(Console.ReadLine());
                    total = Convert.ToDouble((72.7 * altura) - 58.00);
                    total = Math.Round(total, 2);
                    Console.WriteLine("Seu peso -> " + total);
                }

                if (selecao == 4)
                {
                    double total = 0.0;
                    double altura = 0.0;
                    Console.WriteLine("Digite a sua altura:");
                    altura = Convert.ToDouble(Console.ReadLine());
                    total = Convert.ToDouble((62.1 * altura) - 44.7);
                    total = Math.Round(total, 2);
                    Console.WriteLine("Seu peso -> " + total);
                }

                Console.WriteLine("\nDeseja finalizar [S/N]?");
                cancelar = Console.ReadKey().KeyChar;

                if (cancelar == 's' || cancelar == 'S')
                {
                    break;
                }

            } while (cancelar != 's' || cancelar != 'S');
        }
    }
}

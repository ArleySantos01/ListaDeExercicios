using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exercicio24
    {
    	static void Main24(string[] args)
    	{
    		int selecao;
    		int primeiroNum;
    		int segundoNum;
    		int total;
    		Console.WriteLine("Digite uma das opções:");
    		Console.WriteLine("1- Ache o múltiplo");
    		Console.WriteLine("2- Números pares");
    		Console.WriteLine("3- Média");
    		Console.WriteLine("4- Sair");
    		selecao = Convert.ToInt32(Console.ReadLine());
    		
    		switch(selecao)
    		{
    			case 1:
    				Console.WriteLine("Digite o produto");
    				primeiroNum = Convert.ToInt32(Console.ReadLine());
    				Console.WriteLine("Digite o multiplicando");
    				segundoNum = Convert.ToInt32(Console.ReadLine());
    				
    				for (int i = 0; i <= 10; i++)
    				{
    					total = segundoNum * i;
    					if (total == primeiroNum)
    					{
    						Console.WriteLine("" + segundoNum + " X " + i + "");
    						break;
    					}
    					else
    					{
    						Console.WriteLine("" + segundoNum + " X " + i + "");
    					}
    				}
    				Console.WriteLine("O número " + primeiroNum + " é múltiplo de " + segundoNum);
    				break;
    			case 2:
    				Console.WriteLine("Digite o primeiro número");
    				primeiroNum = Convert.ToInt32(Console.ReadLine());
    				Console.WriteLine("Digite o segundo número");
    				segundoNum = Convert.ToInt32(Console.ReadLine());
    				//bool interrompa = false;
				if (primeiroNum%2 == 0)
				{
					Console.WriteLine(primeiroNum + " é par");
				}				
				else if (primeiroNum%2 == 1)
				{
					Console.WriteLine(primeiroNum + " é ímpar");
				}				
				if (segundoNum%2 == 0)
				{
					Console.WriteLine(segundoNum + " é par");
				}				
				else if (segundoNum%2 == 1)
				{
					Console.WriteLine(segundoNum + " é ímpar");
				}
				
    				break;
    				
    			case 3:
    				Console.WriteLine("Digite o primieiro número");
    				primeiroNum = Convert.ToInt32(Console.ReadLine());
    				Console.WriteLine("Digite o segundo número");
    				segundoNum = Convert.ToInt32(Console.ReadLine());
    				total = (primeiroNum + segundoNum) / 2;
    				if (total >= 7)
    				{
    					Console.WriteLine("A média é -> " + total);
    				}
    				else
    				{
    					Console.WriteLine("Resultado abaixo da média");
    				}
    				break;
    				
    			case 4:
    				Environment.Exit(0);
    				break;
    				
    		}
    	}
    }
}

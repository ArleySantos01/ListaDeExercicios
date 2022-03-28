using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exercicio23
    {
    	static void Main23(string[] args)
    	{
    		int select;
    		int primeiroNum, segundoNum;
    		int total;
    		Console.WriteLine("Selecione uma operação");
    		Console.WriteLine("1 - Adição");
    		Console.WriteLine("2 - Subtração");
    		Console.WriteLine("3 - Multiplicação");
    		Console.WriteLine("4 - divisão");
    		select = Convert.ToInt32(Console.ReadLine());
    		
    		switch(select)
    		{
    			case 1:
    				Console.WriteLine("Digite o primeiro número -> ");
    				primeiroNum = Convert.ToInt32(Console.ReadLine());
    				Console.WriteLine("Digite o segundo número -> ");
    				segundoNum = Convert.ToInt32(Console.ReadLine());
    				total = primeiroNum + segundoNum;
				Console.WriteLine("Resultado -> " + total);
    				break;
    			case 2:
    				Console.WriteLine("Digite o primeiro número -> ");
    				primeiroNum = Convert.ToInt32(Console.ReadLine());
    				Console.WriteLine("Digite o segundo número -> ");
    				segundoNum = Convert.ToInt32(Console.ReadLine());
    				total = primeiroNum - segundoNum;
    				Console.WriteLine("Resultado -> " + total);
    				break;
    			case 3:
    				Console.WriteLine("Digite o primeiro número -> ");
    				primeiroNum = Convert.ToInt32(Console.ReadLine());
    				Console.WriteLine("Digite o segundo número -> ");
    				segundoNum = Convert.ToInt32(Console.ReadLine());
    				total = primeiroNum * segundoNum;
    				Console.WriteLine("Resultado -> " + total);
    				break;
    			case 4:
    				Console.WriteLine("Digite o primeiro número -> ");
    				primeiroNum = Convert.ToInt32(Console.ReadLine());
    				Console.WriteLine("Digite o segundo número -> ");
    				segundoNum = Convert.ToInt32(Console.ReadLine());
    				total = primeiroNum / segundoNum;
    				Console.WriteLine("Resultado -> " + total);
    				break;
    		}
    	}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio16
    {
    	static void Main16(string[] args)
    	{
    		double primeiroNum;
    		double segundoNum;
    		
    		Console.WriteLine("Digite o primeiro número");
    		primeiroNum = Convert.ToDouble(Console.ReadLine());
    		Console.WriteLine("Digite o segundo número");
    		segundoNum = Convert.ToDouble(Console.ReadLine());
    		
    		if (primeiroNum > segundoNum)
    		{
    			Console.WriteLine("Primeiro número maior que o segundo");
    		}
    		
    		if (segundoNum > primeiroNum)
    		{
    			Console.WriteLine("Segundo número maior que o primeiro");
    		}
    		
    		if (primeiroNum == segundoNum)
    		{
    			Console.WriteLine("Primeiro número igual ao segundo");
    		}
    	}
    }    
}

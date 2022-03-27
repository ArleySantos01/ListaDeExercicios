using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio22
    {
    	static void Main22(string[] args)
    	{
    		int leitura;
    		int A, B;
    		
    		Console.WriteLine("Digite um número positivo ou negativo");
    		leitura = Convert.ToInt32(Console.ReadLine());
    		if (leitura > 0)
    		{
    			A = leitura;
    			Console.WriteLine("Número digitado -> " + A);
    		}
    		
    		if (leitura < 0)
    		{
    			B = leitura;
	    		Console.WriteLine("Número digitado -> " + B);
    		}
    	}
    }
}

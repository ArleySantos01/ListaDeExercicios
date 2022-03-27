using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio17
    {
    	static void Main17(string[] args)
    	{
    		int numEntrada = 0;
    		Console.WriteLine("Digite um número de 0 a 9");
    		numEntrada = Convert.ToInt32(Console.ReadLine());
    		
    		if (numEntrada >= 0 && numEntrada <= 9)
    		{
	    		Console.WriteLine("Valor válido");
    		}
    		else
    		{
	    		Console.WriteLine("Valor inválido");
    		}
    	}
    }
}

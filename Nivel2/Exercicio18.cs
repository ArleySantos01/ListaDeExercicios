using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio18
    {
    	static void Main18(string[] args)
    	{
    		int codigo;
    		Console.WriteLine("Selecione um código de 1 a 3");
    		codigo = Convert.ToInt32(Console.ReadLine());
    		
    		switch(codigo)
    		{
    			case 1:
    				Console.WriteLine("Código " + codigo + " é válido");
    				break;
    			case 2:
    				Console.WriteLine("Código " + codigo + " é válido");
    				break;
    			case 3:
    				Console.WriteLine("Código " + codigo + " é válido");
    				break;
    			default:
    				Console.WriteLine("Código " + codigo + " é inválido");
    				break;
    		}
    	}
    }
}

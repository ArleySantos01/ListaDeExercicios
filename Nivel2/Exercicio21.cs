using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio21
    {
    	static void Main21(string[] args)
    	{
    		char confirma = 'n';
    		int numeroLeitura;
    		while(confirma != 'S')
    		{
	    		Console.WriteLine("Digite um número positivo ou negativo");
    			numeroLeitura = Convert.ToInt32(Console.ReadLine());
    			Console.WriteLine("Deseja parar (Digite S para sim, ou qualquer outro digito para continuar)");
    			confirma = Console.ReadKey().KeyChar;
    			if (confirma == 'S')
    			{
    				break;
    			}
    		}
    	}
    }
}

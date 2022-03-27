using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio19
    {
    	static void Main19(string[] args)
    	{
    		double A = 0.0;
    		double B = 0.0;
    		double C = 0.0;
    		double lado1 = 0.0;
    		double lado2 = 0.0;
    		double lado3 = 0.0;
    		
    		Console.WriteLine("Digite um valor para A:");
    		A = Convert.ToDouble(Console.ReadLine());
    		Console.WriteLine("Digite um valor para B:");
    		B = Convert.ToDouble(Console.ReadLine());
    		Console.WriteLine("Digite um valor para C:");
    		C = Convert.ToDouble(Console.ReadLine());
    		
    		lado1 = A+B;
    		lado2 = A+C;
    		lado3 = B+C;
    		
    		if (A < lado3 && B < lado2 && C < lado1)
    		{
    			if (A == B && B == C)
    			{
    				Console.WriteLine("Equilátero");
    			}
    			
    			else if (A == B || A == C || B == C)
    			{
    				Console.WriteLine("Isóceles");
    			}
    			
    			else if (A != B || A != C || B != C)
    			{
    				Console.WriteLine("Escaleno");    			
    			}
    		}
    		
    		else
    		{
    			Console.WriteLine("Um dos valores digitados é maior que a soma de um dos lados");
    		}
    	}
    }
}

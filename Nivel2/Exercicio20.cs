using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio20
    {
    	static void Main20(string[] args)
    	{
    		int a; 
    		int b;
    		int c;
    		int total1;
    		int total2;
    		//int total3;
    		
    		Console.WriteLine("Digite o valor de A: ");
    		if((a = Convert.ToInt32(Console.ReadLine())) < 0)
    		{
    			Console.WriteLine("Digite um valor válido!");
    			Environment.Exit(0);
    		}
    		
    		Console.WriteLine("Digite o valor de B: ");
    		if((b = Convert.ToInt32(Console.ReadLine())) < 0)
    		{
    			Console.WriteLine("Digite um valor válido!");
    			Environment.Exit(0);
    		}
    		Console.WriteLine("Digite o valor de C: ");
    		if((c = Convert.ToInt32(Console.ReadLine())) < 0)
    		{
    			Console.WriteLine("Digite um valor válido!");
    			Environment.Exit(0);
    		}
    		
    		/*
    		if (a < 0 || b < 0 || c < 0)
    		{
			Console.WriteLine("Excesso de valores inválidos digitados!");
    		}
    		*/
    		
    		
    		if (a < b)
    		{
    			total1 = a*b;
    			total2 = b/a;
    			Console.WriteLine("Multiplicação ->" + total1);
    			Console.WriteLine("Divisão -> " + total2);
    		}
    		
    		if (a < c)
    		{
    			total1 = a*c;
    			total2 = c/a;
    			Console.WriteLine("Multiplicação ->" + total1);
    			Console.WriteLine("Divisão -> " + total2);
    		}
    		
    		if (b < a)
    		{
    			total1 = b*a;
    			total2 = a/b;
    			Console.WriteLine("Multiplicação ->" + total1);
    			Console.WriteLine("Divisão -> " + total2);
    		}
    		
    		if (b < c)
    		{
    			total1 = b*c;
    			total2 = c/b;
    			Console.WriteLine("Multiplicação ->" + total1);
    			Console.WriteLine("Divisão -> " + total2);
    		}
    		
    		if (c < a)
    		{
    			total1 = c*a;
    			total2 = a/c;
    			Console.WriteLine("Multiplicação ->" + total1);
    			Console.WriteLine("Divisão -> " + total2);
    		}
    		
    		if (c < b)
    		{
    			total1 = c*b;
    			total2 = b/c;
    			Console.WriteLine("Multiplicação ->" + total1);
    			Console.WriteLine("Divisão -> " + total2);
    		}
    	}
    }
}

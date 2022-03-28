using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exercicio25
    {
    	public double pesoIdeal(string altura, char sexo)
    	{
    		double total = 0.0;
    		double resultadoAltura = Convert.ToDouble(altura);
    		if (sexo == 'm')
    		{
    			total = Convert.ToDouble((72.7 * resultadoAltura) - 58.00);
    			total = Math.Round(total, 2);
    			Console.WriteLine("Seu peso -> " + total);
    		}
    		
    		if (sexo == 'f')
    		{
    			total = Convert.ToDouble((62.1 * resultadoAltura) - 44.7);
    			total = Math.Round(total, 2);
    			Console.WriteLine("Seu peso -> " + total);
    		}
    		return total;
    	}
    	
    	static void Main(string[] args)
    	{
    		Exercicio25 entradaInicial = new Exercicio25();
    		char entreSexo;
    		string entreAltura;
    		Console.WriteLine("Digite seu sexo, 'f' para feminino, ou 'm' para masculino");
    		entreSexo = Console.ReadKey().KeyChar;
    		Console.WriteLine("Digite a sua altura");
    		entreAltura = Console.ReadLine();
    		entradaInicial.pesoIdeal(entreAltura, entreSexo);
    	}
    }
}

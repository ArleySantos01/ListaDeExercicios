using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio15
    {
        static void Main15(string[] args)
        {
            double[] nota = new double[4];
            double media = 0.0;
            double total = 0.0;
            
            for (int i = 0; i < nota.Length; i++)
            {
            	Console.WriteLine("Digite a média do aluno -> ");
            	nota[i] = Convert.ToDouble(Console.ReadLine());
            	media += nota[i];            	
            }
            
            total = media / 4;
            
            if (total >= 7)
            {
            	Console.WriteLine("Aluno aprovado!");
            }
            
            if (total < 7)
            {
            	Console.WriteLine("Aluno está em recuperação!");
            	Console.WriteLine("Digite a nota de recuperação para o cálculo da nova média -> ");
            	double notaRecuperacao;
		notaRecuperacao = Convert.ToDouble(Console.ReadLine());
		notaRecuperacao += total;
		
		if (notaRecuperacao >= 7)
		{
			Console.WriteLine("Aluno aprovado na recuperação");
		}
		
		else if(notaRecuperacao < 7)
		{
			Console.WriteLine("Aluno reprovado!");
		}
            }
        }
    }
}

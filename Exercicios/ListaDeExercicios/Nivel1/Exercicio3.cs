using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio3
    {
		static void Main3(string[] args)
		{
			String vendedor;
			int idPeca, quantVendida;
			double valorUni, total, comissao, totalComissao;
			Console.WriteLine("Vendedor: ");
			vendedor = Console.ReadLine();
			Console.WriteLine("Código da peça:");
			idPeca = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Preço unidade: ");
			valorUni = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("N° de unidades: ");
			quantVendida = Convert.ToInt32(Console.ReadLine());
			
			Convert.ToDouble(quantVendida);
			total = Convert.ToDouble(valorUni * quantVendida);
			comissao = 1 + 0.05;
			totalComissao = total * comissao;
			
			Console.Clear();
			Console.WriteLine("Vendedor: " + vendedor);
			Console.WriteLine("Comissão: " + String.Format("{0:C2}", totalComissao));
			Console.WriteLine("Código da peça: " + idPeca);
			Console.WriteLine("Total: " + String.Format("{0:C2}", total));
		}
    }
}

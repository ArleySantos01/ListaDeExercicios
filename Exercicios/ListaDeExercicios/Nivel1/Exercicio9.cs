using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio9
    {
        static void Main9(string[] args)
        {
            int anos, meses, dias, diasTotais;
            Console.WriteLine("Digite sua anos idade:");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua idade em meses:");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua idade em dias:");
            dias = int.Parse(Console.ReadLine());

            anos *= 365;
            meses *= 30;
            diasTotais = anos + meses + dias;
            Console.WriteLine("Dias totais: " + diasTotais);
        }
    }
}

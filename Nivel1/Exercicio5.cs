using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio5
    {
        static void Main5(string[] args)
        {
            double tempoViagem, velMedia;
            double distancia, litrosUsados;

            Console.WriteLine("Calcule o seu gasto de combustível com o nosso inovador programa de terminal\n");
            Console.WriteLine("Digite o tempo gasto para sua viagem: ");
            tempoViagem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média para a sua viagem: ");
            velMedia = Convert.ToDouble(Console.ReadLine());

            distancia = tempoViagem * velMedia;
            litrosUsados = distancia / 12;
            Console.WriteLine("Velocidade média -> " + velMedia);
            Console.WriteLine("Litros usados -> " + String.Format("{0:C2}", litrosUsados));
        }
    }
}

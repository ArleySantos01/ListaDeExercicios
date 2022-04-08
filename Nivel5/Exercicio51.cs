using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio51
    {
        static void Main51(string[] args)
        {
            int quantAluno = 0;
            int quantidade = 0;
            int aprovado = 0;
            int reprovado = 0;
            double nota = 0.0;
            double media = 0.0;
            double somaNota = 0.0;
            Console.WriteLine("Qual a quantidade de alunos na sua sala?");
            quantAluno = Convert.ToInt32(Console.ReadLine());
            String nome = "";
            quantidade = quantAluno;
            while (quantAluno > 0)
            {
                Console.WriteLine("Nome do aluno:");
                nome = Console.ReadLine();
                Console.WriteLine("Nota do aluno:");
                nota = Convert.ToDouble(Console.ReadLine());
                somaNota += nota;

                if (nota >= 7.0)
                {
                    Console.WriteLine("Aluno aprovado -> " + nome);
                    aprovado++;
                }

                if (nota <= 5.0)
                {
                    Console.WriteLine("Aluno reprovado -> " + nome);
                    reprovado++;
                }
                quantAluno--;
            }

            if (reprovado > aprovado)
            {
                Console.WriteLine("Nenhum aluno com nota superior a 5");
            }

            media = somaNota / quantidade;
            Console.WriteLine("Média total de todos os alunos -> " + Math.Round(media, 1));
        }
    }
}

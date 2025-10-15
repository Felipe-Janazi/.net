using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            //for(int i = 1;  i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}.");
            //}

            double somatorio = 0;
            Console.Write("Informe o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoTurma);

            for (int i = 1; i < tamanhoTurma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                double.TryParse(Console.ReadLine(), out double notaAtual);
                somatorio += notaAtual;
            }

            double mediaTurma = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Média da turma: {0}", mediaTurma);
        }
    }
}

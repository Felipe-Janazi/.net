using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {


            Console.WriteLine("Digita a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            string entrada = Console.ReadLine().ToUpper();
            bool bomComportamento = entrada == "S";


            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}

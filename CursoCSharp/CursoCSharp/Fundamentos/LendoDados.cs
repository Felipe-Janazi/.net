using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade");
            // Transformando um texto em int
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu sálario");
            // Colocando o , para centavos com CultureInfo
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}

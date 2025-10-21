using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            // Atráves do STATIC podemos usar sem ter que instâncias a classe
            Console.WriteLine(CalculadoraEstatica.Somar(1, 1));

            var calculadoraEstatica = new CalculadoraEstatica();
            Console.WriteLine(calculadoraEstatica.Multiplicar(2, 2));
        }
    }
}

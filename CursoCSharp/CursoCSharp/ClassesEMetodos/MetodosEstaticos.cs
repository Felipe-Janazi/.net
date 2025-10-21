using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class CalculadoraEstatica
    {
        // Método da classe
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        // Método da instância
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

            // Nesse caso o MULTIPLICAR não está estático
            var calculadoraEstatica = new CalculadoraEstatica();
            Console.WriteLine(calculadoraEstatica.Multiplicar(2, 2));

            // Um membro estatico pertence a classe e não a instância
            // Se pertencente a classe cada atributo vai ter apenas uma instância
        }
    }
}

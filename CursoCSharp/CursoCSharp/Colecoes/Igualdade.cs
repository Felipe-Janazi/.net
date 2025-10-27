using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar ()
        {
            var p1 = new Produto("Caneta",1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            // False, comparando referências de memória 
            Console.WriteLine(p1 == p2);
            // Verdadeiro, apontando pra mesma referência de memória
            Console.WriteLine(p3 == p2);

            // Equals também compara endereço de memória 
            Console.WriteLine(p1.Equals(p2));
        }
    }
}

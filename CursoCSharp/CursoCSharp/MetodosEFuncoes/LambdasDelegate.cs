using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);

    internal class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao multiplicacao = (x, y) => x * y;

            Console.WriteLine(sum(2,3));
            Console.WriteLine(sub(2,3));
            Console.WriteLine(multiplicacao(2,3));

            // Dessa forma padronizamos os tipos de uma função, não prendendo dentro do tipo qual a função a ser executada
        }
    }
}

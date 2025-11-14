using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {

            // Numa action o retorno sempre é void
            Action<string> algoNoConsole = (a) =>
            {
               Console.WriteLine("Lambda com C#!" + a);
            };

            algoNoConsole("!!");

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());


            // Em uma func o último tipo passado se refere ao retorno da mesma


            Func<int, string> conversorHex = (numero) => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(6,3,2006));


        }
    }
}

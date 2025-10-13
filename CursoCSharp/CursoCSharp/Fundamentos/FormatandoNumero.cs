using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            // Somente uma casa decimal, arredondando
            Console.WriteLine(valor.ToString("F1"));

            // Transformando em valor monetário 
            Console.WriteLine(valor.ToString("C"));

            // Valor percentual
            Console.WriteLine(valor.ToString("P"));

            // Número com duas casas decimais, como em F2
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            // Completando números até uma certa quantidade de caracteres
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}

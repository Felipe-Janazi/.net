using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            // Cortando os decimais e convertendo, pois há perda de informação nma conversão
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Digite sua idade");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine(idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Idade = {idadeInteiro}");

            Console.Write("Digite um número");
            string palavra = Console.ReadLine();
            // Tentando enviar o que tem na variável palavra para dentro do número
            int.TryParse(palavra, out int numero1);
            Console.WriteLine(numero1);

            Console.Write("Digite um número");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);
        }


    }
}

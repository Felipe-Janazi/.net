using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols:" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor possível: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Total da população brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor do Long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador: " + precoComputador);

            double valorDeMercadoDaApple = 1000000000000000.00; // Mais usados dos reais
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal valorEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Valor entre duas estrelas " + valorEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Uma única letra " + letra);

            string texto = "Teste de string";
            Console.WriteLine("Utilização de string " + texto);

        }
    }
}

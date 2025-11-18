using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{

    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo; 
        }

        public void Sacar (double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente!");
            }

            Saldo -= valor;
        }
    }

    internal class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try
            {
                // Envia pro catch por conta do catch estar lidando com todas as exceções de forma genérica
                int.Parse("abc");

                conta.Sacar(100);
                Console.WriteLine("Retirada com sucesso!");
            } // Não é obrigado a lidar com todas as exceções
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}

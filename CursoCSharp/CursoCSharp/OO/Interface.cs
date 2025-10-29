using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    // Métodos que não podem ter corpo, onde uma classe pode implementar várias interfaces
    interface Teste
    {
        bool bla(string a);
    }

    // Uma interface também pode herdar outras interfaces
    interface OperacaoBinaria // : Teste
    {
        // Todos os métodos de uma interface são abstratos e públicos
        int Operacao(int a, int b);

    }

    class Soma : OperacaoBinaria, Teste 
    {
        // Obrigatoriamente publico
        public int Operacao(int a, int b)
        {
            return a + b;
        }

        public bool bla(string teste)
        {
            return true;
        }
    }

    class Subtracao: OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(), 
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach(var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }

    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}

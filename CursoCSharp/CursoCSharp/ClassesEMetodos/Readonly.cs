using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class Cliente
    {

        public string Nome;
        // Valor imutavel, podendo mudar somente na inicialização ou no construtor
        // Uma const na inicialização do programa precisa ter um valor
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() 
        { 
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month,  Nascimento.Year);
        }
    }
    internal class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana", new DateTime(1983, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

        }
    }
}

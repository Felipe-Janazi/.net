using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro {

        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }

    internal class Construtores
    {
        public static void Executar()
        {
            // Construtor padrão
            var carro1 = new Carro("325i", "BMW", 2017);

            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

        }
    }
}

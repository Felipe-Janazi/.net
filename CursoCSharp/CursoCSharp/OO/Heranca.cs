using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro (int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        // Pode ser alterado somente por heranças, por conta do protected
        protected int AlterarVelocidade( int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            } else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;

        }

        // Com o virtual estamos permitindo que seja sobreescrito por classes filhas
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    // Uno recebe (Herda) de carro
    public class Uno : Carro
    {
        // Construtor padrão precisa que o filho chame o da classe pai
        public Uno () : base(200) { }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350) { }

        // Sobrescrevendo um método da classe pai 
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        // Dessa forma podemos ocultar o Frear() da classe pai e utilizar a nova
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    internal class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");

            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");

            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com o tipo Carro...");
            Carro carro3 = new Ferrari(); // Polimorfismo
            // Mesmo o tipo sendo Carro o método acelerar foi sobrescrito
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            // Como o tipo é Carro ele chama o método ocultado que está dentro de Carro e não Ferrari
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public abstract class Celular 
    {
        // Obrigátorio de toda herança sobrescrever
        public abstract string Assistente();

        // Repassado por herança para todos 
        public string Tocar()
        {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }

    internal class Abstract
    {
        public static void Executar()
        {
            // Não podemos instânciar classes abstratas
            //Celular c = new Celular();

            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung(),
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine($"{celular.Assistente()}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    sealed class SemFilho
    {
        public double ValorDaFortuna ()
        {
            return 1_245_354.54;
        }
    }

    // Não é possível herdar de uma classe selada (sealed)
    //class SouFilho : SemFilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia ()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        // Não é possível sobrescrever mas podemos ocultar
        public new bool HonrarNomeFamilia()
        {
            return false;
        }
    }
        

    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho =  new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}

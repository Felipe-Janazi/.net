using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {

        int a = 10;
        public static void Executar()
        {
            // Desafio: Acessr a variável A sem mexer diretamente na linha de criação dela:

            var desafioAtributo = new DesafioAtributo();
            Console.WriteLine(desafioAtributo.a);
        }
    }
}

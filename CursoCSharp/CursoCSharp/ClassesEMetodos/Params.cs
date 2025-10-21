using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Params
    {
        // Utilizando o PARAMS podemos passar parâmetros variáveis, sendo 2, 4, 10 e etc
        public static void Recepcionar(params string[] pessoas) { 
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);

            }
        }
        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Felipe");
        }
    }
}

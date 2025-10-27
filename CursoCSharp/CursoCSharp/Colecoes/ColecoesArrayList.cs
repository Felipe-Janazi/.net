using System;
// Necessario remover generics do collections
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach(object item in arrayList)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}

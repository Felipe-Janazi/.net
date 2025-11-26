using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.Api
{

    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {

            //Colocando um caminho fixo para criação, sendo dentro da pasta home do usuário 
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                           Environment.OSVersion.Platform == PlatformID.MacOSX)
                           ? Environment.GetEnvironmentVariable("HOME")
                           : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }


    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();


            // Escrevendo dentro de um arquivo não existente
            if (!File.Exists(path)){

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }


            // Adicionando mais textos dentro de um arquivo já existente
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //busca pelo o caractere
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s")); //ultima letra s
        }
    }
}

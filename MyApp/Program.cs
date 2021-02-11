using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //começa com e termina com
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("texte"));
            Console.WriteLine(texto.EndsWith("Texte"));
            Console.WriteLine(texto.EndsWith("xpro"));

        }
    }
}

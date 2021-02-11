using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //comparacao de identico
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));

        }
    }
}

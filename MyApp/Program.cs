using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //busca pelo o caractere
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Length); //mostra numero de caracteres
    
        }
    }
}

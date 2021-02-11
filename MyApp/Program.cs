using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); // gera com id novo
            id.ToString();

            id = new Guid("7874f71e-d53a-42d8-b7b1-4457f5b49bc3");

            if (id == Guid.NewGuid())
                Console.WriteLine(id.ToString().Substring(0, 8)); //SubString para pegar os 8 primeiros caracteres
        }
    }
}

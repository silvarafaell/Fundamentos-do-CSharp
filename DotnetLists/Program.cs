using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new Teste[2];
            meuArray[0] = new Teste();

            Console.WriteLine(meuArray[0].Id);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);

        }
    }

    struct Teste
    {
        public int Id { get; set; }
    }
}

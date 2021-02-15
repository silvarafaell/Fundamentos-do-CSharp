using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] {1, 2, 3, 4, 5};
            meuArray[0] = 12;
            
            Console.WriteLine(meuArray.Length);

            for( var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }
            

        }
    }

    struct Teste
    {
        public int Id { get; set; }
    }
}

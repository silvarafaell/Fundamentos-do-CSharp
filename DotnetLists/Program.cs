using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 1, Nome = "Rafael" };


            foreach (var Funcionario in funcionarios)
            {
                Console.WriteLine(Funcionario.Id);
                Console.WriteLine(Funcionario.Nome);
            }
        }


    }

    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}

struct Teste
{
    public int Id { get; set; }
}


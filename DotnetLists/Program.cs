using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                //     Console.WriteLine(arr[index]);
                // }
                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto");
            }
            // catch (MinhaException ex)
            // {
            //     Console.WriteLine(ex.InnerException);
            //     Console.WriteLine(ex.Message);
            //     Console.WriteLine(ex.QuandoAconteceu);
            //     Console.WriteLine("Exceção customizada");
            // }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new ArgumentNullException("o texto não pode se nulo ou vazio");
        }
    }
}



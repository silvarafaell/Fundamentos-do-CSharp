using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            var formatada = String.Format("{0: dd/MM/yyyy }", data);
            Console.WriteLine(formatada);


        }
    }
}

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
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(-12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddHours(1));


        }
    }
}

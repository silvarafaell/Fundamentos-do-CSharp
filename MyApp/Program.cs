using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = new DateTime(2021, 02, 13, 07, 48, 50);
            //var data = DateTime.Now; //pega a data atual
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);

            Console.WriteLine((int)data.DayOfWeek); //pega de um enum

        }
    }
}

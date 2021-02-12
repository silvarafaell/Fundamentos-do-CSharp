using System;
using System.Text.RegularExpressions;
namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Visualização");
            Console.WriteLine("---------");
            Replace(text);
            Console.WriteLine("---------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            //Regex substitui strigs
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            Console.WriteLine(strong);
        }
    }
}
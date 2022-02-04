using System;

namespace UzbToRus
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter your text: ");
            String text = Console.ReadLine();
            text = text.ToLower();
            text = text.Replace('a', 'а');
            text = text.Replace('b', 'б');
            text = text.Replace('c', 'с');
            text = text.Replace('d', 'д');
            text = text.Replace('e', 'е');
            text = text.Replace('f', 'ф');
            text = text.Replace('g', 'г');
            text = text.Replace('h', 'х');
            text = text.Replace('i', 'и');
            text = text.Replace('j', 'ж');
            text = text.Replace('k', 'к');
            text = text.Replace('l', 'л');
            text = text.Replace('m', 'м');
            text = text.Replace('n', 'н');
            text = text.Replace('o', 'о');
            text = text.Replace('p', 'п');
            text = text.Replace('q', 'к');
            text = text.Replace('r', 'р');
            text = text.Replace('s', 'с');
            text = text.Replace('t', 'т');
            text = text.Replace('u', 'у');
            text = text.Replace('v', 'в');
            text = text.Replace('`', 'ъ');
            text = text.Replace('x', 'х');
            text = text.Replace('y', 'й');
            text = text.Replace('z', 'з');
            text = text.Replace('a', 'а');
            text = text.Replace("ya", "я");
            Console.WriteLine("Result: ");
            Console.WriteLine(text);
        }
    }
}

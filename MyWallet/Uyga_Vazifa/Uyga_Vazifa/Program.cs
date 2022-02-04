using System;

namespace Uyga_Vazifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1984 dan katta yil kiriting");
            
            int year;
            year = int.Parse(Console.ReadLine());

            int k = year - 1983;
            int a = k / 12 + 1;
            int b = k % 12;
            switch(a)
            {
                case 1:
                    Console.Write("yashil ");
                    break;
                case 2:
                    Console.Write("qizil ");
                    break;
                case 3:
                    Console.Write("sariq ");
                    break;
                case 4:
                    Console.Write("oq ");
                    break;
                case 5:
                    Console.Write("qora ");
                    break;
            }

            switch (b)
            {
                case 1:
                    Console.Write("sichqon ");
                    break;
                case 2:
                    Console.Write("sigir ");
                    break;
                case 3:
                    Console.Write("yolbars ");
                    break;
                case 4:
                    Console.Write("quyon ");
                    break;
                case 5:
                    Console.Write("ajdar ");
                    break;
                case 6:
                    Console.Write("ilon ");
                    break;
                case 7:
                    Console.Write("ot ");
                    break;
                case 8:
                    Console.Write("qoy ");
                    break;
                case 9:
                    Console.Write("maymun ");
                    break;
                case 10:
                    Console.Write("tovuq ");
                    break;
                case 11:
                    Console.Write("it ");
                    break;
                case 12:
                    Console.Write("tongiz ");
                    break;
            }
            Console.WriteLine("yili");
        }
    }
}

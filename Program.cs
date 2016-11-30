using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            var count = ch.Where((n) => n >= '0' && n <= '9').Count();
            Console.WriteLine("Количество цифр в строке: " + count);
            Console.ReadKey();
        }
    }
}

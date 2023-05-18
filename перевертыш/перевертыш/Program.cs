using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перевертыш
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string text = Console.ReadLine().Trim();

            char[] letters = text.ToCharArray();
            Array.Reverse(letters);

            text = String.Concat(letters);
            Console.WriteLine(text);
            Console.ReadKey();

        }
    }
}


using System;
namespace C2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Кол-во яблок: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Количество шкилы: ");
            int w = int.Parse(Console.ReadLine());
            int e = q / w;
            Console.WriteLine("Каждому шкиле достанется по " + e + " яблоку");
            Console.ReadKey();
        }
    }
}


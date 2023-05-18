using System;
namespace C3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Кол-во яблок: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Количество шкилы: ");
            int w = int.Parse(Console.ReadLine());
            int e = q % w;
            Console.WriteLine("В корзике шкиле останется " + e + " apple");
            Console.ReadKey();
        }
    }
}


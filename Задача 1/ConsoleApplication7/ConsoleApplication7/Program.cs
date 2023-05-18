using System;
namespace C1
{
    class Program
    {
        static void Main()
    {
        Console.Write("Введите 1 число:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите 2 число:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите 3 число:");
        int c = int.Parse(Console.ReadLine());
        int d = a + b + c;
        int g = a + b + c;
        Console.WriteLine("Сумма трёх чисел равна " + d + " Произведение чисел равно" + g);
        Console.ReadKey();
        }
    }
}


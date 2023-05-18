using System;
namespace C6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите сторону квадрата:  ");
            int q = int.Parse(Console.ReadLine());
            int z = q * 4;
            Console.WriteLine("Периметр квадрата равен: " + z);
            Console.ReadKey();
        }
    }
}
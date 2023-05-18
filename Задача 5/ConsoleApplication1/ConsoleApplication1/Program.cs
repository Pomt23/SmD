using System;
namespace C5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число:  ");
            int q = int.Parse(Console.ReadLine());
            int z = q * q * q *q * q * q;
            Console.WriteLine("Введенное число в шестой степени будет:" + z);
            Console.ReadKey();
        }
    }
}
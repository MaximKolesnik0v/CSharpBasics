using System;

namespace IntegerSwap
{
    class IntegerSwapper
    {
        /*
         4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
         а) с использованием третьей переменной;
         б) *без использования третьей переменной.
        Колесников Максим
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());

            //Вариант А
            SwapWithBuffer(a, b);
            //Вариант Б
            //SwapWithoutBuffer(a, b);

            Console.ReadKey();
        }

        static void SwapWithBuffer(int a, int b)
        {
            int c = b;
            b = a;
            a = c;

            Console.WriteLine($"Значение a: {a}");
            Console.WriteLine($"Значение b: {b}");
        }

        static void SwapWithoutBuffer(int a, int b)
        {
            b += a;
            a = b - a;
            b = b - a;

            Console.WriteLine($"Значение a: {a}");
            Console.WriteLine($"Значение b: {b}");
        }
    }
}

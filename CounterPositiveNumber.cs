using System;

namespace Zadanie3
{
    class CounterPositiveNumber
    {
        /*
        С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        Колесников Максим
         */
        static void Main(string[] args)
        {
            
            float a = 2;
            float Sum = 0;
            while (a != 0)
            {
                Console.WriteLine("Введите число:");
                a = Convert.ToSingle(Console.ReadLine());
                if (a % 2 != 0 && a > 0)
                    Sum += a;
            }

                Console.WriteLine("Суммa нечетных положительных чисел= " + Sum);
       
        }
    }
}

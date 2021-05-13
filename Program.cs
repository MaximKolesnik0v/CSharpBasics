using System;

namespace Reset
{
    class MinimumOfThreeNumbers
        /* 
         Написать метод, возвращающий минимальное из трёх чисел
         Колесников Максим 
        */
        
        static void Main(string[] args)
        {
            MainMethod();
            Console.ReadKey();
        }

        static void MainMethod()
        {
            Console.WriteLine("Введите три числа:");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            float c = Convert.ToSingle(Console.ReadLine());
            
            float Min = MinOfThree(a, b, c);

            Console.WriteLine("Минимальное число: "+ Min);
        }

        static float MinOfThree(float a, float b, float c)
        {
            float Min;

            if (a < b && a < c)
                Min = a;
            else if (b < c)
                Min = b;
            else
                Min = c;

            return Min;
        }

    }
}

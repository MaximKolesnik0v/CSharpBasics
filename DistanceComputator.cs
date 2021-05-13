using System;

namespace Task3
{
    class DistanceComputator
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            Console.WriteLine("Введите координаты X1, X2, Y1, Y2: ");
            float X1 = Convert.ToSingle(Console.ReadLine());
            float X2 = Convert.ToSingle(Console.ReadLine());
            float Y1 = Convert.ToSingle(Console.ReadLine());
            float Y2 = Convert.ToSingle(Console.ReadLine());

            double r = 0;

            //Вариант А
            r = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));

            //Вариант Б
            //r = DistanceComputation(X1, X2, Y1, Y2);
            
            Console.WriteLine("Расстояние: " + $"{r:f}");
            Console.ReadKey();
        }

        static double DistanceComputation(float x1, float x2, float y1, float y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        } 
    }
}

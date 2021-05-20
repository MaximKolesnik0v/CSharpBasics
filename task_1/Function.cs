using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionDouble
{
    public delegate double Fun(double x, double a);

    class Function1
    {
        public static void Table(Fun F, double x, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= a)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public void SinSquare()
        {
            Console.WriteLine("Таблица функции a* sin(x):");
            Table(delegate (double x, double a) { return a * Math.Sin(x); }, -2, 2);
        
            Console.WriteLine("Таблица функции a* x^2:");
            Table(delegate (double x, double a) { return a * x * x; }, -2, 2);
        }
    }

}

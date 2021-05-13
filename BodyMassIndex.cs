using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BodyMassIndex
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите вес в килограммах: ");
            float m = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в метрах: ");
            float h = Convert.ToSingle(Console.ReadLine());
            float i = m / (h * h);
            Console.WriteLine("Индекс вашего тела: " + $"{i:F7}");
            Console.ReadKey();
        }
    }
}

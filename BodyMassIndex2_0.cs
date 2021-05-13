using System;

namespace wen
{
    class BodyMassIndex2_0
    /*
     а) Написать программу, которая запрашивает массу и рост человека,
     вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.  
     б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
     */
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес в килограммах: ");
            float m = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах: ");
            float h = Convert.ToSingle(Console.ReadLine());

            BodyMassIndex(m,h);
            WeightCorrection(h,m);
        }
        static float BodyMassIndex(float m,float h)
        {
            float Index = m / (h * h);

            if (Index <= 18.5)
                Console.WriteLine("Ваш индекс массы тела: " + Index + '.' + "Вам следует набрать вес");
            else if (Index > 18.5 && Index < 25)
                Console.WriteLine("Ваш индекс массы тела: " + Index + '.' + "Ваш вес в норме");
            else
                Console.WriteLine("Ваш индекс массы тела: " + Index + '.' + "Вам следует похудеть");
            return Index;
        }
        static float WeightCorrection( float h, float m)
        {
            float RecommendedWeight = 0;
            float Index = m / (h * h);
            if (Index <= 18.5)
            {
                Index = 19;
                RecommendedWeight = (Index * (h * h)) - m;
                Console.WriteLine("Вам нужно набрать: " + RecommendedWeight + " килограмм");
            }
            else if (Index >= 25)
            {
                Index = 24;
                RecommendedWeight = m - (Index * (h * h));
                Console.WriteLine("Вам нужно скинуть: " + RecommendedWeight +" килограмм");
            }
            return RecommendedWeight;


        }

    }
}

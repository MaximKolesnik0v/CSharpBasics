using System;

namespace Task1
{
    class StringsConstructor
    {
        static void Main(string[] args)
        //1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) используя вывод со знаком $.
        {
           Console.WriteLine("Введите номер режима использования (0 - Склеивание, 1 - форматированный, 2 - через $)");
            int mode = Convert.ToInt32(Console.ReadLine());

            if(mode < 0 || mode > 2)
            {
                Console.WriteLine("Неверный номер режима, перезапустите приложение");
                Console.ReadKey();
            }
            else
            {
                switch (mode)
                {
                    case 0:
                        ConstructStringConcat();
                        break;
                    case 1:
                        ConstructStringFormat();
                        break;

                    default:
                        ConstructStringAmpersand();
                        break;
                }
            }
        }

        static void ConstructStringConcat()
        {
            Console.WriteLine("Введите ваше имя: ");
            var a = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            var b = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            var c = Console.ReadLine();
            Console.WriteLine("Введите ваш рост: ");
            var d = Console.ReadLine();
            Console.WriteLine("Введите ваш вес: ");
            var e = Console.ReadLine();
            Console.WriteLine("имя: " + a + ',' + " фамилия: " + b + ',' + " возраст: " + c + ',' + " рост: " + d + ',' + " вес: " + e);
            Console.ReadKey();
        }

        static void ConstructStringFormat()
        {
            Console.WriteLine("Введите ваше имя: ");
            var a = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            var b = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            var c = Console.ReadLine();
            Console.WriteLine("Введите ваш рост: ");
            var d = Console.ReadLine();
            Console.WriteLine("Введите ваш вес: ");
            var e = Console.ReadLine();
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", a, b, c, d, e);
            Console.ReadKey();
        }

        static void ConstructStringAmpersand()
        {
            Console.WriteLine("Введите ваше имя: ");
            var a = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            var b = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            var c = Console.ReadLine();
            Console.WriteLine("Введите ваш рост: ");
            var d = Console.ReadLine();
            Console.WriteLine("Введите ваш вес: ");
            var e = Console.ReadLine();
            Console.WriteLine($"Имя: {a}, Фамилия: {b}, Возраст: {c}, Рост: {d}, Вес: {e}");
            Console.ReadKey();
        }
    }
}

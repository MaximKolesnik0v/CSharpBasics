using System;
using System.Text;

namespace NumberOfDigits
{
    class NumberOfDigits
    /*
     Написать метод подсчета количества цифр числа.
     Колесников Максим
     */
    {
        static void Main(string[] args)
        {
             /*Console.WriteLine("Введите число:");
             float a = Convert.ToSingle(Console.ReadLine());*/

            NumberCountString(123456f);

             /*int count = NumberCount(a);

             Console.WriteLine("Цифр в числе: " + count);*/

            Console.ReadKey();


        }
        static int NumberCount(float number)
        {
            int count = 0;

            while (number % 1 != 0)//Программа не работает с дробными числами, из-за не точности float(неверное округление) 
            {
                count++;
                number *= 10;
            }
            if (number >= 1)
                while (number >= 1)
                {
                    number /= 10;
                    count++;
                }

            return count;
        }
        static int NumberCountString(float number)
        {
            string stringNumber = Convert.ToString(number);
            int digitsCounter = 0;

            for (int i = 0; i < stringNumber.Length; i++)
            {
                char currentSymbol = stringNumber[i];

                if (currentSymbol == '0' ||
                    currentSymbol == '1' ||
                    currentSymbol == '2' ||
                    currentSymbol == '3' ||
                    currentSymbol == '4' ||
                    currentSymbol == '5' ||
                    currentSymbol == '6' ||
                    currentSymbol == '7' ||
                    currentSymbol == '8' ||
                    currentSymbol == '9')
                    digitsCounter++;
            }

            Console.WriteLine(digitsCounter);

            return 0;
        }

    }
}

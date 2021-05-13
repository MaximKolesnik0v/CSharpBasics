using System;

namespace zadanie_6
{
    class Program
    /*
     Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
     «Хорошим» называется число, которое делится на сумму своих цифр.
     Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
     Колесников Максим
     */
    {
        static void Main(string[] args)
        {
            GoodNumbers();
        
        }
        static int GoodNumbers()
        {
            int number = 0;
            for (int i = 1; i <222; i++)
            {

                int length = i;
                int n = i;
                int sum = 0;
                if (n % 10 !=0)
                {

                    while (length >= 1)
                    {
                        sum = sum + n % 10;
                        length = n / 10;
                    }

                    if (n % sum != 0)
                        break;
                    else
                    {
                        number++;
                    }
                }
                else
                    number++;
            }
            Console.WriteLine("Количество 'хороших' чисел: " + number);

            return number;
        }
    }
}

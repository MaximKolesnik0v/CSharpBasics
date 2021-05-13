using System;

namespace PairsOfElements
    /*Дан целочисленный массив из 20 элементов.
    Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    Заполнить случайными числами.
    Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
    В данной задаче под парой подразумевается два подряд идущих элемента массива.
    Колесников Максим*/
{
    class PairsOfElements
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] array = new int[n]; //сделал, если мы захотим заменить 20 на любое другое значение
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }
            Pair(n, array);
        }
        static int Pair(int n, int[] array)
        {
            int pairs = 0;
            for (int i = 0; i < n; i++)
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0)
                    pairs++;
            Console.WriteLine("Количество пар: " + pairs) ;
            return pairs;
        }
    }
}

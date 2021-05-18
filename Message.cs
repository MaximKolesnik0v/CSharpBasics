using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Message
{
    class Message
    {
        public void NoMoreN()
        //а) Вывести только те слова сообщения, которые содержат не более n букв.
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("С какого числа букв в слове искать слова?");
            int N = Convert.ToInt32(Console.ReadLine());

            string[] Data = str.Split(' ', ',', '.', '!', '?');

            foreach (string elements in Data)
            {
                if (elements.Length >= N)
                    Console.WriteLine($"{elements}");
            }
        }

        public void DeleteACharacter()
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("Слова с окончанием на какой символ будут удалены? ");
            char N = Convert.ToChar(Console.ReadLine());

            string[] Data = str.Split(' ', ',', '.', '!', '?');

            Regex delet = new Regex($"{N}$");

            foreach (string elements in Data)
            {
                if (!delet.IsMatch(elements))
                    Console.Write(elements + ' ');

            }
        }
        public void TheLongestWord()
        //в) Найти самое длинное слово сообщения.
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            string[] Data = str.Split(' ', ',', '.', '!', '?');

            string max = string.Empty;

            foreach (string elements in Data)
            {
                if (elements.Length > max.Length)
                    max = elements;
            }
            Console.WriteLine($"Самое длинное слово: {max}"); 
        }
        public void StringBuilder()
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            string[] Data = str.Split(' ', ',', '.', '!', '?');

            StringBuilder buid = new StringBuilder();
            
            string max = string.Empty;

            foreach (string elements in Data)
                if (elements.Length > max.Length)
                {
                    max = elements;
                }
            foreach (string elements in Data)
            {
                if (elements.Length == max.Length)
                    buid.Append(elements + ' ');
            }

            Console.WriteLine($"{buid}");
        }
    }

}

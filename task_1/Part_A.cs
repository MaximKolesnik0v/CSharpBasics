using System;
using System.Collections.Generic;
using System.Text;

namespace Login
{
    class Part_A
    {
        public void EnteringUsername()
        {
            Console.WriteLine("Введите логин: ");
            string Str = Convert.ToString(Console.ReadLine());

            char[] Data = Str.ToCharArray();

            bool correct = true;

            if (2 < Str.Length && Str.Length < 10)
            {
                if (!char.IsDigit(Data[0]))
                {
                    for (int i = 0; i < Str.Length; i++)
                        if (!char.IsLetterOrDigit(Data[i]))
                        {
                            correct = false;
                            break;
                        }
                }
                else
                    correct = false;

            }
            else
                correct = false;

            if (correct)
                Console.WriteLine("Логин корректный");
            else
                Console.WriteLine("Логин не корректный");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Login
{
    class Part_B
    {
        public void WithRegularExpressions()
        {

            Console.WriteLine("Введите логин: ");
            string Str = Convert.ToString(Console.ReadLine());

            char[] Data = Str.ToCharArray();

            Regex login1 = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            if (login1.Match(Str).Success)
                Console.WriteLine("Логин корректный");
            else
                Console.WriteLine("Логин не корректный");
        }
    }
}

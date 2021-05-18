using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangingWords
{
    class Changer
    {
        public void changer()
        {
            Console.WriteLine("Введите строку 1: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Введите строку 2: ");
            string str2 = Console.ReadLine();

            str1 = str1.ToLower();
            str2 = str2.ToLower();

            string Data1 = str1[0].ToString();
            string Data2 = str2[0].ToString();

            for (int i = 1; i < str1.Length; i++)
                CharIntoStr(ref Data1, str1[i]);

            for (int i = 1; i < str2.Length; i++)
                CharIntoStr(ref Data2, str2[i]);

            if (Data1.Equals(Data2))
                Console.WriteLine("Строки одианковы");
            else
                Console.WriteLine("Строки разные");
        }
        static void CharIntoStr(ref string s, char ch)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > ch)
                {
                    s = s.Insert(i, ch.ToString());
                    break;
                }
                else
                    if (i == s.Length - 1)
                {
                    s += ch.ToString();
                    break;
                }
            }

        }
    }
}

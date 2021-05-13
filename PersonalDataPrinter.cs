using System;

namespace PersonalDataOutput
{
    class PersonalDataPrinter
    {
        /*а
        а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        б) Сделать задание, только вывод организовать в центре экрана.
        в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
        Колесников Максим
         */
        static void Main(string[] args)
        {
            Output();

            Console.ReadKey();
        }

        static void Output()
        {
            int lineNumber = Console.WindowHeight / 2 ;
            lineNumber--;
            Print("Maksim", lineNumber);
            lineNumber++;
            Print("Kolesnikov", lineNumber);
            lineNumber++;
            Print("Moscow", lineNumber);
        }

        static void Print(string line, int lineNumber)
        {
            int xCenter = Console.WindowWidth / 2 - line.Length / 2;

            Console.SetCursorPosition(xCenter, lineNumber);
            Console.WriteLine(line);
        }
    }
}

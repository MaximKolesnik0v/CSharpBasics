using System;
using System.Text.RegularExpressions;

namespace Login
/*1. Создать программу, которая будет проверять корректность ввода логина.
Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
Колесников Максим */
{
    class Login
    {

        static void Main(string[] args)
        {
            Part_A Menu = new Part_A(); // часть А
            Menu.EnteringUsername();

           //Part_B Menu1 = new Part_B(); // Часть B
           // Menu1.WithRegularExpressions(); 
        }
    }
}
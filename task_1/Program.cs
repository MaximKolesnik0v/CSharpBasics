using System;

namespace FunctionDouble
    /*Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    Колесников Максим */

{
    class Function
    {
        static void Main(string[] args)
        {
            Function1 menu = new Function1();
            menu.SinSquare();
        }
    }
}

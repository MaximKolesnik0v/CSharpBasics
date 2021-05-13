using System;

namespace zadanie_4
{
    class authentication
    /*
     Реализовать метод проверки логина и пароля. 
     На вход метода подается логин и пароль.
     На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
     Используя метод проверки логина и пароля, написать программу: 
     пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
     С помощью цикла do while ограничить ввод пароля тремя попытками.
     */
    {
        static void Main(string[] args)
        {
            bool check = false;

            CheckData();

            if (check = true)
                Console.WriteLine("Доступ разрешен");
            else
                Console.WriteLine("Доступ запрещен");

        }
        static bool CheckData()
        {
            string login;
            string password;

            string CorrectLogin = "root";
            string CorrectPassword = "GeekBrains";
            bool check = false;

            int attempts = 3;

            do
            {
                Console.WriteLine("Введите Логин:");
                login = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Введите пароль:");
                password = Convert.ToString(Console.ReadLine());

                if (login == CorrectLogin && password == CorrectPassword)
                {
                    check = true;
                    break;
                }

                attempts--;
                Console.WriteLine("Осталось попыток: " + attempts);
            } while (attempts > 0);

            return check;
        }
    }
}

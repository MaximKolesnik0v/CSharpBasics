﻿using System;

namespace Message
    /*Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    а) Вывести только те слова сообщения, которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    д) *** Создать метод, который производит частотный анализ текста.
    В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    Здесь требуется использовать класс Dictionary.
    Колесников Максим*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Message menu = new Message();
            //menu.NoMoreN();//A
            //menu.DeleteACharacter();//Б
            //menu.TheLongestWord();//В
            //menu.StringBuilder();//Г
        }
    }
}

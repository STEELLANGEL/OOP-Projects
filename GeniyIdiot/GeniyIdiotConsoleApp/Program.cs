using System;
using System.Diagnostics;
using GeniyIdiot.Common;
using GeniyIdiotConsoleApp;

namespace GeniusIdiotConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stroke = new String('-', 30);

            Console.WriteLine(stroke);
            Console.WriteLine("Здравствуйте, как Вас зовут ?");
            Console.WriteLine(stroke);

            string userName = Console.ReadLine();
            Console.WriteLine();

            stroke = new String('-', 52);

            Console.WriteLine(stroke);
            var message = """
                Вам будут предложены 5 вопросов.
                На обдумывание каждого вопроса у вас есть 10 секунд.
                Затем вы доложны дать ответ.
                По окончанию теста Вам будет выставлен диагноз.
                Если пожелаете, Вы сможете пройти тест еще раз.
                """;
            Console.WriteLine(message);
            Console.WriteLine(stroke);

            var startMenu = """

                Тест - 1.
                Показать результаты - 2.
                Выйти - 3.
                Добавить вопрос - 4.
                Удалиить существующий вопрос - 5.
                Отправить на почту последний результат - 6.

                """;

            var results = UserResultsStorage.GetAll();

            StartMenu.GetChoce(startMenu, userName, results);
        }
    }
}
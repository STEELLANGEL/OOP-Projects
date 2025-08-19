using System;
using System.Collections.Generic;
using GeniusIdiotConsoleApp;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
    public class StartMenu
    {
        public static void GetChoce(string startMenu, string userName, List<User> results)
        {
            while (true)
            {
                Console.WriteLine(startMenu);
                string userAnswer = Console.ReadLine();

                if (userAnswer == "1")
                {
                    Console.WriteLine();
                    Test.Begining(userName);

                    results = UserResultsStorage.GetAll();

                    if (UserInput.ConveyYesOrNo("Вывести результаты , Да или Нет ?"))
                    {
                        StatisticsList.Show(results);

                        if (UserInput.ConveyYesOrNo("Отправить Ваш результат по почте, Да или Нет?"))
                        {
                            Mail.Send(results);
                        }
                    }

                    GetChoce(startMenu, userName, results);
                    break;
                }

                if (userAnswer == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine(userName + ", Вы завершили тест.");
                    Environment.Exit(0);
                }

                if (userAnswer == "2")
                {
                    StatisticsList.Show(results);
                }

                if (userAnswer == "4")
                {
                    Console.WriteLine();
                    QuestionManager.Add();
                }

                if (userAnswer == "5")
                {
                    Console.WriteLine();
                    QuestionManager.Remove();
                }
                if (userAnswer == "6")
                {
                    Console.WriteLine();
                    Mail.Send(results);
                }
            }
        }
    }
}

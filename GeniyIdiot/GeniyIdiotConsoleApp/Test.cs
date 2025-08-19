using System;
using System.Collections.Generic;
using GeniusIdiotConsoleApp;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
    internal class Test
    {
        public static void Begining(string userName)
        {
            var user = new User(userName);

            var questions = QuestionsStorage.GetAll();

            var questionsCount = questions.Count;

            var rightAnswersCount = user.RightAnsweresCount;

            Random random = new Random();

            for (int i = 0; i < questionsCount; i++)
            {
                Console.WriteLine("Вопрос N№ " + (i + 1));

                var randomIndex = random.Next(0, questions.Count);

                Console.WriteLine(i + 1 + ". " + questions[randomIndex].Text);
                Console.WriteLine();

                int userAnswer = UserInput.ConveyNumber();
                Console.WriteLine();

                int rightAnswer = questions[randomIndex].Answer;

                if (userAnswer == rightAnswer)
                {
                    user.RightAnseresAccept();
                }
                questions.RemoveAt(randomIndex);
            }

            string stroke = new string('-', 33);

            Console.WriteLine(stroke);
            Console.WriteLine("Количество правильных ответов: " + user.RightAnsweresCount);

            var diagnos = DiagnoseStorage.Calculate(questionsCount, user.RightAnsweresCount);

            user.Diagnos = diagnos.MedicalConclusion;

            Console.WriteLine();
            Console.WriteLine(userName + ", Ваш диагноз = " + user.Diagnos);
            Console.WriteLine(stroke);
            Console.WriteLine();

            UserResultsStorage.Append(user);
        }
    }
}
using System;
using GeniyIdiot.Common;

namespace GeniusIdiotConsoleApp
{
    public class QuestionManager
    {
        public static void Remove()
        {
            Console.WriteLine("Введите номер удаляемого вопроса");
            Console.WriteLine();

            var questions = QuestionsStorage.GetAll();

            for (var i = 0; i < questions.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + questions[i].Text);
                Console.WriteLine();
            }

            var removeIndex = UserInput.ConveyNumber();

            while (removeIndex < 1 || removeIndex > questions.Count)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите существующий номер вопроса");
                Console.WriteLine();
                removeIndex = UserInput.ConveyNumber();
            }

            removeIndex = removeIndex - 1;

            QuestionsStorage.Remove(removeIndex);
        }

        public static void Add()
        {
            Console.WriteLine("Введите текст вопроса");
            Console.WriteLine();
            var text = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите ответ на ваш вопрос");
            Console.WriteLine();
            var answer = UserInput.ConveyNumber();

            var newQuestion = new Question(text, answer);
            QuestionsStorage.Add(newQuestion);
        }
    }
}

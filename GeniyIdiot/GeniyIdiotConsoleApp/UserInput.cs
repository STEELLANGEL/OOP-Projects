using System;

namespace GeniusIdiotConsoleApp
{
    public class UserInput
    {
        public static bool ConveyYesOrNo(string question)
        {
            Console.WriteLine(question);

            Console.WriteLine();
            string userAnswer = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (userAnswer == "ДА")
                return true;

            if (userAnswer == "НЕТ")
                return false;

            return ConveyYesOrNo(question);
        }
        public static int ConveyNumber()
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ведите число....");
                    Console.WriteLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите число меньше ... ");
                    Console.WriteLine();
                }
            }
        }
    }

}

using System;
using System.Collections.Generic;
using GeniyIdiot.Common;

namespace GeniusIdiotConsoleApp
{
    public class StatisticsList
    {
        public static void Show(List<User> results)
        {
            var stroke = new string('=', 86);

            string tableHeaderPattern = "{0,-32}{1,-44}{2,-32}";
            string pattern = "{0,-20}{1,26}{2,36}";

            Console.WriteLine(stroke);
            Console.WriteLine(tableHeaderPattern, "Имя", "Счетчик правильных ответов", "Диагноз");
            Console.WriteLine(stroke);

            foreach (var user in results)
            {
                Console.WriteLine(pattern, user.Name, user.RightAnsweresCount, user.Diagnos);
            }
            Console.WriteLine(stroke);
            Console.WriteLine();
        }
    }
}

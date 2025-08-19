using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class DiagnoseStorage
    {
        public static List<Diagnose> ObtainAll()
        {
            var diagnoses = new List<Diagnose>();

            diagnoses.Add(new Diagnose("Идиот"));
            diagnoses.Add(new Diagnose("Кретин"));
            diagnoses.Add(new Diagnose("Дурак"));
            diagnoses.Add(new Diagnose("Нормальный"));
            diagnoses.Add(new Diagnose("Талант"));
            diagnoses.Add(new Diagnose("Гений"));
            return diagnoses;
        }

        public static Diagnose Calculate(int questionsCount, int rightAnswersCount)
        {
            var diagnoses = ObtainAll();

            int rightAnswersPercent = rightAnswersCount * 100 / questionsCount;

            if (rightAnswersPercent < 10)
                return diagnoses[0];
            if (rightAnswersPercent < 30)
                return diagnoses[1];
            if (rightAnswersPercent < 45)
                return diagnoses[2];
            if (rightAnswersPercent < 80)
                return diagnoses[3];
            if (rightAnswersPercent < 100)
                return diagnoses[4];

            return diagnoses[5];
        }
    }
}

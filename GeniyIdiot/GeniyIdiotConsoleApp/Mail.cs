using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
    public class Mail
    {
        public static void Send(List<User> results)
        {
            var result = new List<User>();

            result.AddRange(results);

            Console.WriteLine("Введите вашу почту:");
            Console.WriteLine();

            var userMail = "";

            while (true)
            {
                userMail = Console.ReadLine();

                if (userMail.Contains("@"))
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Введите существющий адрес эоектронной почты");
                Console.WriteLine();
            }

            result.Reverse();

            var sendMessage = "";
            foreach (var user in result)
            {
                sendMessage = "" + user.Name + ", Вы набрали очков: " + user.RightAnsweresCount + "." + " Ваш диагноз: " + user.Diagnos;
                break;
            }
            sendMessage += """
                
                Диагноз не является окончательным и Вы всегда можете пройти тест заново.
                Диагноз не указывает на какие либо психические отклонения, но рекомендуется отнестись с вниманием к своему развитию!

                """;

            result.Reverse();

            SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 587);//Тут нужно 587
            Smtp.Credentials = new NetworkCredential("steellangel", "y4fRgKEUNScA4JwRd3Z4");
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("steellangel@mail.ru"); // пишем свой e-mail.
            Message.To.Add(new MailAddress(userMail)); // Куда отправлять
            Message.Subject = "Тест Гений/Идиот. Ваши результаты"; // свой заголовок
            Message.Body = sendMessage;
            Smtp.EnableSsl = true;
            Smtp.Send(Message);
        }
    }
}
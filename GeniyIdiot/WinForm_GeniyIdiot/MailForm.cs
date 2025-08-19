using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;

using System.Windows.Forms;

namespace WinForm_GeniyIdiot
{
    public partial class mailForm : Form
    {
        public mailForm()
        {
            InitializeComponent();
        }

        public mailForm(String userNameTransfer)
        {
            InitializeComponent();
            nameLabel.Text = userNameTransfer;
        }

        private void outFromMaleButton_Click(object sender, EventArgs e)
        {
            OutFromMale();
        }

        private void OutFromMale()
        {
            MainForm f = new MainForm(nameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            List<User> result = UserResultsStorage.GetAll();

            result.Reverse();

            var emailMessage = "";
            foreach (var user in result)
            {
                emailMessage = "" + user.Name + ", Вы набрали очков: " + user.RightAnsweresCount + "." + " Ваш диагноз: " + user.Diagnos;
                break;
            }
            emailMessage += """
                

                Диагноз не является окончательным и Вы всегда можете пройти тест заново.
                Диагноз не указывает на какие либо психические отклонения, но рекомендуется отнестись с вниманием к своему развитию!

                """;

            result.Reverse();

            var userMail = "";

            userMail = insertUserMail.Text;

            ConveyTrueMail(userMail, emailMessage);
        }

        private bool ConveyTrueMail(string userMail, string emailMessage)
        {
            try
            {
                SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 587);//Тут нужно 587
                Smtp.Credentials = new NetworkCredential("steellangel", "y4fRgKEUNScA4JwRd3Z4");
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress("steellangel@mail.ru"); // пишем свой e-mail.
                Message.To.Add(new MailAddress(userMail)); // Куда отправлять
                Message.Subject = "Тест Гений/Идиот. Ваши результаты"; // свой заголовок
                Message.Body = emailMessage;
                Smtp.EnableSsl = true;
                Smtp.Send(Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Введите существющий адрес эоектронной почты");
            }
            return false;
        }
    }
}

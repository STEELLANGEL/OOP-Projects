using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace WinForm_GeniyIdiot
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testForm f = new testForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultForm f = new resultForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sendResultMailButton_Click(object sender, EventArgs e)
        {
            mailForm f = new mailForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        public MainForm(String userNameTransfer)
        {
            InitializeComponent();
            userNameLabel.Text = userNameTransfer;
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            addQuestionForm f = new addQuestionForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            removeQuestionForm f = new removeQuestionForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var message = """
                Вам будут предложены 5 вопросов.
                На обдумывание каждого вопроса у вас есть 10 секунд.
                Затем вы доложны дать ответ.
                По окончанию теста Вам будет выставлен диагноз.
                Если пожелаете, Вы сможете пройти тест еще раз.
                """;

            rulesLabel.Text = message;
        }

        private void reLoadTestButton_Click(object sender, EventArgs e)
        {
            UserNameForm f = new UserNameForm();
            f.Show();
            this.Hide();
        }
    }  
}

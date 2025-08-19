using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForm_GeniyIdiot
{
    public partial class addQuestionForm : Form
    {
        private User user;

        public addQuestionForm()
        {
            InitializeComponent();
        }

        public addQuestionForm(String userNameTransfer)
        {
            InitializeComponent();
            userNameLabel.Text = userNameTransfer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = new User(userNameLabel.Text);

            List<Question> questions = QuestionsStorage.GetAll();

            var text = inputQuestion.Text;

            if (IsVadeAnswer() == false)
            {
                return;
            }
            var answer = Convert.ToInt32(inputAnswer.Text);

            var newQuestion = new Question(text, answer);

            QuestionsStorage.Add(newQuestion);

            ReLoadAddQuestion();
        }

        private void ReLoadAddQuestion()
        {
            addQuestionForm f = new addQuestionForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        public bool IsVadeAnswer()
        {
            try
            {
                int.Parse(inputAnswer.Text);
                    return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(user.Name + " , Ведите число....");
            }
            catch (OverflowException)
            {
                MessageBox.Show(user.Name + " , Введите число меньше ... ");

            }
            return false;
        }

        private void offAddQuestionButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }
    }
}

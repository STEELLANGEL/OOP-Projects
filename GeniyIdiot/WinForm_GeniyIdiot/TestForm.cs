using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Windows.Forms;
using GeniyIdiot.Common;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Linq;
using Microsoft.Win32;

namespace WinForm_GeniyIdiot
{
    public partial class testForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int questionsCount;
        private int questionNumber = 1;

        int seconds = 10;

        public testForm()
        {
            InitializeComponent();
        }

        public testForm(String userNameTransfer)
        {
            InitializeComponent();
            userNameLabel.Text = userNameTransfer;
        }

        public void mainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            sec.Text = seconds.ToString();

            questions = QuestionsStorage.GetAll();

            questionsCount = questions.Count;

            user = new User(userNameLabel.Text);

            ShowNextQuestion();
        }

        public void ShowNextQuestion()
        {
            if (questions.Count == 0)
            {
                EndGame();

                return;
            }

            Random random = new Random();

            int randomIndex = random.Next(0, questions.Count);

            currentQuestion = questions[randomIndex];

            questionNumberLabel.Text = "Вопрос N : " + questionNumber;

            questionNumber += 1;

            questionTextLabel.Text = currentQuestion.Text;

            seconds = 11;

            timer1.Start();
        }


        public void nextButton_Click(object sender, EventArgs e)
        {
            if (ChechNumber() == false)
            {
                return;
            }
            AcceptAnswer();
            var endGame = questions.Count == 0;

            if (endGame)
            {
                EndGame();
                return;
            }
            ShowNextQuestion();

            inputAnswerQuestion.Text = string.Empty;
        }

        private void EndGame()
        {
            timer1.Stop();

            var diagnos = DiagnoseStorage.Calculate(questionsCount, user.RightAnsweresCount);

            user.Diagnos = diagnos.MedicalConclusion;

            MessageBox.Show(user.Name + " ,  ваш диагноз  : " + user.Diagnos);

            UserResultsStorage.Append(user);

            FinishTest();
        }

        public void AcceptAnswer()
        {
            int userAnswer = Convert.ToInt32(inputAnswerQuestion.Text);

            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer) 
            {
                user.RightAnseresAccept();
            }
            questions.Remove(currentQuestion);
        }

        private void FinishTest()
        {
            MainForm f = new MainForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void endTestButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            FinishTest();
        }
        public bool ChechNumber()
        {
            try
            {
                int.Parse(inputAnswerQuestion.Text);
                return true;
            }

            catch (FormatException)
            {
                MessageBox.Show("введите число...");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введите число меньше ... ");
            }
            return false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            seconds = seconds - 1;

            sec.Text = seconds.ToString();

            if (seconds == 0)
            {
                questions.Remove(currentQuestion);

                ShowNextQuestion();
            }
        }
    }
}

using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForm_GeniyIdiot
{
    public partial class removeQuestionForm : Form
    {
        private List<Question> questions;
        private User user;

        public removeQuestionForm(String userNameTransfer)
        {
            InitializeComponent();
            userNameLabel.Text = userNameTransfer;
        }

        public removeQuestionForm()
        {
            InitializeComponent();
        }

        private void removeQuestionForm_Load(object sender, EventArgs e)
        {
            user = new User(userNameLabel.Text);

            questions = QuestionsStorage.GetAll();

            for (var i = 0; i < questions.Count; i++)
            {
                showAllQuestion.AppendText("" + (i + 1) + ". " + (questions[i].Text) + Environment.NewLine);
            }
        }

        public bool CheckNumber()
        {
            try
            {
                int.Parse(inputNumber.Text);
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

        private void ReLoadRemoveQuestion()
        {
            removeQuestionForm f = new removeQuestionForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void outFromRemoveButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            if (CheckNumber() == false)
            {
                return;
            }
            var removeIndex = Convert.ToInt32(inputNumber.Text);

            if (removeIndex < 1 || removeIndex > questions.Count)
            {
                MessageBox.Show("Выберите существующий номер вопроса");
                return;
            }
            
            removeIndex = removeIndex - 1;

            QuestionsStorage.Remove(removeIndex);

            ReLoadRemoveQuestion();
            

        }
    }
}

using System.Text.RegularExpressions;

namespace Race
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void getUserNameButton_Click(object sender, EventArgs e)
        {
            if (CheckUserName() == false)
            {
                MessageBox.Show("введите настоящее Имя...");
                return;
            }

            RaceGame f = new RaceGame(inputName.Text);
            f.Show();
            this.Hide();
        }
        public bool CheckUserName()
        {
            return (Regex.IsMatch(inputName.Text, @"^[a-zA-Zа-яА-Я]+$"));
        }
    }
}

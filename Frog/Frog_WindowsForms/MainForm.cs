using System;
using System.Windows.Forms;

namespace Frog_WindowsForms
{
    public partial class MainForm : Form
    {
        private Form form;

        private int score = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void WaterLily_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);

            if (EndGame())
            {
                if (score == 24)
                {
                    MessageBox.Show("Поздравляем! Вы справились за МИНИМАЛЬНОЕ колличество ходов!");

                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Поздравляем! Вы справились!");

                    Application.Restart();
                }
            }
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyWaterLily.Location.X) / emptyWaterLily.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("Нельзя прыгнуть! ");
            }
            else
            {
                var location = clickedPicture.Location;

                clickedPicture.Location = emptyWaterLily.Location;

                emptyWaterLily.Location = location;

                score++;

                stepCountLabel.Text = score.ToString();
            }
        }
        public bool EndGame()
        {
            return leftWaterLily1.Location.X > emptyWaterLily.Location.X &&
                leftWaterLily2.Location.X > emptyWaterLily.Location.X &&
                leftWaterLily3.Location.X > emptyWaterLily.Location.X &&
                leftWaterLily4.Location.X > emptyWaterLily.Location.X &&
                rightWaterLily1.Location.X < emptyWaterLily.Location.X &&
                rightWaterLily2.Location.X < emptyWaterLily.Location.X &&
                rightWaterLily3.Location.X < emptyWaterLily.Location.X &&
                rightWaterLily4.Location.X < emptyWaterLily.Location.X;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameMenu f = new GameMenu();
            f.Show();
            this.Hide();
        }
    }
}

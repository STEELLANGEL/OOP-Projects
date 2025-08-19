using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using _2048.Common;

namespace _2048_WindowsForms
{
    public partial class MainForm: Form
    {
        private User user;
        private int mapSize = 4;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        private int bestScore = 0;

        private const int startX = 4;
        private const int startY = 90;
        private const int padding = 6;
        private const int labelSize = 70;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User(userNameLabel.Text);

            СlculateMapSize(startForm.radioButtons);

            InitMap();
            ConveyRandomNumber();
            ShowScore();
            CalculateShowBestScore();
        }

        private void СlculateMapSize(List<RadioButton> radioButtons)
        {
            foreach (var item in radioButtons)
            {
                if (item.Checked)
                {
                    mapSize = Convert.ToInt32(item.Text);
                    break;
                }
            }
            gameSizeLabel.Text = "" + mapSize + " x " + mapSize;
        }

        private void CalculateShowBestScore()
        {
            var users = UserManager.GetAll();

            if (users.Count == 0)
            {
                return;
            }
            bestScore = users[0].Score;

            foreach (var user in users)
            {
                if (user.Score > bestScore)
                {
                    bestScore = user.Score;
                }
            }
            ShowBestScore();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }
        private void ShowBestScore()
        {
            if (score > bestScore)
            {
                bestScore = score;
            }
            bestScoreLabel.Text = bestScore.ToString();

        }

        private void InitMap()
        {
            this.ClientSize = new System.Drawing.Size(startX + (labelSize + padding) * mapSize, startY + (labelSize + padding) * mapSize);

            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j, i * mapSize + j);

                    Controls.Add(newLabel);

                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private bool ConveyRandomNumber()
        {
            var labelNumber = random.Next(mapSize * mapSize);
            var indexRow = labelNumber / mapSize;
            var indexColumn = labelNumber % mapSize;

            var randomNumber = (random.Next(2) > 0) ? 2 : 4;

            if (random.NextDouble() < 0.25)
            {
                randomNumber = 4;
            }
            if (random.NextDouble() > 0.25)
            {
                randomNumber = 2;
            }

            if (labelsMap[indexRow, indexColumn].Text == string.Empty)
            {
                labelsMap[indexRow, indexColumn].Text = randomNumber.ToString();
                return true;
            }
            return false;
        }

        private Label CreateLabel(int rowLocation, int columnLocation, int number)
        {
            var label = new Label();
            label.BackColor = Color.FromArgb(205, 193, 180);
            label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(labelSize, labelSize);
            label.Text = "";
            label.TextAlign = ContentAlignment.MiddleCenter;

            int x = startX + columnLocation * (labelSize + padding);
            int y = startY + rowLocation * (labelSize + padding);

            label.Location = new Point(x, y);

            label.TextChanged += Label_TextChanged;

            return label;
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            var label = (Label)sender;

            switch (label.Text)
            {
                case "": label.BackColor = Color.FromArgb(205, 193, 180); break;
                case "2": label.BackColor = Color.FromArgb(238, 228, 218); break;
                case "4": label.BackColor = Color.FromArgb(237, 224, 200); break;
                case "8": label.BackColor = Color.FromArgb(242, 177, 121); break;
                case "16": label.BackColor = Color.FromArgb(245, 149, 99); break;
                case "32": label.BackColor = Color.FromArgb(246, 124, 95); break;
                case "64": label.BackColor = Color.FromArgb(246, 94, 59); break;
                case "128": label.BackColor = Color.FromArgb(237, 207, 114); break;
                case "256": label.BackColor = Color.FromArgb(237, 204, 97); break;
                case "512": label.BackColor = Color.FromArgb(237, 200, 80); break;
                case "1024": label.BackColor = Color.FromArgb(237, 197, 63); break;
                case "2048": label.BackColor = Color.FromArgb(237, 197, 63); break;
            }
            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Escape)
            {
                return;
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }

            if (e.KeyCode == Keys.Escape)
            {
                user.Score = score;

                UserManager.Append(user);

                MenuForm f = new MenuForm(userNameLabel.Text);
                f.Show();
                this.Hide();
            }
            
            ConveyRandomNumber();
            ShowScore();
            ShowBestScore();

            if (Win())
            {
                UserManager.Append(new User (userNameLabel.Text) { Name = "Test" + score, Score = score });

                MessageBox.Show("Поздравляем!!! " + userNameLabel.Text + " , Вы Победили!");
                return;
            }

            if (EndGame())
            {
                UserManager.Append(new User(userNameLabel.Text) { Name = "Test" + score, Score = score });
                MessageBox.Show("" + userNameLabel.Text + " , Вы проиграли...");
                return;
            }
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += (number * 2);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += (number * 2);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += (number * 2);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += (number * 2);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private bool EndGame()
        {
            for(int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }

            for(int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                   if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public MainForm(String userNameTransfer)
        {
            InitializeComponent();
            userNameLabel.Text = userNameTransfer;
        }
    }
}

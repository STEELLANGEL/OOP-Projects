using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_WindowsForms
{
    public partial class MenuForm: Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuForm(String userNameTransfer)
        {
            InitializeComponent();
            userNameLabel.Text = userNameTransfer;
        }

        private void endGameButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            startForm f = new startForm();
            f.Show();
            this.Hide();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            resultForm f = new resultForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void ruleButton_Click(object sender, EventArgs e)
        {
            GameRuleForm f = new GameRuleForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void gameName_Click(object sender, EventArgs e)
        {
            gameName.BackColor = System.Drawing.Color.Transparent;
        }
    }
}

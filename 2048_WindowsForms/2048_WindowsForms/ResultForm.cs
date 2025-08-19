using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _2048.Common;

namespace _2048_WindowsForms
{
    public partial class resultForm: Form
    {
        public resultForm()
        {
            InitializeComponent();
        }

        public resultForm(String userNameTransfer)
        {
            InitializeComponent();
            userNameLabel.Text = userNameTransfer;
        }


        private void ResultForm_Load(object sender, EventArgs e)
        {
            List<User> results = UserManager.GetAll();

            foreach (var result in results)
            {
                resultBoard.Rows.Add(result.Name , result.Score);
            }
        }

        private void outFromResultButton_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        public static string path = "userResults.json";

        private void deliteResults_Click(object sender, EventArgs e)
        {
            
            FileProvider.Clear(path);

            ReloadResultsForm();
        }

        private void ReloadResultsForm()
        {
            resultForm f = new resultForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }
    }
}

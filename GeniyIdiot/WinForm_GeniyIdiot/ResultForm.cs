using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace WinForm_GeniyIdiot
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
            List<User> results = UserResultsStorage.GetAll();

            foreach (var result in results)
            {
                resultBoard.Rows.Add(result.Name , result.RightAnsweresCount, result.Diagnos);
            }
        }

        private void outFromResultButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(userNameLabel.Text);
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

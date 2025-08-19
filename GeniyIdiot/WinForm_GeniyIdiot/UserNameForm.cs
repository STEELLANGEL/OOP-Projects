using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace WinForm_GeniyIdiot
{
    public partial class UserNameForm: Form
    {
        public UserNameForm()
        {
            InitializeComponent();
        }

        private void getUserNameButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm(inputName.Text);
            f.Show();
            this.Hide();
        }
    }
}

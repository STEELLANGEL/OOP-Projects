using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048_WindowsForms
{
    public partial class startForm: Form
    {
        public static List<RadioButton> radioButtons;

        public startForm()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>() 
            {radioButton4, radioButton5, radioButton6, radioButton7,
            radioButton8, radioButton9};
        }

        private void getUserNameButton_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(inputName.Text);
            f.Show();
            this.Hide();
        }
    }
}

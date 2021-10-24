using System;
using System.Windows.Forms;


namespace PictureBoxAndComboBox
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var number = int.Parse(numberTb.Text);

            resultLbl.Text = (number > 0 ? number + 10 : number - 5).ToString();
        }
    }
}
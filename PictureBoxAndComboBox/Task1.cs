using System;
using System.Drawing;
using System.Windows.Forms;


namespace PictureBoxAndComboBox
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Picture (*.jpg, *.jpeg, *.png, *.svg)|";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePb.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            imagePb.Image = null;
        }
    }
}
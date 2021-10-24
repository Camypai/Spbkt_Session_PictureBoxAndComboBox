using System;
using System.Drawing;
using System.Windows.Forms;


namespace PictureBoxAndComboBox
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void trafficLightCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trafficLight = (TrafficLight)trafficLightCmb.SelectedIndex;

            switch (trafficLight)
            {
                case TrafficLight.Red:
                    trafficLightLbl.Text = "Стой!";
                    trafficLightLbl.BackColor = Color.Red;
                    break;
                case TrafficLight.Yellow:
                    trafficLightLbl.Text      = "Жди...";
                    trafficLightLbl.BackColor = Color.Yellow;
                    break;
                case TrafficLight.Green:
                    trafficLightLbl.Text      = "Иди";
                    trafficLightLbl.BackColor = Color.Green;
                    break;
            }
        }
    }
}
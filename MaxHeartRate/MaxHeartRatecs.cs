using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MaxHeartRatecs : Form
    {
        public MaxHeartRatecs()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(ageTextBox.Text);

                int maxheartRate = 220 - age;
                resultLabel.Text = $" Maximum Heart Rate: {maxheartRate} beats per minute";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaxHeartRatecs_Load(object sender, EventArgs e)
        {

        }
    }
}

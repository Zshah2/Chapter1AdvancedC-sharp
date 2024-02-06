using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class HeartRateForm : Form
    {
        public HeartRateForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ageTextBox.Text, out int age))
            {
                // Calculate the maximum heart rate using the formula: 220 - age
                int maxHeartRate = 220 - age;

                // Display the result in the label
                resultLabel.Text = $"Maximum Heart Rate: {maxHeartRate} beats per minute";
            }
            else
            {
                // Display an error message if the entered age is not a valid integer
                resultLabel.Text = "Please enter a valid age";
            }

           
        }
    }
}
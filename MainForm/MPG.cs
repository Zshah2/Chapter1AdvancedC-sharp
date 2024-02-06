namespace MainForm
{
    public partial class MPG : Form
    {
        public MPG()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from the textboxes
                double milesDriven = double.Parse(milesTextBox.Text);
                double gallonsConsumed = double.Parse(gallonsTextBox.Text);

                // Calculate MPG
                double mpg = milesDriven / gallonsConsumed;

                // Display the result
                resultLabel.Text = $"Miles Per Gallon: {mpg:F2} MPG";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for miles driven and gallons consumed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

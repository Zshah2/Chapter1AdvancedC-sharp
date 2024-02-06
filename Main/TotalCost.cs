namespace Main
{
    public partial class Form1 : Form
    {

        private const double SalesTaxRate = 0.08;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input values
                double laborCost = double.Parse(laborCostTextBox.Text);
                double materialCost = double.Parse(materialCostTextBox.Text);

                // Calculate subtotal, sales tax, and total
                double subtotal = laborCost + materialCost;
                double salesTax = subtotal * SalesTaxRate;
                double total = subtotal + salesTax;

                // Display results in labels
                subtotalLabel.Text = $"Subtotal: {subtotal:C}";
                salesTaxLabel.Text = $"Sales Tax: {salesTax:C}";
                totalLabel.Text = $"Total: {total:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for labor and material costs.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            laborCostTextBox.Clear();
            materialCostTextBox.Clear();
            subtotalLabel.Text = string.Empty;
            salesTaxLabel.Text = string.Empty;
            totalLabel.Text = string.Empty;
        }
    }
}

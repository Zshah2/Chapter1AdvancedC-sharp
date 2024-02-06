using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegisterFormApp
{
    public partial class RegisterForm : Form
    {
        private List<double> items = new List<double>();
        private double subtotal = 0;
        private const double TaxRate = 0.08; // 8% tax rate

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                double itemPrice = double.Parse(itemPriceTextBox.Text);
                items.Add(itemPrice);
                subtotal += itemPrice;
                itemListBox.Items.Add($"Item: ${itemPrice:F2}");
                itemPriceTextBox.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid item price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompletePurchaseButton_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                MessageBox.Show("No items added yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tax = subtotal * TaxRate;
            double total = subtotal + tax;

            itemListBox.Items.Add($"Subtotal: ${subtotal:F2}");
            itemListBox.Items.Add($"Tax: ${tax:F2}");
            itemListBox.Items.Add($"Total: ${total:F2}");
            itemListBox.Items.Add($"Number of Items: {items.Count}");

            addItemButton.Enabled = false;
            completePurchaseButton.Enabled = false;
        }
    }
}

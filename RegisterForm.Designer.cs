namespace RegisterFormApp
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.completePurchaseButton = new System.Windows.Forms.Button();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            
            // itemPriceLabel
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(12, 15);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(70, 13);
            this.itemPriceLabel.TabIndex = 0;
            this.itemPriceLabel.Text = "Item Price:";
            
            // itemPriceTextBox
            this.itemPriceTextBox.Location = new System.Drawing.Point(88, 12);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemPriceTextBox.TabIndex = 1;
            
            // addItemButton
            this.addItemButton.Location = new System.Drawing.Point(194, 10);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            
            // completePurchaseButton
            this.completePurchaseButton.Location = new System.Drawing.Point(275, 10);
            this.completePurchaseButton.Name = "completePurchaseButton";
            this.completePurchaseButton.Size = new System.Drawing.Size(114, 23);
            this.completePurchaseButton.TabIndex = 3;
            this.completePurchaseButton.Text = "Complete Purchase";
            this.completePurchaseButton.UseVisualStyleBackColor = true;
            this.completePurchaseButton.Click += new System.EventHandler(this.CompletePurchaseButton_Click);
            
            // itemListBox
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(15, 41);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(374, 186);
            this.itemListBox.TabIndex = 4;
            
            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 239);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.completePurchaseButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemPriceLabel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button completePurchaseButton;
        private System.Windows.Forms.ListBox itemListBox;
    }
}

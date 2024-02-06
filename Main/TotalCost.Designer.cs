
namespace Main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            label1 = new Label();
            laborCostTextBox = new TextBox();
            materialCostTextBox = new TextBox();
            button1 = new Button();
            totalLabel = new TextBox();
            salesTaxLabel = new TextBox();
            subtotalLabel = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Labor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 2;
            label3.Text = "Material:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(233, 53);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 6;
            label4.Text = "Sale Tax:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F);
            label5.Location = new Point(233, 83);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 7;
            label5.Text = "SubTotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F);
            label6.Location = new Point(233, 112);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 8;
            label6.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "Cost of:";
            // 
            // laborCostTextBox
            // 
            laborCostTextBox.BackColor = SystemColors.InactiveBorder;
            laborCostTextBox.ForeColor = SystemColors.InactiveCaptionText;
            laborCostTextBox.Location = new Point(89, 55);
            laborCostTextBox.Name = "laborCostTextBox";
            laborCostTextBox.Size = new Size(109, 23);
            laborCostTextBox.TabIndex = 3;
            // 
            // materialCostTextBox
            // 
            materialCostTextBox.BackColor = SystemColors.InactiveBorder;
            materialCostTextBox.ForeColor = SystemColors.InactiveCaptionText;
            materialCostTextBox.Location = new Point(91, 92);
            materialCostTextBox.Name = "materialCostTextBox";
            materialCostTextBox.Size = new Size(109, 23);
            materialCostTextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(91, 140);
            button1.Name = "button1";
            button1.Size = new Size(80, 33);
            button1.TabIndex = 5;
            button1.Text = "Compute Cost";
            button1.UseVisualStyleBackColor = true;
            button1.Click += calculateButton_Click;
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.InactiveBorder;
            totalLabel.ForeColor = SystemColors.InactiveCaptionText;
            totalLabel.Location = new Point(317, 112);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(109, 23);
            totalLabel.TabIndex = 9;
            // 
            // salesTaxLabel
            // 
            salesTaxLabel.BackColor = SystemColors.InactiveBorder;
            salesTaxLabel.ForeColor = SystemColors.InactiveCaptionText;
            salesTaxLabel.Location = new Point(317, 53);
            salesTaxLabel.Name = "salesTaxLabel";
            salesTaxLabel.Size = new Size(109, 23);
            salesTaxLabel.TabIndex = 10;
            // 
            // subtotalLabel
            // 
            subtotalLabel.BackColor = SystemColors.InactiveBorder;
            subtotalLabel.ForeColor = SystemColors.InactiveCaptionText;
            subtotalLabel.Location = new Point(317, 84);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(109, 23);
            subtotalLabel.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(283, 150);
            button2.Name = "button2";
            button2.Size = new Size(53, 25);
            button2.TabIndex = 12;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += clearButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(204, 150);
            button3.Name = "button3";
            button3.Size = new Size(53, 25);
            button3.TabIndex = 13;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(459, 187);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(subtotalLabel);
            Controls.Add(salesTaxLabel);
            Controls.Add(totalLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(materialCostTextBox);
            Controls.Add(laborCostTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void CalculateButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox laborCostTextBox;
        private TextBox materialCostTextBox;
        private Button button1;
        private TextBox totalLabel;
        private TextBox salesTaxLabel;
        private TextBox subtotalLabel;
        private Button button2;
        private Button button3;
    }
}

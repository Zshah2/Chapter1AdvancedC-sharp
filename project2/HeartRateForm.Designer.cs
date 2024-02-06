
namespace main
{
    partial class HeartRateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            ageTextBox = new TextBox();
            resultLabel = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(308, 142);
            button1.Name = "button1";
            button1.Size = new Size(113, 53);
            button1.TabIndex = 0;
            button1.Text = "Solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += calculateButton_Click;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(287, 92);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(149, 23);
            ageTextBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(287, 224);
            resultLabel.Multiline = true;
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(161, 23);
            resultLabel.TabIndex = 2;
            resultLabel.TextChanged += resultLabel_TextChanged;
            // 
            // HeartRateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(ageTextBox);
            Controls.Add(button1);
            Name = "HeartRateForm";
            Text = "HeartRateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void resultLabel_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private TextBox ageTextBox;
        private TextBox resultLabel;
    }
}
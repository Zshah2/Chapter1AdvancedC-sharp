namespace MainForm
{
    partial class MaxHeartRatecs
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
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(361, 162);
            button1.Name = "button1";
            button1.Size = new Size(64, 43);
            button1.TabIndex = 0;
            button1.Text = "Solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CalculateButton_Click;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(348, 110);
            ageTextBox.Multiline = true;
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(93, 46);
            ageTextBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(326, 225);
            resultLabel.Multiline = true;
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(133, 51);
            resultLabel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 113);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter A Value";
            label1.Click += label1_Click;
            // 
            // MaxHeartRatecs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            Controls.Add(ageTextBox);
            Controls.Add(button1);
            Name = "MaxHeartRatecs";
            Text = "MaxHeartRatecs";
            Load += MaxHeartRatecs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox ageTextBox;
        private TextBox resultLabel;
        private Label label1;
    }
}
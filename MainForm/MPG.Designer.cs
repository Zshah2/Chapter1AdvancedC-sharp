namespace MainForm
{
    partial class MPG
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
            label1 = new Label();
            label2 = new Label();
            milesTextBox = new TextBox();
            gallonsTextBox = new TextBox();
            resultLabel = new TextBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 129);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Miles :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 183);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Gallons:";
            // 
            // milesTextBox
            // 
            milesTextBox.Location = new Point(284, 126);
            milesTextBox.Name = "milesTextBox";
            milesTextBox.Size = new Size(146, 23);
            milesTextBox.TabIndex = 4;
            // 
            // gallonsTextBox
            // 
            gallonsTextBox.Location = new Point(284, 175);
            gallonsTextBox.Name = "gallonsTextBox";
            gallonsTextBox.Size = new Size(146, 23);
            gallonsTextBox.TabIndex = 5;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(239, 233);
            resultLabel.Multiline = true;
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(232, 162);
            resultLabel.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(297, 204);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 8;
            button1.Text = "Click to Solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += calculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(resultLabel);
            Controls.Add(gallonsTextBox);
            Controls.Add(milesTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox milesTextBox;
        private TextBox gallonsTextBox;
        private TextBox resultLabel;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

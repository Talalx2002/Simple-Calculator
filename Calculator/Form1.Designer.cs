namespace Calculator
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
            this.numericButtons = new System.Windows.Forms.GroupBox();
            this.equalButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.numericButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericButtons
            // 
            this.numericButtons.AutoSize = true;
            this.numericButtons.Controls.Add(this.equalButton);
            this.numericButtons.Controls.Add(this.zeroButton);
            this.numericButtons.Controls.Add(this.threeButton);
            this.numericButtons.Controls.Add(this.minusButton);
            this.numericButtons.Controls.Add(this.twoButton);
            this.numericButtons.Controls.Add(this.fourButton);
            this.numericButtons.Controls.Add(this.fiveButton);
            this.numericButtons.Controls.Add(this.sixButton);
            this.numericButtons.Controls.Add(this.divideButton);
            this.numericButtons.Controls.Add(this.oneButton);
            this.numericButtons.Controls.Add(this.plusButton);
            this.numericButtons.Controls.Add(this.nineButton);
            this.numericButtons.Controls.Add(this.eightButton);
            this.numericButtons.Controls.Add(this.removeButton);
            this.numericButtons.Controls.Add(this.multiplyButton);
            this.numericButtons.Controls.Add(this.sevenButton);
            this.numericButtons.Controls.Add(this.clearButton);
            this.numericButtons.Location = new System.Drawing.Point(3, 174);
            this.numericButtons.Name = "numericButtons";
            this.numericButtons.Size = new System.Drawing.Size(529, 333);
            this.numericButtons.TabIndex = 0;
            this.numericButtons.TabStop = false;
            this.numericButtons.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(269, 258);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(254, 53);
            this.equalButton.TabIndex = 17;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(9, 258);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(254, 53);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(269, 199);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(124, 53);
            this.threeButton.TabIndex = 15;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(399, 199);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(124, 53);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.operation_Performed);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(139, 199);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(124, 53);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(9, 140);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(124, 53);
            this.fourButton.TabIndex = 12;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(139, 140);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(124, 53);
            this.fiveButton.TabIndex = 11;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(269, 140);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(124, 53);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(399, 140);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(124, 53);
            this.divideButton.TabIndex = 9;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.operation_Performed);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(9, 199);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(124, 53);
            this.oneButton.TabIndex = 8;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(399, 81);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(124, 53);
            this.plusButton.TabIndex = 7;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.operation_Performed);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(269, 81);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(124, 53);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(139, 81);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(124, 53);
            this.eightButton.TabIndex = 5;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(269, 22);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(124, 53);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "<-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(399, 22);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(124, 53);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.operation_Performed);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(9, 81);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(124, 53);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(9, 22);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(254, 53);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(3, 155);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(523, 39);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Location = new System.Drawing.Point(3, 137);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(0, 15);
            this.topLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 502);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.numericButtons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.numericButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox numericButtons;
        private Button removeButton;
        private Button multiplyButton;
        private Button sevenButton;
        private Button clearButton;
        private Button zeroButton;
        private Button threeButton;
        private Button minusButton;
        private Button twoButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button divideButton;
        private Button oneButton;
        private Button plusButton;
        private Button nineButton;
        private Button eightButton;
        private Button equalButton;
        private TextBox resultTextBox;
        private Label topLabel;
    }
}
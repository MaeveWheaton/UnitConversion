
namespace UnitConversion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.choiceInput = new System.Windows.Forms.TextBox();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertOutput = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(109, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(529, 69);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Conversion";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(173, 149);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(393, 156);
            this.optionsLabel.TabIndex = 1;
            this.optionsLabel.Text = "1.  Inches to Centimetres\r\n2.  Feet to Centimetres\r\n3.  Yards to Metres\r\n4.  Mile" +
    "s to Kilometres";
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Location = new System.Drawing.Point(115, 353);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(392, 32);
            this.choiceLabel.TabIndex = 2;
            this.choiceLabel.Text = "Enter conversion choice (1-4):";
            // 
            // choiceInput
            // 
            this.choiceInput.Location = new System.Drawing.Point(538, 350);
            this.choiceInput.Name = "choiceInput";
            this.choiceInput.Size = new System.Drawing.Size(100, 38);
            this.choiceInput.TabIndex = 3;
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(538, 429);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(100, 38);
            this.valueInput.TabIndex = 4;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(115, 432);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(369, 32);
            this.valueLabel.TabIndex = 5;
            this.valueLabel.Text = "Enter value to be converted:";
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.convertButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.convertButton.FlatAppearance.BorderSize = 2;
            this.convertButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.convertButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Location = new System.Drawing.Point(121, 523);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(517, 65);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // convertOutput
            // 
            this.convertOutput.ForeColor = System.Drawing.Color.Red;
            this.convertOutput.Location = new System.Drawing.Point(115, 611);
            this.convertOutput.Name = "convertOutput";
            this.convertOutput.Size = new System.Drawing.Size(523, 80);
            this.convertOutput.TabIndex = 7;
            this.convertOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(121, 706);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(517, 65);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 801);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertOutput);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.choiceInput);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Unit Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.TextBox choiceInput;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label convertOutput;
        private System.Windows.Forms.Button clearButton;
    }
}


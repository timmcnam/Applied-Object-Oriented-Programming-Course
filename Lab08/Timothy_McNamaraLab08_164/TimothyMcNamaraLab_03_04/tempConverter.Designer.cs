
namespace TimothyMcNamaraLab_03_04
{
    partial class tempConverter
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
            this.temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.celciusToFahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.fahrenheitToCelciusRadioButton = new System.Windows.Forms.RadioButton();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.insertTemperatureLabel = new System.Windows.Forms.Label();
            this.convertedTempLabel = new System.Windows.Forms.Label();
            this.degreeCelciusLabel = new System.Windows.Forms.Label();
            this.degreeFahrenheitLabel = new System.Windows.Forms.Label();
            this.converterButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.temperatureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // temperatureGroupBox
            // 
            this.temperatureGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.temperatureGroupBox.AutoSize = true;
            this.temperatureGroupBox.Controls.Add(this.celciusToFahrenheitRadioButton);
            this.temperatureGroupBox.Controls.Add(this.fahrenheitToCelciusRadioButton);
            this.temperatureGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureGroupBox.Location = new System.Drawing.Point(12, 12);
            this.temperatureGroupBox.Name = "temperatureGroupBox";
            this.temperatureGroupBox.Size = new System.Drawing.Size(245, 96);
            this.temperatureGroupBox.TabIndex = 0;
            this.temperatureGroupBox.TabStop = false;
            this.temperatureGroupBox.Text = "Select Temperature Conversion";
            // 
            // celciusToFahrenheitRadioButton
            // 
            this.celciusToFahrenheitRadioButton.AutoSize = true;
            this.celciusToFahrenheitRadioButton.Location = new System.Drawing.Point(6, 48);
            this.celciusToFahrenheitRadioButton.Name = "celciusToFahrenheitRadioButton";
            this.celciusToFahrenheitRadioButton.Size = new System.Drawing.Size(213, 23);
            this.celciusToFahrenheitRadioButton.TabIndex = 0;
            this.celciusToFahrenheitRadioButton.TabStop = true;
            this.celciusToFahrenheitRadioButton.Text = "Converts Celcius to Fahrenheit";
            this.celciusToFahrenheitRadioButton.UseVisualStyleBackColor = true;
            // 
            // fahrenheitToCelciusRadioButton
            // 
            this.fahrenheitToCelciusRadioButton.AutoSize = true;
            this.fahrenheitToCelciusRadioButton.Location = new System.Drawing.Point(6, 22);
            this.fahrenheitToCelciusRadioButton.Name = "fahrenheitToCelciusRadioButton";
            this.fahrenheitToCelciusRadioButton.Size = new System.Drawing.Size(217, 23);
            this.fahrenheitToCelciusRadioButton.TabIndex = 0;
            this.fahrenheitToCelciusRadioButton.TabStop = true;
            this.fahrenheitToCelciusRadioButton.Text = " Converts Fahrenheit to Celcius";
            this.fahrenheitToCelciusRadioButton.UseVisualStyleBackColor = true;
            // 
            // tempTextBox
            // 
            this.tempTextBox.Location = new System.Drawing.Point(282, 63);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(100, 20);
            this.tempTextBox.TabIndex = 0;
            // 
            // insertTemperatureLabel
            // 
            this.insertTemperatureLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTemperatureLabel.Location = new System.Drawing.Point(263, 41);
            this.insertTemperatureLabel.Name = "insertTemperatureLabel";
            this.insertTemperatureLabel.Size = new System.Drawing.Size(147, 23);
            this.insertTemperatureLabel.TabIndex = 2;
            this.insertTemperatureLabel.Text = "Insert Temperature ";
            this.insertTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedTempLabel
            // 
            this.convertedTempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedTempLabel.Location = new System.Drawing.Point(282, 121);
            this.convertedTempLabel.Name = "convertedTempLabel";
            this.convertedTempLabel.Size = new System.Drawing.Size(100, 23);
            this.convertedTempLabel.TabIndex = 3;
            this.convertedTempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // degreeCelciusLabel
            // 
            this.degreeCelciusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeCelciusLabel.Location = new System.Drawing.Point(388, 122);
            this.degreeCelciusLabel.Name = "degreeCelciusLabel";
            this.degreeCelciusLabel.Size = new System.Drawing.Size(33, 23);
            this.degreeCelciusLabel.TabIndex = 4;
            this.degreeCelciusLabel.Text = "°C";
            this.degreeCelciusLabel.Visible = false;
            // 
            // degreeFahrenheitLabel
            // 
            this.degreeFahrenheitLabel.AutoSize = true;
            this.degreeFahrenheitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeFahrenheitLabel.Location = new System.Drawing.Point(388, 125);
            this.degreeFahrenheitLabel.Name = "degreeFahrenheitLabel";
            this.degreeFahrenheitLabel.Size = new System.Drawing.Size(24, 19);
            this.degreeFahrenheitLabel.TabIndex = 5;
            this.degreeFahrenheitLabel.Text = "°F";
            this.degreeFahrenheitLabel.Visible = false;
            // 
            // converterButton
            // 
            this.converterButton.BackColor = System.Drawing.Color.Salmon;
            this.converterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterButton.Location = new System.Drawing.Point(181, 113);
            this.converterButton.Name = "converterButton";
            this.converterButton.Size = new System.Drawing.Size(95, 38);
            this.converterButton.TabIndex = 1;
            this.converterButton.Text = "Convert";
            this.converterButton.UseVisualStyleBackColor = false;
            this.converterButton.Click += new System.EventHandler(this.converterButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Salmon;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(181, 157);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 38);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(282, 157);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 38);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(427, 219);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.converterButton);
            this.Controls.Add(this.degreeFahrenheitLabel);
            this.Controls.Add(this.degreeCelciusLabel);
            this.Controls.Add(this.convertedTempLabel);
            this.Controls.Add(this.insertTemperatureLabel);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.temperatureGroupBox);
            this.Name = "tempConverter";
            this.Text = "Temperature Conversion";
            this.temperatureGroupBox.ResumeLayout(false);
            this.temperatureGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox temperatureGroupBox;
        private System.Windows.Forms.RadioButton celciusToFahrenheitRadioButton;
        private System.Windows.Forms.RadioButton fahrenheitToCelciusRadioButton;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.Label insertTemperatureLabel;
        private System.Windows.Forms.Label convertedTempLabel;
        private System.Windows.Forms.Label degreeCelciusLabel;
        private System.Windows.Forms.Label degreeFahrenheitLabel;
        private System.Windows.Forms.Button converterButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}


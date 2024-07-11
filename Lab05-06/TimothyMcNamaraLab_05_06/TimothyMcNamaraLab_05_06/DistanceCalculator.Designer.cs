
namespace TimothyMcNamaraLab_05_06
{
    partial class DistanceCalculator
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
            this.calculateDistanceMilesTraveled = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.vehicleSpeedInMilesPerHourLabel = new System.Windows.Forms.Label();
            this.hoursTraveledLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.distanceListBox = new System.Windows.Forms.ListBox();
            this.writeDataToFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateDistanceMilesTraveled
            // 
            this.calculateDistanceMilesTraveled.BackColor = System.Drawing.Color.LightBlue;
            this.calculateDistanceMilesTraveled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateDistanceMilesTraveled.Location = new System.Drawing.Point(21, 457);
            this.calculateDistanceMilesTraveled.Name = "calculateDistanceMilesTraveled";
            this.calculateDistanceMilesTraveled.Size = new System.Drawing.Size(345, 65);
            this.calculateDistanceMilesTraveled.TabIndex = 2;
            this.calculateDistanceMilesTraveled.Text = "Calculate Distance (miles) Traveled";
            this.calculateDistanceMilesTraveled.UseVisualStyleBackColor = false;
            this.calculateDistanceMilesTraveled.Click += new System.EventHandler(this.calculateDistanceMilesTraveled_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightBlue;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(600, 457);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 65);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightBlue;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(709, 457);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 65);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // vehicleSpeedInMilesPerHourLabel
            // 
            this.vehicleSpeedInMilesPerHourLabel.AutoSize = true;
            this.vehicleSpeedInMilesPerHourLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleSpeedInMilesPerHourLabel.Location = new System.Drawing.Point(195, 36);
            this.vehicleSpeedInMilesPerHourLabel.Name = "vehicleSpeedInMilesPerHourLabel";
            this.vehicleSpeedInMilesPerHourLabel.Size = new System.Drawing.Size(190, 22);
            this.vehicleSpeedInMilesPerHourLabel.TabIndex = 3;
            this.vehicleSpeedInMilesPerHourLabel.Text = "Vehicle Speed in MPH";
            // 
            // hoursTraveledLabel
            // 
            this.hoursTraveledLabel.AutoSize = true;
            this.hoursTraveledLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTraveledLabel.Location = new System.Drawing.Point(195, 81);
            this.hoursTraveledLabel.Name = "hoursTraveledLabel";
            this.hoursTraveledLabel.Size = new System.Drawing.Size(134, 22);
            this.hoursTraveledLabel.TabIndex = 4;
            this.hoursTraveledLabel.Text = "Hours Traveled";
            // 
            // speedTextBox
            // 
            this.speedTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.speedTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.speedTextBox.Location = new System.Drawing.Point(439, 36);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(212, 30);
            this.speedTextBox.TabIndex = 0;
            // 
            // timeTextBox
            // 
            this.timeTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.timeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.timeTextBox.Location = new System.Drawing.Point(439, 81);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(212, 30);
            this.timeTextBox.TabIndex = 1;
            // 
            // distanceListBox
            // 
            this.distanceListBox.BackColor = System.Drawing.Color.LightBlue;
            this.distanceListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceListBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.distanceListBox.FormattingEnabled = true;
            this.distanceListBox.ItemHeight = 22;
            this.distanceListBox.Location = new System.Drawing.Point(173, 117);
            this.distanceListBox.Name = "distanceListBox";
            this.distanceListBox.Size = new System.Drawing.Size(493, 334);
            this.distanceListBox.TabIndex = 6;
            // 
            // writeDataToFileButton
            // 
            this.writeDataToFileButton.BackColor = System.Drawing.Color.LightBlue;
            this.writeDataToFileButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeDataToFileButton.Location = new System.Drawing.Point(372, 457);
            this.writeDataToFileButton.Name = "writeDataToFileButton";
            this.writeDataToFileButton.Size = new System.Drawing.Size(222, 65);
            this.writeDataToFileButton.TabIndex = 3;
            this.writeDataToFileButton.Text = "Write Data to File";
            this.writeDataToFileButton.UseVisualStyleBackColor = false;
            this.writeDataToFileButton.Click += new System.EventHandler(this.writeDataToFileButton_Click);
            // 
            // DistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(824, 534);
            this.Controls.Add(this.writeDataToFileButton);
            this.Controls.Add(this.distanceListBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.hoursTraveledLabel);
            this.Controls.Add(this.vehicleSpeedInMilesPerHourLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateDistanceMilesTraveled);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "DistanceCalculator";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateDistanceMilesTraveled;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label vehicleSpeedInMilesPerHourLabel;
        private System.Windows.Forms.Label hoursTraveledLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.ListBox distanceListBox;
        private System.Windows.Forms.Button writeDataToFileButton;
    }
}


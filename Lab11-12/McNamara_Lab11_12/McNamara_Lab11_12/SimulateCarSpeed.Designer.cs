
namespace McNamara_Lab11_12
{
    partial class SimulateCarSpeed
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
            this.simulateCarSpeedLabel = new System.Windows.Forms.Label();
            this.carGroupBox = new System.Windows.Forms.GroupBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.CreateCarBtn = new System.Windows.Forms.Button();
            this.AccelerateBtn = new System.Windows.Forms.Button();
            this.BrakeBtn = new System.Windows.Forms.Button();
            this.carSpeedLabel = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.carGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulateCarSpeedLabel
            // 
            this.simulateCarSpeedLabel.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulateCarSpeedLabel.Location = new System.Drawing.Point(18, 14);
            this.simulateCarSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.simulateCarSpeedLabel.Name = "simulateCarSpeedLabel";
            this.simulateCarSpeedLabel.Size = new System.Drawing.Size(574, 66);
            this.simulateCarSpeedLabel.TabIndex = 0;
            this.simulateCarSpeedLabel.Text = "Simulate Car Speed";
            this.simulateCarSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carGroupBox
            // 
            this.carGroupBox.Controls.Add(this.speedTextBox);
            this.carGroupBox.Controls.Add(this.modelLabel);
            this.carGroupBox.Controls.Add(this.makeLabel);
            this.carGroupBox.Controls.Add(this.yearTextBox);
            this.carGroupBox.Controls.Add(this.speedLabel);
            this.carGroupBox.Controls.Add(this.yearLabel);
            this.carGroupBox.Controls.Add(this.modelTextBox);
            this.carGroupBox.Controls.Add(this.makeTextBox);
            this.carGroupBox.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carGroupBox.Location = new System.Drawing.Point(99, 115);
            this.carGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carGroupBox.Name = "carGroupBox";
            this.carGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carGroupBox.Size = new System.Drawing.Size(414, 305);
            this.carGroupBox.TabIndex = 1;
            this.carGroupBox.TabStop = false;
            this.carGroupBox.Text = "Enter Car Data";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(128, 225);
            this.speedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(252, 29);
            this.speedTextBox.TabIndex = 7;
            // 
            // modelLabel
            // 
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(26, 105);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(93, 34);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model:";
            // 
            // makeLabel
            // 
            this.makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.Location = new System.Drawing.Point(26, 46);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(93, 34);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(128, 166);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(252, 29);
            this.yearTextBox.TabIndex = 6;
            // 
            // speedLabel
            // 
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(26, 228);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(93, 34);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed:";
            // 
            // yearLabel
            // 
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(26, 166);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(93, 34);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(128, 105);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(252, 29);
            this.modelTextBox.TabIndex = 5;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(128, 46);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(252, 29);
            this.makeTextBox.TabIndex = 4;
            // 
            // CreateCarBtn
            // 
            this.CreateCarBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCarBtn.Location = new System.Drawing.Point(196, 445);
            this.CreateCarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateCarBtn.Name = "CreateCarBtn";
            this.CreateCarBtn.Size = new System.Drawing.Size(220, 35);
            this.CreateCarBtn.TabIndex = 2;
            this.CreateCarBtn.Text = "Create Car Object";
            this.CreateCarBtn.UseVisualStyleBackColor = true;
            this.CreateCarBtn.Click += new System.EventHandler(this.CreateCarBtn_Click);
            // 
            // AccelerateBtn
            // 
            this.AccelerateBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccelerateBtn.Location = new System.Drawing.Point(99, 511);
            this.AccelerateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccelerateBtn.Name = "AccelerateBtn";
            this.AccelerateBtn.Size = new System.Drawing.Size(172, 35);
            this.AccelerateBtn.TabIndex = 3;
            this.AccelerateBtn.Text = "Accelerate";
            this.AccelerateBtn.UseVisualStyleBackColor = true;
            this.AccelerateBtn.Click += new System.EventHandler(this.AccelerateBtn_Click);
            // 
            // BrakeBtn
            // 
            this.BrakeBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrakeBtn.Location = new System.Drawing.Point(340, 511);
            this.BrakeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrakeBtn.Name = "BrakeBtn";
            this.BrakeBtn.Size = new System.Drawing.Size(172, 35);
            this.BrakeBtn.TabIndex = 4;
            this.BrakeBtn.Text = "Brake";
            this.BrakeBtn.UseVisualStyleBackColor = true;
            this.BrakeBtn.Click += new System.EventHandler(this.BrakeBtn_Click);
            // 
            // carSpeedLabel
            // 
            this.carSpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carSpeedLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carSpeedLabel.Location = new System.Drawing.Point(18, 575);
            this.carSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carSpeedLabel.Name = "carSpeedLabel";
            this.carSpeedLabel.Size = new System.Drawing.Size(564, 45);
            this.carSpeedLabel.TabIndex = 5;
            this.carSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(18, 643);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(106, 35);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(470, 643);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(123, 35);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SimulateCarSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 691);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.carSpeedLabel);
            this.Controls.Add(this.BrakeBtn);
            this.Controls.Add(this.AccelerateBtn);
            this.Controls.Add(this.CreateCarBtn);
            this.Controls.Add(this.carGroupBox);
            this.Controls.Add(this.simulateCarSpeedLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SimulateCarSpeed";
            this.Text = "Car Simulation";
            this.carGroupBox.ResumeLayout(false);
            this.carGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label simulateCarSpeedLabel;
        private System.Windows.Forms.GroupBox carGroupBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Button CreateCarBtn;
        private System.Windows.Forms.Button AccelerateBtn;
        private System.Windows.Forms.Button BrakeBtn;
        private System.Windows.Forms.Label carSpeedLabel;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}


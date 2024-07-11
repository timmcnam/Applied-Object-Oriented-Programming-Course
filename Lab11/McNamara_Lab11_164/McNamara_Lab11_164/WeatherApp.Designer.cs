
namespace McNamara_Lab11_164
{
    partial class WeatherApp
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectADateLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPrecipitation = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.precipitationLabel = new System.Windows.Forms.Label();
            this.highTempLabel = new System.Windows.Forms.Label();
            this.lowTempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(57, 32);
            this.dateTimePicker.MaxDate = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(354, 27);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // selectADateLabel
            // 
            this.selectADateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectADateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.selectADateLabel.Location = new System.Drawing.Point(53, 6);
            this.selectADateLabel.Name = "selectADateLabel";
            this.selectADateLabel.Size = new System.Drawing.Size(166, 23);
            this.selectADateLabel.TabIndex = 1;
            this.selectADateLabel.Text = "Select a Date";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Brown;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn.Location = new System.Drawing.Point(87, 262);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(121, 50);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Brown;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Location = new System.Drawing.Point(271, 262);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(121, 50);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDate.Location = new System.Drawing.Point(53, 82);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(184, 23);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date:";
            // 
            // labelPrecipitation
            // 
            this.labelPrecipitation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecipitation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrecipitation.Location = new System.Drawing.Point(53, 120);
            this.labelPrecipitation.Name = "labelPrecipitation";
            this.labelPrecipitation.Size = new System.Drawing.Size(184, 23);
            this.labelPrecipitation.TabIndex = 5;
            this.labelPrecipitation.Text = "Precipitation:";
            // 
            // labelHigh
            // 
            this.labelHigh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHigh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHigh.Location = new System.Drawing.Point(53, 160);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(184, 23);
            this.labelHigh.TabIndex = 6;
            this.labelHigh.Text = "High Temperature:";
            // 
            // labelLow
            // 
            this.labelLow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLow.Location = new System.Drawing.Point(53, 201);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(184, 23);
            this.labelLow.TabIndex = 7;
            this.labelLow.Text = "Low Temperature:";
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateLabel.Location = new System.Drawing.Point(258, 82);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(134, 23);
            this.dateLabel.TabIndex = 8;
            // 
            // precipitationLabel
            // 
            this.precipitationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precipitationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.precipitationLabel.Location = new System.Drawing.Point(258, 120);
            this.precipitationLabel.Name = "precipitationLabel";
            this.precipitationLabel.Size = new System.Drawing.Size(134, 23);
            this.precipitationLabel.TabIndex = 9;
            // 
            // highTempLabel
            // 
            this.highTempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highTempLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highTempLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.highTempLabel.Location = new System.Drawing.Point(258, 160);
            this.highTempLabel.Name = "highTempLabel";
            this.highTempLabel.Size = new System.Drawing.Size(134, 23);
            this.highTempLabel.TabIndex = 10;
            // 
            // lowTempLabel
            // 
            this.lowTempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowTempLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowTempLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lowTempLabel.Location = new System.Drawing.Point(258, 201);
            this.lowTempLabel.Name = "lowTempLabel";
            this.lowTempLabel.Size = new System.Drawing.Size(134, 23);
            this.lowTempLabel.TabIndex = 11;
            // 
            // WeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(460, 394);
            this.Controls.Add(this.lowTempLabel);
            this.Controls.Add(this.highTempLabel);
            this.Controls.Add(this.precipitationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.labelPrecipitation);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.selectADateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "WeatherApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WeatherApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label selectADateLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPrecipitation;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label precipitationLabel;
        private System.Windows.Forms.Label highTempLabel;
        private System.Windows.Forms.Label lowTempLabel;
    }
}


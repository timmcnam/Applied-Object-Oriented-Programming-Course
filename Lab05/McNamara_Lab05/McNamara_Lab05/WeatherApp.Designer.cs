
namespace McNamara_Lab05
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPrecip = new System.Windows.Forms.Label();
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
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.OliveDrab;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.OliveDrab;
            this.dateTimePicker.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(72, 12);
            this.dateTimePicker.MaxDate = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(427, 39);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.clearBtn.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(72, 332);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(195, 43);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.exitBtn.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(304, 332);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(195, 43);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(12, 84);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(213, 39);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date:";
            // 
            // labelPrecip
            // 
            this.labelPrecip.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecip.Location = new System.Drawing.Point(12, 139);
            this.labelPrecip.Name = "labelPrecip";
            this.labelPrecip.Size = new System.Drawing.Size(213, 36);
            this.labelPrecip.TabIndex = 4;
            this.labelPrecip.Text = "Precipitation:";
            // 
            // labelHigh
            // 
            this.labelHigh.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHigh.Location = new System.Drawing.Point(12, 194);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(213, 36);
            this.labelHigh.TabIndex = 5;
            this.labelHigh.Text = "High Temperature:";
            // 
            // labelLow
            // 
            this.labelLow.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLow.Location = new System.Drawing.Point(12, 249);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(213, 36);
            this.labelLow.TabIndex = 6;
            this.labelLow.Text = "Low Temperature:";
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(340, 84);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(208, 36);
            this.dateLabel.TabIndex = 7;
            // 
            // precipitationLabel
            // 
            this.precipitationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precipitationLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationLabel.Location = new System.Drawing.Point(340, 139);
            this.precipitationLabel.Name = "precipitationLabel";
            this.precipitationLabel.Size = new System.Drawing.Size(208, 36);
            this.precipitationLabel.TabIndex = 8;
            // 
            // highTempLabel
            // 
            this.highTempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highTempLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highTempLabel.Location = new System.Drawing.Point(340, 194);
            this.highTempLabel.Name = "highTempLabel";
            this.highTempLabel.Size = new System.Drawing.Size(208, 36);
            this.highTempLabel.TabIndex = 9;
            // 
            // lowTempLabel
            // 
            this.lowTempLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowTempLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowTempLabel.Location = new System.Drawing.Point(340, 249);
            this.lowTempLabel.Name = "lowTempLabel";
            this.lowTempLabel.Size = new System.Drawing.Size(208, 36);
            this.lowTempLabel.TabIndex = 10;
            // 
            // WeatherApp
            // 
            this.AcceptButton = this.clearBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(585, 418);
            this.Controls.Add(this.lowTempLabel);
            this.Controls.Add(this.highTempLabel);
            this.Controls.Add(this.precipitationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.labelPrecip);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "WeatherApp";
            this.Text = "Weather Data";
            this.Load += new System.EventHandler(this.WeatherApp_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPrecip;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label precipitationLabel;
        private System.Windows.Forms.Label highTempLabel;
        private System.Windows.Forms.Label lowTempLabel;
    }
}


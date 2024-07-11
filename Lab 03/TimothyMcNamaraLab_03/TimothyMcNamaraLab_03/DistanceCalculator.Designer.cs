
namespace TimothyMcNamaraLab_03
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
            this.speedLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.speedTxtBox = new System.Windows.Forms.TextBox();
            this.hoursTxtBox = new System.Windows.Forms.TextBox();
            this.distanceListBox = new System.Windows.Forms.ListBox();
            this.calculateDistanceBtn = new System.Windows.Forms.Button();
            this.writeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedLabel
            // 
            this.speedLabel.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.speedLabel.Location = new System.Drawing.Point(12, 117);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(249, 51);
            this.speedLabel.TabIndex = 7;
            this.speedLabel.Text = "Vehicle Speed in MPH";
            // 
            // hoursLabel
            // 
            this.hoursLabel.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.hoursLabel.Location = new System.Drawing.Point(49, 180);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(212, 51);
            this.hoursLabel.TabIndex = 8;
            this.hoursLabel.Text = "Hours Traveled";
            // 
            // speedTxtBox
            // 
            this.speedTxtBox.BackColor = System.Drawing.Color.ForestGreen;
            this.speedTxtBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedTxtBox.ForeColor = System.Drawing.Color.White;
            this.speedTxtBox.Location = new System.Drawing.Point(267, 117);
            this.speedTxtBox.Name = "speedTxtBox";
            this.speedTxtBox.Size = new System.Drawing.Size(178, 35);
            this.speedTxtBox.TabIndex = 0;
            // 
            // hoursTxtBox
            // 
            this.hoursTxtBox.BackColor = System.Drawing.Color.ForestGreen;
            this.hoursTxtBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTxtBox.ForeColor = System.Drawing.Color.White;
            this.hoursTxtBox.Location = new System.Drawing.Point(267, 180);
            this.hoursTxtBox.Name = "hoursTxtBox";
            this.hoursTxtBox.Size = new System.Drawing.Size(178, 35);
            this.hoursTxtBox.TabIndex = 1;
            // 
            // distanceListBox
            // 
            this.distanceListBox.BackColor = System.Drawing.Color.ForestGreen;
            this.distanceListBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceListBox.ForeColor = System.Drawing.Color.White;
            this.distanceListBox.FormattingEnabled = true;
            this.distanceListBox.ItemHeight = 22;
            this.distanceListBox.Location = new System.Drawing.Point(451, 12);
            this.distanceListBox.Name = "distanceListBox";
            this.distanceListBox.Size = new System.Drawing.Size(337, 334);
            this.distanceListBox.TabIndex = 6;
            // 
            // calculateDistanceBtn
            // 
            this.calculateDistanceBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.calculateDistanceBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateDistanceBtn.ForeColor = System.Drawing.Color.White;
            this.calculateDistanceBtn.Location = new System.Drawing.Point(19, 221);
            this.calculateDistanceBtn.Name = "calculateDistanceBtn";
            this.calculateDistanceBtn.Size = new System.Drawing.Size(426, 62);
            this.calculateDistanceBtn.TabIndex = 2;
            this.calculateDistanceBtn.Text = "Calculate Distance (miles) Traveled";
            this.calculateDistanceBtn.UseVisualStyleBackColor = false;
            this.calculateDistanceBtn.Click += new System.EventHandler(this.calculateDistanceBtn_Click);
            // 
            // writeBtn
            // 
            this.writeBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.writeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeBtn.ForeColor = System.Drawing.Color.White;
            this.writeBtn.Location = new System.Drawing.Point(240, 289);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(205, 57);
            this.writeBtn.TabIndex = 3;
            this.writeBtn.Text = "Write data to file";
            this.writeBtn.UseVisualStyleBackColor = false;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.clearBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(451, 359);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(164, 57);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(621, 359);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(167, 57);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // DistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateDistanceBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.distanceListBox);
            this.Controls.Add(this.hoursTxtBox);
            this.Controls.Add(this.speedTxtBox);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.speedLabel);
            this.Name = "DistanceCalculator";
            this.Text = "Vehicle Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox speedTxtBox;
        private System.Windows.Forms.TextBox hoursTxtBox;
        private System.Windows.Forms.ListBox distanceListBox;
        private System.Windows.Forms.Button calculateDistanceBtn;
        private System.Windows.Forms.Button writeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}


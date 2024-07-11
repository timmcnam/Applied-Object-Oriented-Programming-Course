
namespace TimothyMcNamaraLab_01
{
    partial class ControlsPractice
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
            this.welcomeBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.dogLabel = new System.Windows.Forms.Label();
            this.dogNameBtn = new System.Windows.Forms.Button();
            this.clearTextBtn = new System.Windows.Forms.Button();
            this.showPictureBtn = new System.Windows.Forms.Button();
            this.hidePictureBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.myNameBtn = new System.Windows.Forms.Button();
            this.myPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeBtn
            // 
            this.welcomeBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.welcomeBtn.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBtn.Location = new System.Drawing.Point(28, 133);
            this.welcomeBtn.Name = "welcomeBtn";
            this.welcomeBtn.Size = new System.Drawing.Size(234, 49);
            this.welcomeBtn.TabIndex = 0;
            this.welcomeBtn.Text = "Display Welcome";
            this.welcomeBtn.UseVisualStyleBackColor = false;
            this.welcomeBtn.Click += new System.EventHandler(this.welcomeBtn_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(301, 133);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(208, 38);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dogLabel
            // 
            this.dogLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dogLabel.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogLabel.Location = new System.Drawing.Point(301, 196);
            this.dogLabel.Name = "dogLabel";
            this.dogLabel.Size = new System.Drawing.Size(208, 38);
            this.dogLabel.TabIndex = 2;
            this.dogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dogNameBtn
            // 
            this.dogNameBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.dogNameBtn.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogNameBtn.Location = new System.Drawing.Point(28, 277);
            this.dogNameBtn.Name = "dogNameBtn";
            this.dogNameBtn.Size = new System.Drawing.Size(234, 49);
            this.dogNameBtn.TabIndex = 2;
            this.dogNameBtn.Text = "Display Dog Name";
            this.dogNameBtn.UseVisualStyleBackColor = false;
            this.dogNameBtn.Click += new System.EventHandler(this.dogNameBtn_Click);
            // 
            // clearTextBtn
            // 
            this.clearTextBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.clearTextBtn.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTextBtn.Location = new System.Drawing.Point(269, 277);
            this.clearTextBtn.Name = "clearTextBtn";
            this.clearTextBtn.Size = new System.Drawing.Size(97, 49);
            this.clearTextBtn.TabIndex = 3;
            this.clearTextBtn.Text = "Clear";
            this.clearTextBtn.UseVisualStyleBackColor = false;
            this.clearTextBtn.Click += new System.EventHandler(this.clearTextBtn_Click);
            // 
            // showPictureBtn
            // 
            this.showPictureBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.showPictureBtn.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPictureBtn.Location = new System.Drawing.Point(553, 205);
            this.showPictureBtn.Name = "showPictureBtn";
            this.showPictureBtn.Size = new System.Drawing.Size(234, 49);
            this.showPictureBtn.TabIndex = 4;
            this.showPictureBtn.Text = "Show Picture";
            this.showPictureBtn.UseVisualStyleBackColor = false;
            this.showPictureBtn.Click += new System.EventHandler(this.showPictureBtn_Click);
            // 
            // hidePictureBtn
            // 
            this.hidePictureBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.hidePictureBtn.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidePictureBtn.Location = new System.Drawing.Point(553, 277);
            this.hidePictureBtn.Name = "hidePictureBtn";
            this.hidePictureBtn.Size = new System.Drawing.Size(234, 49);
            this.hidePictureBtn.TabIndex = 5;
            this.hidePictureBtn.Text = "Hide Picture";
            this.hidePictureBtn.UseVisualStyleBackColor = false;
            this.hidePictureBtn.Click += new System.EventHandler(this.hidePictureBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.exitBtn.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(439, 277);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(97, 49);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // myNameBtn
            // 
            this.myNameBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.myNameBtn.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myNameBtn.Location = new System.Drawing.Point(28, 205);
            this.myNameBtn.Name = "myNameBtn";
            this.myNameBtn.Size = new System.Drawing.Size(234, 49);
            this.myNameBtn.TabIndex = 1;
            this.myNameBtn.Text = "Display My Name";
            this.myNameBtn.UseVisualStyleBackColor = false;
            this.myNameBtn.Click += new System.EventHandler(this.myNameBtn_Click);
            // 
            // myPicture
            // 
            this.myPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPicture.Image = global::TimothyMcNamaraLab_01.Properties.Resources.Cat;
            this.myPicture.Location = new System.Drawing.Point(567, 12);
            this.myPicture.Name = "myPicture";
            this.myPicture.Size = new System.Drawing.Size(154, 147);
            this.myPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.myPicture.TabIndex = 7;
            this.myPicture.TabStop = false;
            this.myPicture.Visible = false;
            // 
            // ControlsPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(799, 348);
            this.Controls.Add(this.myPicture);
            this.Controls.Add(this.myNameBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.hidePictureBtn);
            this.Controls.Add(this.showPictureBtn);
            this.Controls.Add(this.clearTextBtn);
            this.Controls.Add(this.dogNameBtn);
            this.Controls.Add(this.dogLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.welcomeBtn);
            this.Name = "ControlsPractice";
            this.Text = "Practice";
            ((System.ComponentModel.ISupportInitialize)(this.myPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button welcomeBtn;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label dogLabel;
        private System.Windows.Forms.Button dogNameBtn;
        private System.Windows.Forms.Button clearTextBtn;
        private System.Windows.Forms.Button showPictureBtn;
        private System.Windows.Forms.Button hidePictureBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button myNameBtn;
        private System.Windows.Forms.PictureBox myPicture;
    }
}


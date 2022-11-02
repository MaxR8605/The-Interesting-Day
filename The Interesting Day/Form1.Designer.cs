namespace The_Interesting_Day
{
    partial class TheInterestingDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheInterestingDay));
            this.optionLabel = new System.Windows.Forms.Label();
            this.firstOptionButton = new System.Windows.Forms.Button();
            this.secondOptionButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.storyLabel = new System.Windows.Forms.Label();
            this.thirdOptionButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Font = new System.Drawing.Font("Stencil", 25.25F);
            this.optionLabel.ForeColor = System.Drawing.Color.Azure;
            this.optionLabel.Location = new System.Drawing.Point(39, 317);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(37, 120);
            this.optionLabel.TabIndex = 0;
            this.optionLabel.Text = "1\r\n2\r\n3";
            // 
            // firstOptionButton
            // 
            this.firstOptionButton.BackColor = System.Drawing.Color.Lavender;
            this.firstOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstOptionButton.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstOptionButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.firstOptionButton.Location = new System.Drawing.Point(83, 320);
            this.firstOptionButton.Name = "firstOptionButton";
            this.firstOptionButton.Size = new System.Drawing.Size(338, 33);
            this.firstOptionButton.TabIndex = 1;
            this.firstOptionButton.Text = "option 1";
            this.firstOptionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.firstOptionButton.UseVisualStyleBackColor = false;
            this.firstOptionButton.Click += new System.EventHandler(this.firstOptionButton_Click);
            // 
            // secondOptionButton
            // 
            this.secondOptionButton.BackColor = System.Drawing.Color.Lavender;
            this.secondOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondOptionButton.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondOptionButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.secondOptionButton.Location = new System.Drawing.Point(83, 360);
            this.secondOptionButton.Name = "secondOptionButton";
            this.secondOptionButton.Size = new System.Drawing.Size(338, 33);
            this.secondOptionButton.TabIndex = 2;
            this.secondOptionButton.Text = "option 2";
            this.secondOptionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secondOptionButton.UseVisualStyleBackColor = false;
            this.secondOptionButton.Click += new System.EventHandler(this.secondOptionButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Azure;
            this.questionLabel.Location = new System.Drawing.Point(12, 242);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(352, 63);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "Question...";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // storyLabel
            // 
            this.storyLabel.Font = new System.Drawing.Font("Calibri", 16F);
            this.storyLabel.ForeColor = System.Drawing.Color.Azure;
            this.storyLabel.Location = new System.Drawing.Point(24, 21);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(397, 177);
            this.storyLabel.TabIndex = 4;
            this.storyLabel.Text = "Story...";
            // 
            // thirdOptionButton
            // 
            this.thirdOptionButton.BackColor = System.Drawing.Color.Lavender;
            this.thirdOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdOptionButton.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdOptionButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.thirdOptionButton.Location = new System.Drawing.Point(83, 400);
            this.thirdOptionButton.Name = "thirdOptionButton";
            this.thirdOptionButton.Size = new System.Drawing.Size(338, 33);
            this.thirdOptionButton.TabIndex = 5;
            this.thirdOptionButton.Text = "option 3";
            this.thirdOptionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thirdOptionButton.UseVisualStyleBackColor = false;
            this.thirdOptionButton.Visible = false;
            this.thirdOptionButton.Click += new System.EventHandler(this.thirdOptionButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(224, 144);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(175, 119);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // TheInterestingDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.thirdOptionButton);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.secondOptionButton);
            this.Controls.Add(this.firstOptionButton);
            this.Controls.Add(this.optionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheInterestingDay";
            this.Text = "The Interesting Day";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Button firstOptionButton;
        private System.Windows.Forms.Button secondOptionButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Button thirdOptionButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}


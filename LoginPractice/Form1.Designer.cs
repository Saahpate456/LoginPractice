namespace LoginPractice
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
            this.enterName = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.difficultyLevel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterName.Location = new System.Drawing.Point(93, 61);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(201, 20);
            this.enterName.TabIndex = 0;
            this.enterName.Text = "Enter Your Name Hero: ";
            this.enterName.Click += new System.EventHandler(this.enterName_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(300, 61);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(139, 20);
            this.nameInput.TabIndex = 1;
            // 
            // difficultyLevel
            // 
            this.difficultyLevel.AutoSize = true;
            this.difficultyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.difficultyLevel.Location = new System.Drawing.Point(158, 116);
            this.difficultyLevel.Name = "difficultyLevel";
            this.difficultyLevel.Size = new System.Drawing.Size(235, 20);
            this.difficultyLevel.TabIndex = 2;
            this.difficultyLevel.Text = "Select Your Difficulty Level: ";
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.easyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.easyButton.Location = new System.Drawing.Point(106, 153);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(92, 49);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mediumButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediumButton.Location = new System.Drawing.Point(224, 153);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(100, 49);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hardButton.Location = new System.Drawing.Point(350, 153);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(89, 49);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.beginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beginButton.Location = new System.Drawing.Point(189, 220);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(165, 44);
            this.beginButton.TabIndex = 6;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(159, 282);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(608, 345);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.difficultyLevel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.enterName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label difficultyLevel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label outputLabel;
    }
}


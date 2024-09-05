namespace PROGPOE
{
    partial class CallNumbers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.choice3 = new System.Windows.Forms.Button();
            this.choice1 = new System.Windows.Forms.Button();
            this.choice4 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.musicBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentPoints = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::PROGPOE.Properties.Resources.tree;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.choice3);
            this.panel1.Controls.Add(this.choice1);
            this.panel1.Controls.Add(this.choice4);
            this.panel1.Controls.Add(this.choice2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 645);
            this.panel1.TabIndex = 0;
            // 
            // choice3
            // 
            this.choice3.Location = new System.Drawing.Point(302, 577);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(141, 54);
            this.choice3.TabIndex = 3;
            this.choice3.Text = "button3";
            this.choice3.UseVisualStyleBackColor = true;
            this.choice3.Click += new System.EventHandler(this.choice3_Click);
            // 
            // choice1
            // 
            this.choice1.Location = new System.Drawing.Point(11, 507);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(138, 63);
            this.choice1.TabIndex = 2;
            this.choice1.Text = "button1";
            this.choice1.UseVisualStyleBackColor = true;
            this.choice1.Click += new System.EventHandler(this.choice1_Click);
            // 
            // choice4
            // 
            this.choice4.Location = new System.Drawing.Point(406, 478);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(137, 61);
            this.choice4.TabIndex = 1;
            this.choice4.Text = "button4";
            this.choice4.UseVisualStyleBackColor = true;
            this.choice4.Click += new System.EventHandler(this.choice4_Click);
            // 
            // choice2
            // 
            this.choice2.Location = new System.Drawing.Point(146, 577);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(126, 54);
            this.choice2.TabIndex = 0;
            this.choice2.Text = "button2";
            this.choice2.UseVisualStyleBackColor = true;
            this.choice2.Click += new System.EventHandler(this.choice2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.highscore);
            this.panel2.Controls.Add(this.currentPoints);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.InstructionsLabel);
            this.panel2.Controls.Add(this.HeadingLabel);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.musicBtn);
            this.panel2.Controls.Add(this.helpBtn);
            this.panel2.Location = new System.Drawing.Point(550, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 642);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label1.Location = new System.Drawing.Point(68, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 90);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.InstructionsLabel.Location = new System.Drawing.Point(41, 91);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(376, 77);
            this.InstructionsLabel.TabIndex = 20;
            this.InstructionsLabel.Text = "Select the root which you think matches the call number below";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.Font = new System.Drawing.Font("Arial Narrow", 34F, System.Drawing.FontStyle.Bold);
            this.HeadingLabel.Location = new System.Drawing.Point(3, 9);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(392, 78);
            this.HeadingLabel.TabIndex = 17;
            this.HeadingLabel.Text = "Dewey Decimal Quiz";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Snow;
            this.backBtn.Location = new System.Drawing.Point(92, 526);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(187, 38);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // musicBtn
            // 
            this.musicBtn.BackColor = System.Drawing.Color.Snow;
            this.musicBtn.Location = new System.Drawing.Point(92, 458);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(187, 42);
            this.musicBtn.TabIndex = 14;
            this.musicBtn.Text = "Music";
            this.musicBtn.UseVisualStyleBackColor = false;
            this.musicBtn.Click += new System.EventHandler(this.musicBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.Snow;
            this.helpBtn.Location = new System.Drawing.Point(92, 581);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(187, 38);
            this.helpBtn.TabIndex = 13;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(123, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Points:";
            // 
            // currentPoints
            // 
            this.currentPoints.AutoSize = true;
            this.currentPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.currentPoints.Location = new System.Drawing.Point(208, 358);
            this.currentPoints.Name = "currentPoints";
            this.currentPoints.Size = new System.Drawing.Size(24, 26);
            this.currentPoints.TabIndex = 23;
            this.currentPoints.Text = "0";
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.highscore.Location = new System.Drawing.Point(208, 402);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(24, 26);
            this.highscore.TabIndex = 25;
            this.highscore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(92, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Highscore:";
            // 
            // CallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CallNumbers";
            this.Text = "CallNumbers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CallNumbers_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Button choice3;
        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.Button choice4;
        private System.Windows.Forms.Button choice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Label currentPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
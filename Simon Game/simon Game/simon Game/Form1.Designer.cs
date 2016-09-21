namespace simon_Game
{
    partial class frmSimon
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnblue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYelow = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(12, 12);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(100, 100);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnblue
            // 
            this.btnblue.Location = new System.Drawing.Point(118, 12);
            this.btnblue.Name = "btnblue";
            this.btnblue.Size = new System.Drawing.Size(100, 100);
            this.btnblue.TabIndex = 1;
            this.btnblue.Text = "Blue";
            this.btnblue.UseVisualStyleBackColor = true;
            this.btnblue.Click += new System.EventHandler(this.btnblue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(12, 118);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(100, 100);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYelow
            // 
            this.btnYelow.Location = new System.Drawing.Point(118, 118);
            this.btnYelow.Name = "btnYelow";
            this.btnYelow.Size = new System.Drawing.Size(100, 100);
            this.btnYelow.TabIndex = 3;
            this.btnYelow.Text = "Yellow";
            this.btnYelow.UseVisualStyleBackColor = true;
            this.btnYelow.Click += new System.EventHandler(this.btnYelow_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(235, 36);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(47, 13);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(238, 98);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(73, 13);
            this.PatternLabel.TabIndex = 5;
            this.PatternLabel.Text = "Items in Chain";
            // 
            // frmSimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 246);
            this.Controls.Add(this.PatternLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.btnYelow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnblue);
            this.Controls.Add(this.btnRed);
            this.Name = "frmSimon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnblue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYelow;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label PatternLabel;
    }
}

